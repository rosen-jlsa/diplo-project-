-- Създаване на БД
DROP DATABASE IF EXISTS LibraryDB;
CREATE DATABASE LibraryDB;
USE LibraryDB;

-- Таблици
CREATE TABLE Books (
    BookId INT AUTO_INCREMENT PRIMARY KEY,
    Title VARCHAR(255) NOT NULL,
    Author VARCHAR(255) NOT NULL,
    Genre VARCHAR(100),
    Year INT CHECK (Year > 0),
    TotalCopies INT NOT NULL DEFAULT 1 CHECK (TotalCopies >= 0)
);

CREATE TABLE Readers (
    ReaderId INT AUTO_INCREMENT PRIMARY KEY,
    FirstName VARCHAR(100) NOT NULL,
    LastName VARCHAR(100) NOT NULL,
    Email VARCHAR(255) NOT NULL UNIQUE,
    Phone VARCHAR(20),
    RegistrationDate DATE DEFAULT (CURRENT_DATE)
);

CREATE TABLE Loans (
    LoanId INT AUTO_INCREMENT PRIMARY KEY,
    BookId INT NOT NULL,
    ReaderId INT NOT NULL,
    LoanDate DATE NOT NULL DEFAULT (CURRENT_DATE),
    DueDate DATE NOT NULL,
    ReturnDate DATE NULL,
    CONSTRAINT FK_Loans_Book FOREIGN KEY (BookId) REFERENCES Books(BookId) ON DELETE CASCADE,
    CONSTRAINT FK_Loans_Reader FOREIGN KEY (ReaderId) REFERENCES Readers(ReaderId) ON DELETE CASCADE,
    CONSTRAINT CHK_ReturnDate CHECK (ReturnDate IS NULL OR ReturnDate >= LoanDate)
);

CREATE INDEX IDX_Books_Title ON Books(Title);
CREATE INDEX IDX_Books_Author ON Books(Author);
CREATE INDEX IDX_Books_Genre ON Books(Genre);
CREATE INDEX IDX_Loans_ReturnDate ON Loans(ReturnDate);

-- Изглед за наличност
CREATE VIEW v_BookAvailability AS
SELECT 
    b.BookId,
    b.Title,
    b.Author,
    b.Genre,
    b.Year,
    b.TotalCopies,
    (b.TotalCopies - COUNT(l.LoanId)) AS AvailableCopies
FROM Books b
LEFT JOIN Loans l ON b.BookId = l.BookId AND l.ReturnDate IS NULL
GROUP BY b.BookId;

-- Процедури
DELIMITER $$
CREATE PROCEDURE BorrowBook(IN p_BookId INT, IN p_ReaderId INT, IN p_DaysToReturn INT)
BEGIN
    DECLARE available INT;
    SELECT AvailableCopies INTO available FROM v_BookAvailability WHERE BookId = p_BookId;
    IF available IS NULL OR available <= 0 THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'No available copies.';
    ELSE
        INSERT INTO Loans (BookId, ReaderId, LoanDate, DueDate)
        VALUES (p_BookId, p_ReaderId, CURDATE(), DATE_ADD(CURDATE(), INTERVAL p_DaysToReturn DAY));
    END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE ReturnBook(IN p_LoanId INT)
BEGIN
    DECLARE existing_return DATE;
    SELECT ReturnDate INTO existing_return FROM Loans WHERE LoanId = p_LoanId;
    IF existing_return IS NULL THEN
        UPDATE Loans SET ReturnDate = CURDATE() WHERE LoanId = p_LoanId;
    ELSE
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Book already returned.';
    END IF;
END$$
DELIMITER ;
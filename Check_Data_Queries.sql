-- Колко книги имаме?
SELECT COUNT(*) AS TotalBooks FROM Books;

-- Колко читатели?
SELECT COUNT(*) AS TotalReaders FROM Readers;

-- Колко активни заемания?
SELECT COUNT(*) AS ActiveLoans FROM Loans WHERE ReturnDate IS NULL;

-- Колко върнати?
SELECT COUNT(*) AS ReturnedLoans FROM Loans WHERE ReturnDate IS NOT NULL;

-- Преглед на всички книги с наличност (използвайки изгледа)
SELECT * FROM v_BookAvailability;

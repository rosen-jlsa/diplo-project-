using System;
using System.Linq;
using DiplomaticMission.Models;
using DiplomaticMission.Services;
using DiplomaticMission.Exceptions;

namespace DiplomaticMission
{
    class Program
    {
        private static readonly IDiplomaticService _service = new DiplomaticService();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Diplomatic Mission Management System ===");
                Console.WriteLine("1. Manage Diplomats");
                Console.WriteLine("2. Manage Missions");
                Console.WriteLine("3. Reports & Search (LINQ)");
                Console.WriteLine("0. Exit");
                Console.Write("\nSelect option: ");

                var choice = Console.ReadLine();
                try
                {
                    switch (choice)
                    {
                        case "1": ManageDiplomats(); break;
                        case "2": ManageMissions(); break;
                        case "3": RunReports(); break;
                        case "0": return;
                        default: Console.WriteLine("Invalid choice."); break;
                    }
                }
                catch (BaseDiplomaticException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nERROR: {ex.Message}");
                    Console.ResetColor();
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nUNEXPECTED ERROR: {ex.Message}");
                    Console.ResetColor();
                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }

        static void ManageDiplomats()
        {
            Console.Clear();
            Console.WriteLine("--- Diplomat Management ---");
            Console.WriteLine("1. List All");
            Console.WriteLine("2. Add New");
            Console.WriteLine("3. Delete");
            Console.Write("\nSelect option: ");

            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    foreach (var d in _service.GetAllDiplomats()) Console.WriteLine(d);
                    break;
                case "2":
                    var diplomat = new Diplomat();
                    Console.Write("Name: "); diplomat.Name = Console.ReadLine() ?? string.Empty;
                    Console.Write("Rank (Ambassador, Minister, Counselor, Secretary, Attache): ");
                    diplomat.Rank = Enum.Parse<DiplomaticRank>(Console.ReadLine() ?? "Attache", true);
                    Console.Write("Specialization: "); diplomat.Specialization = Console.ReadLine() ?? string.Empty;
                    Console.Write("Experience Years: "); diplomat.ExperienceYears = int.Parse(Console.ReadLine() ?? "0");
                    _service.AddDiplomat(diplomat);
                    Console.WriteLine("Diplomat added successfully!");
                    break;
                case "3":
                    Console.Write("Enter ID to delete: ");
                    int id = int.Parse(Console.ReadLine() ?? "0");
                    _service.DeleteDiplomat(id);
                    Console.WriteLine("Diplomat deleted.");
                    break;
            }
        }

        static void ManageMissions()
        {
            Console.Clear();
            Console.WriteLine("--- Mission Management ---");
            Console.WriteLine("1. List All");
            Console.WriteLine("2. Add New");
            Console.Write("\nSelect option: ");

            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    foreach (var m in _service.GetAllMissions()) Console.WriteLine(m);
                    break;
                case "2":
                    var mission = new Mission();
                    Console.Write("Country: "); mission.Country = Console.ReadLine() ?? string.Empty;
                    Console.Write("City: "); mission.City = Console.ReadLine() ?? string.Empty;
                    Console.Write("Start Date (yyyy-mm-dd): "); mission.StartDate = DateTime.Parse(Console.ReadLine() ?? "");
                    Console.Write("End Date (yyyy-mm-dd): "); mission.EndDate = DateTime.Parse(Console.ReadLine() ?? "");
                    mission.Status = MissionStatus.Planned;
                    _service.AddMission(mission);
                    Console.WriteLine("Mission added!");
                    break;
            }
        }

        static void RunReports()
        {
            Console.Clear();
            Console.WriteLine("--- Reports & Search (LINQ) ---");
            Console.WriteLine("1. Experienced Diplomats (> 10 years)");
            Console.WriteLine("2. Active Missions by Country");
            Console.WriteLine("3. Search Diplomat by Name");
            Console.Write("\nSelect option: ");

            var choice = Console.ReadLine();
            var diplomats = _service.GetAllDiplomats();
            var missions = _service.GetAllMissions();

            switch (choice)
            {
                case "1":
                    var experienced = diplomats.Where(d => d.ExperienceYears > 10).OrderByDescending(d => d.ExperienceYears);
                    foreach (var d in experienced) Console.WriteLine(d);
                    break;
                case "2":
                    Console.Write("Enter Country: ");
                    var country = Console.ReadLine();
                    var countryMissions = missions.Where(m => m.Country.Equals(country, StringComparison.OrdinalIgnoreCase));
                    foreach (var m in countryMissions) Console.WriteLine(m);
                    break;
                case "3":
                    Console.Write("Enter partial name: ");
                    var namePart = Console.ReadLine();
                    var found = diplomats.Where(d => d.Name.Contains(namePart ?? "", StringComparison.OrdinalIgnoreCase));
                    foreach (var d in found) Console.WriteLine(d);
                    break;
            }
        }
    }
}

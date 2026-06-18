using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using DiplomaticMission.Models;
using DiplomaticMission.Exceptions;

namespace DiplomaticMission.Services
{
    public class DiplomaticService : IDiplomaticService
    {
        private List<Diplomat> _diplomats = new List<Diplomat>();
        private List<Mission> _missions = new List<Mission>();
        private List<DiplomaticEvent> _events = new List<DiplomaticEvent>();

        private readonly string _dataPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
        private readonly string _diplomatsFile;
        private readonly string _missionsFile;
        private readonly string _eventsFile;

        public DiplomaticService()
        {
            if (!Directory.Exists(_dataPath)) Directory.CreateDirectory(_dataPath);
            
            _diplomatsFile = Path.Combine(_dataPath, "diplomats.json");
            _missionsFile = Path.Combine(_dataPath, "missions.json");
            _eventsFile = Path.Combine(_dataPath, "events.json");

            LoadData();
        }

        // --- Diplomats ---
        public void AddDiplomat(Diplomat diplomat)
        {
            if (diplomat.ExperienceYears < 0)
                throw new ValidationException("Experience years cannot be negative.");
            
            diplomat.Id = _diplomats.Any() ? _diplomats.Max(d => d.Id) + 1 : 1;
            _diplomats.Add(diplomat);
            SaveData();
        }

        public IEnumerable<Diplomat> GetAllDiplomats() => _diplomats;

        public Diplomat GetDiplomat(int id)
        {
            var diplomat = _diplomats.FirstOrDefault(d => d.Id == id);
            if (diplomat == null) throw new EntityNotFoundException("Diplomat", id);
            return diplomat;
        }

        public void DeleteDiplomat(int id)
        {
            var diplomat = GetDiplomat(id);
            _diplomats.Remove(diplomat);
            SaveData();
        }

        // --- Missions ---
        public void AddMission(Mission mission)
        {
            if (mission.EndDate < mission.StartDate)
                throw new ValidationException("End date cannot be before start date.");

            mission.Id = _missions.Any() ? _missions.Max(m => m.Id) + 1 : 1;
            _missions.Add(mission);
            SaveData();
        }

        public IEnumerable<Mission> GetAllMissions() => _missions;

        public Mission GetMission(int id)
        {
            var mission = _missions.FirstOrDefault(m => m.Id == id);
            if (mission == null) throw new EntityNotFoundException("Mission", id);
            return mission;
        }

        public void UpdateMission(Mission mission)
        {
            var existing = GetMission(mission.Id);
            _missions.Remove(existing);
            _missions.Add(mission);
            SaveData();
        }

        // --- Events ---
        public void AddEvent(DiplomaticEvent @event)
        {
            // Validate references
            GetDiplomat(@event.DiplomatId);
            GetMission(@event.MissionId);

            @event.Id = _events.Any() ? _events.Max(e => e.Id) + 1 : 1;
            _events.Add(@event);
            SaveData();
        }

        public IEnumerable<DiplomaticEvent> GetAllEvents() => _events;

        // --- Persistence ---
        public void SaveData()
        {
            File.WriteAllText(_diplomatsFile, JsonSerializer.Serialize(_diplomats));
            File.WriteAllText(_missionsFile, JsonSerializer.Serialize(_missions));
            File.WriteAllText(_eventsFile, JsonSerializer.Serialize(_events));
        }

        public void LoadData()
        {
            if (File.Exists(_diplomatsFile))
                _diplomats = JsonSerializer.Deserialize<List<Diplomat>>(File.ReadAllText(_diplomatsFile)) ?? new List<Diplomat>();
            
            if (File.Exists(_missionsFile))
                _missions = JsonSerializer.Deserialize<List<Mission>>(File.ReadAllText(_missionsFile)) ?? new List<Mission>();

            if (File.Exists(_eventsFile))
                _events = JsonSerializer.Deserialize<List<DiplomaticEvent>>(File.ReadAllText(_eventsFile)) ?? new List<DiplomaticEvent>();
        }
    }
}

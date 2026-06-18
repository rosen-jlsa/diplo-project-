using System.Collections.Generic;
using DiplomaticMission.Models;

namespace DiplomaticMission.Services
{
    public interface IDiplomaticService
    {
        // Diplomats
        void AddDiplomat(Diplomat diplomat);
        IEnumerable<Diplomat> GetAllDiplomats();
        Diplomat GetDiplomat(int id);
        void DeleteDiplomat(int id);

        // Missions
        void AddMission(Mission mission);
        IEnumerable<Mission> GetAllMissions();
        Mission GetMission(int id);
        void UpdateMission(Mission mission);

        // Events
        void AddEvent(DiplomaticEvent @event);
        IEnumerable<DiplomaticEvent> GetAllEvents();

        // Persistence
        void SaveData();
        void LoadData();
    }
}

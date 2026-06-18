using System;

namespace DiplomaticMission.Models
{
    public class DiplomaticEvent
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public int DiplomatId { get; set; }
        public int MissionId { get; set; }

        public override string ToString()
        {
            return $"[{Id}] {Title} on {Date:yyyy-MM-dd} (Diplomat: {DiplomatId}, Mission: {MissionId})";
        }
    }
}

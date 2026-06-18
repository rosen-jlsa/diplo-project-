using System;

namespace DiplomaticMission.Models
{
    public enum MissionStatus
    {
        Planned,
        Active,
        Completed,
        Cancelled
    }

    public class Mission
    {
        public int Id { get; set; }
        public string Country { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MissionStatus Status { get; set; }

        public override string ToString()
        {
            return $"[{Id}] {Country} ({City}) | {Status} | {StartDate:yyyy-MM-dd} to {EndDate:yyyy-MM-dd}";
        }
    }
}

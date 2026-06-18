namespace DiplomaticMission.Models
{
    public enum DiplomaticRank
    {
        Ambassador,
        Minister,
        Counselor,
        Secretary,
        Attache
    }

    public class Diplomat
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DiplomaticRank Rank { get; set; }
        public string Specialization { get; set; } = string.Empty;
        public int ExperienceYears { get; set; }

        public override string ToString()
        {
            return $"[{Id}] {Name} - {Rank} ({Specialization}, {ExperienceYears} years exp)";
        }
    }
}

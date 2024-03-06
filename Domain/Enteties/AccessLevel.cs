using Microsoft.EntityFrameworkCore;

namespace Domain.Enteties
{
    public class AccessLevel
    {      
        public Guid AccessLevelId { get; set; }
        public string Level { get; set;}

        public ICollection<Pass> Passes { get; set;}
        public ICollection<Checkpoint> Checkpoints{ get; set; }

        public AccessLevel(string level)
        {
            AccessLevelId = Guid.NewGuid();
            Level = level;

            Passes = new List<Pass>();   
            Checkpoints = new List<Checkpoint>();
        }   
    }
}

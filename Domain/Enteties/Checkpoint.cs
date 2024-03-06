using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace Domain.Enteties
{
    public class Checkpoint
    {
        public Guid CheckpointId { get; set; }
        public string BlockName { get; set; }
        public bool IsLock { get; set; }

        public Guid AccessLevelId { get; set; }        
        public AccessLevel AccessLevel { get; set; }

        public ICollection<Report> Reports { get; set; }

        public Checkpoint(string blockName, Guid accessLevelId)
        {
            CheckpointId = Guid.NewGuid();
            BlockName = blockName;
            AccessLevelId = accessLevelId;
            IsLock = false;

            Reports = new List<Report>();
        }
    }
}

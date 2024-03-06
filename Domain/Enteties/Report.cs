using Microsoft.EntityFrameworkCore;

namespace Domain.Enteties
{
    public class Report
    {
        public Guid ReportId { get; set; }
        public DateTime DateIn { get; set; }
        public DateTime DateOut { get; set; }

        public Guid PassId { get; set; }
        public Guid CheckpointId { get; set; }

        public Pass Pass { get; set; }
        public Checkpoint Checkpoint { get; set; }

        public Report(DateTime dateIn, DateTime dateOut, Guid passId, Guid checkpointId)
        {
            ReportId =Guid.NewGuid();
            DateIn = dateIn;
            DateOut = dateOut;
            PassId = passId;
            CheckpointId = checkpointId;
        }
    }
}

namespace TaskManagementAPI.Models
{
    public partial class AuditModel
    {
        public AuditModel()
        {
            CreatedAt = DateTimeOffset.UtcNow;

            UpdatedAt = DateTimeOffset.UtcNow;
        }

        public DateTimeOffset CreatedAt { get; private set; }

        public DateTimeOffset UpdatedAt { get; set; }
    }
}
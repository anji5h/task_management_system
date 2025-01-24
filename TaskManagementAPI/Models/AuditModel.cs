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

    public partial class AuditModelWithSoftDelete : AuditModel
    {
        public bool IsDeleted { get; set; } = false;
    }
}
using System;

namespace CQRSMediatR.Entities
{
    public abstract class AuditableEntity : IEntity
    {
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }
    }
}

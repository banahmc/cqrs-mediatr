using System;

namespace CQRSMediatR.Entities
{
    public class UserEntity : AuditableEntity
    {
        public Guid Id { get; set; } = Guid.Empty;
        public bool IsNew => Id == Guid.Empty;

        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}

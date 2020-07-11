using CQRSMediatR.Entities;
using MediatR;
using System;

namespace CQRSMediatR.Cqrs.User.Queries.GetById
{
    public class GetByIdQuery : IRequest<UserEntity>
    {
        public Guid Id { get; set; }
    }
}

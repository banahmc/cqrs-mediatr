using CQRSMediatR.Entities;
using CQRSMediatR.Exceptions;
using CQRSMediatR.Repository;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSMediatR.Cqrs.User.Queries.GetById
{
    public class GetByIdQueryHandler : IRequestHandler<GetByIdQuery, UserEntity>
    {
        private readonly IBaseRepository<UserEntity> _userRepository;

        public GetByIdQueryHandler(IBaseRepository<UserEntity> userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<UserEntity> Handle(GetByIdQuery request, CancellationToken cancellationToken)
        {
            if (request.Id == Guid.Empty)
            {
                throw new BadRequestException(new { User = "Invalid ID" });
            }

            var user = _userRepository.FindOne(request.Id);

            if (user == null)
            {
                throw new NotFoundException(new { User = "Not Found" });
            }

            return Task.FromResult(user);
        }
    }
}

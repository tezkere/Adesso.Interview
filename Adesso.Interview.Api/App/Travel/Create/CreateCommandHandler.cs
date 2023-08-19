using Adesso.Interview.Business.Models.Travel.Requests;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Adesso.Interview.Business.Services;

namespace Adesso.Interview.Api.App.Travel.Create
{
    public class CreateCommandHandler : IRequestHandler<CreateCommand,CreateDto>
    {
        private readonly ITravelService _travelService;

        public CreateCommandHandler(ITravelService travelService)
        {
            _travelService = travelService;
        }
        public async Task<CreateDto> Handle(CreateCommand request, CancellationToken cancellationToken)
        {
            
            var response = await _travelService.CreateTravel(new CreateRequest
            {
                ToFrom = request.ToFrom,
                ToWhere = request.ToWhere,
                Date = request.Date,
                Description = request.Description,
                AvailableSeatingCapacity = request.Capacity
            });

            return new CreateDto
            {
                Id = response.Id
            };
        }
    }
}

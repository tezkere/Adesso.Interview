using Adesso.Interview.Business.Models.Travel.Requests;
using Adesso.Interview.Business.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Adesso.Interview.Api.App.Travel.RollBackPublish

{
    public class RollBackPublishCommandHandler : IRequestHandler<RollBackPublishCommand, RollBackPublishDto>
    {
        private readonly ITravelService _travelService;

        public RollBackPublishCommandHandler(ITravelService travelService)
        {
            _travelService = travelService;
        }
        public async Task<RollBackPublishDto> Handle(RollBackPublishCommand request, CancellationToken cancellationToken)
        {            
            var response = await _travelService.RollBackPublishTravel(new RollBackPublishRequest
            {
                Id = request.Id
            });

            return new RollBackPublishDto
            {
                Id = response.Id,
                Message = response.Message
            };
        }
    }
}

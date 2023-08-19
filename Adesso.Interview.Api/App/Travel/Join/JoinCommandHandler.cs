using Adesso.Interview.Business.Models.Travel.Requests;
using Adesso.Interview.Business.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Adesso.Interview.Api.App.Travel.Join

{
    public class PublishCommandHandler : IRequestHandler<JoinCommand, JoinDto>
    {
        private readonly ITravelService _travelService;

        public PublishCommandHandler(ITravelService travelService)
        {
            _travelService = travelService;
        }
        public async Task<JoinDto> Handle(JoinCommand request, CancellationToken cancellationToken)
        {            
            var response = await _travelService.JoinTravel(new JoinRequest
            {
                Id = request.Id,
                SeatingCount = request.SeatingCount
            });

            return new JoinDto
            {
                Id = response.Id,
                Message = response.Message
            };
        }
    }
}

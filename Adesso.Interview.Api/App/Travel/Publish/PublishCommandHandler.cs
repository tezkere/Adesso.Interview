using Adesso.Interview.Business.Models.Travel.Requests;
using Adesso.Interview.Business.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Adesso.Interview.Api.App.Travel.Publish

{
    public class PublishCommandHandler : IRequestHandler<PublishCommand, PublishDto>
    {
        private readonly ITravelService _travelService;

        public PublishCommandHandler(ITravelService travelService)
        {
            _travelService = travelService;
        }
        public async Task<PublishDto> Handle(PublishCommand request, CancellationToken cancellationToken)
        {            
            var response = await _travelService.PublishTravel(new PublishRequest
            {
                Id = request.Id
            });

            return new PublishDto
            {
                Id = response.Id,
                Message = response.Message
            };
        }

    }
}

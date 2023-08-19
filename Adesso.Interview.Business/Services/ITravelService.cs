using Adesso.Interview.Business.Models.Travel.Requests;
using Adesso.Interview.Business.Models.Travel.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Adesso.Interview.Business.Services
{
    public interface ITravelService
    {
        Task<CreateResponse> CreateTravel(CreateRequest request);

        Task<PublishResponse> PublishTravel(PublishRequest request);

        Task<RollBackPublishResponse> RollBackPublishTravel(RollBackPublishRequest request);

        Task<JoinResponse> JoinTravel(JoinRequest request);

        Task<List<TravelResponse>> TravelList(TravelRequest request);
    }
}

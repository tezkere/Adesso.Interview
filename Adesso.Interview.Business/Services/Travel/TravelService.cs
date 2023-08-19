using Adesso.Interview.Business.Models.Travel.Requests;
using Adesso.Interview.Business.Models.Travel.Responses;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Adesso.Interview.Business.Services
{
    public class TravelService : ITravelService
    {
        public Task<CreateResponse> CreateTravel(CreateRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<RollBackPublishResponse> RollBackPublishTravel(RollBackPublishRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<JoinResponse> JoinTravel(JoinRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<PublishResponse> PublishTravel(PublishRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<List<TravelResponse>> TravelList(TravelRequest request)
        {
            throw new NotImplementedException();
        }
    }
}

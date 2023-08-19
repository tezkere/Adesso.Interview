using Adesso.Interview.Business.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Adesso.Interview.Api.App.Travel.Search
{
    public class SearchQueryHandler : IRequestHandler<SearchQuery, List<SearchDto>>
    {
        private readonly ITravelService _travelService;

        public SearchQueryHandler(ITravelService travelService)
        {
            _travelService = travelService;
        }
        public async Task<List<SearchDto>> Handle(SearchQuery request, CancellationToken cancellationToken)
        {
            var response = await _travelService.TravelList(new Business.Models.Travel.Requests.TravelRequest
            {
                ToFrom = request.ToFrom,
                ToWhere = request.ToWhere
            });

            return response.Select(item => new SearchDto
            {
                Id = item.Id,
                ToFrom = item.ToFrom,
                ToWhere = item.ToWhere,
                Description = item.Description,
                Date = item.Date,
                Capacity = item.SeatingCapacity
            }).ToList();
        }

    }

}

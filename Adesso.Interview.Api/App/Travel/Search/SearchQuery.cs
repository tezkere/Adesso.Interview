using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Adesso.Interview.Api.App.Travel.Search
{

    public class SearchQuery : IRequest<List<SearchDto>>
    {
        [Required] [Range(1, 1000)] public int ToFrom { get; set; }
        [Required] [Range(1, 1000)] public int ToWhere { get; set; }
    }

}

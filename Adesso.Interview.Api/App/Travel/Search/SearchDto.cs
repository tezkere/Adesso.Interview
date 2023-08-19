using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adesso.Interview.Api.App.Travel.Search
{
    public class SearchDto
    {
        public Guid Id { get; set; }
        public int ToFrom { get; set; }
        public int ToWhere { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int Capacity { get; set; }
    }
}

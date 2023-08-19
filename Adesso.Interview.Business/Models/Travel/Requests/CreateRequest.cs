using System;
using System.Collections.Generic;

namespace Adesso.Interview.Business.Models.Travel.Requests
{
    public class CreateRequest
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int ToFrom { get; set; }
        public int ToWhere { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int AvailableSeatingCapacity { get; set; }
        public bool IsPublish { get; set; } = false;
        public List<int> NeighbourList { get; set; }
    }
}

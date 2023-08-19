using System;

namespace Adesso.Interview.Business.Models.Travel.Responses
{
    public class TravelResponse
    {
        public Guid Id { get; set; }
        public int ToFrom { get; set; }
        public int ToWhere { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int SeatingCapacity { get; set; }
    }
}

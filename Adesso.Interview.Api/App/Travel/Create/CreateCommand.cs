using MediatR;
using System;
using System.ComponentModel.DataAnnotations;


namespace Adesso.Interview.Api.App.Travel.Create
{
    public class CreateCommand : IRequest<CreateDto>
    {
        [Required] [Range(1, 1000)] public int ToFrom { get; set; }
        [Required] [Range(1, 1000)] public int ToWhere { get; set; }
        [Required] public DateTime Date { get; set; } = DateTime.Now;
        [Required] public string Description { get; set; }
        [Range(1, 10)] public int Capacity { get; set; } = 1;
    }
}

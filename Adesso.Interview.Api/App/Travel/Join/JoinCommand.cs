using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Adesso.Interview.Api.App.Travel.Join
{
    public class JoinCommand : IRequest<JoinDto>
    {
        [Required] public string Id { get; set; }
        [Range(1, 3)] public int SeatingCount { get; set; } = 1;
    }
}

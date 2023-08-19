using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Adesso.Interview.Api.App.Travel.Publish

{
    public class PublishCommand : IRequest<PublishDto>
    {
        [Required] public string Id { get; set; }        
    }
}

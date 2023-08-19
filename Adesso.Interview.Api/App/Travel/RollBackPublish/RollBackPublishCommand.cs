using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Adesso.Interview.Api.App.Travel.RollBackPublish

{
    public class RollBackPublishCommand : IRequest<RollBackPublishDto>
    {
        public string Id { get; set; }     
    }
}

using Adesso.Interview.Api.App.Travel.Create;
using Adesso.Interview.Api.App.Travel.Publish;
using Adesso.Interview.Api.App.Travel.RollBackPublish;
using Adesso.Interview.Api.App.Travel.Join;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;
using System.Collections.Generic;
using Adesso.Interview.Api.App.Travel.Search;

namespace Adesso.Interview.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TravelController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TravelController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [ProducesResponseType(typeof(CreateDto), (int)HttpStatusCode.Created)]
        public async Task<IActionResult> Post([FromBody] CreateCommand command)
        {
            var model = await _mediator.Send(command);
            return Ok(model);
        }

        [HttpPut]
        [Route("publish")]
        [ProducesResponseType(typeof(PublishDto), (int)HttpStatusCode.NoContent)]
        public async Task<IActionResult> Put([FromBody] PublishCommand command)
        {
            var model = await _mediator.Send(command);
            return Ok(model);
        }

        [HttpPut]
        [Route("rollback")]
        [ProducesResponseType(typeof(RollBackPublishDto), (int)HttpStatusCode.NoContent)]
        public async Task<IActionResult> Put([FromBody] RollBackPublishCommand command)
        {
            var model = await _mediator.Send(command);
            return Ok(model);
        }

        [HttpPut]
        [Route("join")]
        [ProducesResponseType(typeof(JoinDto), (int)HttpStatusCode.NoContent)]
        public async Task<IActionResult> Put([FromBody] JoinCommand command)
        {
            var model = await _mediator.Send(command);
            return Ok(model);
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<SearchDto>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> Get([FromQuery] SearchQuery command)
        {
            var model = await _mediator.Send(command);
            return Ok(model);
        }
    }
}

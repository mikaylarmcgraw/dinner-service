namespace DinnerMenu.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Core;

    [ApiController]
    [Route("api/dinners")]
    public class DinnerController : BaseController<Dinner>
    {
        private readonly IDinnerService _service;

        public DinnerController(IDinnerService service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }

        [HttpGet("")]
        public List<string> Get()
        {
            var result = _service.Get();
            return result;
        }

        [HttpPost("")]
        public async Task<Dinner> Post(Dinner input)
        {
            var result = await _service.Add(input);
            return result;
        }


        [HttpPut("")]
        public async Task<Dinner> Update(Dinner input)
        {
            var result = await _service.Add(input);
            if (result is null)
            {
                return null;
            }
            return result;
        }

        [HttpDelete("")]
        public void Delete()
        {

        }


    }
}

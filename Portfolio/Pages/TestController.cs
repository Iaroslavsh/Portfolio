using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Data;
using System.Net;

namespace Portfolio.Pages
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("GetAll")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult> GetAll()
        {
            return Ok("Ok");
        }

        [HttpPost("SetLanguage")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult> SetLanguage(LanguageDisplayModel lang)
        {
            return Ok(lang);
        }
    }
}

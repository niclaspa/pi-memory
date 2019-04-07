using Microsoft.AspNetCore.Mvc;
using PiMemory.Web.ViewModels;

namespace PiMemory.Web.Controllers
{
    [Route("pi-decimals")]
    public class PiDecimalController : Controller
    {
        private readonly IPiService piService;

        public PiDecimalController(IPiService piService)
        {
            this.piService = piService;
        }

        [HttpGet]
        public DecimalSegment Get([FromQuery] int length, [FromQuery] int offset = 0)
        {
            var decimals = this.piService.GetDecimalsCached(offset, length);

            return new DecimalSegment()
            {
                Digits = decimals,
                Offset = offset
            };
        }
    }
}

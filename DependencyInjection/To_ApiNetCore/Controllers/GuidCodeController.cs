using Microsoft.AspNetCore.Mvc;
using To_ApiNetCore.Services.Interfaces;

namespace To_ApiNetCore.Controllers
{
    [Route("api/{{controller}}")]
    public class GuidCodeController : ControllerBase
    {
        private readonly IGuidCodeSingleton _guidCodeSingleton;
        private readonly IGuidCodeScoped _guidCodeScoped;
        private readonly IGuidCodeTransient _guidCodeTransient;

        public GuidCodeController(IGuidCodeSingleton guidCodeSingleton, IGuidCodeScoped guidCodeScoped, IGuidCodeTransient guidCodeTransient)
        {
            _guidCodeSingleton = guidCodeSingleton;
            _guidCodeTransient = guidCodeTransient;
            _guidCodeScoped = guidCodeScoped;
        }

        [HttpGet]
        public IActionResult GetGuidCode()
        {
            var res = $"Singleton:{_guidCodeSingleton.Guid},Transient:{_guidCodeTransient.Guid},Scoped:{_guidCodeScoped.Guid}";
            return StatusCode(201, res);
        }
    }
}
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace SelfieAWookie.API.UI.Controllers
{
    [Route("api/V1/[controller]")]
    [ApiController]
    public class SelfiesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Selfie> TestListe()
        {
            return Enumerable.Range(0, 10).Select(item => new Selfie() { Id = item });
        }
    }
}

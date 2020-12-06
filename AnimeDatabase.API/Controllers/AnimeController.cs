using AnimeDatabase.API.Models;
using AnimeDatabase.API.Services.Interfaces;
using AnimeDatabase.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Net;
using System.Threading.Tasks;

namespace AnimeDatabase.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnimeController : ApiController<Anime>
    {
        private new readonly IAnimeService _service;

        public AnimeController(IAnimeService service, IOptions<AppSettings> appSettings)
            : base(service, appSettings)
        {
            _service = service;
        }

        [SwaggerResponse((int)HttpStatusCode.OK, type: typeof(Anime[]))]
        public override async Task<IActionResult> Get()
        {
            return await base.Get();
        }

    }
}

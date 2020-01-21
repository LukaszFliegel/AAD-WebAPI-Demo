using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AAD_WebAPI_Demo.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ManaSymbolsController : ControllerBase
    {
        private static readonly ManaSymbol[] ManaSymbols = new[]
        {
            new ManaSymbol() { Url = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=476501&type=card" },
            new ManaSymbol() { Url = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=476502&type=card" },
            new ManaSymbol() { Url = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=476503&type=card" },
            new ManaSymbol() { Url = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=476504&type=card" },
            new ManaSymbol() { Url = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=476505&type=card" }
        };

        private readonly ILogger<ManaSymbolsController> _logger;

        public ManaSymbolsController(ILogger<ManaSymbolsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<ManaSymbol> Get()
        {
            return ManaSymbols;
        }
    }

    public class ManaSymbol
    {
        public string Url { get; set; }
    }
}

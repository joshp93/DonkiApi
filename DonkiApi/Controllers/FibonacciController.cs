using DonkiApi.Models.Classes;
using DonkiApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace DonkiApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FibonacciController : ControllerBase
    {
        private readonly ILogger<FibonacciController> logger;
        private const string EndpointName = "GetFibonacciNumbers";
        private readonly IFibonacciService _fibonacciService;

        public FibonacciController(ILogger<FibonacciController> logger, IFibonacciService fibonacciService)
        {
            _fibonacciService = fibonacciService;
            this.logger = logger;
        }

        [HttpGet(Name = EndpointName)]
        public FibonacciResponse Get(string numberOfNumbers = "10")
        {
            logger.Log(LogLevel.Information, $"In {EndpointName}");

            var n = int.Parse(numberOfNumbers);
            var result = _fibonacciService.GetFibonacciSequence(n);
            var response = new FibonacciResponse(n, result);
            logger.Log(LogLevel.Debug, "Response: {0}", response);
            return response;
        }
    }
}

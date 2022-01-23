//using Microsoft.AspNetCore.Mvc;

//namespace POCApp.Controllers
//{
//    [ApiController]
//    [Route("[controller]")]
//    public class WeatherForecastController : ControllerBase
//    {
//        private static readonly string[] Summaries = new[]
//        {
//        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
//        };

//        private readonly ILogger<WeatherForecastController> _logger;

//        public WeatherForecastController(ILogger<WeatherForecastController> logger)
//        {
//            _logger = logger;
//        }


//        // Get Function
//        [HttpGet(Name = "GetWeatherForecast")] // it is only Name
//        public IEnumerable<WeatherForecast> Get()
//        {
//            IEnumerable<WeatherForecast> wf = Enumerable.Range(1, 5)
//                .Select(index => new WeatherForecast // index is 1, 2, 3, 4, 5
//            {
//                Date = DateTime.Now.AddDays(index),
//                TemperatureC = Random.Shared.Next(-20, 55),
//                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
//            }).ToArray();

//            foreach(WeatherForecast i in wf)
//            {
//               Console.WriteLine(i.Date);
//            }

//            return wf;
//        }

//        [HttpPost]
//        public void Post(WeatherForecast obj)
//        {
//            Console.WriteLine(obj.Date);
//            Console.WriteLine(obj.TemperatureC);
//            Console.WriteLine(obj.TemperatureF);
//            Console.WriteLine(obj.Summary);
//        }
//    }
//}
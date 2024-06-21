using Microsoft.AspNetCore.Mvc;
using Racetijden.Models;

namespace Racetijden.Controllers
{
    [Route("circuits")]
    [ApiController]
    public class CircuitController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            var circuits = new List<Circuit>
            {
                new Circuit
                {
                    Name = "Abu Dhabi GP",
                    Description = "Yas Marina Circuit",
                    Flag = "are"
                },
                new Circuit
                {
                    Name = "Australian GP",
                    Description = "Melbourne",
                    Flag = "au"
                },
                new Circuit
                {
                    Name = "Austrian GP",
                    Description = "Red Bull Ring, Spielberg",
                    Flag = "aut"
                },
                new Circuit
                {
                    Name = "Azerbaijan GP",
                    Description = "Baku City Circuit",
                    Flag = "aze"
                },
                new Circuit
                {
                    Name = "Bahrain GP",
                    Description = "Bahrein, Sakhir",
                    Flag = "bhr"
                },
                new Circuit
                {
                    Name = "Belgian GP",
                    Description = "Spa-Francorchamps",
                    Flag = "bel"
                },
                new Circuit
                {
                    Name = "Brazilian GP",
                    Description = "Interlagos, São Paulo",
                    Flag = "bra"
                },
                new Circuit
                {
                    Name = "British GP",
                    Description = "Circuit Silverstone",
                    Flag = "gbr"
                },
                new Circuit
                {
                    Name = "Canadian GP",
                    Description = "Gilles Villeneuve",
                    Flag = "can"
                },
                new Circuit
                {
                    Name = "Chinese GP",
                    Description = "Shanghai",
                    Flag = "chi"
                },
                new Circuit
                {
                    Name = "Dutch GP",
                    Description = "Circuit Zandvoort",
                    Flag = "nld"
                },
                new Circuit
                {
                    Name = "Emilia Romagna GP",
                    Description = "Imola",
                    Flag = "ita"
                },
                new Circuit
                {
                    Name = "French GP",
                    Description = "Circuit Paul Ricard, Le Castellet",
                    Flag = "fra"
                },
                new Circuit
                {
                    Name = "Hungarian GP",
                    Description = "Hungaroring, Budapest",
                    Flag = "hun"
                },
                new Circuit
                {
                    Name = "Italian GP",
                    Description = "Monza",
                    Flag = "ita"
                },
                new Circuit
                {
                    Name = "Japanese GP",
                    Description = "Suzuka Circuit",
                    Flag = "jap"
                },
                new Circuit
                {
                    Name = "Mexican GP",
                    Description = "Autodromo Hermanos Rodriguez",
                    Flag = "mex"
                },
                new Circuit
                {
                    Name = "Miami GP",
                    Description = "Miami International Autodrome",
                    Flag = "usa"
                },
                new Circuit
                {
                    Name = "Monaco GP",
                    Description = "Monte Carlo",
                    Flag = "mco"
                },
                new Circuit
                {
                    Name = "Portuguese GP",
                    Description = "Portimão",
                    Flag = "por"
                },
                new Circuit
                {
                    Name = "Russian GP",
                    Description = "Sochi Autodrom",
                    Flag = "rus"
                },
                new Circuit
                {
                    Name = "Saudi Arabian GP",
                    Description = "Jeddah Street Circuit",
                    Flag = "sau"
                },
                new Circuit
                {
                    Name = "Singapore GP",
                    Description = "Marina Bay Street Circuit",
                    Flag = "sgp"
                },
                new Circuit
                {
                    Name = "Spanish GP",
                    Description = "Barcelona",
                    Flag = "esp"
                },
                new Circuit
                {
                    Name = "United States GP",
                    Description = "Austin, Texas",
                    Flag = "usa"
                }
            };

            return Ok(circuits);
        }
    }
}

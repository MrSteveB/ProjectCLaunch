using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace CLaunch.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _config;

        public HomeController(IConfiguration configuration)
        {
            _config = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Strategies()
        {
            using (SqlConnection connection = new SqlConnection(_config.GetConnectionString("dbConnectionString")))
            {
                try
                {
                    // connection.Open();

                    return View("Strategies");
                }
                catch (Exception ex)
                {
                    var bla = ex;
                    return View("Strategies");
                }
            }

        
        }
    }
}

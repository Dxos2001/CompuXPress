namespace Prototipo.Controllers
{
    public class LoginController : Controller
    {
        
        private readonly ILogger<LoginController> _logger;
        private readonly Util _util;
        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
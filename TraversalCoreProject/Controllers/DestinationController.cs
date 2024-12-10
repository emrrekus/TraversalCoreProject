using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Controllers
{
    public class DestinationController : Controller
    {
        private readonly IDestinationService _destinationService;

        public DestinationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            return View(_destinationService.TGetAll());
        }

        public IActionResult DestinationDetails(int id)
        {
            return View(_destinationService.TGetById(id));
        }

        [HttpPost]
        public IActionResult DestinationDetails(Destination destination)
        {
            return View();
        }
    }
}

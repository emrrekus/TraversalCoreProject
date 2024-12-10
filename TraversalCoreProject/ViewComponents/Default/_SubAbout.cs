using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _SubAbout : ViewComponent
    {
        private readonly ISubAboutService _subAboutService;

        public _SubAbout(ISubAboutService subAboutService)
        {
            _subAboutService = subAboutService;
        }

        public IViewComponentResult Invoke()
        {
            return View(_subAboutService.TGetAll());
        }

    }
}

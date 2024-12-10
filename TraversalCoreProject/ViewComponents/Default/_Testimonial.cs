using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _Testimonial : ViewComponent
    {

        private readonly ITestimonialsService _testimonialsService;

        public _Testimonial(ITestimonialsService testimonialsService)
        {
            _testimonialsService = testimonialsService;
        }

        public IViewComponentResult Invoke()
        {
            return View(_testimonialsService.TGetAll());
        }
    }
}

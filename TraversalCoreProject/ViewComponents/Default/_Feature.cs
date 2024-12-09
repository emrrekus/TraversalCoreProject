using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _Feature : ViewComponent
    {
        private readonly IFeatureService _featureService;

        public _Feature(IFeatureService featureService)
        {
            _featureService = featureService;
        }

        public IViewComponentResult Invoke()
        {
            return View(_featureService.TGetAll());
        }
    }
}

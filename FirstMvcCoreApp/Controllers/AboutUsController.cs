using FirstMvcCoreApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMvcCoreApp.Controllers
{
    public class AboutUsController : Controller
    {
        private readonly ITransientServices _transientServices1;
        private readonly ITransientServices _transientServices2;

        private readonly ISingletonServices _singletonServices1;
        private readonly ISingletonServices _singletonServices2;


        private readonly IScopedServices _scopedServices1;
        private readonly IScopedServices _scopedServices2;

        public AboutUsController(

        ITransientServices transientServices1,
        ITransientServices transientServices2,
        ISingletonServices singletonServices1,
        ISingletonServices singletonServices2,
        IScopedServices    scopedServices1,
        IScopedServices    scopedServices2
            )


        {
            _transientServices1 = transientServices1;
            _transientServices2 = transientServices2;
            _singletonServices1 = singletonServices1;
            _singletonServices2 = singletonServices2;
            _scopedServices1 = scopedServices1;
            _scopedServices2 = scopedServices2;
        }

        public IActionResult Index()
        {
            ViewBag.transient1 = _transientServices1.getOperation();
            ViewBag.transient2 = _transientServices2.getOperation();
            ViewBag.singleton1 = _singletonServices1.getOperation();
            ViewBag.singleton2 = _singletonServices2.getOperation();
            ViewBag.scoped1 = _scopedServices1.getOperation();
            ViewBag.scoped2 = _scopedServices2.getOperation();
            return View();
        }
    }
}

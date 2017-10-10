using Microsoft.AspNetCore.Mvc;
using Parcel.Models;

namespace Parcel.Controllers
{
  public class HomeController : Controller
  {
    [Route("/form")]
    public ActionResult Form()
    {
      return View();
    }

    [Route("/Result")]
    public ActionResult Result()
    {
      ParcelVariable myParcel = new ParcelVariable();
      myParcel.SetParcel(Request.Query["Length"],Request.Query["Width"],Request.Query["Height"],Request.Query["Weight"]);
      return View("Index", myParcel);
    }

  }
}

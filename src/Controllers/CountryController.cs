using Microsoft.AspNet.Mvc;
using System;
using System.Linq;
using System.Collections.Generic;

namespace aspnetefdemo {

  public class CountryController : Controller
  {
    private readonly DemoContext dataContext;

    public CountryController(DemoContext dataContext)
    {
      this.dataContext = dataContext;
    }

    public IEnumerable<Country> Index()
    {
      return this.dataContext.Countries;
    }
  }
}

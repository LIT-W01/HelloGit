using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloGit.Controllers
{
    public class HomeController : Controller
    {
        public void Index()
        {
            Response.Write("<h1>Hello from git!!</h1>");
        }

        public void About()
        {
            Response.Write("<h1>About Page</h1>");
        }

        public void BarPage()
        {
            Response.Write("<h3>From the bar page</h3>");
        }

        public void FooPage()
        {
            Response.Write("<h1>Foo page!</h1>");
        }
    }
}

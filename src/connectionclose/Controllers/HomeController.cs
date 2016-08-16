using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace connectionclose.Controllers
{
    public class A
    {
        public B b { get; set; }
    }
    public class B
    {
        public A a { get; set; }
    }

    public class HomeController
    {
        [Route("/")]
        public A Index()
        {
            var a = new A
            {
                b = null
            };

            var b = new B
            {
                a = a
            };
            a.b = b;

            return a;
        }
    }
}

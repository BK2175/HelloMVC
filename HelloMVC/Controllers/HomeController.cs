﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace HelloMVC.Controllers
{
    public class HomeController : Controller
    {
       public ViewResult Index()
        {
            return View();
        }

        
    }
}

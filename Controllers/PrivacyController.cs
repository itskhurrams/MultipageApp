﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

namespace MultipageApp.Controllers {
    public class PrivacyController : Controller {
        public IActionResult Index() {
            return View();
        }
    }
}

﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.Areas.MemberArea.Controllers
{
    [Area("MemberArea")]
    [AllowAnonymous]
    public class ReservationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
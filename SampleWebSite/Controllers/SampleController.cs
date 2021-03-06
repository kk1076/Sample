﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleWebSite.Models;
using NUnit.Framework;
using SampleWebSite.Test;

namespace SampleWebSite.Controllers
{
    public class SampleController : Controller
    {
        public ActionResult SampleMvcInnerSublayout()
        {
            var model = new SampleMvcInnerSublayoutViewModel
            {
                CurrentYear = Sitecore.DateUtil.ToServerTime(DateTime.UtcNow).Year
            };

            return View(model);
        }
    }
}


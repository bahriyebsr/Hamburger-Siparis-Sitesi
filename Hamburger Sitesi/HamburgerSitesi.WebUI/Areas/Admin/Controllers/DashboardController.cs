﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace HamburgerSitesi.WebUI.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Authorize(Roles = "Admin")]
	public class DashboardController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}

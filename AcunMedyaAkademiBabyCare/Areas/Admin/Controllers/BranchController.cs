﻿using AcunMedyaAkademiBabyCare.Context;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaAkademiBabyCare.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BranchController : Controller
    {
        private readonly BabyCareContext _context;

        public BranchController(BabyCareContext context)
        {
            _context = context;
        }

        public IActionResult BranchList()
        {
            var values = _context.Branches.ToList();
            return View(values);
        }
    }
}

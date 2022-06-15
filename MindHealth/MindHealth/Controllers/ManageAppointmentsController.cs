using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MindHealth.Data;
using MindHealth.Models;

namespace MindHealth.Controllers
{
    public class ManageAppointmentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ManageAppointmentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ManageAppointments
        [Authorize(Roles = "Psiholog")]
        public async Task<IActionResult> Index()
        {
            var x = await _context.Korisnik.ToListAsync();
            var x1 = await _context.Users.ToListAsync();
            List<Termin> ter = new List<Termin>();
            if (x1.Count > 0 && x.Count > 0)
                foreach (var i in x)
                {
                    if (x1.Any(a => a.UserName == i.email))
                    {
                        var y = x1.First(a => a.UserName == i.email);
                        if (y != null)
                        {
                            var termini = await _context.Termin.ToListAsync();
                            foreach(var j in termini)
                            {
                                if (j.usernamePsihoterapeuta == i.username && !ter.Contains(j))
                                {
                                    ter.Add(j);
                                }

                            }
                        }
                    }
                }


            return View(ter);
        }

 
      

        
    }
}

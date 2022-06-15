using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MindHealth.Data;
using MindHealth.Models;

namespace MindHealth.Controllers
{
    public class ChatController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ChatController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Chat
        public async Task<IActionResult> Index(string id)
        {
            var x= await  _context.Chat.ToListAsync();
            var users = await _context.Users.ToListAsync();
           
            List<Chat> poruke =new List<Chat>();
            foreach(Chat i in x){
                if (i.idUser == id.ToString()&&User.Identity.Name==i.idTherapist)
                {
                    poruke.Add(i);
                } }
            return View(poruke);
        }

        // GET: Chat/Create
        public IActionResult Create(int idUsera)
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idUser,idTherapist,message")] Chat chat)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chat);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index),"/Chat/"+chat.idUser);
            }
            return View(chat);
        }
    }

}

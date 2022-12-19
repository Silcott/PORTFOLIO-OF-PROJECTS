using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TicketsController : Controller
    {
        public IActionResult TicketForm()
        {
            var tickets = new Tickets(){firstName = "James"};
            return View(tickets);
        }
    }
}

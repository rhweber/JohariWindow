using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Interfaces;
using ApplicationCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JohariWindowProject.Pages.Admin
{
    public class JohariWindowModel : PageModel
    {
        [BindProperty]
        public Client ClientObj { get; set; }

        public IActionResult OnGet(int? id)
        {
            ClientObj = new Client();

            if (id != 0) //edit mode
            {
                //ClientObj = IUnitofWork.Client.Get(u => u.Id == id);

                if (ClientObj == null)
                {
                    return NotFound();
                }
            }

            return Page(); // assume insert mode
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Interfaces;
using ApplicationCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace JohariWindowProject.Pages.Admin.Clients
{
    public class ClientModel : PageModel
    {
        private readonly IUnitofWork _unitofWork;


        [BindProperty]
        public IList<SelectListItem> Adjectives { get; set; }
        [TempData]
        public string SelectedAdjectivesName { get; set; }
        [TempData]
        public string SelectedAdjectivesId { get; set; }

        public ClientModel(IUnitofWork unitofWork) => _unitofWork = unitofWork;

        public IActionResult OnGet(string id)
        {
            List<Adjective> AdjectiveList = new();
            AdjectiveList = (List<Adjective>)_unitofWork.Adjective.List(null, a => a.AdjectiveName, null);
            Adjectives = AdjectiveList.ToList<Adjective>()
                .Select(a => new SelectListItem { Text = a.AdjectiveName, Value = a.AdjectiveID.ToString() })
                .ToList<SelectListItem>();

            return Page();
        }
    }
}

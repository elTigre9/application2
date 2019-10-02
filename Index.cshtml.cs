using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace application2.Pages
{
    public class IndexModel : PageModel
    {
        public string[] RobotNames { get; set; }
        public void OnGet()
        {
            RobotNames = new string[] { "Litol Tigre", "Claudie B", "Litol NaNa", "Sugar Bear" };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ThemeParkDatabase.Models;
using Microsoft.AspNetCore.Authorization;

namespace ThemeParkDatabase.Pages.MaintenanceAudits
{
    [Authorize(Roles = "Admin, Manager")]
    public class IndexModel : PageModel
    {
        private readonly ThemeParkDatabase.Models.ThemeParkDatabaseContext _context;

        public IndexModel(ThemeParkDatabase.Models.ThemeParkDatabaseContext context)
        {
            _context = context;
        }

        public IList<MaintenanceAudit> MaintenanceAudit { get;set; }

        public async Task OnGetAsync()
        {
            MaintenanceAudit = await _context.MaintenanceAudit.ToListAsync();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AdvancedProgramming_Lesson4.Data;
using AdvancedProgramming_Lesson4.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace AdvancedProgramming_Lesson4.Pages
{
    public class UsersModel : PageModel
    {
        private readonly AdvancedProgramming_Lesson4.Data.ApplicationDbContext _context;

        public UsersModel(AdvancedProgramming_Lesson4.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<IdentityUser> Users { get;set; }

        public async Task OnGetAsync()
        {
            Users = await _context.Users.ToListAsync();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AdvancedProgramming_Lesson4.Data;
using AdvancedProgramming_Lesson4.Models;

namespace AdvancedProgramming_Lesson4.Pages
{
    public class HistoryModel : PageModel
    {
        private readonly AdvancedProgramming_Lesson4.Data.ApplicationDbContext _context;

        public HistoryModel(AdvancedProgramming_Lesson4.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<ChatMessage> ChatMessage { get;set; }

        public async Task OnGetAsync()
        {
            ChatMessage = await _context.ChatMessages.Where(c => c.User == User.Identity.Name).ToListAsync();
        }
    }
}

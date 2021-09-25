using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdvancedProgramming_Lesson4.Models
{
    [Table("Messages")]
    public class ChatMessage
    {
        public ChatMessage(string user, string message)
        {
            this.User = user;
            this.Message = message;
        }
        public int Id { get; set; }
        public string User { set; get; }
        public string Message { set; get; }
    }
}

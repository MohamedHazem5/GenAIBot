using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_ChatBot.Models
{
    public class ChatHistory
    {
        public ChatHistory(string author, string content)
        {
            Author = author;
            Content = content;
        }

        public string Author { get; set; }
        public string Content { get; set; }
    }
}
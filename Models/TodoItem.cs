using System;

namespace demo.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string Content { get; set; }
        public bool IsComplete { get; set; }
    }
}

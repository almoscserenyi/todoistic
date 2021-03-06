﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Todoistic.Models
{
    public class TodoItem
    {
        public int TodoItemID { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        public DateTime Due { get; set; }

        [Required]
        public int StatusID { get; set; }

        [Required]
        public int Priority { get; set; }

        public Status Status { get; set; }
    }
}
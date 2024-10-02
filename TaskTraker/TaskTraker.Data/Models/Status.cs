﻿namespace TaskApp.Data.Models
{
    public class Status
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<TaskItem> Tasks { get; set; }
    }
}

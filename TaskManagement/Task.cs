using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace TaskManagement
{
    internal class Task
    {
        //Properties
        public string _Title { get; set; }
        public bool IsCompleted { get; set; }

        //Constructor
        public Task(string title)
        {
            _Title = title;
            IsCompleted = false;
        }
        //Method to display the task in the ListBox
        public override string ToString()
        {
            return IsCompleted ? $"[✓]{_Title}" : $"[] {_Title}";
        }
    }
}

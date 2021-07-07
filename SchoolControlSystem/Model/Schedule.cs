using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SchoolControlSystem.Model
{
    
    public class Schedule
    {
        [Key]
        public int ID { get; set; }
        public List<List<String>> schedule { get; set; } = new List<List<string>>();

        public Schedule()
        {
            for(int i = 0; i < 7; i++)
            {
                schedule.Add(new List<string>());
                for(int j = 0; j < 9; j++)
                {
                    schedule[i].Add("-");
                }
            }
        }
    }
}

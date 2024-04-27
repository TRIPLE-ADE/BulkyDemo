﻿namespace MVCDemo.Models
{
    public class PersonModel
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public int Age { get; set; } = 0;

        public bool isAlive { get; set; } = true;
    }
}

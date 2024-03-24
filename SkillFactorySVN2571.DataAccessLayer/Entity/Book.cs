﻿namespace SkillFactorySVN2571.DataAccessLayer.Entity
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public Guid? UserId { get; set; }
        public User? User { get; set; }
    }
}

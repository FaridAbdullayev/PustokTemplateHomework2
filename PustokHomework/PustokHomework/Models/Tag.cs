﻿namespace PustokHomework.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<BookTag> BookTags { get; set; }
    }
}

﻿namespace ProductsAPI.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }

        public Product(string name, string description, string author)
        {
            this.Id = Guid.NewGuid().ToString("D");
            this.Name = name;
            this.Description = description;
            this.Author = author;
        }

    }
}

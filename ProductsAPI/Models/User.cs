﻿namespace ProductsAPI.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User(string username, string password)
        {
            this.Id = Guid.NewGuid();
            this.Username = username;
            this.Password = password;
        }

    }
}

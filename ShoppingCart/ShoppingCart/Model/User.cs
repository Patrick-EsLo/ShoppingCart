﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ShoppingCart.Model
{
    public class User
    {
        [PrimaryKey]
        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public User() { }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public bool CheckInformation()
        {
            if (string.IsNullOrWhiteSpace(Username) && string.IsNullOrWhiteSpace(Password))
                return false;

            return true;
        }
    }
}

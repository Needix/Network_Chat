// User.cs
// Copyright 2015
// 
// Author: Need
// Contact:      
//     Mail:     mailto:needdragon@gmail.com 
//     Twitter: https://twitter.com/NeedDragon

using System;

namespace Network_Chat.ProjectSRC.Model {
    public class User {
        public enum Ranks {
            Guest,
            User,
            Mod,
            Admin,
            SuperAdmin,
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public Ranks Rank { get; set; }

        public User() { }
        public User(string username, string password, Ranks rank) {
            Username = username;
            Password = password;
            Rank = rank;
        }
    }
}
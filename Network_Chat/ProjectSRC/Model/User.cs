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

        public String Username { get; set; }
        public String Password { get; set; }
        public Ranks Rank { get; set; }

        public User() { }
        public User(String username, String password, Ranks rank) {
            Username = username;
            Password = password;
            Rank = rank;
        }
    }
}
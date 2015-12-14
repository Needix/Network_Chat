// ServerModel.cs
// Copyright 2015
// 
// Author: Need
// Contact:      
//     Mail:     mailto:needdragon@gmail.com 
//     Twitter: https://twitter.com/NeedDragon

using System;

namespace Network_Chat.ProjectSRC.Model {
    public class ServerModel {
        public string Servername { get; set; }
        public int Port { get; set; }
        public int MaxPlayer { get; set; } 
    }
}
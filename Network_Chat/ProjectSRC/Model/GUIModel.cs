// GUIModel.cs
// Copyright 2015
// 
// Project Lead: Need
// Contact:      
//     Mail:     mailto:needdragon@gmail.com 
//     Twitter: https://twitter.com/NeedDragon

using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Network_Chat.ProjectSRC.Model {
    [XmlRoot("GUIModel")]
    [XmlInclude(typeof(User)), XmlInclude(typeof(ServerModel)), XmlInclude(typeof(ClientModel))] // include classes, that are serialized here
    public class GUIModel {
        [XmlIgnore]
        public List<User> Users { get; set; }

        public ServerModel ServerModel { get; set; }
        public ClientModel ClientModel { get; set; }

        [XmlIgnore]
        public List<string> MessageList { get; set; }

        public GUIModel() {
            Users = new List<User>();
            ServerModel = new ServerModel();
            ClientModel = new ClientModel();
            MessageList = new List<string>();
        }
    }
}
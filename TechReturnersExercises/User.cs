using System;

namespace TechReturners {

    public class User {

        public User(String username, String operatingSystem, String type) {
            this.username = username;
            this.operatingSystem = operatingSystem;
            this.type = type;
        }

        public string Username 
        { get; set; }

        public string OperatingSystem
        { get; set; }

        public string Type 
        { get; set; }
    }
}


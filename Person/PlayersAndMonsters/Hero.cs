using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters
{
    public class Hero
	{
		//        	•	A constructor, which accepts:
		//		o username – string
		//		o   level – int
		//	•	The following properties:
		//		o Username - string
		//		o   Level – int
		//ToString() method

		private string username;
		private int level;

        public Hero(string username, int level)
        {
            Level = level;
            Username = username;
        }

        public int Level { get; set; }
        public string Username { get; set; }

        public override string ToString()
        {
            return $"Type: {this.GetType().Name} Username: {this.Username} Level: {this.Level}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ExitJail.Entities.Jail
{
    class Jail
    {
        public String Name { get; set; }
        public int Level { get; set; }
        public String Location { get; set; }
        public HashSet<Block> Blocks { get; set; }

        public Jail()
        {
        }

        public Jail(string name, int level, string location, HashSet<Block> blocks)
        {
            Name = name;
            Level = level;
            Location = location;
            Blocks = blocks;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Jali: " + Name);
            stringBuilder.AppendLine("Level: " + Level);
            stringBuilder.AppendLine("Location: " + Location);
            stringBuilder.AppendLine("Bloks:");

            foreach(Block item in Blocks)
            {   
                //Refector
                stringBuilder.AppendLine(item.ToString());
            }

            return stringBuilder.ToString();
        }
    }
}

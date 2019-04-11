using System;
using System.Collections.Generic;
using System.Text;

namespace ExitJail.Entities.Characters
{
    class Character
    {
        public String Name { get; set; }
        public String Nickname { get; set;}
        public Double Life { get; set; }
        public Double Power { get; set; }
        public Double Money { get; set; }
        public HashSet<Weapon> Weapons { get; set; }

        public Character() {}

        public Character(string name, string nickname)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Nickname = nickname ?? throw new ArgumentNullException(nameof(nickname));
            Life = 100.0F;
            Power = 10.0f;
            Money = 0.0f;
            Weapons = new HashSet<Weapon>();
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("      "+Nickname+" => ");
            stringBuilder.Append($"Life: {Life}     Money: $ {Money}        Power: {Power}");
            stringBuilder.Append("Weapons: ");

            foreach (Weapon w in Weapons)
            {
                stringBuilder.Append(w.Name + "   ");
            }

            return stringBuilder.ToString();
        }

    }
}

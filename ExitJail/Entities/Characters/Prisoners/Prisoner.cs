using System;
using System.Collections.Generic;
using System.Text;

namespace ExitJail.Entities.Characters.Prisoners
{
    class Prisoner : Character
    {
        public Double Respect { get; set; }

        public Prisoner(string name, string nickname) :base(name,nickname)
        {
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(base.ToString());
            stringBuilder.Append(" Respect: "+Respect);
            
            return stringBuilder.ToString();
        }
    }
}

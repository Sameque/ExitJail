using System;
using System.Collections.Generic;
using System.Text;

namespace ExitJail.Entities.Characters.Prisoners
{
    sealed class Killer : Prisoner
    {
        public int Murders { get; set; }

        public Killer(string name, string nikname, int murders):base(name,nikname)
        {
            Murders = murders;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(base.ToString());
            stringBuilder.Append(" Murders: "+Murders);

            return stringBuilder.ToString();
        }

    }
}

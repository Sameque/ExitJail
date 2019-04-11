using System;
using System.Collections.Generic;
using System.Text;

namespace ExitJail.Entities.Characters.Prisoners
{
    sealed class Thief : Prisoner
    {
        public Thief (string name, string nickname) : base(name, nickname)
        {
        }

        public Double Abiliity { get; set; }
    }
}

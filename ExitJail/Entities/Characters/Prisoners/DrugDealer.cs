using System;
using System.Collections.Generic;
using System.Text;

namespace ExitJail.Entities.Characters.Prisoners
{
    sealed class DrugDealer : Prisoner
    {
        public Double Influence { get; set; }

        public DrugDealer(string name,string nickName) :base(name, nickName)
        {
        }
    }
}

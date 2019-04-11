using System;
using System.Collections.Generic;
using System.Text;

namespace ExitJail.Entities.Characters
{
    class Guard : Character
    {
        public Double Corrupt { get; set; }

        public Guard(string name, string nickName) :base(name,nickName)
        {
        }
    }
}

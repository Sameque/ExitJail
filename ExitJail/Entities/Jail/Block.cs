using System;
using System.Collections.Generic;
using System.Text;

namespace ExitJail.Entities.Jail
{
    class Block
    {
        public String Name  { get; set; }
        public HashSet<StructureBlock> StructureBlocks { get; set; }

        public Block(string name, HashSet<StructureBlock> structureBlocks)
        {
            Name = name;
            StructureBlocks = structureBlocks;
        }

        public override string ToString()
        {
            StringBuilder stringBilder = new StringBuilder();
            stringBilder.AppendLine("Blok: "+Name);



            return stringBilder.ToString();
        }
    }
}

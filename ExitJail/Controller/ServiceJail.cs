using ExitJail.Entities.Characters;
using ExitJail.Entities.Characters.Enum;
using ExitJail.Entities.Jail;
using ExitJail.Entities.Jail.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExitJail.Controller
{
    class ServiceJail
    {

        public static void MountJail(ref Jail jail)
        {

            HashSet<Block> bloks = new HashSet<Block>();
            HashSet<StructureBlock> structureBlocks = new HashSet<StructureBlock>();
            StructureBlock structureBlock = new StructureBlock();
            Character character;


            character = FactoryCharacters.CreateCharacter("Jose", "JZ", EnumCharacters.Thief);

            structureBlock = FactoryStructureBlock.CreateStructureBlock(EnumStructureBlocks.Hall);
            structureBlock.Characters.Add(character);



            structureBlocks.Add(structureBlock);
            structureBlocks.Add(FactoryStructureBlock.CreateStructureBlock(EnumStructureBlocks.Saddle));
            structureBlocks.Add(FactoryStructureBlock.CreateStructureBlock(EnumStructureBlocks.Saddle));
            structureBlocks.Add(FactoryStructureBlock.CreateStructureBlock(EnumStructureBlocks.Saddle));

            bloks.Add(CreateBloks(1,structureBlocks));
            
            jail = new Jail("hell", 10, "são tomé e príncipe", bloks);

        }

        public static Block CreateBloks(int number, HashSet<StructureBlock> structureBlocks)
        {
            return new Block("B " + number,structureBlocks);

        }

        public static HashSet<StructureBlock> CreateStructureBlock(int amaunt,EnumStructureBlocks enumStructureBlocks)
        {
            HashSet<StructureBlock> structureBlocks = new HashSet<StructureBlock>();

            for (int i = 0; i < amaunt; i++)
            {
                structureBlocks.Add(FactoryStructureBlock.CreateStructureBlock(enumStructureBlocks));
            }
            
            return structureBlocks;
        }
    }
}

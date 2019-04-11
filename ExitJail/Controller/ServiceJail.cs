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
            Character Character;

            Character = FactoryCharacters.CreateCharacter("Jose", "JZ", EnumCharacters.Thief); 

            structureBlocks.Add(FactoryStructureBlock.CreateStructureBlock(EnumStructureBlocks.Hall));
            structureBlocks.Add(FactoryStructureBlock.CreateStructureBlock(EnumStructureBlocks.Saddle));
            structureBlocks.Add(FactoryStructureBlock.CreateStructureBlock(EnumStructureBlocks.Saddle));
            structureBlocks.Add(FactoryStructureBlock.CreateStructureBlock(EnumStructureBlocks.Saddle));


            bloks.Add(CreateBloks(1,structureBlocks));
            

            //foreach (Block item in bloks)
            //{
            //    if (item.Name == "B 1")
            //    {
            //        item.StructureBlocks = CreateStructureBlock(1,EnumStructureBlocks.HallWay);
            //        //item.StructureBlocks = CreateStructureBlock(1, EnumStructureBlocks.H);
            //        //for (int i = 0; i < 9; i++)
            //        //{
            //        //    saddle = new Saddle($"Saddle - {i + 1}");
            //        //    structureBlocks.Add(saddle);
            //        //}

            //    }
            //}

    

            //for (int i = 0; i < 9; i++)
            //{
            //    saddle = new Saddle($"Saddle - {i + 1}");
            //    structureBlocks.Add(saddle);
            //}


            jail = new Jail("hell", 10, "são tomé e príncipe", bloks);

            //String name = "Sameque da Silva Sant' ana";
            //String nickname = "Samer";

            //killer = new Character(name, nickname);

            //hallway.Characters.Add(killer);


        }
        
        public static Character CreateCharacter(string name, string nikName, EnumCharacters enumCharacters)
        {
            Character character;
            character = FactoryCharacters.CreateCharacter(string name, string nikName, enumCharacters);
            return null;
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

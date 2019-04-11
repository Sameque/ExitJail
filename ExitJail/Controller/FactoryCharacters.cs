using ExitJail.Entities.Characters.Enum;
using ExitJail.Entities.Characters.Prisoners;
using ExitJail.Entities.Characters;

namespace ExitJail.Controller
{
    static class FactoryCharacters
    {
        public static Character CreateCharacter(string name, string nickName, EnumCharacters enumCharacters)
        {
            if (enumCharacters == EnumCharacters.DrugDealer)
            {
                return new DrugDealer(name, nickName);
            }
            else if (enumCharacters == EnumCharacters.Guard)
            {
                return new Guard(name, nickName);
            }
            else if (enumCharacters == EnumCharacters.Killer)
            {
                return new Killer(name, nickName, 0);
            }
            else if (enumCharacters == EnumCharacters.Thief)
            {
                return new Thief(name, nickName);
            }

            return null;
        }
    }

}

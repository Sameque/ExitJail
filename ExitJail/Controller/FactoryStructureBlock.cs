
using ExitJail.Entities.Jail;
using ExitJail.Entities.Jail.Enum;

namespace ExitJail.Controller
{
    static class FactoryStructureBlock
    {
        public static StructureBlock CreateStructureBlock(EnumStructureBlocks enumStructureBlocks)
        {
            if (enumStructureBlocks == EnumStructureBlocks.Bathroom)
                return new Bathroom();
            if (enumStructureBlocks == EnumStructureBlocks.Courtyard)
                return new Courtyard();
            if (enumStructureBlocks == EnumStructureBlocks.Hall)
                return new Hall();
            if (enumStructureBlocks == EnumStructureBlocks.Kitchen)
                return new Kitchen();
            if (enumStructureBlocks == EnumStructureBlocks.Refectory)
                return new Refectory();
            if (enumStructureBlocks == EnumStructureBlocks.Saddle)
                return new Saddle();

            return null;
        }
    }
}

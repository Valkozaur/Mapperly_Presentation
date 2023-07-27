using Riok.Mapperly.Abstractions;

namespace Mapperly_Presentation._2._StaticMapper
{
    [Mapper]
    public static partial class StaticMapper
    {
        public static partial AggregateDto ToDTO(this Holding holding);
    }
}

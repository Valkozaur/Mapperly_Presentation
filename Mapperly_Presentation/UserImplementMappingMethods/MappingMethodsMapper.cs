using Riok.Mapperly.Abstractions;

namespace Mapperly_Presentation.UserImplementMappingMethods
{
    [Mapper]
    public partial class MappingMethodsMapper
    {
        public partial AggregateDto Map(Holding holding);

        private string DateTimeToString(DateTime dt) => dt.ToString("d");
    }
}

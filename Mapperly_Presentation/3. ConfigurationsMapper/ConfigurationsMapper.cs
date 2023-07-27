using Riok.Mapperly.Abstractions;

namespace Mapperly_Presentation._2._ConfigurationsMapper
{
    [Mapper]
    public partial class ConfigurationsMapper
    {
        [MapProperty(new[] { nameof(Holding.Instrument), nameof(Holding.Instrument.Isin) }, new[] { nameof(HoldingDTO.Isin) })]
        [MapProperty("Instrument.Isin", "Isin")]
        [MapProperty($"{nameof(Instrument)}.{nameof(Instrument.Isin)}", nameof(HoldingDTO.Isin))]
        public partial HoldingDTO Map(Holding holding);
    }
}

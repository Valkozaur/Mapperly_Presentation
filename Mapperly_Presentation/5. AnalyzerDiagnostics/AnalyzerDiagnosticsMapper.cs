using Riok.Mapperly.Abstractions;

namespace Mapperly_Presentation._5._AnalyzerDiagnostics
{
    [Mapper]
    public partial class AnalyzerDiagnosticsMapper
    {
        [MapperIgnoreTarget(nameof(AggregateDto.Isin))] //required
        public partial AggregateDto Map(Holding holding);
    }
}


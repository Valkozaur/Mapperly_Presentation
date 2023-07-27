using Riok.Mapperly.Abstractions;

namespace Mapperly_Presentation._5._AnalyzerDiagnostics
{
    [Mapper]
    public partial class AnalyzerDiagnosticsMapper
    {
        [MapperIgnoreTarget(nameof(HoldingDTO.Isin))] //required
        public partial HoldingDTO Map(Holding holding);
    }
}


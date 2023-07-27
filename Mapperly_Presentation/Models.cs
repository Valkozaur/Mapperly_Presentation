using System.Text.Json;

namespace Mapperly_Presentation
{
    public class Holding
    {
        public required string Id { get; set; }
        public required string CurrencyCode { get; set; }
        public required Instrument Instrument { get; set; }
    }

    public class Instrument
    {
        public required string Id { get; set; }
        public required string Name { get; set; }
        public DateTime DateOfIssue { get; set; }
        public required string Isin { get; set; }
    }

    public class HoldingDTO
    {
        public required string Id { get; set; }
        public required string CurrencyCode { get; set; }
        public required string InstrumentId { get; set; }
        public required string InstrumentName { get; set; }
        public string? Isin { get; set; }
        public string? InstrumentDateOfIssue { get; set; }
        public override string ToString()
        {
            return JsonSerializer.Serialize(this, options: new()
            {
                WriteIndented = true
            });
        }
    }

    public static class Models
    {
        public static Holding Holding = new()
        {
            Id = "fakeHoldingId",
            CurrencyCode = "EUR",
            Instrument = new()
            {
                Id = "fakeInstrumentId",
                Name = "TSLA",
                Isin = "TSLA:US"
            }
        };
    }
}

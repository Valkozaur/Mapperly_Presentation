﻿using Riok.Mapperly.Abstractions;

namespace Mapperly_Presentation._4._BeforeAfterMapper
{
    [Mapper]
    public partial class BeforeAfterMapper
    {
        public HoldingDTO Map(Holding holding) 
        {
            //before effect
            holding.Id = "NotSoFakeId";

            var dto = MapTo(holding);

            //after effect
            dto.Isin = "What is the ISIN?";

            return dto;
        }

        private partial HoldingDTO MapTo(Holding holding);
    }
}

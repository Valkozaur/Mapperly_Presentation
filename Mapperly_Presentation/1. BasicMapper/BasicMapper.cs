﻿using Riok.Mapperly.Abstractions;

namespace Mapperly_Presentation._1._BasicMapper
{
    [Mapper]
    public partial class BasicMapper
    {
        public partial AggregateDto Map(Holding holding);

    }
}

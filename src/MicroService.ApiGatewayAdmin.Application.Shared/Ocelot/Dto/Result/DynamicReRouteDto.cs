﻿using Newtonsoft.Json;
using System;

namespace MicroService.ApiGateway.Ocelot.Dto
{
    [Serializable]
    public class DynamicReRouteDto : DynamicReRouteDtoBase
    {
        [JsonConverter(typeof(HexLongConverter))]
        public virtual long DynamicReRouteId { get; set; }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Serialization.Models {
    public class Product {
        
        [JsonProperty(PropertyName="NAME")]
        public string Name { get; set; }

        [JsonProperty(PropertyName="PRICE")]
        public decimal Price { get; set; }

        [JsonIgnore]
        public int SecretCode { get; set; }

    }
}
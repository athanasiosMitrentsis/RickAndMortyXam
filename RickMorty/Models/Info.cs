using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace RickMorty.Models
{
    public class Response
    {
        [JsonProperty("results")]
        public IEnumerable<Character> Characters{ get; set; }

    }
}

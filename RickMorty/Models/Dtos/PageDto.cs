using System;
using System.Collections.Generic;

namespace RickMorty.Models.Dtos
{
    public class PageDto<T>
    {
        public PageInfoDto Info { get; set; }
        public IEnumerable<T> Results { get; set; }
    }
}

using System;
namespace RickMorty.Models.Dtos
{
    public class CharacterOriginDto
    {
        /// <summary>
        /// Name to the character's origin location.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Link to the character's origin location.
        /// </summary>
        public string Url { get; set; }
    }
}

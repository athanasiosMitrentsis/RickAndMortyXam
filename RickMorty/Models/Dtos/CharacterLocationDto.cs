using System;
namespace RickMorty.Models.Dtos
{
    public class CharacterLocationDto
    {
        /// <summary>
        /// Name to the character's last known location.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Link to the character's last known location.
        /// </summary>
        public string Url { get; set; }
    }
}

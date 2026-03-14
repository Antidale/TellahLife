namespace TellahLife.Models
{
    public class SpoilerLocation
    {
        /// <summary>
        /// The general location for an item, either the dungeon it is in or the broad area, e.g. Brinstar, Dark World, Palace of Darkness
        /// </summary>
        public string LocationArea { get; set; } = string.Empty;
        /// <summary>
        /// A more specific map section, e.g. Light World Death Mountain West or Crateria Central
        /// </summary>
        public string LocationRegion { get; set; } = string.Empty;
        /// <summary>
        /// the specific check where the item resides
        /// </summary>
        public string LocationName { get; set; } = string.Empty;
        public int WorldId { get; set; }
        public int ItemWorldId { get; set; }
        public string ItemName { get; set; } = string.Empty;
    }
}

namespace Eventeam.Models
{
    public class PlatformInfoViewModel
    {
        // Platform
        public int PlatformId { get; set; }
        public string Name { get; set; }
        public string CityName { get; set; }
        public string Address { get; set; }

        public ImageViewModel MainPhoto { get; set; }
    }
}
using System.Collections.Generic;

namespace Eventeam.Models
{
    public class ProjectViewModel
    {
        public string ProjectName { get; set; }
        public string FormatName { get; set; }
        public string Сustomer { get; set; }
        public string Participants { get; set; }
        public string Location { get; set; }
        public string Task { get; set; }
        public string Implementation { get; set; }
        public string Result { get; set; }
        public List<ProjectPhotoViewModel> MainPhotoList { get; set; }
        public List<ProjectPhotoViewModel> GalleryPhotoList { get; set; }
    }
}
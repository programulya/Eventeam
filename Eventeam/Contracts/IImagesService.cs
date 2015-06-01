using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eventeam.Models;

namespace Eventeam.Contracts
{
    /// <summary>
    /// Images service
    /// </summary>
    public interface IImagesService
    {
        /// <summary>
        /// Get portfolio photos
        /// </summary>
        /// <param name="folderName">Portfolio folderName</param>
        /// <param name="name">Portfolio name</param>
        /// <returns>Photos</returns>
        IList<ImageViewModel> GetPortfolioPhotos(string folderName, string name);

        /// <summary>
        /// Get platform photos
        /// </summary>
        /// <param name="folderName"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        IList<ImageViewModel> GetPlatformPhotos(string folderName, string name);

        /// <summary>
        /// Filter platform main photo
        /// </summary>
        /// <param name="photos">All photos</param>
        /// <returns>Main photo</returns>
        ImageViewModel FilterPlatformMainPhoto(IList<ImageViewModel> photos);

        /// <summary>
        /// Filter platform photos
        /// </summary>
        /// <param name="photos">All photos</param>
        /// <returns>Photos</returns>
        IList<ImageViewModel> FilterPlatformPhotos(IList<ImageViewModel> photos);
    }
}

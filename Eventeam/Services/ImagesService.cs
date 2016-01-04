using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Eventeam.Contracts;
using Eventeam.Models;

namespace Eventeam.Services
{
    public class ImagesService : IImagesService
    {
        private const string ImagesPortfolioPath = "~/images/portfolio/";
        private const string ImagesPlatformsPath = "~/images/platforms/";
        private const string ImageFile = "-.jpg";
        private const string ImageMain = "_main-.jpg";

        public IEnumerable<ImageViewModel> GetPortfolioPhotos(string folderName, string name)
        {
            if (folderName == null)
            {
                throw new ArgumentNullException(nameof(folderName));
            }

            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            var directory = GetDirectory(ImagesPortfolioPath, folderName);
            var photoList = new List<ImageViewModel>();

            if (directory != null)
            {
                var photos = Directory.GetFiles(directory).ToList();

                foreach (var p in photos)
                {
                    if (p.EndsWith(ImageFile))
                    {
                        var fileName = Path.GetFileName(p);
                        var link = ImagesPortfolioPath + folderName + "/" + fileName;
                        var linkResponsive = ImagesPortfolioPath + folderName + "/" +
                                             fileName.Substring(0, fileName.Length - ImageFile.Length) + "--400x250.jpg";

                        photoList.Add(new ImageViewModel
                        {
                            Link = link,
                            LinkResponsive = linkResponsive,
                            Alt = name
                        });
                    }
                }
            }

            return photoList;
        }

        public IList<ImageViewModel> GetPlatformPhotos(string folderName, string name)
        {
            if (folderName == null)
            {
                throw new ArgumentNullException(nameof(folderName));
            }

            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            var directory = GetDirectory(ImagesPlatformsPath, folderName);
            var photoList = new List<ImageViewModel>();

            if (directory != null)
            {
                var photos = Directory.GetFiles(directory).ToList();

                foreach (var p in photos)
                {
                    if (p.EndsWith(ImageFile))
                    {
                        var fileName = Path.GetFileName(p);
                        var link = ImagesPlatformsPath + folderName + "/" + fileName;

                        photoList.Add(new ImageViewModel
                        {
                            Link = link,
                            Alt = name
                        });
                    }
                }
            }

            return photoList;
        }

        public ImageViewModel FilterPlatformMainPhoto(IEnumerable<ImageViewModel> photos)
        {
            if (photos == null)
            {
                throw new ArgumentNullException(nameof(photos));
            }

            var mainPhoto = photos.FirstOrDefault(p => p.Link.EndsWith(ImageMain));

            return mainPhoto;
        }

        public IList<ImageViewModel> FilterPlatformPhotos(IEnumerable<ImageViewModel> photos)
        {
            if (photos == null)
            {
                throw new ArgumentNullException(nameof(photos));
            }

            var platformPhotos = photos.Where(p => !p.Link.EndsWith(ImageMain));

            return platformPhotos.ToList();
        }

        #region Helpers

        private static string GetDirectory(string path, string name)
        {
            var directories = Directory.GetDirectories(HttpContext.Current.Server.MapPath(path)).ToList();
            var directory = directories.FirstOrDefault(d => d.EndsWith(name));

            return directory;
        }

        #endregion
    }
}
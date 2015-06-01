using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Eventeam.Contracts;
using Eventeam.Models;

namespace Eventeam.Services
{
<<<<<<< HEAD
    public class ImagesService: IImagesService
    {
        private const string ImagesPortfolioPath = "~/images/portfolio/";
        private const string ImagesPlatformsPath = "~/images/platforms/";
        private const string ImgFile = "-.jpg";
=======
    public class ImagesService : IImagesService
    {
        private const string ImagesPortfolioPath = "~/images/portfolio/";
        private const string ImagesPlatformsPath = "~/images/platforms/";
        private const string ImageFile = "-.jpg";
        private const string ImageMain = "-main-.jpg";
>>>>>>> 111c5d47581eec99c64032d8db508701ee576373

        public IList<ImageViewModel> GetPortfolioPhotos(string folderName, string name)
        {
            if (folderName == null)
            {
                throw new ArgumentNullException("folderName");
            }

            if (name == null)
            {
                throw new ArgumentNullException("name");
            }

            var directory = GetDirectory(ImagesPortfolioPath, folderName);
            var photoList = new List<ImageViewModel>();

            if (directory != null)
            {
                var photos = Directory.GetFiles(directory).ToList();

<<<<<<< HEAD
                if (photos.Count != 0)
                {
                    foreach (var p in photos)
                    {
                        if (p.EndsWith(ImgFile))
                        {
                            var fileName = Path.GetFileName(p);
                            var link = ImagesPortfolioPath + folderName + "/" + fileName;
                            var linkResponsive = ImagesPortfolioPath + folderName + "/" +
                                                 name.Substring(0, name.Length - ImgFile.Length) + "--400x250.jpg";

                            photoList.Add(new ImageViewModel
                            {
                                Link = link,
                                LinkResponsive = linkResponsive,
                                Alt = name
                            });
                        }
=======
                foreach (var p in photos)
                {
                    if (p.EndsWith(ImageFile))
                    {
                        var fileName = Path.GetFileName(p);
                        var link = ImagesPortfolioPath + folderName + "/" + fileName;
                        var linkResponsive = ImagesPortfolioPath + folderName + "/" +
                                             name.Substring(0, name.Length - ImageFile.Length) + "--400x250.jpg";

                        photoList.Add(new ImageViewModel
                        {
                            Link = link,
                            LinkResponsive = linkResponsive,
                            Alt = name
                        });
>>>>>>> 111c5d47581eec99c64032d8db508701ee576373
                    }
                }
            }

            return photoList;
        }

        public IList<ImageViewModel> GetPlatformPhotos(string folderName, string name)
        {
            if (folderName == null)
            {
                throw new ArgumentNullException("folderName");
            }

            if (name == null)
            {
                throw new ArgumentNullException("name");
            }

            var directory = GetDirectory(ImagesPlatformsPath, folderName);
<<<<<<< HEAD

=======
>>>>>>> 111c5d47581eec99c64032d8db508701ee576373
            var photoList = new List<ImageViewModel>();

            if (directory != null)
            {
                var photos = Directory.GetFiles(directory).ToList();

<<<<<<< HEAD
                // TODO check
                if (photos.Count != 0)
                {
                    foreach (var p in photos)
                    {
                        if (p.EndsWith(ImgFile))
                        {
                            var fileName = Path.GetFileName(p);
                            var link = ImagesPlatformsPath + folderName + "/" + fileName;
                           
                            photoList.Add(new ImageViewModel
                            {
                                Link = link,
                                Alt = name
                            });
                        }
=======
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
>>>>>>> 111c5d47581eec99c64032d8db508701ee576373
                    }
                }
            }

            return photoList;
        }

        public ImageViewModel FilterPlatformMainPhoto(IList<ImageViewModel> photos)
        {
            if (photos == null)
            {
                throw new ArgumentNullException("photos");
            }

<<<<<<< HEAD
            // TODO
            var mainPhoto = photos.FirstOrDefault(p => p.Link.EndsWith("-main-.jpg"));
=======
            var mainPhoto = photos.FirstOrDefault(p => p.Link.EndsWith(ImageMain));
>>>>>>> 111c5d47581eec99c64032d8db508701ee576373

            return mainPhoto;
        }

        public IList<ImageViewModel> FilterPlatformPhotos(IList<ImageViewModel> photos)
        {
            if (photos == null)
            {
                throw new ArgumentNullException("photos");
            }

<<<<<<< HEAD
            var platformPhotos = photos.Where(p => !p.Link.EndsWith("-main-.jpg"));
=======
            var platformPhotos = photos.Where(p => !p.Link.EndsWith(ImageMain));
>>>>>>> 111c5d47581eec99c64032d8db508701ee576373

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
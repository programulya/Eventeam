using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Eventeam.Database.Helpers
{
    public static class ResourceHelper
    {
        public static string ReadEmbedded(string resourceName)
        {
            var assembly = typeof(ResourceHelper).Assembly;

            using (var stream = assembly.GetManifestResourceStream(resourceName))
            {
                using (var reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }
}
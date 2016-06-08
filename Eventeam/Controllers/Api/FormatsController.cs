using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using Eventeam.Database;

namespace Eventeam.Controllers.Api
{
    public class FormatsController : ApiController
    {
        // GET api/formats
        public HttpResponseMessage GetAll()
        {
            using (var db = new EventeamContext())
            {
                var formats = db.Formats.ToList();

                var content = formats.Select(p => new
                {
                    p.FormatID,
                    p.Name
                }).ToList();

                return Request.CreateResponse(HttpStatusCode.OK, content, JsonMediaTypeFormatter.DefaultMediaType);
            }
        }
    }
}
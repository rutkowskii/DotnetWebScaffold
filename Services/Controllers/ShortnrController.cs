using System.Web.Http;
using DotnetWebScaffold.Dtos;

namespace DotnetWebScaffold.Controllers
{
    public class SampleApiController : ApiController
    {
        //POST api/shortnr/reallink
        [HttpPost]
        [Route("api/shortnr/reallink")]
        public ShortenLinkResponse ShortenLink([FromBody] ShortenLinkRequest shortenLinkRequest)
        {
            var result = new ShortenLinkResponse
            {
                ShortenedLinkId = "x"
            };
            return result;
        }

        //GET api/shortnr/shortened/{shortenedLinkId}
        [HttpGet]
        [Route("api/shortnr/shortened/{shortenedLinkId}")]
        public GetByShortenedLinkResponse GetByShortenedLink(string shortenedLinkId)
        {
            var result = new GetByShortenedLinkResponse
            {
                RealLink = "x"
            };
            return result;
        }
    }
}
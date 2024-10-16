using Concessionaria.Api.Infra.Configuration;
using System.Web.Http;

namespace Concessionaria.Api.Controllers
{
    public class PingController : AuthApiController
    {
        public IHttpActionResult Get() => Ok();
    }
}

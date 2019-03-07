using RenaultTest.Models;
using System.Web.Http;

namespace RenaultTest.Controllers
{
    [AllowAnonymous]
    [RoutePrefix("api/test")]
    public class TestController : ApiController
    {
        StudentMining sm = new StudentMining();

        [HttpGet]
        public IHttpActionResult GetTest()
        {
            return Ok(sm.GetStudents());
        }

        [HttpGet]
        [Route("{term}")]
        public IHttpActionResult GetTest(int term)
        {
            return Ok(sm.GetStudents(term));
        }
    }
}
using Models;
using RenaultTest.Models;
using System.Web.Http;

namespace RenaultTest.Controllers
{
    //[Authorize]
    [AllowAnonymous]
    [RoutePrefix("api/subject")]
    public class SubjectController : ApiController
    {
        SubjectMining sm = new SubjectMining();
        [HttpGet]
        public IHttpActionResult GetSubjects() => Ok(sm.GetSubjects);

        [HttpGet]
        [Route("id={id}")]
        public IHttpActionResult GetSubject(long id) => Ok(sm.GetSubject(id));

        [HttpPost]
        public IHttpActionResult PostSubject([FromBody]Subject subject) => Ok(sm.PostSubject(subject));

        [HttpPut]
        public IHttpActionResult PutSubject([FromBody]Subject subject) => Ok(sm.PutSubject(subject));

        [HttpDelete]
        public IHttpActionResult DeleteSubject([FromBody]Subject subject) => Ok(sm.DeleteSubject(subject));
    }
}
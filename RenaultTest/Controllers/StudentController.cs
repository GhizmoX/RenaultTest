using Models;
using RenaultTest.Models;
using System.Web.Http;

namespace RenaultTest.Controllers
{
    //[Authorize]
    [AllowAnonymous]
    [RoutePrefix("api/student")]
    public class StudentController : ApiController
    {
        StudentMining sm = new StudentMining();
        [HttpGet]
        public IHttpActionResult GetStudent() => Ok(sm.GetStudents());

        [HttpGet]
        [Route("{term}")]
        public IHttpActionResult GetStudent(int term) => Ok(sm.GetStudents(term));

        [HttpGet]
        [Route("id={id}")]
        public IHttpActionResult GetStudent(long id) => Ok(sm.GetStudent(id));

        [HttpPost]
        public IHttpActionResult PostStudent([FromBody]Student student) => Ok(sm.PostStudent(student));

        [HttpPut]
        public IHttpActionResult PutStudent([FromBody]Student student) => Ok(sm.PutStudent(student));

        [HttpDelete]
        public IHttpActionResult DeleteStudent([FromBody]Student student) => Ok(sm.DeleteStudent(student));
    }
}
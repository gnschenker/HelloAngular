using HelloAngular.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace HelloAngular.Controllers
{
    public class TasksController : ApiController
    {
        static List<Task> tasks = new List<Task>{
            new Task{Id = 1, Name = "Learn AngularJS", Status = TaskStatus.Pending.ToString()},
            new Task{Id = 2, Name = "Write blog post", Status = TaskStatus.Pending.ToString()},
            new Task{Id = 3, Name = "Buy milk", Status = TaskStatus.Done.ToString()},
        };

        public IEnumerable<Task> Get()
        {
            return tasks;
        }

        static int maxId = 3;

        public void Post([FromBody]Task value)
        {
            var headers = HttpContext.Current.Request.Headers;
            IEnumerable<string> headerValues = headers.GetValues("CommandType");
            var commandType = headerValues.FirstOrDefault();
            if (commandType != "CreateTask")
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            value.Id = ++maxId;
            value.Status = TaskStatus.Pending.ToString();
            tasks.Add(value);
            HttpContext.Current.Response.AddHeader("Location", "api/tasks/" + value.Id);
        }

        public Task Get(int id)
        {
            return tasks.Single(t => t.Id == id);
        }

        #region More code...
        public void Put(int id, [FromBody]Task value)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            tasks = tasks.Where(t => t.Id != id).ToList();
        }
        #endregion
    }
}
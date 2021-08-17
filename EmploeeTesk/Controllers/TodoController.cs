using EmploeeTesk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace EmploeeTesk.Controllers
{
    // [EnableCors(origins: "https://9chox.csb.app", headers: "*", methods: "*")]

    public class TodoController : ApiController
    {

        public List<Todo> tasks;
        TodoController()
        {
            tasks = new List<Todo>();
            tasks.Add(new Todo()
            {
                id = 1,
                Userid = 1,
                title = "first task",
                complated = true
            });
            tasks.Add(new Todo()
            {
                id = 2,
                Userid = 1,
                title = "second task",
                complated = true
            }
            );
            tasks.Add(new Todo()
            {
                id = 5,
                Userid = 1,
                title = "second task",
                complated = true
            }
            );
            tasks.Add(new Todo()
            {
                id = 6,
                Userid = 2,
                title = "second task",
                complated = true
            }
            );
            tasks.Add(new Todo()
            {
                id = 8,
                Userid = 2,
                title = "second task",
                complated = true
            }
            );
            tasks.Add(new Todo()
            {
                id = 10,
                Userid = 1,
                title = "second task",
                complated = false
            }
            );
        }

        public List<Todo> getTasks(int id)
        {
            var newList = tasks.Where((t) => t.Userid.Equals(id)).OrderBy(x => x.complated).ToList();

            return newList;
        }

        [HttpPost]
        public void AddTask([fromBody]Todo task)
        {
            tasks.Add(task);

        }

        [HttpPut]
        public Boolean setStatusTask([fromBody]Todo task,int id)
        {
            var t = tasks.Find((i) => i.id == id);
            t.complated = true;
            return t.complated;
        }
    }
}
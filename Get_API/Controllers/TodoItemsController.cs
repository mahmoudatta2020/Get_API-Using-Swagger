using Get_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Get_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoItemsController : ControllerBase
    {
        List<TodoItem> todoitem = new List<TodoItem>();
        public TodoItemsController()
        {
            todoitem.Add(new TodoItem
            {
                Id = 1,
                Name="item1",
                Iscomplete=true
            });
            todoitem.Add(new TodoItem
            {
                Id = 2,
                Name = "item2",
                Iscomplete = false
            });
            todoitem.Add(new TodoItem
            {
                Id = 3,
                Name = "item3",
                Iscomplete = true
            });
        }
        [HttpGet]
        public List<TodoItem> Get()
        {
            return todoitem;
        }
    }
}

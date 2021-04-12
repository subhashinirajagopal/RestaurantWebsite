using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace karikanji.Models
{
    public class ModelInitializer : System.Data.Entity.DropCreateDatabaseAlways<UsersContext>
    {
        protected override void Seed(UsersContext context)
        {
            var todos = new List<Todo>
            {
            new Todo{TodoId=1, ThingsToDo="Buy"},
            new Todo{TodoId=2, ThingsToDo="Regret"}
            };

            todos.ForEach(s => context.Todos.Add(s));
            context.SaveChanges();
        }
    }
}
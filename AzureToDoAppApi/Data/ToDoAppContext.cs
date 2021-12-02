using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AzureToDoAppApi.Models;

namespace AzureToDoAppApi.Data
{
    public class ToDoAppContext : DbContext
    {
        public ToDoAppContext (DbContextOptions<ToDoAppContext> options)
            : base(options)
        {
        }

        public DbSet<AzureToDoAppApi.Models.TodoItem> TodoItem { get; set; }
    }
}

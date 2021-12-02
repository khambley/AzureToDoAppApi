using AzureToDoAppApi.Data;
using AzureToDoAppApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Datasync;
using Microsoft.AspNetCore.Datasync.EFCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AzureToDoAppApi.Controllers
{
	[AllowAnonymous]
	[Route("tables/[controller]")]
	[ApiController]
	public class TodoItemsController : TableController<TodoItem>
	{
		public TodoItemsController(ToDoAppContext context) : base()
		{
			Repository = new EntityTableRepository<TodoItem>(context);
		}
	}
}

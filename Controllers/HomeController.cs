﻿using Microsoft.AspNetCore.Mvc;
using DotNetTodoList.Models;

namespace DotNetTodoList.Controllers
{
  public class HomeController : Controller
  {
    private readonly Todo _todo;

    public HomeController(TodoContext context)
    {
      _todo = new Todo(context);
    }

    public IActionResult Index()
    {
      ViewBag.Tasks = _todo.GetALl();
      return View();
    }
  }
}

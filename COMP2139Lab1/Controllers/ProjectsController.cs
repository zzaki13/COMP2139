using Microsoft.AspNetCore.Mvc;
using COMP2139Lab1.Models; 
using System.Collections.Generic;
using System.Linq;

namespace COMP2139Lab1.Controllers;

public class ProjectsController : Controller
{
        private static List<Project> _projects = new List<Project>();

        public IActionResult Index()
        {
            return View(_projects);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Project project)
        {
            if (ModelState.IsValid)
            {
                project.Id = _projects.Count + 1;
                _projects.Add(project);
                return RedirectToAction("Index");
            }
            return View(project);
        }

        public IActionResult Details(int id)
        {
            var project = _projects.FirstOrDefault(p => p.Id == id);
            if (project == null)
            {
                return NotFound();
            }
            return View(project);
        }
    }

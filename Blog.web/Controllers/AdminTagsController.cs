using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.web.Data;
using Blog.web.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Blog.web.Controllers
{
    public class AdminTagsController : Controller
    {
        private BlogDbContext _blogDbContext;

        public AdminTagsController(BlogDbContext blogDbContext)
        {
            this._blogDbContext = blogDbContext;
        }


        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddTagRequest addTagRequest)
        {
            var tag = new Models.Tag();
            tag.Name = addTagRequest.name;
            tag.DisplayName = addTagRequest.displayName;

            _blogDbContext.Add(tag);
            _blogDbContext.SaveChanges();
            return View("Add");
        }
    }
}


using Blog.Entity.Entities;
using Blog.Service.Services.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Drawing.Text;
using System.Security.Claims;

namespace Blog.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IArticleService articleService;

        public HomeController(IArticleService articleService)
        {
            this.articleService = articleService;
        
        }
        public async Task<IActionResult> Index()
        {
            var articles = await articleService.GetAllArticleWithCategoryNonDeletedAsync();
            
            return View(articles);
        }
    }
}

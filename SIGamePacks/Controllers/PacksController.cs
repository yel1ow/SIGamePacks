using Microsoft.AspNetCore.Mvc;
using SIGamePacks.Data.Interfaces;
using SIGamePacks.ViewModels;

namespace SIGamePacks.Controllers
{
    public class PacksController : Controller
    {
        private readonly IPacksService packsService;
        private readonly ITagsService tagsService;

        public PacksController(IPacksService packsService, ITagsService tagsService)
        {
            this.packsService = packsService;
            this.tagsService = tagsService;
        }

        // GET
        public ViewResult Index()
        {
            ViewBag.Title = "Page with packs";
            var obj = new PacksIndexViewModel
            {
                Packs = packsService.GetAllPacks,
                Tags = tagsService.GetAllTags
            };
            return View(obj);
        }
    }
}
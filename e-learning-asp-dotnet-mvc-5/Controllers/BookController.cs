using System.Web.Mvc;
using BookModel = e_learning_asp_dotnet_mvc_5.Models.BookModel;

namespace e_learning_asp_dotnet_mvc_5.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            return View("BookView", new BookModel
            {
                Title = "Head First Design Patterns: A Brain-Friendly Guide 1st Edition",
                Authors = "Eric Freeman",
                Tags = "Code design"
            });
        }
    }
}
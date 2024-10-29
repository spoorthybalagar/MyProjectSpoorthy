using CodeFirstApprochWith2Tables.Models;
//using CodeFirstApprochWith2Tables.Repository;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;

//namespace CodeFirstApprochWith2Tables.Controllers
//{
//    public class TutorialController : Controller
//    {
//        private readonly ITutorialRepository _tutorialRepository;
//        private readonly TutorialDbContext _context;
//        public TutorialController(ITutorialRepository tutorialRepository, TutorialDbContext context)
//        {
//            _tutorialRepository = tutorialRepository;
//            _context = context;
//        }
//        public IActionResult Index()
//        {
//            return View(_tutorialRepository.GetAllTutorial());
//        }
//        public IActionResult Details(int id)
//        {
//            return View(_tutorialRepository.GetTutorialById(id));
//        }
//        public IActionResult Create()
//        {
//            ViewData["ArticleId"] = new SelectList(_context.Articles, "ArticleId", "ArticleId");
//            return View();
//        }
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public IActionResult Create([Bind("ArticleId,TutorialName,TutorialDescription,TutorialId")] Tutorial tutorial)
//        {

//            if (ModelState.IsValid)
//            {
//                _tutorialRepository.AddTutorial(tutorial);
//                return RedirectToAction("Index");
//            }
//            return View();
//        }
//        public IActionResult Edit(int id)
//        {
//            return View(_tutorialRepository.GetTutorialById(id));
//        }
//        [HttpPost]
//        public IActionResult Edit(Tutorial tutorial)
//        {
//            _tutorialRepository.UpdateTutorial(tutorial);
//            return RedirectToAction("Index");
//        }
//        public IActionResult Delete(int id)
//        {
//            return View(_tutorialRepository.DeleteTutorial(id));
//        }
//        [HttpPost, ActionName("Delete")]
//        public IActionResult DeleteConfirmed(int id)
//        {
//            _tutorialRepository.DeleteTutorial(id);
//            return RedirectToAction("Index");
//        }
//    }
//}
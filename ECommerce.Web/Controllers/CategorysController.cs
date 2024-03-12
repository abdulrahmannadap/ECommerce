using ECommerce.DAL.Services.Interface;
using ECommerce.Models;
using Microsoft.AspNetCore.Http.Metadata;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Web.Controllers
{
    public class CategorysController : Controller
    {
        private readonly ICategoryRepo _categoryRepo;
        public CategorysController(ICategoryRepo categoryRepo)
        {
            _categoryRepo = categoryRepo;
            
        }
        public IActionResult List()
        {
           var categories = _categoryRepo.GetAll().Where(c => c.IsActive==true);
            return View(categories);
        }
        public IActionResult Upsert(int? id)
        {
            if (id == null || id == 0)
                return View("CategoryForm",new Category());
            else
            {
                var categoryInDb = _categoryRepo.Get(c => c.Id == id);
                return View("CategoryForm",categoryInDb);

            }
        }
        [HttpPost]
        public IActionResult Upsert(Category category)
        {
            if(ModelState.IsValid)
            {
                if(category.Id == 0 || category.Id == null)
                {
                    _categoryRepo.Add(category);
                    _categoryRepo.Save();
                    return RedirectToAction("List", "Categorys");
                }
                else
                {
                    _categoryRepo.Update(category);
                    _categoryRepo.Save();
                    return RedirectToAction("List", "Categorys");
                }
            }
                return View("CategoryForm", category);
        }
        public IActionResult Delete(int id)
        {
            var deleteInDb = _categoryRepo.Get(id);
            return View(deleteInDb);

        }
        [HttpPost]
        public IActionResult DeleteConfirme(int id)
        {
            _categoryRepo.Remove(id);
            _categoryRepo.Save();
            return RedirectToAction("List","Categorys");

        }
    }
}

// Importing necessary namespaces
using BulkyBookWeb.Data;
using BulkyBookWeb.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

// Defining a controller for handling category-related actions
namespace BulkyBookWeb.Controllers
{
    public class CategoryController : Controller
    {
        // Creating an instance of the application database context
        private readonly ApplicationDBContext _db;

        // Constructor to initialize the controller with the database context
        public CategoryController(ApplicationDBContext db)
        {
            _db = db;
        }

        // Action method for displaying the list of categories
        public IActionResult Index()
        {
            // Retrieving a list of categories from the database
            IEnumerable<Category> objCategoryList = _db.Categories.ToList();

            // Checking if the list is empty or null
            if (objCategoryList == null || !objCategoryList.Any())
            {
                // Handle the case when there are no categories in the database.
                // You can set a message or return a different view.
                return View("NoCategoriesFound"); // Example: Create a view named "NoCategoriesFound.cshtml"
            }

            // Returning the list of categories to the corresponding view
            return View(objCategoryList);
        }

        // GET action method for displaying the category creation form
        public IActionResult Create()
        {
            return View();
        }

        // POST action method for handling category creation
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category obj)
        {
            // Validating if the Name and DisplayOrder values are the same
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "The DisplayOrder cannot exactly match the Name.");
            }

            // Checking if the model state is valid
            if (ModelState.IsValid)
            {
                // Adding the new category to the database and saving changes
                _db.Categories.Add(obj);
                _db.SaveChanges();

                // Setting a success message in TempData and redirecting to the Index action
                TempData["success"] = "Category Created Successfully";
                return RedirectToAction("Index");
            }

            // Returning to the Create view with validation errors if the model state is not valid
            return View(obj);
        }

        // GET action method for displaying the category edit form
        public IActionResult Edit(int? id)
        {
            // Checking if the category ID is null or zero
            if (id == null || id == 0)
            {
                return NotFound();
            }

            // Finding the category from the database based on the provided ID
            var categoryFromDb = _db.Categories.Find(id);

            // Returning a 404 Not Found result if the category is not found
            if (categoryFromDb == null)
            {
                return NotFound();
            }

            // Returning the category to the Edit view
            return View(categoryFromDb);
        }

        // POST action method for handling category updates
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category obj)
        {
            // Validating if the Name and DisplayOrder values are the same
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "The DisplayOrder cannot exactly match the Name.");
            }

            // Checking if the model state is valid
            if (ModelState.IsValid)
            {
                // Updating the category in the database and saving changes
                _db.Categories.Update(obj);
                _db.SaveChanges();

                // Setting a success message in TempData and redirecting to the Index action
                TempData["success"] = "Category Updated Successfully";
                return RedirectToAction("Index");
            }

            // Returning to the Edit view with validation errors if the model state is not valid
            return View(obj);
        }

        // GET action method for displaying the category delete confirmation page
        public IActionResult Delete(int? id)
        {
            // Checking if the category ID is null or zero
            if (id == null || id == 0)
            {
                return NotFound();
            }

            // Finding the category from the database based on the provided ID
            var categoryFromDb = _db.Categories.Find(id);

            // Returning a 404 Not Found result if the category is not found
            if (categoryFromDb == null)
            {
                return NotFound();
            }

            // Returning the category to the Delete view
            return View(categoryFromDb);
        }

        // POST action method for handling category deletion
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            // Finding the category from the database based on the provided ID
            var obj = _db.Categories.Find(id);

            // Returning a 404 Not Found result if the category is not found
            if (obj == null)
            {
                return NotFound();
            }

            // Removing the category from the database and saving changes
            _db.Categories.Remove(obj);
            _db.SaveChanges();

            // Setting a success message in TempData and redirecting to the Index action
            TempData["success"] = "Category deleted Successfully";

            return RedirectToAction("Index");
        }
    }
}

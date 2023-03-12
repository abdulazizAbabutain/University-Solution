using Microsoft.AspNetCore.Mvc;
using RestSharp;
using University_CRM_UI.MVC.Models;

namespace University_CRM_UI.MVC.Controllers
{
    public class CollageController : Controller
    {
        public readonly RestClient client = new RestClient("https://localhost:7075/api");
        public CollageController()
        {

        }        
        
        public IActionResult Index()
        {   
            var request = new RestRequest("collage");
            var model = client.Get<List<CollageViewModel>>(request);
            return View(model);
        }
        [HttpGet]
        public IActionResult AddCollage() 
        { 
            return View();
        }
        [HttpPost]
        public IActionResult AddCollage(AddCollageViewModel viewModel)
        {
            var request = new RestRequest("collage").AddJsonBody(viewModel);
            var result = client.Post(request);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Details(int id)
        {
            var collageRequest = new RestRequest($"collage/{id}");
            
            var model = client.Get<CollageViewModel>(collageRequest);

            var departmentRequest = new RestRequest("department").AddParameter("CollageId", id);

            model!.Departments = client.Get<List<DepartmentViewModel>>(departmentRequest);


            return RedirectToAction(nameof(Index));
        }
    }
}

using DataUtilities.Repository;
using DataUtilities.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace coffeTeaProject.Controllers
{
    public class HomeController : Controller
    {
        private Repository_Recipe _repositoryRecipe;
       
        protected override void Initialize(System.Web.Routing.RequestContext requestContext)
        {            
            base.Initialize(requestContext);

            _repositoryRecipe = new Repository_Recipe();
        }
        public ActionResult Index()
        {
            var recipes = _repositoryRecipe.getAllRecipes();
            return View(recipes);
        }

       

        [HttpPost]
        public JsonResult getStepsFromId(string idReceive)
        {
            if (String.IsNullOrEmpty(idReceive)) { return null; }
            int id_ = Convert.ToInt32(idReceive);
            if (id_ >= 0) {

                List<Model_Step> steps = _repositoryRecipe.getStepsFromId(id_);
                if (steps != null) {
                    JsonResult JsonResult = new JsonResult()
                    {
                        Data = new { object_ = new object[0] },
                        JsonRequestBehavior = JsonRequestBehavior.AllowGet
                    };

                    JsonResult.Data = new List<object>();

                    steps.ForEach(step =>
                    {
                        int stepId = step.id;
                        string stepDescription = step.description;
                        ((List<object>)JsonResult.Data).Add(new { @stepId= stepId, @stepDescription= stepDescription });
                    });

                    return JsonResult;
                }
                
            }
            return null;
        }

    }
}
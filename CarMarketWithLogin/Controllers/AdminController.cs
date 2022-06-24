using System.Linq;
using CarMarketWithLogin.Data;
using CarMarketWithLogin.Helpers;
using CarMarketWithLogin.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CarMarketWithLogin.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly IUsers _users;
        private readonly IComments _comments;
        private readonly IAllCars _allCars;

        public AdminController(ApplicationDbContext applicationDbContext, IUsers users, IComments comments, IAllCars allCars)
        {
            _applicationDbContext = applicationDbContext;
            _users = users;
            _comments = comments;
            _allCars = allCars;
        }




        [Route("/Admin/AllComments")]
        public ViewResult AllUserComments()
        {
            if (User.Identity.IsAuthenticated && User.IsAdmin())
            {
                return View(_users.Users.ToList());
            }

            return View();
        }

        [Route("/Admin/DeleteComment/{idComment}")]
        public ActionResult DeleteComment(string idComment)
        {
            if (User.Identity.IsAuthenticated && User.IsAdmin())
            {
                idComment = idComment.Replace("{", "").Replace("}", "");
                var id = int.Parse(idComment);

                var comment = _applicationDbContext.Comments.First(x => x.Id == id);
                
                _applicationDbContext.Comments.Remove(comment);
                _applicationDbContext.SaveChanges();

            }

            return RedirectToAction("AllUserComments", "Admin");
        } 
        
        
        
        [Route("/Admin/AllUsers")]
        public ViewResult AllUsers()
        {
            if (User.Identity.IsAuthenticated && User.IsAdmin())
            {
                return View(_users.Users.ToList());
            }

            return View();
        }
 
        
        [Route("/Admin/DeleteUser/{id}")]
        public ActionResult DeleteUser(string id)
        {
            if (User.Identity.IsAuthenticated && User.IsAdmin())
            {
                id = id.Replace("{", "").Replace("}", "");
                _applicationDbContext.Users.Remove(_users.Users.First(x => x.Id.Equals(id)));
                _applicationDbContext.SaveChanges();
            }

            return RedirectToAction("AllUsers", "Admin");
        }
        
        [Route("/Admin/DeleteUserWithComments/{id}")]
        public ActionResult DeleteUserWithComments(string id)
        {
            if (User.Identity.IsAuthenticated && User.IsAdmin())
            {
                id = id.Replace("{", "").Replace("}", "");

                var user = _users.Users.First(x => x.Id.Equals(id));

                var comments = user.Comments.ToList(); 
                
                foreach (var comment in comments) 
                {
                    var test = _allCars.Cars.First(x => x.Id == comment.Car.Id);
                        var test2 = test.Comments.Remove(comment);
                    _applicationDbContext.Comments.Remove(comment);
                }

                _applicationDbContext.Users.Remove(user);
                _applicationDbContext.SaveChanges();
            }

            return RedirectToAction("AllUsers", "Admin");
        }
    }
}
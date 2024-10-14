using Microsoft.AspNetCore.Mvc;
using WebUI.Models;

namespace WebUI.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<CommentUserViewModel>
            {
                new CommentUserViewModel
                {
                    Id = 1,
                    UserName = "Erhan"
                },
                new CommentUserViewModel
                {
                    Id= 2,
                    UserName = "Mustafa"
                },
                new CommentUserViewModel
                {
                    Id = 3,
                    UserName = "Ahmet"
                }
            };
            return View(commentValues);
        }
    }
}

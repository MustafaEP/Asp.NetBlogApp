using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Comment
{
    public class CommentListByBlog : ViewComponent
    {
        CommentManager _commentManager = new CommentManager (new EFCommentRepository ());
        public IViewComponentResult Invoke(int id)
        {
            var values = _commentManager.GetList(id);
            return View(values);
        }
    }
}

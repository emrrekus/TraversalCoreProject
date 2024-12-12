using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Comment
{
    public class _CommentList : ViewComponent
    {

        private readonly ICommentService _commentService;

        public _CommentList(ICommentService commentService)
        {
            _commentService = commentService;
        }

        //public IViewComponentResult Invoke(int id)
        //{
        //    ViewBag.commentCount = context.Comments.Where(x => x.DestinationID == id).Count();
        //    var values = commentManager.TGetListCommentWithDestinationAndUser(id);
        //    return View(values);
        //}
    }
}

using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Models;

namespace Nop.Web.Models.News
{
    public partial record AddNewsCommentModel : BaseNopModel
    {
        [NopResourceDisplayName("News.Comments.CommentTitle")]
        public string CommentTitle { get; set; }

        [NopResourceDisplayName("News.Comments.CommentText")]
        public string CommentText { get; set; }

        //Default = false
        public bool AutomaticallyApproveComments { get => true; set => AutomaticallyApproveComments = value; }
      
        public bool DisplayCaptcha { get; set; }
    }
}
using Blog.Models;

namespace Blog.ViewModels
{
    public class CommentVM
    {
        public int Id { get; set; }
        public string? Commenter {  get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string? Content { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
namespace CodeFirstApprochWith2Tables.Models
{
    public class Article
    {
        public int? ArticleId { get; set; }

        //[Key]
        [Required(ErrorMessage = "please enter Article Title")]
        public string ArticleTitle { get; set; }
        [Required(ErrorMessage = "please enter Article Content")]
        public string ArticleContent { get; set; }

        public int TutorialId { get; set; }
        public Tutorial? Tutorials { get; set; } = null;
    }
}

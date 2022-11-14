using System.ComponentModel.DataAnnotations;

namespace WebApp.Domain.Entities
{
    public class NewsItem : EntityBase
    {
        [Required(ErrorMessage = "Fill the name")]
        [Display(Name = "Name")]
        public override string Title { get; set; }

        [Display(Name = "Short name")]
        public override string Subtitle { get; set; }

        [Display(Name = "Full description")]
        public override string Text { get; set; }

    }
}

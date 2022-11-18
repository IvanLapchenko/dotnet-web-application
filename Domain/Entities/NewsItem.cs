using System.ComponentModel.DataAnnotations;
namespace WebApp.Domain.Entities
{
    public class NewsItem : EntityBase
    {
        [Required(ErrorMessage = "Fill the name")]
        [Display(Name = "Name")]
        public override string Title { get; set; }

        [Display(Name = "Your Email")]
        public string Email { get; set; }
        public string Review { get; set; }

        [Display(Name = "Full description")]
        public override string Text { get; set; }
        public string CodeWord { get; set; }
        public bool IsApproved { get; set; }
        public bool IsRejected { get; set; }

    }
}

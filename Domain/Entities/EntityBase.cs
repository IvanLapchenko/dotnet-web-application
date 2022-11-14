using System;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Domain.Entities
{
    public abstract class EntityBase
    {
        protected EntityBase() => DateAdded = DateTime.UtcNow;

        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Name")]
        public virtual string Title { get; set; }

        [Display(Name = "Short Description")]
        public virtual string Subtitle { get; set; }

        [Display(Name = "Description")]
        public virtual string Text { get; set; }

        [Display(Name = "Title Image")]
        public virtual string TitleImagePath { get; set; }

        [Display(Name = "SEO Metatag Title")]
        public string MetaTitle { get; set; }

        [Display(Name = "SEO Metatag Description")]
        public string MetaDescription { get; set; }

        [Display(Name = "SEO Metatag Keywords")]
        public string MetaKeywords { get; set; }   

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }
    }
}

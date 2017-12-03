using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SampleMvc.Db.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле {0} обязательно для заполнения")]
        [MaxLength(64)]
        [Display(Name = "Заголовок")]

        public string Title { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "dd-MMM-yyyy", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        [MaxLength(1024)]
        public string Description { get; set; }

        [Required]
        [MaxLength(256)]
        public string Genre { get; set; }
        public decimal TicketPrice { get; set; }

        public ApplicationUser Owner { get; set; }
        public string OwnerId { get; set; }
    }
}

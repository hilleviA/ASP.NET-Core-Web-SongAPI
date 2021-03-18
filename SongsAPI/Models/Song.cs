using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SongsAPI.Models
{
    public class Song
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Du måste ange artist")]
        public string Artist { get; set; }

        [Required(ErrorMessage ="Du måste ange namn på låten")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Du måste ange längd på låten")]
        public int Length { get; set; }

        [Required(ErrorMessage = "Du måste ange en genre till låten")]
        public string Genre { get; set; }
    }
}

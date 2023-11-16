using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualStudio.Web.CodeGeneration.Utils;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;

namespace MVC_CRud.Models
{
    public class Movie
    {

        public int Id { get; set; }

        //The Required and MinimumLength attributes indicate that a property must have a value;
        //but nothing prevents a user from entering white space to satisfy this validation.
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? Title { get; set; }


        //The RegularExpression attribute is used to limit what characters can be input.
        //In the preceding code, "Genre": Must only use letters.
        //The first letter is required to be uppercase.
        //White spaces are allowed while numbers, and special characters are not allowed.
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }


        //The RegularExpression "Rating": Requires that the first character be an uppercase letter.
        //Allows special characters and numbers in subsequent spaces.
        //"PG-13" is valid for a rating, but fails for a "Genre".
        [Range(1, 100)]
        //The Range attribute constrains a value to within a specified range.
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }


        //The StringLength attribute lets you set the maximum length of a string property, and optionally its minimum length.
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string? Genre { get; set; }

        //Value types (such as decimal, int, float, DateTime) are inherently required and don't need the [Required] attribute.
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]
        public string? Rating { get; set; }

    }
}

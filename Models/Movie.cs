using System;
using System.ComponentModel.DataAnnotations;


// The Movie class contains:
//
// 1. The ID field is required by the database for the primary key.
//
// 2. [DataType(DataType.Date)]: The DataType attribute specifies the type of the data (Date). With this attribute:
//
// 2.1 The user is not required to enter time information in the date field.
// 2.2 Only the date is displayed, not time information.
namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}

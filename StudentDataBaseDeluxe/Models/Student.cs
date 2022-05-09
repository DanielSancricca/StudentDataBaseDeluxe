using System;
using System.Collections.Generic;

namespace StudentDataBaseDeluxe.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Hometown { get; set; }
        public string? FavoriteFood { get; set; }
        public string? FavoriteColor { get; set; }
    }
}

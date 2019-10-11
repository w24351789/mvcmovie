using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Phone
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Brand { get; set; }
        public string Price { get; set; }
    }
}

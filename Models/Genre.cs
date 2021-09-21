using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Models
{
    public class Genre
    {
        public byte Id { get; set; }
        
        public string Name { get; set; }
        
    }
}

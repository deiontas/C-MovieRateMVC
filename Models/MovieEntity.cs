using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MovieRate.Models
{
    public class MovieEntity
    {   
    
        public int Id {get; set;}
        public string Title {get; set;}
        public int Year {get; set;}
    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public string? BlogTittle { get; set; }
        public string? BlogContent { get; set; }
        public string? BlogThumbneilImage { get; set; }
        public string? BlogImage { get; set; }
        public DateTime? BlogCreateDate { get; set; }
        public bool BlogStatus { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int WriterId { get; set; }
        public Writer Writer { get; set; }
        public List<Comment> Comments { get; set; }
    }
}

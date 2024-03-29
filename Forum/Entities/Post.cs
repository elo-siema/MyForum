﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Entities
{
    public class Post
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(2000)]
        public string body { get; set; }
        public DateTime date { get; set; }
        public string nickname { get; set; }
        public string topic { get; set; }
        public byte[] image { get; set; }
        public int answerTo { get; set; }
    }
}

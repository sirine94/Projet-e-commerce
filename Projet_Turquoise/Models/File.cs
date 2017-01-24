﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebGrease.Activities;

namespace Projet_Turquoise.Models
{
  
    public class File
    {
        public int FileId { get; set; }
        [StringLength(255)]
        public string FileName { get; set; }
        [StringLength(100)]
        public string ContentType { get; set; }
        public byte[] Content { get; set; }
        public  FileType FileType { get; set; }
        public int PersonId { get; set; }
        public virtual Article article { get; set; }
    }
}
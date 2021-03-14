﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PhotoGallery.DAL.Models
{
    public class GenreDAL
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<PhotoDAL> Photos { get; set; } = new List<PhotoDAL>();        
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PhotoGallery.DAL.Models
{
    public class PhotoDAL
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Format { get; set; }
        public string Path { get; set; }
        public List<GenreDAL> Genres { get; set; } = new List<GenreDAL>();
    }
}

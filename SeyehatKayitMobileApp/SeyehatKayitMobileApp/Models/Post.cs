using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeyehatKayitMobileApp.Models
{
    public class Post
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(250)]
        public string Description { get; set; }
    }
}

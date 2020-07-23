using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CBQAPosts
{
    public class Post
    {
        [Key]
        public int idPost { get; set; }
        public string descriptionPost { get; set; }
    }
}

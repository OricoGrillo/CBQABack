using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CBQAPosts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly DataContext _data;

        public PostsController(DataContext data)
        {
            _data = data;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Post>> GetPosts()
        {
            var posts = _data.Posts.ToList();
            return Ok(posts);
        }

        [HttpPost]
        public ActionResult AddPost([FromBody] Post post)
        {
            _data.Posts.Add(post);
            _data.SaveChanges();
            return Ok(post);
        }

        [HttpPut]
        public ActionResult UpdatePost([FromBody] Post post)
        {
            _data.Posts.Update(post);
            _data.SaveChanges();
            return Ok(post);
        }

        [HttpDelete, Route("delete/{id}")]
        public ActionResult DeleteCategoria(int id)
        {
            var product = new Post { idPost = id };
            _data.Posts.Remove(product);
            _data.SaveChanges();

            return Ok(product);
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserPosts.Domain;

namespace UserPosts.Services.Tests
{
    class CommentDummyRepo : ICommentRepository
    {
        public IList<Comment> GetAll()
        {
            throw new NotImplementedException();
        }

        public Comment GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Comment> GetCommentsByUserId(int id)
        {
            throw new NotImplementedException();
        }
    }
}

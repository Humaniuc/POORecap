using System.Collections.Generic;

namespace UserPosts.Services
{
    public class UserService
    {
        private readonly IUserRepository userRepository;
        private readonly IPostRepository postRepository;
        private readonly ICommentRepository commentRepository;

        public UserService(IUserRepository userRepository, IPostRepository postRepository, ICommentRepository commentRepository)
        {
            this.userRepository = userRepository;
            this.postRepository = postRepository;
            this.commentRepository = commentRepository;
        }

        public UserActiveRespose GetUserActiveRespose(int id)
        {
            var response = new UserActiveRespose();

            var user = this.userRepository.GetById(id);

            response.Email = user.Email;

            var posts = this.postRepository.GetPostsByUserId(id);

            var numberOfPosts = posts.Count;

            if(numberOfPosts < 5)
            {
                response.Status = UserPostsStatus.Inactive;
            }
            else
            {
                if (numberOfPosts > 5 && numberOfPosts < 10)
                {
                    response.Status = UserPostsStatus.Active;
                }
                else
                {
                    if (numberOfPosts >= 10)
                    {
                        response.Status = UserPostsStatus.Superactive;
                    }
                }
            }
           
            return response;
        }

        public UserComments GetCommentsPerUser(int id)
        {
            var comments = new UserComments();

            var user = this.userRepository.GetById(id);

            comments.Name = user.Name;

            var comms = this.commentRepository.GetCommentsByUserId(user.Id);

            foreach(var comm in comms)
            {
                comments.Comments.Add(comm.Id, comm.Text);
            }

            return comments;
        }
    }
}

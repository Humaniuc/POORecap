﻿using NUnit.Framework;

namespace UserPosts.Services.Tests
{
    [TestFixture]
    public class UserServiceTests
    {
        UserService sut;

        [Test]
        public void Test()
        {
            IUserRepository userRepository = new UserDummyRepo();
            IPostRepository postRepository = new PostDummyRepo();
            ICommentRepository commentRepository = new CommentDummyRepo();

            sut = new UserService(userRepository, postRepository, commentRepository);

            var expected = new UserActiveRespose()
            {
                Email = "andrei@wtf.com",
                Status = UserPostsStatus.Inactive
            };

            var actual = sut.GetUserActiveRespose(1);

            Assert.AreEqual(expected.Email, actual.Email);
            Assert.AreEqual(expected.Status, actual.Status);
        }
    }
}

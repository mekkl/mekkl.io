using System;
using mekkl.Application.Posts.Commands.CreatePost;
using Xunit;

namespace mekkl.Tests.Application.Posts.Commands.CreatePost
{
    public class CreatePostCommandTest
    {
        [Fact]
        public void Test()
        {
            var command = new CreatePostCommandHandler();
            var input = new CreatePostCommand 
            {
                Title = "title"
            };

            Assert.ThrowsAsync<NotImplementedException>(() => command.Handle(input, new System.Threading.CancellationToken()));
        }
    }
}
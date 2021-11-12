using System;
using mekkl.Application.Posts.Queries;
using Xunit;


namespace mekkl.Tests.Application.Posts.Queries
{
    public class GetPostsQueryTest
    {
        [Fact]
        public async void Test()
        {
            var command = new GetPostsQueryHandler();
            var input = new GetPostsQuery();

            var result = await command.Handle(input, new System.Threading.CancellationToken());

            Assert.Equal(2, result.Posts.Count);
        }
    }
}
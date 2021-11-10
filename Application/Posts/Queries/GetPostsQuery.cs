using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace mekkl.Application.Posts.Queries
{
    public class GetPostsQuery : IRequest<PostsVm>
    {
    }

    public class GetPostsQueryHandler : IRequestHandler<GetPostsQuery, PostsVm>
    {
        public Task<PostsVm> Handle(GetPostsQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new PostsVm 
            {
                Posts = new List<PostDto> { new PostDto { Title = "Title1" }, new PostDto { Title = "Title2" } }
            });
        }
    }
}
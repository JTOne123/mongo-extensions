﻿using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Models;

namespace SimpleBlog.DataAccess
{
    public interface IBlogRepository
    {
        Task AddBlogAsync(
            Blog blog, CancellationToken cancellationToken = default);

        Task<IEnumerable<Blog>> GetBlogsAsync(
            CancellationToken cancellationToken = default);
    }
}
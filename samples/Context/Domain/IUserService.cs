﻿using System.Threading;
using System.Threading.Tasks;
using Models;

namespace SimpleBlog.Domain
{
    public interface IUserService
    {
        Task EnsureUserAsync(string userId, CancellationToken cancellationToken = default);
        Task RegisterUserAsync(User newUser, CancellationToken cancellationToken = default);
    }
}
﻿using Project.Models;

namespace Project.Repositories;
public interface IPostRepository
{
    Task<IEnumerable<Post>> GetAllPostsAsync();
    Task<Post> GetPostByIdAsync(int id);
    Task<IEnumerable<Post>> GetPostsByUserIdAsync(int userId);
    Task<Post> CreatePostAsync(Post post);
    Task<Post> UpdatePostAsync(int id, Post post);
    Task<bool> DeletePostAsync(int id);
}

﻿namespace Dotnet.EFCore.Blog.Crud.Models
{
    public sealed class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }

        public IList<Post> Posts { get; set; }
    }
}

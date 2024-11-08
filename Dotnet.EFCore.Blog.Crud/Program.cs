using Dotnet.EFCore.Blog.Crud.Data;
using Dotnet.EFCore.Blog.Crud.Models;

using var context = new BlogDataContext();

//var postWithTagsCount = context.PostWithTagsCount.ToList();

//foreach (var post in postWithTagsCount)
//{
//    Console.WriteLine("Title: " + post.Title);
//    Console.WriteLine("Count: " + post.Count);
//}

//context.Users.Add(new User
//{
//    Name = "MateusNovo",
//    Slug = "mateus-slugsss",
//    Email = "eeeeeemail.com",
//    Bio = "bio",
//    Image = "image",
//    PasswordHash = "hash123"
//});
//context.SaveChanges();


//var user = context.Users.FirstOrDefault();

//var post = new Post
//{
//    Author = user,
//    Category = new Category
//    {
//        Name = "Bnackend",
//        Slug = "backenddddd"
//    },
//    Tags = null,
//    Body = "bodyuuu",
//    Slug = "Slugggg",
//    Summary = "Summaryyyyy",
//    Title = "Titleeee"
//};

//context.Posts.Add(post);
//context.SaveChanges();

// Insert
//var tag = new Tag
//{
//    Name = "Teste EF",
//    Slug = "test-slug-ef"
//};
//context.Tags.Add(tag);
//context.SaveChanges();

// Update
//var tag = context.Tags.FirstOrDefault(x => x.Id == 1);
//tag.Name = ".NET";
//tag.Slug = "dotnet";
//context.Tags.Update(tag);
//context.SaveChanges();

// Delete
//var tag = context.Tags.FirstOrDefault(x => x.Id == 1);
//context.Tags.Remove(tag);
//context.SaveChanges();

// SELECT
//var tags = context
//    .Tags
//    .AsNoTracking()
//    .ToList();
//foreach (var tag in tags)
//    Console.WriteLine(tag.Name);



//var user = new User
//{
//    Name = "Mateus",
//    Slug = "mateus-slug",
//    Email = "email.com",
//    Bio = "bio",
//    Image = "image",
//    PasswordHash = "hash123"
//};

//var category = new Category
//{
//    Name = "Categroy",
//    Slug = "category-slug"
//};

//var post = new Post
//{
//    Author = user,
//    Category = category,
//    Body = "body",
//    Slug = "Slug",
//    Summary = "Summary",
//    Title = "Title",
//    CreateDate = DateTime.Now,
//    LastUpdateDate = DateTime.Now
//};

//context.Posts.Add(post);
//context.SaveChanges();


// SELECT
//var posts = context
//    .Posts
//    .AsNoTracking()
//    .Include(x => x.Author)
//    .Include(x => x.Category)
//    .Where(x => x.AuthorId == 2002)
//    .OrderBy(x => x.LastUpdateDate)
//    .ToList();

//foreach (var post in posts)
//    Console.WriteLine($"{post.Title} escrito por {post.Author?.Name} em {post.Category?.Name}.");


// SELECT
//var post = context
//    .Posts
//    //.AsNoTracking() UPDATE PRECISA DO TRACKING
//    .Include(x => x.Author)
//    .Include(x => x.Category)
//    .OrderBy(x => x.LastUpdateDate)
//    .FirstOrDefault();

//post.Author.Name = "Nome Alterado";
//context.Posts.Update(post);
//context.SaveChanges();
using System;
using System.Linq;
using System.Threading.Tasks;
using EFCoreGettingStarted.Models;

namespace EFCoreGettingStarted
{
	/// <summary>
	/// Base of this application playground is taken from
	/// https://docs.microsoft.com/en-us/ef/core/get-started/?tabs=visual-studio
	/// </summary>
	class Program
	{
		public static async Task Main(string[] args)
		{
			using (var db = new BloggingContext())
			{
				// Create
				Console.WriteLine("Inserting a new blog");
				await db.AddAsync(new Blog { Url = "http://blogs.msdn.com/adonet" });
				await db.SaveChangesAsync();

				// Read
				Console.WriteLine("Querying for a blog");
				var blog = db.Blogs
					.OrderBy(b => b.BlogId)
					.First();

				// Update
				Console.WriteLine("Updating the blog and adding a post");
				blog.Url = "https://devblogs.microsoft.com/dotnet";
				blog.Posts.Add(
					new Post
					{
						Title = "Hello World",
						Content = "I wrote an app using EF Core!"
					});
				await db.SaveChangesAsync();

				// Delete
				Console.WriteLine("Delete the blog");
				db.Remove(blog);
				await db.SaveChangesAsync();
			}
		}
	}
}

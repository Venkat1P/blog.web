using System;
namespace Blog.web.Models
{
	public class Tag
	{
		public Tag()
		{

		}

		public Guid Id { get; set; }

		public string Name { get; set; }

		public string DisplayName { get; set; }

		public ICollection<BlogPost> BlogPosts { get; set; }
	}
}


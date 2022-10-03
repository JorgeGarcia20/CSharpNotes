using System.Text;
using System.Text.Json;

namespace FundamentalsHttpRequest
{
	public class Program
	{
		public static async Task Main(string[] args)
		{
            //await GetHttpPost();
            //await PostHttpPost();

            //Post post = new();
            //post.UserId = 20;
            //post.Body = "Updated body";

            //await PutHttpPost(20, post);

            await DeleteHttpPost(80);
        }

		public static async Task GetHttpPost()
		{
            string url = "https://jsonplaceholder.typicode.com/posts";
            HttpClient client = new();

            /*Once we get the response we can continue with the program*/
            var httpResponse = await client.GetAsync(url);

            if (httpResponse.IsSuccessStatusCode)
            {
                string content = await httpResponse.Content.ReadAsStringAsync();
                List<Post>? posts = JsonSerializer.Deserialize<List<Post>>(content,
                    new JsonSerializerOptions()
                    {
                        PropertyNameCaseInsensitive = true
                    }
                    );
            }
        }

		public static async Task PostHttpPost()
		{
            string url = "https://jsonplaceholder.typicode.com/posts";
			HttpClient client = new();

			Post post = new Post()
			{
				UserId = 20,
				Body = "Test body post",
				Title = "Test title"
			};

			var data = JsonSerializer.Serialize<Post>(post);
			HttpContent content = new StringContent(data, Encoding.UTF8, "application/json");
			HttpResponseMessage httpResponse = await client.PostAsync(url, content);

			if (httpResponse.IsSuccessStatusCode)
			{
				string result = await httpResponse.Content.ReadAsStringAsync();
				Post? postResul = JsonSerializer.Deserialize<Post>(result);
				Console.WriteLine(postResul?.ToString());
			}
        }

		public static async Task PutHttpPost(int Id, Post post)
		{
            string url = $"https://jsonplaceholder.typicode.com/posts/{Id}";
            HttpClient client = new();

            Post updatedPost = new()
            {
                Id = post.Id,
                UserId = post.UserId,
                Body = post.Body,
                Title = post.Title
            };

            var data = JsonSerializer.Serialize<Post>(post);
            HttpContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage httpResponse = await client.PutAsync(url, content);

            if (httpResponse.IsSuccessStatusCode)
            {
                string result = await httpResponse.Content.ReadAsStringAsync();
                Post? postResul = JsonSerializer.Deserialize<Post>(result);
                Console.WriteLine(postResul?.ToString());
            }
        }

        public static async Task DeleteHttpPost(int Id)
        {
            string url = $"https://jsonplaceholder.typicode.com/posts/{Id}";
            HttpClient client = new();

            HttpResponseMessage httpResponse = await client.DeleteAsync(url);

            if (httpResponse.IsSuccessStatusCode)
            {
                string result = await httpResponse.Content.ReadAsStringAsync();
                Console.WriteLine(result);
            }
        }
    }
}

using System.Text.Json;

namespace FundamentalsHttpRequest
{
	public class Program
	{
		public static async Task Main(string[] args)
		{
			string url = "https://jsonplaceholder.typicode.com/posts";
			HttpClient client = new();

			/*Once we get the response we can continue with the program*/
			var httpResponse = await client.GetAsync(url);

			if(httpResponse.IsSuccessStatusCode)
			{
				var content = await httpResponse.Content.ReadAsStringAsync();
				List<Post>? posts = JsonSerializer.Deserialize<List<Post>>(content,
					new JsonSerializerOptions()
					{
						PropertyNameCaseInsensitive = true
					}
					);
			}
        }
	}
}

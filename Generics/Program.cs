using Generics.Models;
using Generics.Service;

namespace Generics
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Post newPost = new()
            {
                UserId = 20,
                Title = "Generics in C#",
                Body = "Learning what generics are and how to use its"
            };

            SendRequest <Post> postService = new SendRequest<Post>();
            var result = await postService.Send(newPost);

            Todo newTodo = new()
            {
                UserId = 20,
                Title = "Learning about Generics in C#",
                Completed = false
            };

            SendRequest<Todo> todoService = new SendRequest<Todo>();
            var todoResult = await todoService.Send(newTodo);
        }
    }
}

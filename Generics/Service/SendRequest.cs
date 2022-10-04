using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Generics.Service
{
    /* Si queremos delimitar el uso de un servicio debemos hacer uso 
     * de interfaces en las clases donde vamos a implementar determinado servicio
     * asi podemos condicionar el uso de determinado servicio.
     * para hacer esto debemos usar where T : Interface, por ejemplo.
     * 
     * public class SendRequest<T> where T:Interface
     * 
     * asi solo las clases que implementen determinada interface podran hacer uso de el
     * servicio SendRequest.
     */
    public class SendRequest<T>
    {
        private HttpClient _client = new();

        public async Task<T> Send(T model)
        {
            string url = "https://jsonplaceholder.typicode.com/posts";


            string data = JsonSerializer.Serialize<T>(model);
            HttpContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage httpResponse = await _client.PostAsync(url, content);

            if (httpResponse.IsSuccessStatusCode)
            {
                string result = await httpResponse.Content.ReadAsStringAsync();
                var postResult = JsonSerializer.Deserialize<T>(result, 
                    new JsonSerializerOptions() 
                    { 
                        PropertyNameCaseInsensitive=true
                    });

                return postResult;
            }
            return default(T);
        }
    }
}

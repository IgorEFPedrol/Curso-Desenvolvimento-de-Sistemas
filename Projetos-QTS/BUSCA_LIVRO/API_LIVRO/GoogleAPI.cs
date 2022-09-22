using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace API_LIVRO
{
    public class GoogleAPI
    {
        public async Task<string> Conectar(string url)
        {
            using (var cliente = new HttpClient())
            {
                var baseURI = url;
                cliente.BaseAddress = new Uri(baseURI);
                cliente.DefaultRequestHeaders.Clear();
                var response = await cliente.GetAsync(baseURI);
                if (response.IsSuccessStatusCode)
                {
                    var JSON = await response.Content.ReadAsStringAsync();
                    return JSON.ToString();
                }
            }
            return null;
        }

        public async Task <dynamic> GoogleBooks(string Codigo)
        {
            string url = String.Format(
                "https://www.googleapis.com/books/v1/volumes?q=isbn:{0}",
                Codigo);
            string json = await Conectar(url);
            if (json != null)
            {
                dynamic resultado = Newtonsoft.Json.
                    JsonConvert.DeserializeObject(json);
                return resultado;
            }
            return null;
        }
    }
}

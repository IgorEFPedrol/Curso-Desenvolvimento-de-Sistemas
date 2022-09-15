using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace API_CEP
{
    public class WebCEP
    {
        public async Task<string> Conectar(string url)
        {
            using (var cliente = new HttpClient())
            {
                var baseURI = url;
                cliente.BaseAddress = new Uri(baseURI);
                cliente.DefaultRequestHeaders.Accept.Clear();
                var response = await cliente.GetAsync(baseURI);
                if (response.IsSuccessStatusCode)
                {
                    var JSON = await response.Content.ReadAsStringAsync();
                    return JSON;
                }
                else return "";
            }
        }
        public async Task<dynamic> Consultar(string cep)
        {
            string endereco = String.Format(
                "http://viacep.com.br/ws/{0}/json/", cep); 
            string json = await Conectar(endereco);
            if (json == "") return null;
            dynamic resultado = Newtonsoft.Json.
                JsonConvert.DeserializeObject(json);
            return resultado;
        }
    }
}

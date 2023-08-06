using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Security.Policy;
using Newtonsoft.Json.Linq;

namespace Consumo_de_API
{
    public class ConsumoAPI_Publica
    {
        private string url = "";
        public ConsumoAPI_Publica(string url) { 
            this.url = url;
        }
        private dynamic GetDefaultContentAPI()
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "https://jsonplaceholder.typicode.com/posts/1";
                client.DefaultRequestHeaders.Clear();
                //client.DefaultRequestHeaders.Add("Authorization", "password");
                var rep = client.GetAsync(url).Result;
                var res = rep.Content.ReadAsStringAsync().Result;

                dynamic r = JObject.Parse(res);
                return r;
            }
        }
        public dynamic GetDefaultData()
        {
            using (HttpClient cliente = new HttpClient())//Crea el cliente
            {
                var Get = cliente.GetAsync(url).Result;//Utilizando un Get optiene la info de la apli.
                var resGet = Get.Content.ReadAsStringAsync().Result;//lee el contenido solicitado y lo almacena.
                return JObject.Parse(resGet);//Retorna la respuesta obtenida por medio de una variable dynamica.
            }
        }
        public dynamic PostDataAPI(string titulo, string descripccion, string id)
        {
            //La funcion de este metodo es la de enviar datos a la api y capturar la respuesta de esta.
            using (HttpClient cliente = new HttpClient())
            {
                cliente.DefaultRequestHeaders.Clear();
                //define los parametros del json a enviar
                string jsonText = "{'titel': '" + titulo + "', 'body': '" + descripccion + "', 'userId': '" + id + "'}";
                dynamic Json = JObject.Parse(jsonText);

                var httpContent = new StringContent(Json.ToString(), Encoding.UTF8, "application/json");
                var respuesta = cliente.PostAsync(url, httpContent).Result;
                var res = respuesta.Content.ReadAsStringAsync().Result;
                return JObject.Parse(res);
            }
        }
        public dynamic PutDataAPI(string titulo, string descripccion, string id)
        {
            //La funcion de este metodo es la de enviar datos a la api y capturar la respuesta de esta.
            using (HttpClient cliente = new HttpClient())
            {
                cliente.DefaultRequestHeaders.Clear();
                //define los parametros del json a enviar
                string jsonText = "{'titel': '" + titulo + "', 'body': '" + descripccion + "', 'userId': '" + id + "'}";
                dynamic Json = JObject.Parse(jsonText);

                var httpContent = new StringContent(Json.ToString(), Encoding.UTF8, "application/json");
                var respuesta = cliente.PutAsync(url, httpContent).Result;
                var res = respuesta.Content.ReadAsStringAsync().Result;
                return JObject.Parse(res);
            }
        }
    }
}

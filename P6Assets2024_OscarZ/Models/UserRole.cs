using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace P6Assets2024_OscarZ.Models
{
    public class UserRole
    {

        //cuando queremos comunicarnos con el API hay dos formas mas usadas
        //1. con las librerias nativas de .NET
        //2. O usando herramientas de terceros.
        // en lo perosnal he encontrado mas facil y eficiente el uso de restsharp

        public RestRequest? Request { get; set; }

        public int UserRoleId { get; set; }

        public string UserRoleDescription { get; set; } = null!;


        //FUNCIONES

        //cargar todos los roles de usuario

        public async Task<List<UserRole>?> GetAllUserRolesAsync()
        {
            try 
            {
                //tenemos que armar la ruta completa de consumo del API
                //para eso tenemos en WebAPIConnection la ruta base del API
                //y aca la completamos
                string RouterSufix = string.Format("UserRoles");

                //armamos la ruta completa de consumo del API
                string URL = Services.WebAPIConnection.ProductionURLPrefix + RouterSufix;
                // ajora tenemos la ruta completa lista

                //configuramos el request

                RestClient client =  new RestClient(URL);

                Request =  new RestRequest(URL, Method.Get);

                //agregamos el metodo de seguridad, en este caso tenemos apikey
                Request.AddHeader(Services.WebAPIConnection.ApiKeyName,Services.WebAPIConnection.ApiKeyValue);


                //y ahora ejecutamos la llamada al API
                RestResponse response = await client.ExecuteAsync(Request);

                //validamos que todo haya salido bien

                HttpStatusCode statusCode = response.StatusCode;

                if (statusCode == HttpStatusCode.OK)
                {
                    //si obtuvimos respuesta positiva desde el API
                    var list = JsonConvert.DeserializeObject<List<UserRole>>(response.Content);

                    return list;

                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                string ErrorMsg = ex.Message;
                throw;
            }

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6Assets2024_OscarZ.Services
{
    class WebAPIConnection
    {
        //aca definimos ta ruta raiz del URL det servicio web (API Rest)
        // a esta raiz, que Itamaremos Prefijo, se Ie debe adjuntar
        //el resto de ta ruta URL, que llamares Sufijo, para cada
        //endpoint que vayamos a usar

        //ademas es im ortante indicar ue normalmente los APIs
        //trabajan en dos versiones: Pruebas y Produccion

        public static string ProductionURLPrefix = "http://192.168.100.2:45455/api/";

        public static string TestingURLPrefix = "http://192.168.100.2:45455/api/";

        //ademas de la raiz de URL aca vamos a indicar cual es la API KEY que deberia
        // usar para consumir los endpoints

        public static string ApiKeyName = "P6ApiKey";
        public static string ApiKeyValue = "OscarDP6Api";
    }
}

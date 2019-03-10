using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApiServiceApplication.Controllers
{

    [EnableCors("*","*","*")] 
    public class CityController : ApiController  
    {
        private string[] sehirler = new string[] { "Ankara", "İstanbul", "Çorum" }; //string türünden array döndürelim

        public string[] Get() //Eğer Parametre gönderilmemişse dizinin hepsini alır. 
        {

            //return ("Merhaba Wep Api");
            return sehirler;
 
        }
        public string Get(int id) //parametre gönderildiği için string tipinde dizi içerisinde parametreye ait indis e karşılık gelen değeri gösterir.
        {
            return sehirler[id]; 
        } 

    }
}

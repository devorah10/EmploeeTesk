using EmploeeTesk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace EmploeeTesk.Controllers
{
    //[EnableCors(origins: "https://9chox.csb.app", headers: "*", methods: "*")]
    public class EmploeeController : ApiController
    {
        public  List<Emploee> emploeeDetails;
          EmploeeController()
        {
            emploeeDetails = new List<Emploee>();
           
            emploeeDetails.Add(new Emploee()
            {
                id = 1,
                name = "Moshe",
                userName = "Mosh",
                email = "77bat7@gmail.com",
                adress = new Address{ city = "Jerusalem", street = "H.M.G", suite = 54, zipcode = 123456 },
                geo = new geo{ ing = true, lat = false },
                phone = "0504120718"
            });
            emploeeDetails.Add(new Emploee()
            {
                id = 1,
                name = "BatSheva",
                userName = "bat7",
                email = "77b77@gmail.com",
                adress = new Address{ city = "Jerusalem", street = "H.M.G", suite = 54, zipcode = 123456 },
                geo = new geo{ ing = true, lat = false },
                phone = "0504120718"
            });

        }
        public Emploee getTasks(string email)
        {
            var emploee = emploeeDetails.Where((e) => e.email.Equals(email));

            return emploee.FirstOrDefault();
        }
    }
}

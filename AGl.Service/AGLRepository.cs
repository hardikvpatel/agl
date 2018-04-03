using AGL.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AGl.Service
{
    public class AGLRepository
    {
        private WebClient web;
        private string serviceUrl { get; set; }


        public AGLRepository(string url)
        {
            web = new WebClient();
            this.serviceUrl = url;
        }

        /// <summary>
        /// GetData from serviceURL
        /// </summary>
        /// <returns></returns>
        public List<Person> GetData()
        {
            var res = web.DownloadString(serviceUrl);
            var persons = JsonConvert.DeserializeObject<List<Person>>(res);
            return persons;
        }

        /// <summary>
        /// Get persons with Cats
        /// </summary>
        /// <returns></returns>
        public List<Person> GetPeronsWithCats()
        {
            var res = web.DownloadString(serviceUrl);
            var persons = JsonConvert.DeserializeObject<List<Person>>(res);
            var grouped = persons.Select(x => new Person { name = x.name, age = x.age, gender = x.gender, pets = x.pets.Where(c => c.type == "Cat").ToList() }).ToList();
            return grouped;
        }

    }
}

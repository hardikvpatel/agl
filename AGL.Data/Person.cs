using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGL.Data
{
    public class Person
    {
        public string name { get; set; }
        public string gender { get; set; }
        public int age { get; set; }

        private List<Pet> _pets;
        public List<Pet> pets
        {
            get { return this._pets; }
            set
            {
                if (value == null)
                {
                    this._pets = new List<Pet>();
                }
                else {
                    this._pets = value;
                }
            }
        }
    }
}

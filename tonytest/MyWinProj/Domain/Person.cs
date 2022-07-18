using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWinProj.Domain
{
    public class Person
    {
        private string id;
        private string name;

        public Person(string id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public string Id
        {
            get { return this.id; }
        }

        public string Name
        {
            get { return this.id; }
            set { this.name = value; }
        }
    }
}

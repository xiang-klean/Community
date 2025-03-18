using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Community
{
    class Province
    {
        private int id;
        private string name;
        public Province()
        { }

        public Province(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public int Id
        {
            set { this.id = value; }
            get { return this.id; }
        }
        public string Name 
        {
            set { this.name = value; }
            get { return this.name; }
        }
    }
}

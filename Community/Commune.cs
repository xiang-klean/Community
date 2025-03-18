using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Community
{
    class Commune
    {
        private int id;
        private int d_id;
        private string name;
        public Commune() { }
        public Commune(int id, int d_id, string name)
        {
            this.id = id;
            this.d_id = d_id;
            this.name = name;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int D_Id
        {
            get { return d_id; }
            set { d_id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}

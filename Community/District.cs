using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Community
{
    class District
    {
        private int id;
        private int p_id;
        private string name;
        public District() { }
        public District(int id, int p_id, string name)
        {
            this.id = id;
            this.p_id = p_id;
            this.name = name;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int P_Id
        {
            get { return p_id; }
            set { p_id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Community
{
    class DataList
    {
        private List<Province> plist;
        private List<District> dlist;
        private List<Commune> clist;

        public DataList()
        {
            this.plist = new List<Province>();
            this.dlist = new List<District>();
            this.clist = new List<Commune>();
        }
        public DataList (Province p)
        {
            this.plist = new List<Province>();
            this.plist.Add(p);
        }
        public DataList(District d)
        {
            this.dlist = new List<District>();
            this.dlist.Add(d);
        }
        public DataList(Commune c)
        {
            this.clist = new List<Commune>();
            this.clist.Add(c);
        }
        public DataList (Province p,District d)
        {
            this.plist = new List<Province>();
            this.plist.Add(p);
            this.dlist = new List<District>();
            this.dlist.Add(d);
        }
        public DataList(Province p,District d,Commune c)
        {
            this.plist = new List<Province>();
            this.plist.Add(p);
            this.dlist = new List<District>();
            this.dlist.Add(d);
            this.clist = new List<Commune>();
            this.clist.Add(c);
        }
        public void addProvince(Province p)
        {
            this.plist.Add(p);
        }
        public void addDistrict(District d)
        {
            this.dlist.Add(d);
        }
        public void addCommune(Commune c)
        {
            this.clist.Add(c);
        }
        public void removeProvince(int id)
        {
            foreach(Province p in this.plist)
            {
                if(p.Id==id)
                {
                    this.plist.Remove(p);
                    return;
                }    
            }    
        }
        public void removeDistrict(int id)
        {
            foreach (District d in this.dlist)
            {
                if (d.Id == id)
                {
                    this.dlist.Remove(d);
                    return;
                }
            }
        }
        public void removeCommune(int id)
        {
            foreach (Commune c in this.clist)
            {
                if (c.Id == id)
                {
                    this.clist.Remove(c);
                    return;
                }
            }
        }
        public void updateProvince(int id,Province p)
        {
            foreach(Province pr in  this.plist)
            {
                if(pr.Id==id)
                {
                    this.plist.Insert(this.plist.IndexOf(pr),p);
                    return;
                }
            }
        }
        public void updateDistrict(int id, District d)
        {
            foreach (District di in this.dlist)
            {
                if (di.Id == id)
                {
                    this.dlist.Insert(this.dlist.IndexOf(di), d);
                    return;
                }
            }
        }
        public void updateCommune(int id, Commune c)
        {
            foreach (Commune co in this.clist)
            {
                if (co.Id == id)
                {
                    this.clist[this.clist.IndexOf(co)] = c;
                    return;
                }
            }
        }
        public Province getSearchProvince(String name)
        {
            foreach(Province p in this.plist)
            {
                if(p.Name.Equals(name))
                {
                    return p;
                }
            }
            return null;
        }
        public District getSearchDistrict(string name)
        {
            foreach (District d in this.dlist)
            {
                if (d.Name.Equals(name))
                {
                    return d;
                }
            }
            return null;
        }
        public Commune getSearchCommune(string name)
        {
            foreach (Commune c in this.clist)
            {
                if (c.Name.Equals(name))
                {
                    return c;
                }
            }
            return null;
        }
        public List<Province> getProvinceList()
        {
            return this.plist;
        }
        public List<District> getDistrictList()
        {
            return this.dlist;
        }
        public List<Commune> getCommuneList()
        {
            return this.clist;
        }
    }
}

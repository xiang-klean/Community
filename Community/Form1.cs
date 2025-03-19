using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Community
{
    public partial class Form1: Form
    {
        DataList dlst;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dlst = new DataList();
            this.dlst.addProvince(new Province(1, "Phnom Penh"));

            this.dlst.addDistrict(new District(1, 1, "Porsenchey"));
            this.dlst.addCommune(new Commune(1, 1, "Chom Chao 1"));
            this.dlst.addCommune(new Commune(2, 1, "Chom Chao 2"));
            this.dlst.addCommune(new Commune(3, 1, "Chom Chao 3"));
            this.dlst.addCommune(new Commune(4, 1, "Kakab 1"));
            this.dlst.addCommune(new Commune(5, 1, "Kakab 2"));
            this.dlst.addCommune(new Commune(6, 1, "Samraong Kraom"));
            this.dlst.addCommune(new Commune(7, 1, "Trapeang Krasang"));

            this.dlst.addDistrict(new District(2, 1, "Sensok"));
            this.dlst.addDistrict(new District(3, 1, "ToulKork"));
            this.dlst.addDistrict(new District(4, 1, "Chamkar Mon"));
            this.dlst.addDistrict(new District(5, 1, "Doun Penh"));
            this.dlst.addDistrict(new District(6, 1, "Prampir Makara"));
            this.dlst.addDistrict(new District(7, 1, "Dangkao"));
            this.dlst.addDistrict(new District(8, 1, "Mean Chey"));
            this.dlst.addDistrict(new District(9, 1, "Russey Keo"));
            this.dlst.addDistrict(new District(10, 1, "Chroy Changvar"));
            this.dlst.addDistrict(new District(11, 1, "Chbar Ampov"));
            this.dlst.addDistrict(new District(12, 1, "Boeng Keng Kang"));
            this.dlst.addDistrict(new District(13, 1, "Kamboul"));
            this.dlst.addDistrict(new District(14, 1, "Prek Pnov"));

            

            foreach(Province p in this.dlst.getProvinceList())
            {
                this.cmbProvince.Items.Add(p.Name);
            }
        }

        private void lstDistrict_SelectedValueChanged(object sender, EventArgs e)
        {
            District d = this.dlst.getSearchDistrict(this.lstDistrict.SelectedItem.ToString());
            this.lstCommune.Items.Clear();
            foreach (Commune c in this.dlst.getCommuneList())
            {
                if (c.D_Id == d.Id)
                {
                    this.lstCommune.Items.Add(c.Name);
                }
            }
        }

        private void cmbProvince_SelectedValueChanged(object sender, EventArgs e)
        {
            Province p = this.dlst.getSearchProvince(this.cmbProvince.Text);
            this.lstDistrict.Items.Clear();
            foreach (District d in this.dlst.getDistrictList())
            {
                if (p.Id == d.P_Id)
                {
                    this.lstDistrict.Items.Add(d.Name);
                }
            }
        }
    }
}

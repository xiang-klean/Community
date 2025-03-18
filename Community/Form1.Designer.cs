namespace Community
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbProvince = new System.Windows.Forms.ComboBox();
            this.lstDistrict = new System.Windows.Forms.ListBox();
            this.lstCommune = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbProvince
            // 
            this.cmbProvince.FormattingEnabled = true;
            this.cmbProvince.Location = new System.Drawing.Point(240, 23);
            this.cmbProvince.Name = "cmbProvince";
            this.cmbProvince.Size = new System.Drawing.Size(306, 24);
            this.cmbProvince.TabIndex = 0;
            this.cmbProvince.SelectedValueChanged += new System.EventHandler(this.cmbProvince_SelectedValueChanged);
            // 
            // lstDistrict
            // 
            this.lstDistrict.FormattingEnabled = true;
            this.lstDistrict.ItemHeight = 16;
            this.lstDistrict.Location = new System.Drawing.Point(12, 117);
            this.lstDistrict.Name = "lstDistrict";
            this.lstDistrict.Size = new System.Drawing.Size(282, 308);
            this.lstDistrict.TabIndex = 1;
            this.lstDistrict.SelectedValueChanged += new System.EventHandler(this.lstDistrict_SelectedValueChanged);
            // 
            // lstCommune
            // 
            this.lstCommune.FormattingEnabled = true;
            this.lstCommune.ItemHeight = 16;
            this.lstCommune.Location = new System.Drawing.Point(312, 117);
            this.lstCommune.Name = "lstCommune";
            this.lstCommune.Size = new System.Drawing.Size(316, 308);
            this.lstCommune.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Province : ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Districts : ";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(309, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Commune : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(654, 446);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstCommune);
            this.Controls.Add(this.lstDistrict);
            this.Controls.Add(this.cmbProvince);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "FrmCommunity";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProvince;
        private System.Windows.Forms.ListBox lstDistrict;
        private System.Windows.Forms.ListBox lstCommune;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


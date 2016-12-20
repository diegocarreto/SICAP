using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Base;
using posb = PosBusiness;

namespace WindowsFormsApplication1
{
    public partial class Config : BaseForm
    {
        #region Memebers
        #endregion

        #region Builder

        public Config()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        private void LoadData()
        {
            using (var e = new posb.Config())
            {
                this.txtAlta.Text = String.Format("{0:0.00}", e.Alta());
                this.txtMensualidad.Text = String.Format("{0:0.00}", e.Mensualidad());
            }
        }

        private void Save()
        {
            if (this.ValidateForm())
            {
                using (var e = new posb.Config())
                {
                    e.Alta(this.txtAlta.Text);
                    e.Mensualidad(this.txtMensualidad.Text);
                }

                this.Close();
            }
        }

        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (this.ValidateForm())
            {
                this.Save();
            }
        }

        private void Config_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }
    }
}

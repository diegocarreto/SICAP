using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Base;
using posb = PosBusiness;
using UtilitiesForm.Extensions;

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
            this.cmbPrinter.Items.Add("Seleccione...");

            foreach (var printer in PrinterSettings.InstalledPrinters)
            {
                this.cmbPrinter.Items.Add(printer);
            }

            this.cmbPrinter.SelectedIndex = 0;

            using (var e = new posb.Config())
            {
                this.txtAlta.Text = String.Format("{0:0.00}", e.Alta());
                this.txtMensualidad.Text = String.Format("{0:0.00}", e.Mensualidad());
                this.cmbPrinter.Text = e.Printer();
                this.txtPresidente.Text = e.Presidente();
                this.txtTesorero.Text = e.Tesorero();
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
                    e.Printer(this.cmbPrinter.Text);
                    e.Presidente(this.txtPresidente.Text);
                    e.Tesorero(this.txtTesorero.Text);
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

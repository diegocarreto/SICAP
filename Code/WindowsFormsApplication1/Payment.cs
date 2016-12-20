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

namespace WindowsFormsApplication1
{
    public partial class Payment : BaseForm
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            this.SetCostPerMonth();
            this.FillYears();
            this.FillMonth();
        }

        private void SetCostPerMonth()
        {
            this.txtAmount.Text = String.Format("{0:0.00}", 470);
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbMonth.SelectedIndex.Equals(1))
            {
                this.txtTotal.Text = String.Format("{0:0.00}", 12 * decimal.Parse(this.txtAmount.Text));
            }
            else if (this.cmbMonth.SelectedIndex > 1)
            {
                this.txtTotal.Text = String.Format("{0:0.00}", decimal.Parse(this.txtAmount.Text));
            }
            else
            {
                this.txtTotal.Text = String.Format("{0:0.00}", 0);
            }
        }

        private void FillYears()
        {
            this.cmbYear.Items.Add("Seleccionar...");

            for (int i = 1995; i < 2050; i++)
            {
                this.cmbYear.Items.Add(i);
            }

            var currentYear = DateTime.Now.Year.ToString();

            this.cmbYear.Text = currentYear;
        }

        private void FillMonth()
        {
            string[] months = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio",
                              "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"};

            this.cmbMonth.Items.Add("Seleccionar...");
            this.cmbMonth.Items.Add("Todo el año...");

            for (int i = 0; i < months.Length; i++)
            {
                this.cmbMonth.Items.Add(months[i]);
            }

            var currentMonth = DateTime.Now.Month + 1;

            this.cmbMonth.SelectedIndex = currentMonth;
        }
    }
}

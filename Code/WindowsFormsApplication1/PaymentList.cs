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
using UtilitiesForm.Extensions;

namespace WindowsFormsApplication1
{
    public partial class PaymentList : BaseForm
    {
        #region Properties

        private posb.Payment Entity { get; set; }

        #endregion #endregion

        public PaymentList()
        {
            this.Entity = new posb.Payment();

            InitializeComponent();
        }

        private void HabitantList_Load(object sender, EventArgs e)
        {
            this.FillHabitant();
            this.FillYears();
            this.FillMonth();
            this.ConfigureDateTimePicker();

            this.cmbMonth.SelectedIndex = 0;
            this.cmbYear.SelectedIndex = 0;

            this.LoadComplete = true;

            this.FillGridView();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var p = new Payment();

            p.Result += new Payment.Communication(Result);

            p.ShowDialog();
        }

        private void Result(bool IsCorrect, String Message)
        {
            this.FillGridView();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillGridView()
        {
            if (this.LoadComplete)
            {
                this.Entity.Find = this.txtFind.Text;
                this.Entity.StartDate = this.dtpDate1.Value;
                this.Entity.EndDate = this.dtpDate2.Value;

                if (this.cmbHabitant.SelectedIndex > 0)
                    this.Entity.IdHabitantOrRent = this.cmbHabitant.GetVal<int>();
                else
                    this.Entity.IdHabitantOrRent = null;

                if (this.cmbWaterIntake.SelectedIndex > 0)
                    this.Entity.IdWaterIntake = this.cmbWaterIntake.GetVal<int>();
                else
                    this.Entity.IdWaterIntake = null;

                if (this.cmbMonth.SelectedIndex > 0)
                    this.Entity.Month = this.cmbMonth.SelectedIndex;
                else
                    this.Entity.Month = null;

                this.gvList.AutoGenerateColumns = false;
                this.gvList.AllowUserToResizeColumns = false;
                this.gvList.DataSource = this.Entity.List();
            }
        }

        private void FillHabitant()
        {
            using (var habitant = new posb.Habitant())
            {
                this.cmbHabitant.Fill(habitant.List());
            }
        }

        private void cmbHabitant_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbHabitant.SelectedIndex > 0)
            {
                using (var waterIntake = new posb.WaterIntake
                {
                    IdHabitant = this.cmbHabitant.GetVal<int>()
                })
                {
                    var waterIntakeList = waterIntake.List();

                    if (waterIntakeList.Count.Equals(0))
                    {
                        waterIntakeList = waterIntake.List(3);
                    }

                    this.cmbWaterIntake.Fill(waterIntakeList);
                }
            }
            else
            {
                this.cmbWaterIntake.Fill(new List<posb.WaterIntake>());
            }

            this.FillGridView();
        }

        private void FillYears()
        {
            this.cmbYear.Items.Add("Seleccionar...");

            for (int i = 1995; i < 2050; i++)
            {
                this.cmbYear.Items.Add(i);
            }

            //var currentYear = DateTime.Now.Year.ToString();

            //this.cmbYear.Text = currentYear;
        }

        private void FillMonth()
        {
            string[] months = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio",
                               "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"};

            this.cmbMonth.Items.Add("Seleccionar...");

            for (int i = 0; i < months.Length; i++)
            {
                this.cmbMonth.Items.Add(months[i]);
            }

            //var currentMonth = DateTime.Now.Month + 1;

            //this.cmbMonth.SelectedIndex = currentMonth;
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FillGridView();
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FillGridView();
        }

        private void cmbWaterIntake_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FillGridView();
        }

        private void txtFind_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtFind_KeyUp(object sender, KeyEventArgs e)
        {
            this.FillGridView();
        }

        private void ConfigureDateTimePicker()
        {
            dtpDate1.Format = DateTimePickerFormat.Custom;
            dtpDate1.CustomFormat = "dd/MM/yyyy";
            dtpDate1.Value = DateTime.Now.AddDays(-30);

            dtpDate2.Format = DateTimePickerFormat.Custom;
            dtpDate2.CustomFormat = "dd/MM/yyyy";
            dtpDate2.Value = DateTime.Now;
        }

        private void dtpDate1_ValueChanged(object sender, EventArgs e)
        {
            this.FillGridView();
        }

        private void dtpDate2_ValueChanged(object sender, EventArgs e)
        {
            this.FillGridView();
        }
    }
}

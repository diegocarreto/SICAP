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
            this.gvList.AutoGenerateColumns = false;
            this.gvList.AllowUserToResizeColumns = false;
            this.gvList.DataSource = this.Entity.List();
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
        }
    }
}

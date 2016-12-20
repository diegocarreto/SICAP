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
    public partial class Habitant : BaseForm
    {
        #region Memebers

        private int? Id = null;

        public delegate void Communication(bool IsCorrect, String Message);

        public event Communication Result;

        #endregion

        #region Builder

        public Habitant(int? Id)
        {
            this.Id = Id;

            InitializeComponent();
        }

        #endregion

        #region Methods

        private void LoadData(int? Id)
        {
            using (var e = new posb.Habitant
            {
                Id = this.Id
            })
            {
                e.Get();

                this.txtName.Text = e.Name;
                this.txtLastName.Text = e.Paterno;
                this.txtMotherLastName.Text = e.Materno;
                this.txtObservations.Text = e.observations;
                this.cbActive.Checked = e.Active.Value;
            }
        }

        private void Save()
        {
            using (var e = new posb.Habitant
            {
                Id = this.Id,
                Name = this.txtName.Text,
                Paterno = this.txtLastName.Text,
                Materno = this.txtMotherLastName.Text,
                observations = this.txtObservations.Text,
                Active = this.cbActive.Checked
            })
            {
                e.Save();

                this.Result(true, "Success!!");

                this.Close();
            }
        }

        #endregion

        private void Habitant_Load(object sender, EventArgs e)
        {
            if (this.Id.HasValue)
            {
                this.LoadData(this.Id);

                this.btnWaterIntake.Visible = true;
            }
            else
            {
                this.btnWaterIntake.Visible = false;
            }
        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            var entity = new WaterIntakeList(this.Id);

            entity.ShowDialog();
        }
    }
}

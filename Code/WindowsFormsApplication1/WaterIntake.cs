﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Base;
using UtilitiesForm.Extensions;
using posb = PosBusiness;

namespace WindowsFormsApplication1
{
    public partial class WaterIntake : BaseForm
    {
        #region Memebers

        private const string STREET = "Calle";

        private int? Id = null;

        private int? IdHabitant = null;

        public delegate void Communication(bool IsCorrect, String Message);

        public event Communication Result;

        #endregion

        #region Builder

        public WaterIntake(int IdHabitant, int? Id = null)
        {
            this.IdHabitant = IdHabitant;
            this.Id = Id;

            InitializeComponent();
        }

        #endregion

        #region Methods

        private void FillStreet()
        {
            using (var e = new PosBusiness.Catalogs())
            {

                this.cmbStreet.Fill(e.List(STREET));
            }
        }

        private void Save()
        {
            using (var e = new posb.WaterIntake
            {
                Id = this.Id,
                IdHabitant = this.IdHabitant,
                IdStreet = this.cmbStreet.GetVal<int>(),
                ExteriorNumber = this.txtExteriorNumber.Text,
                InteriorNumber = this.txtInteriorNumber.Text,
                Colony = this.txtColony.Text,
                Active = this.cbActive.Checked,
                Total = decimal.Parse(this.txtTotal.Text)
            })
            {
                e.Save();

                this.Result(true, "Success!!");

                this.Close();
            }
        }

        private void LoadData(int? Id)
        {
            using (var e = new posb.WaterIntake
            {
                Id = this.Id
            })
            {
                e.Get();

                this.cmbStreet.SelectedValue = e.IdStreet;
                this.txtExteriorNumber.Text = e.ExteriorNumber;
                this.txtInteriorNumber.Text = e.InteriorNumber;
                this.txtColony.Text = e.Colony;
                this.txtTotal.Text = String.Format("{0:0.00}", e.Total);
                this.cbActive.Checked = e.Active.Value;
            }
        }

        private void SetCostAlta()
        {
            try
            {
                using (var e = new posb.Config())
                {
                    this.txtTotal.Text = String.Format("{0:0.00}", e.Alta());
                }
            }
            catch (Exception ex)
            { 
            
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

        private void WaterIntake_Load(object sender, EventArgs e)
        {
            this.FillStreet();

            if (this.Id.HasValue)
            {
                this.LoadData(this.Id);
            }
            else
            {
                this.SetCostAlta();
            }
        }
    }
}
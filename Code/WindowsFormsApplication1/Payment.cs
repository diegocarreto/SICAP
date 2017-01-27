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
using System.Drawing.Printing;

namespace WindowsFormsApplication1
{
    public partial class Payment : BaseForm
    {
        public delegate void Communication(bool IsCorrect, String Message);

        public event Communication Result;

        private int? StartYear = null;

        private int? StartMonth = null;

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
            this.FillHabitant();
        }

        private void FillHabitant()
        {
            using (var habitant = new posb.Habitant())
            {
                this.cmbHabitant.Fill(habitant.List());
            }
        }

        private void SetCostPerMonth()
        {
            this.txtAmount.Text = String.Format("{0:0.00}", 470);
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbMonth.SelectedIndex.Equals(1))
            {
                var totalMonths = cmbMonth.Items.Count - 2;

                this.txtTotal.Text = String.Format("{0:0.00}", totalMonths * decimal.Parse(this.txtAmount.Text));
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

        private void FillYears(int? StartYear = null)
        {
            this.cmbYear.Items.Clear();

            this.cmbYear.Items.Add("Seleccionar...");

            if (StartYear.HasValue)
            {
                for (int i = StartYear.Value; i < 2050; i++)
                {
                    this.cmbYear.Items.Add(i);
                }

                var currentYear = DateTime.Now.Year.ToString();

                this.cmbYear.Text = currentYear;
            }
            else
            {
                this.cmbYear.SelectedIndex = 0;
            }
        }

        private void FillMonth(int? StartYear = null, int? StartMonth = null)
        {
            string[] months = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio",
                              "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"};

            this.cmbMonth.Items.Clear();

            this.cmbMonth.Items.Add("Seleccionar...");

            if (StartMonth.HasValue)
            {
                var year = 0;

                if (this.cmbYear.SelectedIndex > 0)
                    year = int.Parse(this.cmbYear.Text);

                this.cmbMonth.Items.Add("Todo el año...");
                var startMonth = 0;

                if (this.StartYear.Value.Equals(year))
                {
                    startMonth = StartMonth.Value - 1;
                }

                for (int i = startMonth; i < months.Length; i++)
                {
                    this.cmbMonth.Items.Add(months[i]);
                }

                var currentMonth = DateTime.Now.Month + 1;
                var currentYear = DateTime.Now.Year;

                if (year.Equals(currentYear))
                {
                    this.cmbMonth.SelectedIndex = currentMonth;
                }
                else
                {
                    this.cmbMonth.SelectedIndex = 0;
                }
            }
            else
            {
                this.cmbMonth.SelectedIndex = 0;
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

                    if (this.cmbWaterIntake.Items.Count.Equals(2))
                        this.cmbWaterIntake.SelectedIndex = 1;
                }

                using (var habitant = new posb.Habitant
                {
                    Id = this.cmbHabitant.GetVal<int>()
                })
                {
                    habitant.Get();

                    this.StartYear = habitant.Year;
                    this.StartMonth = habitant.Month;

                    this.FillYears(this.StartYear);
                }
            }
            else
            {
                this.cmbWaterIntake.Fill(new List<posb.WaterIntake>());
                this.FillYears();
                this.FillMonth();

                this.StartYear = null;
                this.StartMonth = null;
            }
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FillMonth(this.StartYear, this.StartMonth);
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            //var p = new PrintDocument();

            //p.PrintPage += delegate(object sender1, PrintPageEventArgs e1)
            //{
            //    string font = "Times New Roman";
            //    SolidBrush brush = new SolidBrush(Color.Black);

            //    Font titleFont = new Font(font, 18, FontStyle.Bold),
            //         f14 = new Font(font, 14, FontStyle.Bold),
            //         f11 = new Font(font, 11),
            //         f10 = new Font(font, 10),
            //         f09 = new Font(font, 09),
            //         f08 = new Font(font, 08),
            //         f04 = new Font(font, 04);

            //    e1.Graphics.DrawString("Delegación de San Diego", titleFont, brush, 160, 20);

            //    e1.Graphics.DrawString("Folio: 0004563", f14, brush, 20, 50);
            //    e1.Graphics.DrawString("Fecha de pago: 10/02/1986 14:56", f14, brush, 20, 70);
            //    e1.Graphics.DrawString("Fecha de impresion: 10/02/1986 14:56", f14, brush, 20, 90);

            //    e1.Graphics.DrawString("Habitante: Diego Alberto Ortega Carreto", f14, brush, 20, 140);
            //    e1.Graphics.DrawString("Toma de agua: Cerrada de constituyentes #16 -2 Barrio 2", f14, brush, 20, 160);
            //};

            //try
            //{
            //    using (var printer = new posb.Config())
            //    {
            //        p.PrinterSettings.PrinterName = printer.Printer();
            //    }

            //    p.Print();
            //}
            //catch (Exception ex)
            //{
            //    this.Alert("Ocurrió un error al intentar imprimir el ticket. Descripcion: " + ex.Message, eForm.TypeError.Error);
            //}

            //return;

            if (this.ValidateForm())
            {
                if (this.Confirm("¿Realmente desea realizar el cobro por el monto de " + this.txtTotal.Text + " ?"))
                {
                    using (var payment = new posb.Payment
                    {
                        IdHabitantOrRent = this.cmbHabitant.GetVal<int>(),
                        IdWaterIntake = this.cmbWaterIntake.GetVal<int>(),
                        Year = int.Parse(this.cmbYear.Text),
                        Month = this.cmbMonth.SelectedIndex,
                        Amount = decimal.Parse(this.txtTotal.Text),
                        Observations = this.txtObservations.Text
                    })
                    {
                        if (!payment.Exist())
                        {
                            payment.Save();

                            //if (this.Confirm("¿Deseas imprimir el recibo?"))
                            //{

                            //}

                            this.Result(true, "Success!!");

                            this.Close();
                        }
                        else
                        {
                            this.Alert("Ya se realizo el pago de la toma de agua en el periodo indicado");
                            this.cmbMonth.Focus();
                        }
                    }
                }
            }
        }
    }
}

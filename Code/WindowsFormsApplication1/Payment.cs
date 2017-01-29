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
            var p = new PrintDocument();

            p.PrintPage += delegate(object sender1, PrintPageEventArgs e1)
            {
                var line = string.Empty;
                for (int i = 0; i < 81; i++)
                    line += "_";

                var line2 = string.Empty;
                for (int i = 0; i < 125; i++)
                    line2 += " - ";

                var font = "Times New Roman";
                var brush = new SolidBrush(Color.Black);
                var brushTwo = new SolidBrush(Color.LightGray);

                var brushRed = new SolidBrush(Color.Red);

                Font titleFont = new Font(font, 18, FontStyle.Bold),
                     titleSubFont = new Font(font, 16, FontStyle.Bold),
                     f14 = new Font(font, 14, FontStyle.Bold),
                     f11 = new Font(font, 11),
                     f10 = new Font(font, 10),
                     f09 = new Font(font, 09),
                     f08 = new Font(font, 08),
                     f06 = new Font(font, 06);

                var pen = new Pen(Brushes.Black);
                pen.Width = 0.8F;

                var imageCom = new Bitmap(System.AppDomain.CurrentDomain.BaseDirectory + "comunidad.jpg");
                var sicap = new Bitmap(System.AppDomain.CurrentDomain.BaseDirectory + "sicap.jpg");
                var image = new Bitmap(System.AppDomain.CurrentDomain.BaseDirectory + "comunidad2.jpg");

                for (int i = 0; i <= 1; i++)
                {
                    var copy = i * 520;

                    
                    e1.Graphics.DrawImage(imageCom, 20, 7 + copy, 90, 110);

                    e1.Graphics.DrawString("COMITÉ DE AGUA POTABLE", titleFont, brush, 240, 40 + copy);
                    e1.Graphics.DrawString("SAN DIEGO TLAILOTLACAN", titleFont, brush, 240, 65 + copy);
                    e1.Graphics.DrawImage(image, 760, 37 + copy, 60, 80);

                    e1.Graphics.FillRectangle(brush, new Rectangle(20, 106 + copy, 795, 6));
                    e1.Graphics.DrawRectangle(pen, new Rectangle(20, 112 + copy, 795, 30));
                    e1.Graphics.DrawString("RECIBO OFICIAL DE INGRESOS", titleSubFont, brush, 30, 115 + copy);

                    e1.Graphics.DrawString("FOLIO", titleSubFont, brush, 550, 115 + copy);
                    e1.Graphics.DrawString("N° " + "1".PadLeft(10, '0'), titleSubFont, brushRed, 630, 115 + copy);

                    e1.Graphics.DrawRectangle(pen, new Rectangle(20, 158 + copy, 795, 127));
                    e1.Graphics.DrawRectangle(pen, new Rectangle(20, 158 + copy, 222, 127));
                   
                    e1.Graphics.DrawString("RECIBI DEL(A) SR(A)", f14, brush, 30, 170 + copy);
                    e1.Graphics.DrawString("Laura Camacho Sanchez", f14, brush, 250, 160 + copy);
                    e1.Graphics.DrawString("Este recibo no proporciona derechos al arrendatario de la propiedad a la cual pertenece la toma de agua", f06, brush, 250, 182 + copy);
                    e1.Graphics.DrawString(line, f14, brush, 17, 170 + copy);

                    e1.Graphics.DrawString("CANTIDAD", f14, brush, 30, 200 + copy);
                    e1.Graphics.DrawString("$3,000.00 MX", f14, brush, 250, 200 + copy);
                    e1.Graphics.DrawString(line, f14, brush, 17, 200 + copy);

                    e1.Graphics.DrawString("CONCEPTO", f14, brush, 30, 230 + copy);
                    e1.Graphics.DrawString("Pago por extracción de agua potable", f14, brush, 250, 230 + copy);
                    e1.Graphics.DrawString(line, f14, brush, 17, 230 + copy);

                    e1.Graphics.DrawString("TOMA DE AGUA", f14, brush, 30, 260 + copy);
                    e1.Graphics.DrawString("Capulines #16 -2 Barrio 2", f14, brush, 250, 260 + copy);

                    e1.Graphics.FillRectangle(brushTwo, new Rectangle(20, 299 + copy, 795, 27));
                    e1.Graphics.DrawRectangle(pen, new Rectangle(20, 299 + copy, 795, 27));
                    e1.Graphics.DrawString("PERIODO DE PAGO", titleSubFont, brush, 309, 300 + copy);

                    e1.Graphics.DrawRectangle(pen, new Rectangle(20, 326 + copy, 398, 27));
                    e1.Graphics.DrawRectangle(pen, new Rectangle(418, 326 + copy, 397, 27));

                    e1.Graphics.DrawString("IMPRESIÓN " + (i + 1) + " - " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"), f08, brush, 20, 360 + copy);
                    e1.Graphics.DrawString("SAN DIEGO TEXCOCO ESTADO DE MEXICO A 28 DE ENERO DE 2017", f10, brush, 345, 360 + copy);

                    e1.Graphics.DrawString("_________________________________", f09, brush, 100, 430 + copy);
                    e1.Graphics.DrawString("TESORERO(A)", f08, brush, 163, 450 + copy);

                    e1.Graphics.DrawString("_________________________________", f09, brush, 500, 430 + copy);
                    e1.Graphics.DrawString("VO.BO. PRESIDENTE DE COMITE", f08, brush, 520, 450 + copy);

                    
                    e1.Graphics.DrawImage(sicap, 403, 430 + copy, 40, 50);

                    e1.Graphics.DrawString("SICAP V1.0.0", f06, brush, 397, 480 + copy);

                    if(i.Equals(0))
                        e1.Graphics.DrawString(line2, f06, brush, 0, 515 + copy);
                }

                pen.Dispose();
            };

            try
            {
                using (var printer = new posb.Config())
                {
                    p.PrinterSettings.PrinterName = printer.Printer();
                }

                p.Print();
            }
            catch (Exception ex)
            {
                this.Alert("Ocurrió un error al intentar imprimir el ticket. Descripcion: " + ex.Message, eForm.TypeError.Error);
            }

            return;

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

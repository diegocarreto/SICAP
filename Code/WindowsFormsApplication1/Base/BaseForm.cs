using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilitiesForm.Extensions;
using Utilities.Extensions;
using PosBusiness;
using System.Drawing.Printing;
using posb = PosBusiness;
using Utilities;

namespace WindowsFormsApplication1.Base
{
    public class BaseForm : Form
    {
        #region Members

        public int? Id;

        private const string TXT_TEXT = "txtText";

        private const string TXT_MONEY = "txtMoney";

        #endregion

        #region Properties

        protected bool UpdateButton { get; set; }

        protected bool LoadComplete { get; set; }

        #endregion

        #region Builder

        public BaseForm()
            : base()
        {
            this.LoadComplete = false;
        }

        #endregion

        #region Methods

        private void ConfigureRol()
        {
            try
            {
                using (var e = new PosBusiness.User())
                {
                    e.Rol();

                    this.UpdateButton = e.Update.Value;

                    var ctrlNew = this.Controls["btnNew"];

                    if (ctrlNew != null)
                    {
                        var btnNew = ctrlNew as Button;

                        btnNew.Enabled = e.New.Value;
                    }

                    var ctrlDelete = this.Controls["btnDelete"];

                    if (ctrlDelete != null)
                    {
                        var btnDelete = ctrlDelete as Button;

                        btnDelete.Enabled = e.Erase.Value;
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void ConfigureTextBoxValidation()
        {
            foreach (Control p in this.Controls)
            {
                if (p is TextBox)
                {
                    var txt = p as TextBox;

                    if (txt.Tag != null)
                    {
                        if (txt.Tag.ToString().Equals(TXT_TEXT, StringComparison.InvariantCultureIgnoreCase))
                        {
                            txt.KeyPress += new KeyPressEventHandler(this.txt_KeyPressText);
                        }
                        else if (txt.Tag.ToString().Equals(TXT_MONEY, StringComparison.InvariantCultureIgnoreCase))
                        {
                            txt.KeyPress += new KeyPressEventHandler(this.txt_KeyPressMoney);
                        }
                    }

                }
            }

        }

        protected bool ValidateForm()
        {
            var isCorrect = true;
            var message = string.Empty;

            foreach (Control p in this.Controls)
            {
                if (p is PictureBox)
                {
                    var name = (p as PictureBox).Name;
                    var parts = name.Split('_');

                    if (parts.Length.Equals(2))
                    {
                        var prefix = parts[0].ToString();

                        if (prefix.Equals("pbval", StringComparison.InvariantCultureIgnoreCase))
                        {
                            var controlValidate = parts[1];
                            var ctrl = this.Controls[controlValidate];
                            var isError = false;

                            if (ctrl is TextBox)
                            {
                                var txt = ctrl as TextBox;
                                isError = string.IsNullOrEmpty(txt.Text);
                            }
                            else if (ctrl is ComboBox)
                            {
                                var cmb = ctrl as ComboBox;
                                isError = cmb.SelectedIndex.Equals(0);
                            }

                            if (isError)
                            {
                                p.Visible = true;
                                isCorrect &= false;
                                ctrl.Focus();

                                message += p.Tag.ToString() + "\r\n";
                            }
                            else
                                p.Visible = false;
                        }
                    }
                }
            }

            if (!isCorrect)
            {
                this.Alert(message);
            }

            return isCorrect;
        }

        protected void Print(int Id, int Type = 1)
        {
            var months = new List<string>
            {
                "ENERO",
                "FEBRERO",
                "MARZO",
                "ABRIL",
                "MAYO",
                "JUNIO",
                "JULIO",
                "AGOSTO",
                "SEPTIEMBRE",
                "OCTUBRE",
                "NOVIEMBRE",
                "DICIEMBRE"
            };

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

                using (posb.Payment payment = new posb.Payment
                {
                    Id = Id
                }
                .Print())
                {
                    var total = new Numalet().Convert(String.Format("{0:0.00}", payment.Amount));

                    for (int i = 0; i <= 1; i++)
                    {
                        var copy = i * 530;

                        e1.Graphics.DrawImage(imageCom, 20, 7 + copy, 90, 110);

                        e1.Graphics.DrawString("COMITÉ DE AGUA POTABLE", titleFont, brush, 240, 40 + copy);
                        e1.Graphics.DrawString("SAN DIEGO TLAILOTLACAN", titleFont, brush, 240, 65 + copy);
                        e1.Graphics.DrawImage(image, 760, 37 + copy, 60, 80);

                        e1.Graphics.FillRectangle(brush, new Rectangle(20, 106 + copy, 795, 6));
                        e1.Graphics.DrawRectangle(pen, new Rectangle(20, 112 + copy, 795, 30));
                        e1.Graphics.DrawString("RECIBO OFICIAL DE INGRESOS", titleSubFont, brush, 30, 115 + copy);

                        e1.Graphics.DrawString("FOLIO", titleSubFont, brush, 550, 115 + copy);
                        e1.Graphics.DrawString("N° " + payment.Folio.PadLeft(10, '0'), titleSubFont, brushRed, 630, 115 + copy);

                        e1.Graphics.DrawRectangle(pen, new Rectangle(20, 158 + copy, 795, 127));
                        e1.Graphics.DrawRectangle(pen, new Rectangle(20, 158 + copy, 222, 127));

                        e1.Graphics.DrawString("RECIBI DEL(A) SR(A)", f14, brush, 30, 170 + copy);
                        e1.Graphics.DrawString(payment.Propietario, f14, brush, 250, 170 + copy);
                        //e1.Graphics.DrawString("Este recibo no proporciona derechos al arrendatario de la propiedad a la cual pertenece la toma de agua", f06, brush, 250, 182 + copy);
                        e1.Graphics.DrawString(line, f14, brush, 17, 170 + copy);

                        e1.Graphics.DrawString("CANTIDAD", f14, brush, 30, 200 + copy);
                        e1.Graphics.DrawString("$" + String.Format("{0:0.00}", payment.Amount) + "   " + total, f14, brush, 250, 200 + copy);
                        e1.Graphics.DrawString(line, f14, brush, 17, 200 + copy);

                        e1.Graphics.DrawString("CONCEPTO", f14, brush, 30, 230 + copy);
                        e1.Graphics.DrawString("Pago por extracción de agua potable", f14, brush, 250, 230 + copy);
                        e1.Graphics.DrawString(line, f14, brush, 17, 230 + copy);

                        e1.Graphics.DrawString("TOMA DE AGUA", f14, brush, 30, 260 + copy);
                        e1.Graphics.DrawString(payment.Direccion, f14, brush, 250, 260 + copy);

                        e1.Graphics.FillRectangle(brushTwo, new Rectangle(20, 299 + copy, 795, 27));
                        e1.Graphics.DrawRectangle(pen, new Rectangle(20, 299 + copy, 795, 27));

                        if (Type.Equals(1))
                        {
                            e1.Graphics.DrawString("PERIODO DE PAGO", titleSubFont, brush, 309, 300 + copy);

                            if (payment.StartDateName.Equals(payment.EndDateName))
                            {
                                e1.Graphics.DrawString(payment.EndDateName, titleSubFont, brush, 350, 326 + copy);
                            }
                            else if (payment.Year.Equals(payment.YearEnd) && payment.Month.Equals(1) && payment.MonthEnd.Equals(12))
                            {
                                e1.Graphics.DrawString("Año " + payment.Year + " completo", titleSubFont, brush, 320, 326 + copy);
                            }
                            else
                            {
                                e1.Graphics.DrawString("De " + payment.StartDateName.Replace(" ", " de ") + " a " + payment.EndDateName.Replace(" ", " de "), titleSubFont, brush, 255, 326 + copy);
                            }
                        }
                        else
                        {
                            e1.Graphics.DrawString("CONCEPTO DE PAGO", titleSubFont, brush, 300, 300 + copy);
                        }

                        e1.Graphics.DrawRectangle(pen, new Rectangle(20, 326 + copy, 795, 27));
                        //e1.Graphics.DrawRectangle(pen, new Rectangle(418, 326 + copy, 397, 27));

                        e1.Graphics.DrawString("SAN DIEGO TEXCOCO ESTADO DE MEXICO A " + payment.CreationDate.Value.ToString("dd") + " DE " + months[int.Parse(payment.CreationDate.Value.ToString("MM")) - 1] + " DE " + payment.CreationDate.Value.ToString("yyyy"), f10, brush, 360, 360 + copy);

                        e1.Graphics.DrawString("_________________________________", f09, brush, 100, 430 + copy);
                        e1.Graphics.DrawString("TESORERO(A): " + payment.Tesorero, f08, brush, 100, 450 + copy);
                        //e1.Graphics.DrawString("", f08, brush, 163, 470 + copy);

                        e1.Graphics.DrawString("_________________________________", f09, brush, 500, 430 + copy);
                        e1.Graphics.DrawString("PRESIDENTE(A): " + payment.Presidente, f08, brush, 500, 450 + copy);
                        //e1.Graphics.DrawString("VO.BO.  DE COMITE", f08, brush, 520, 470 + copy);

                        e1.Graphics.DrawImage(sicap, 403, 430 + copy, 40, 50);

                        e1.Graphics.DrawString("SICAP V1.0.0", f06, brush, 397, 480 + copy);

                        e1.Graphics.DrawString("Impresión " + (i + 1) + " - " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"), f08, brush, 610, 495 + copy);

                        if (i.Equals(0))
                            e1.Graphics.DrawString(line2, f06, brush, 0, 525 + copy);
                    }
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

        }

        protected void PrintFaena(int Id)
        {
            var months = new List<string>
            {
                "ENERO",
                "FEBRERO",
                "MARZO",
                "ABRIL",
                "MAYO",
                "JUNIO",
                "JULIO",
                "AGOSTO",
                "SEPTIEMBRE",
                "OCTUBRE",
                "NOVIEMBRE",
                "DICIEMBRE"
            };

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

                using (posb.Payment payment = new posb.Payment
                {
                    Id = Id
                }
                .FaenaPrint())
                {
                    var total = new Numalet().Convert(String.Format("{0:0.00}", payment.Amount));

                    for (int i = 0; i <= 1; i++)
                    {
                        var copy = i * 530;

                        e1.Graphics.DrawImage(imageCom, 20, 7 + copy, 90, 110);

                        e1.Graphics.DrawString("COMITÉ DE AGUA POTABLE", titleFont, brush, 240, 40 + copy);
                        e1.Graphics.DrawString("SAN DIEGO TLAILOTLACAN", titleFont, brush, 240, 65 + copy);
                        e1.Graphics.DrawImage(image, 760, 37 + copy, 60, 80);

                        e1.Graphics.FillRectangle(brush, new Rectangle(20, 106 + copy, 795, 6));
                        e1.Graphics.DrawRectangle(pen, new Rectangle(20, 112 + copy, 795, 30));
                        e1.Graphics.DrawString("RECIBO OFICIAL DE INGRESOS", titleSubFont, brush, 30, 115 + copy);

                        e1.Graphics.DrawString("FOLIO", titleSubFont, brush, 550, 115 + copy);
                        e1.Graphics.DrawString("N° " + payment.Folio.PadLeft(10, '0'), titleSubFont, brushRed, 630, 115 + copy);

                        e1.Graphics.DrawRectangle(pen, new Rectangle(20, 158 + copy, 795, 127));
                        e1.Graphics.DrawRectangle(pen, new Rectangle(20, 158 + copy, 222, 127));

                        e1.Graphics.DrawString("RECIBI DEL(A) SR(A)", f14, brush, 30, 170 + copy);
                        e1.Graphics.DrawString(payment.Propietario, f14, brush, 250, 170 + copy);
                        //e1.Graphics.DrawString("Este recibo no proporciona derechos al arrendatario de la propiedad a la cual pertenece la toma de agua", f06, brush, 250, 182 + copy);
                        e1.Graphics.DrawString(line, f14, brush, 17, 170 + copy);

                        e1.Graphics.DrawString("CANTIDAD", f14, brush, 30, 200 + copy);
                        e1.Graphics.DrawString("$" + String.Format("{0:0.00}", payment.Amount) + "   " + total, f14, brush, 250, 200 + copy);
                        e1.Graphics.DrawString(line, f14, brush, 17, 200 + copy);

                        e1.Graphics.DrawString("CONCEPTO", f14, brush, 30, 230 + copy);
                        e1.Graphics.DrawString("Pago por cooperación " + payment.Concept, f14, brush, 250, 230 + copy);
                        e1.Graphics.DrawString(line, f14, brush, 17, 230 + copy);

                        e1.Graphics.DrawString("TOMA DE AGUA", f14, brush, 30, 260 + copy);
                        e1.Graphics.DrawString(payment.Direccion, f14, brush, 250, 260 + copy);

                        e1.Graphics.FillRectangle(brushTwo, new Rectangle(20, 299 + copy, 795, 27));
                        e1.Graphics.DrawRectangle(pen, new Rectangle(20, 299 + copy, 795, 27));

                        e1.Graphics.DrawString("DESCRIPCIÓN DE LA COOPERACIÓN", titleSubFont, brush, 240, 300 + copy);
                        e1.Graphics.DrawString(payment.Description, f10, brush, 25, 332 + copy);

                        e1.Graphics.DrawRectangle(pen, new Rectangle(20, 326 + copy, 795, 27));
                        //e1.Graphics.DrawRectangle(pen, new Rectangle(418, 326 + copy, 397, 27));

                        e1.Graphics.DrawString("SAN DIEGO TEXCOCO ESTADO DE MEXICO A " + payment.CreationDate.Value.ToString("dd") + " DE " + months[int.Parse(payment.CreationDate.Value.ToString("MM")) - 1] + " DE " + payment.CreationDate.Value.ToString("yyyy"), f10, brush, 360, 360 + copy);

                        e1.Graphics.DrawString("_________________________________", f09, brush, 100, 430 + copy);
                        e1.Graphics.DrawString("TESORERO(A): " + payment.Tesorero, f08, brush, 100, 450 + copy);
                        //e1.Graphics.DrawString("", f08, brush, 163, 470 + copy);

                        e1.Graphics.DrawString("_________________________________", f09, brush, 500, 430 + copy);
                        e1.Graphics.DrawString("PRESIDENTE(A): " + payment.Presidente, f08, brush, 500, 450 + copy);
                        //e1.Graphics.DrawString("VO.BO.  DE COMITE", f08, brush, 520, 470 + copy);

                        e1.Graphics.DrawImage(sicap, 403, 430 + copy, 40, 50);

                        e1.Graphics.DrawString("SICAP V1.0.0", f06, brush, 397, 480 + copy);

                        e1.Graphics.DrawString("Impresión " + (i + 1) + " - " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"), f08, brush, 610, 495 + copy);

                        if (i.Equals(0))
                            e1.Graphics.DrawString(line2, f06, brush, 0, 525 + copy);
                    }
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

        }


        #endregion

        protected void txt_KeyPressText(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        protected void txt_KeyPressMoney(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;

            if (txt.Text.Contains('.'))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '.' || e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml(this.AppSet<string>("BackColorForm"));

            this.StartPosition = FormStartPosition.CenterScreen;

            foreach (var gv in this.Controls.OfType<DataGridView>())
            {
                gv.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml(this.AppSet<string>("BackColorHeaderGrid"));
            }

            foreach (var btn in this.Controls.OfType<Button>())
            {
                btn.BackColor = ColorTranslator.FromHtml(this.AppSet<string>("BackColorButtons"));
            }

            this.ConfigureTextBoxValidation();

            this.ConfigureRol();

            base.OnLoad(e);
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BaseForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "BaseForm";
            this.Load += new System.EventHandler(this.BaseForm_Load_1);
            this.ResumeLayout(false);

        }

        private void BaseForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}

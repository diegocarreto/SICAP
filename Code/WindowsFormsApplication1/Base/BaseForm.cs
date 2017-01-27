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

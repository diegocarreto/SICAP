using System;
using System.Windows.Forms;
using Utilities.Extensions;

namespace WindowsFormsApplication1
{
    public partial class Sicap : Form
    {
        public string UserName;

        #region Members

        private Config Config = null;

        private HabitantList HabitantList = null;

        private PaymentList PaymentList = null;

        #endregion

        #region Builder

        public Sicap()
        {
            InitializeComponent();
        }

        #endregion

        #region Events

        private void MaxShop_Load(object sender, EventArgs e)
        {
            this.ConfigureRol();
            this.AddStatusBar();
        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Config = ShowOrActiveForm(Config, typeof(Config)) as Config;
        }

        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaymentList = ShowOrActiveForm(PaymentList, typeof(PaymentList)) as PaymentList;
        }

        private void habitantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HabitantList = ShowOrActiveForm(HabitantList, typeof(HabitantList)) as HabitantList;
        }

        private void mnArchivoReiniciar_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void mnArchivoSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnVentanasCascada_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void mnVentanasHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void mnVentanasVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
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

                    this.pagosToolStripMenuItem.Visible = e.Menu_Pagos.Value;
                    this.habitantesToolStripMenuItem.Visible = e.Menu_Habitantes.Value;
                    this.herramientasToolStripMenuItem.Visible = e.Menu_Opciones.Value;
                }
            }
            catch (Exception ex)
            {
            }
        }

        private Form ShowOrActiveForm(Form form, Type t, bool Dialog = false)
        {
            if (form == null)
            {
                form = (Form)Activator.CreateInstance(t);
                form.StartPosition = FormStartPosition.CenterScreen;

                if (!Dialog)
                {
                    form.MdiParent = this;
                    form.Show();
                }
                else
                {
                    form.MdiParent = null;
                    form.ShowDialog();
                }
            }
            else
            {
                form.StartPosition = FormStartPosition.CenterScreen;

                if (form.IsDisposed)
                {
                    form = (Form)Activator.CreateInstance(t);
                    form.MdiParent = this;

                    if (!Dialog)
                    {
                        form.MdiParent = this;
                        form.Show();
                    }
                    else
                    {
                        form.MdiParent = null;
                        form.ShowDialog();
                    }
                }
                else
                {
                    if (!Dialog)
                    {
                        form.Activate();
                    }
                    else
                    {
                        form.MdiParent = null;
                        form.ShowDialog();
                    }

                }
            }
            return form;
        }

        private void AddStatusBar()
        {
            StatusBar main = new StatusBar();

            StatusBarPanel statusPanel = new StatusBarPanel();
            StatusBarPanel statusVersion = new StatusBarPanel();
            StatusBarPanel dateTimePanel = new StatusBarPanel();
            StatusBarPanel serverPanel = new StatusBarPanel();


            statusPanel.BorderStyle = StatusBarPanelBorderStyle.Sunken;
            statusPanel.Text = "Usuario.- " + UserName;
            statusPanel.ToolTipText = UserName;
            statusPanel.AutoSize = StatusBarPanelAutoSize.Spring;

            main.Panels.Add(statusPanel);

            statusVersion.BorderStyle = StatusBarPanelBorderStyle.Sunken;
            statusVersion.Text = "SICAP V1.0.0";
            statusVersion.AutoSize = StatusBarPanelAutoSize.Spring;

            main.Panels.Add(statusVersion);


            dateTimePanel.BorderStyle = StatusBarPanelBorderStyle.Raised;
            dateTimePanel.Text = DateTime.Today.ToLongDateString();
            dateTimePanel.ToolTipText = "Fecha: " + DateTime.Today.ToString("dd/MM/yyyy");
            dateTimePanel.AutoSize = StatusBarPanelAutoSize.Spring;

            main.Panels.Add(dateTimePanel);

            main.ShowPanels = true;

            this.Controls.Add(main);
        }

        #endregion
    }
}
using System;
using System.Windows.Forms;
using Utilities;
using Utilities.Extensions;
using posb = PosBusiness;
using UtilitiesForm.Extensions;

namespace WindowsFormsApplication1
{
    public partial class Sicap : Form
    {
        public string UserName;

        public Login Login;

        #region Members

        private CalleList CalleList = null;

        private Pagos Pagos = null;

        private PaymentYear PaymentYear = null;

        private Concentrado Concentrado = null;

        private HabitantFaenasList HabitantFaenasList = null;

        private FaenasList FaenasList = null;

        private InputOutputsList InputOutputsList = null;

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
                    this.entradasYSalidasToolStripMenuItem.Visible = e.Menu_IngresosEgresos.Value;
                    this.toolStripMenuItem2.Visible = e.Menu_Concentrado.Value;
                    this.faenasToolStripMenuItem.Visible = e.Menu_Cooperaciones.Value;
                    this.cooperacionesToolStripMenuItem.Visible = e.Menu_PagosCooperaciones.Value;
                    this.callesToolStripMenuItem.Visible = e.Menu_Calles.Value;

                    if (e.Menu_Pagos.Value)
                        PaymentList = ShowOrActiveForm(PaymentList, typeof(PaymentList)) as PaymentList;
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

        private void entradasYSalidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputOutputsList = ShowOrActiveForm(InputOutputsList, typeof(InputOutputsList)) as InputOutputsList;
        }

        private void faenasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FaenasList = ShowOrActiveForm(FaenasList, typeof(FaenasList)) as FaenasList;
        }

        private void bloquearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            this.Login.Show();
        }

        private void Sicap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Login != null)
                this.Login.Close();
        }

        private void cooperacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HabitantFaenasList = ShowOrActiveForm(HabitantFaenasList, typeof(HabitantFaenasList)) as HabitantFaenasList;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Concentrado = ShowOrActiveForm(Concentrado, typeof(Concentrado)) as Concentrado;
        }

        private void pagoPorAñoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaymentYear = ShowOrActiveForm(PaymentYear, typeof(PaymentYear)) as PaymentYear;
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var About = new About();

            About.ShowDialog();
        }

        private void pagosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Pagos = ShowOrActiveForm(Pagos, typeof(Pagos)) as Pagos;
        }

        private void callesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalleList = ShowOrActiveForm(CalleList, typeof(CalleList)) as CalleList;
        }
    }
}
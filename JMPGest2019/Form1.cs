using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.OleDb;
using System.Data.SqlClient;




namespace JMPGest2019
{
    public partial class frmPrincipal : Form
    {
        private DateTime fechaHora;

        public frmPrincipal()
        {
            InitializeComponent();
            try
            {
                fechaHora = DateTime.Now;
                fechaHora = DateTime.Parse(toolstripReloj.Text);
            }
            catch
            {
                //MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            toolstripFecha.Text = fechaHora.ToShortDateString();
            this.frmPrincipal_Resize(this, null);
            this.MouseHover += new System.EventHandler(this.Item_MouseHover);
        }

        private void frmPrincipal_Shown(object sender, EventArgs e)
        {
            //Globales.strSQLConnection = System.Configuration.ConfigurationManager.ConnectionStrings["ConexionSQLServer"].ConnectionString;
            Globales.strSQLConnection = System.Configuration.ConfigurationManager.ConnectionStrings["ConexionAccess"].ConnectionString;
            Globales.ConexionAccess = new OleDbConnection(Globales.strSQLConnection);
            toolStripTablas.Visible = false;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            DrawBackgroundGradient();
        }

        private void DrawBackgroundGradient()
        {
            LinearGradientBrush brush =
              new LinearGradientBrush(this.ClientRectangle, Color.Black, Color.Blue, LinearGradientMode.Vertical);
            Bitmap backImage = new Bitmap(this.Width, this.Height);
            Graphics graph = Graphics.FromImage(backImage);
            graph.FillRectangle(brush, 0, 0, ClientRectangle.Width, ClientRectangle.Height);
            this.BackgroundImage = backImage;
            brush.Dispose();
        }

        private void frmPrincipal_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
            toolstripToolTextTip.Width = (ClientRectangle.Width - (toolstripFecha.Width + toolstripReloj.Width +
              toolstripEjercicio.Width + toolstripDatabase.Width)) - 20;
            DrawBackgroundGradient();
        }

        public void Item_MouseHover(object sender, System.EventArgs e)
        {

            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            toolstripToolTextTip.Text = menuItem.ToolTipText;
        }

        public void Button_MouseHover(object sender, System.EventArgs e)
        {
            ToolStripButton ButtonItem = (ToolStripButton)sender;
            toolstripToolTextTip.Text = ButtonItem.ToolTipText;
        }

        private void timerReloj_Tick(object sender, EventArgs e)
        {
            fechaHora = fechaHora.AddSeconds(1);
            toolstripReloj.Text = fechaHora.ToLongTimeString();
        }

        private void TablasMenuItemClick(object sender, EventArgs e)
        {
            ToolStripMenuItem Opcion = (ToolStripMenuItem)sender;
            int MenuItem = 0;
            int.TryParse(Opcion.Tag.ToString(), out MenuItem);
            frmTablas formTablas = new frmTablas();
            formTablas.MdiParent = this;
            formTablas.WindowState = FormWindowState.Maximized;
            formTablas.SelItem = MenuItem;
            formTablas.Show();
        }

        
    }

    public static class Globales
    {
        public enum EditModes { Browse, Insert, Edit }
        public static SqlConnection ConexionSQL;
        public static OleDbConnection ConexionAccess;
        public static string ServerName;
        public static string DatabaseName;
        public static string strSQLConnection { get; set; }
    }
}

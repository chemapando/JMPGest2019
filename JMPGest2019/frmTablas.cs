using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;


namespace JMPGest2019
{
    public partial class frmTablas : Form
    {
        LibFuncs Funcs = new LibFuncs();
        public int SelItem { get; set; }
        DataTable CNAE = null;
        DataTable Bancos = null;
        DataTable Epigrafes = null;
        DataTable IVA = null;
        DataTable Familias = null;
        DataTable FormasPago = null;
        DataTable Marcas = null;
        DataTable Tarifas = null;
        DataTable Provincias = null;
        OleDbDataAdapter sqlAdapter = new OleDbDataAdapter();
        BindingSource tablaActual = new BindingSource();

        public frmTablas()
        {
            InitializeComponent();
        }

        private void frmTablas_Shown(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = SelItem;
            dgrdvProvincias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgrdvBancos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgrdvCNAE.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgrdvEpigrafes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgrdvFamilias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgrdvFormasPago.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgrdvIVA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgrdvMarcas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgrdvTarifas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbtnFindItem.Enabled = txtboxFindItem.Text != "";
            if (SelItem == 0) OpenTable(CNAE, "CNAE", dgrdvCNAE);
        }
     
        private void OpenTable(DataTable Tabla, string TableName, DataGridView grdTabla)
        {
            string query = "SELECT * FROM " + TableName;
            if (Tabla == null)
                Tabla = new DataTable(TableName);
            OleDbCommand sqlCmd = new OleDbCommand(query, Globales.ConexionAccess);
            sqlAdapter.SelectCommand = sqlCmd;
            sqlAdapter.Fill(Tabla);
            tablaActual.DataSource = Tabla;
            grdTabla.DataSource = tablaActual; ;
            bindnavTablas.BindingSource = tablaActual;
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    {
                        OpenTable(CNAE, "CNAE", dgrdvCNAE);
                        break;
                    }
                case 1:
                    {
                        OpenTable(Epigrafes, "Epigrafes", dgrdvEpigrafes);
                        break;
                    }
                case 2:
                    {
                        OpenTable(IVA, "IVA", dgrdvIVA);
                        break;
                    }
                case 3:
                    {
                        OpenTable(Familias, "Familias", dgrdvFamilias);
                        break;
                    }
                case 4:
                    {
                        OpenTable(FormasPago, "FormasPago", dgrdvFormasPago);
                        break;
                    }
                case 5:
                    {
                        OpenTable(Marcas, "Marcas", dgrdvMarcas);
                        break;
                    }
                case 6:
                    {
                        OpenTable(Tarifas, "Tarifas", dgrdvTarifas);
                        break;
                    }
                case 7:
                    {
                        OpenTable(Bancos, "Bancos", dgrdvBancos);
                        break;
                    }
                case 8:
                    {
                        OpenTable(Provincias, "Provincias", dgrdvProvincias);
                        break;
                    }
            }
        }

        private void dgrdvIVA_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((dgrdvIVA.Columns[e.ColumnIndex].Name == "Porcentaje") || (dgrdvIVA.Columns[e.ColumnIndex].Name == "RecargoEquivalencia"))
            {
                if (e.Value != null)
                {
                    dgrdvIVA.Columns[e.ColumnIndex].DefaultCellStyle.Format = "0.0\\%";
                }
            }
        }

        private void tbtnFindItem_Click(object sender, EventArgs e)
        {
            try
            {
                switch (tabControl.SelectedIndex)
                {
                    case 0:
                        {
                            string Actividad = "Actividad LIKE " + Funcs.QuotedStr("*" + txtboxFindItem.Text + "*", "'");
                            DataRow[] foundRows = CNAE.Select("Actividad LIKE " + Funcs.QuotedStr("*" + txtboxFindItem.Text + "*", "'"), "Codigo ASC");
                            CNAE.Clear();
                            foreach (DataRow row in foundRows)
                                CNAE.ImportRow(row);
                            break;
                        }
                }
            }
            catch (SyntaxErrorException e1)
            {
                MessageBox.Show(e1.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void txtboxFindItem_TextChanged(object sender, EventArgs e)
        {
            tbtnFindItem.Enabled = txtboxFindItem.Text != "";
        }
    }
}

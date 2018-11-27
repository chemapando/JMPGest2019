using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace JMPGest2019
{
    public partial class frmClientes : Form
    {
        public Globales.EditModes StatusEdit { get; set; }
        public string sqlqryClientes { get; set; }
        DataTable Clientes;
        OleDbDataAdapter sqlAdapter;
        BindingSource tablaClientes = new BindingSource();
        LibFuncs Funcs = new LibFuncs();
        string Filtro = "";
        string CurrentQuery = "SELECT * FROM Clientes WHERE Activo = -1";

        public frmClientes()
        {
            InitializeComponent();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            bindnavClientes.Dock = DockStyle.None;
            toolStrip1.Dock = DockStyle.None;
            bindnavClientes.Location = new Point(0, 0);
            toolStrip1.Location = new Point(bindnavClientes.Width, 0);
            toolStripContainer1.TopToolStripPanel.ResumeLayout();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            Clientes = new DataTable("Clientes");
            sqlAdapter = new OleDbDataAdapter();
            OleDbCommand sqlcmd = new OleDbCommand(CurrentQuery, Globales.ConexionAccess);
            sqlAdapter.SelectCommand = sqlcmd;
            sqlAdapter.Fill(Clientes);

            tablaClientes.DataSource = Clientes;
            bindnavClientes.BindingSource = tablaClientes;
            grdClientes.DataSource = tablaClientes;

            cboxCriterios.SelectedIndex = 0;
            cboxIndices.SelectedIndex = 2;
        }

        private void ItemToolStripMenu(object sender, EventArgs e)
        {
            UncheckOtherMenuItem((ToolStripMenuItem)sender);
            ToolStripMenuItem CurrentOption = new ToolStripMenuItem();
            CurrentOption = (ToolStripMenuItem)sender;

            if (CurrentOption.Text == "Todos los clientes")
                CurrentQuery = "SELECT * FROM Clientes";
            if (CurrentOption.Text == "Clientes activos")
                CurrentQuery = "SELECT * FROM Clientes WHERE Activo = -1";
            if (CurrentOption.Text == "Clientes inactivos")
                CurrentQuery = "SELECT * FROM Clientes WHERE Activo = 0";

            BtnRefrescar_Click(null, null);
            if (tablaClientes.Filter != "")
            {
                tablaClientes.Filter = "";
                txtboxSelFiltro.Text = "";
                cboxCriterios.SelectedIndex = 0;
                cboxIndices.SelectedItem = "RazonSocial";
            }
        }

        public void UncheckOtherMenuItem(ToolStripMenuItem selectedMenuItem)
        {
            selectedMenuItem.Checked = true;

            // Select other MenuItems from ParentMenu and unchecked this
            foreach (var ltoolstripMenuItem in (from object
                                                item in selectedMenuItem.Owner.Items
                                                let ltoolstripMenuItem = item as ToolStripMenuItem
                                                where ltoolstripMenuItem != null
                                                where !item.Equals(selectedMenuItem)
                                                select ltoolstripMenuItem))
                ltoolstripMenuItem.Checked = false;
        }

        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            Clientes = new DataTable("Clientes");
            sqlAdapter = new OleDbDataAdapter();
            OleDbCommand sqlcmd = new OleDbCommand(CurrentQuery, Globales.ConexionAccess);
            sqlAdapter.SelectCommand = sqlcmd;
            sqlAdapter.Fill(Clientes);

            tablaClientes.DataSource = Clientes;
            bindnavClientes.BindingSource = tablaClientes;
            grdClientes.DataSource = tablaClientes;
        }

        private void grdClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmEditCliente formEditCliente = new frmEditCliente();
            formEditCliente.StatusEdit = Globales.EditModes.Edit;
            formEditCliente.MdiParent = Application.OpenForms[0];
            formEditCliente.WindowState = FormWindowState.Maximized;
            formEditCliente.CodCliente = Funcs.EncloseString(grdClientes.Rows[e.RowIndex].Cells[0].Value.ToString(), "'");
            formEditCliente.sqlqryClientes = "SELECT * FROM Clientes WHERE Codigo = " +
              Funcs.EncloseString(grdClientes.Rows[e.RowIndex].Cells[0].Value.ToString(), "'");
            formEditCliente.Show();
        }

        private void txtboxSelFiltro_TextChanged(object sender, EventArgs e)
        {
            switch (cboxCriterios.SelectedIndex)
            {
                case 0:
                    Filtro = getFilterField() + " LIKE " + Funcs.EncloseString(txtboxSelFiltro.Text + "*", "'");
                    break;
                case 1:
                    Filtro = getFilterField() + " LIKE *" + Funcs.EncloseString(Funcs.EncloseString(txtboxSelFiltro.Text, "*"), "'");
                    break;
            }
            tablaClientes.Filter = Filtro;
        }

        private void frmClientes_Shown(object sender, EventArgs e)
        {
            grdClientes.RowHeadersDefaultCellStyle.BackColor = Color.White;
            grdClientes.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleTurquoise;
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            BtnRefrescar_Click(null, null);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            string CodCliente = grdClientes.CurrentRow.Cells[0].Value.ToString();

            if (MessageBox.Show("Se dispone a borrar un cliente de la tabla. ¿Esta seguro?", "Pregunta",
              MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string sqlcmd = "DELETE FROM Clientes WHERE Codigo = " + Funcs.EncloseString(CodCliente, "'");

                using (OleDbCommand sqlDelete = new OleDbCommand(sqlcmd, Globales.ConexionAccess))
                {
                    try
                    {
                        sqlDelete.ExecuteNonQuery();
                    }
                    catch (Exception E)
                    {
                        MessageBox.Show(E.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void tstrbtnEditar_Click(object sender, EventArgs e)
        {
            frmEditCliente formEditCliente = new frmEditCliente();
            formEditCliente.StatusEdit = Globales.EditModes.Edit;
            formEditCliente.MdiParent = Application.OpenForms[0];
            formEditCliente.WindowState = FormWindowState.Maximized;
            formEditCliente.sqlqryClientes = "SELECT * FROM Clientes WHERE Codigo = " +
              Funcs.EncloseString(grdClientes.Rows[grdClientes.CurrentCell.RowIndex].Cells[0].Value.ToString(), "'");
            formEditCliente.Show();
        }

        private void tstrbtnActivarBuscar_Click(object sender, EventArgs e)
        {
            tstrbtnActivarBuscar.Checked = !tstrbtnActivarBuscar.Checked;
            panelBuscar.Visible = tstrbtnActivarBuscar.Checked;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            frmEditCliente formEditCliente = new frmEditCliente();
            formEditCliente.StatusEdit = Globales.EditModes.Insert;
            formEditCliente.MdiParent = Application.OpenForms[0];
            formEditCliente.WindowState = FormWindowState.Maximized;
            formEditCliente.Show();
        }

        private void frmClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void txtboxSelFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtboxSelFiltro_TextChanged(null, null);
            }
        }

        private string getFilterField()
        {
            string Resultado = "";
            switch (cboxIndices.SelectedIndex)
            {
                case 0:
                    Resultado = "Codigo";
                    break;
                case 1:
                    Resultado = "RazonSocial";
                    break;
                case 2:
                    Resultado = "Domicilio";
                    break;
                case 3:
                    Resultado = "CodigoPostal";
                    break;
                case 4:
                    Resultado = "Poblacion";
                    break;
                case 5:
                    Resultado = "Telefono1";
                    break;
                case 6:
                    Resultado = "NombreComercial";
                    break;
                case 7:
                    Resultado = "NIFoCIF";
                    break;
            }
            return Resultado;
        }
    }
}

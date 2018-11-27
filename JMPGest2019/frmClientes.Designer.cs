namespace JMPGest2019
{
    partial class frmClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelBuscar = new System.Windows.Forms.Panel();
            this.cboxCriterios = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxIndices = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxSelFiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.grdClientes = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tstrbtnActivarBuscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tstrddbtnConsultas = new System.Windows.Forms.ToolStripDropDownButton();
            this.todosLosClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesActivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesInactivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnRefrescar = new System.Windows.Forms.ToolStripButton();
            this.bindnavClientes = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tstrbtnEditar = new System.Windows.Forms.ToolStripButton();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.panelBuscar.SuspendLayout();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindnavClientes)).BeginInit();
            this.bindnavClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(224, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 378);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // panelBuscar
            // 
            this.panelBuscar.Controls.Add(this.cboxCriterios);
            this.panelBuscar.Controls.Add(this.label3);
            this.panelBuscar.Controls.Add(this.cboxIndices);
            this.panelBuscar.Controls.Add(this.label2);
            this.panelBuscar.Controls.Add(this.txtboxSelFiltro);
            this.panelBuscar.Controls.Add(this.label1);
            this.panelBuscar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBuscar.Location = new System.Drawing.Point(0, 0);
            this.panelBuscar.Name = "panelBuscar";
            this.panelBuscar.Size = new System.Drawing.Size(224, 378);
            this.panelBuscar.TabIndex = 1;
            // 
            // cboxCriterios
            // 
            this.cboxCriterios.FormattingEnabled = true;
            this.cboxCriterios.Items.AddRange(new object[] {
            "Empieza por...",
            "Contiene a..."});
            this.cboxCriterios.Location = new System.Drawing.Point(15, 145);
            this.cboxCriterios.Name = "cboxCriterios";
            this.cboxCriterios.Size = new System.Drawing.Size(187, 21);
            this.cboxCriterios.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "con el criterio:";
            // 
            // cboxIndices
            // 
            this.cboxIndices.FormattingEnabled = true;
            this.cboxIndices.Items.AddRange(new object[] {
            "Codigo",
            "Razón Social",
            "Domicilio",
            "Código Postal",
            "Población",
            "Teléfono",
            "Nombre Comercial",
            "N.I.F. o C.I.F."});
            this.cboxIndices.Location = new System.Drawing.Point(15, 88);
            this.cboxIndices.Name = "cboxIndices";
            this.cboxIndices.Size = new System.Drawing.Size(187, 21);
            this.cboxIndices.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "por:";
            // 
            // txtboxSelFiltro
            // 
            this.txtboxSelFiltro.Location = new System.Drawing.Point(15, 30);
            this.txtboxSelFiltro.Name = "txtboxSelFiltro";
            this.txtboxSelFiltro.Size = new System.Drawing.Size(187, 20);
            this.txtboxSelFiltro.TabIndex = 1;
            this.txtboxSelFiltro.TextChanged += new System.EventHandler(this.txtboxSelFiltro_TextChanged);
            this.txtboxSelFiltro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtboxSelFiltro_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar:";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.grdClientes);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitter1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panelBuscar);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 378);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(800, 450);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.bindnavClientes);
            // 
            // grdClientes
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdClientes.Location = new System.Drawing.Point(227, 0);
            this.grdClientes.Name = "grdClientes";
            this.grdClientes.ReadOnly = true;
            this.grdClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdClientes.Size = new System.Drawing.Size(573, 378);
            this.grdClientes.TabIndex = 3;
            this.grdClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdClientes_CellDoubleClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstrbtnActivarBuscar,
            this.toolStripSeparator2,
            this.toolStripButton4,
            this.toolStripSeparator3,
            this.tstrddbtnConsultas,
            this.toolStripSeparator4,
            this.BtnRefrescar});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(243, 25);
            this.toolStrip1.TabIndex = 3;
            // 
            // tstrbtnActivarBuscar
            // 
            this.tstrbtnActivarBuscar.Checked = true;
            this.tstrbtnActivarBuscar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tstrbtnActivarBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstrbtnActivarBuscar.Image = ((System.Drawing.Image)(resources.GetObject("tstrbtnActivarBuscar.Image")));
            this.tstrbtnActivarBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstrbtnActivarBuscar.Name = "tstrbtnActivarBuscar";
            this.tstrbtnActivarBuscar.Size = new System.Drawing.Size(23, 22);
            this.tstrbtnActivarBuscar.Click += new System.EventHandler(this.tstrbtnActivarBuscar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tstrddbtnConsultas
            // 
            this.tstrddbtnConsultas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todosLosClientesToolStripMenuItem,
            this.clientesActivosToolStripMenuItem,
            this.clientesInactivosToolStripMenuItem});
            this.tstrddbtnConsultas.Image = ((System.Drawing.Image)(resources.GetObject("tstrddbtnConsultas.Image")));
            this.tstrddbtnConsultas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstrddbtnConsultas.Name = "tstrddbtnConsultas";
            this.tstrddbtnConsultas.Size = new System.Drawing.Size(88, 22);
            this.tstrddbtnConsultas.Text = "Consultas";
            // 
            // todosLosClientesToolStripMenuItem
            // 
            this.todosLosClientesToolStripMenuItem.CheckOnClick = true;
            this.todosLosClientesToolStripMenuItem.Name = "todosLosClientesToolStripMenuItem";
            this.todosLosClientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.todosLosClientesToolStripMenuItem.Tag = "0";
            this.todosLosClientesToolStripMenuItem.Text = "Todos los clientes";
            this.todosLosClientesToolStripMenuItem.Click += new System.EventHandler(this.ItemToolStripMenu);
            // 
            // clientesActivosToolStripMenuItem
            // 
            this.clientesActivosToolStripMenuItem.Checked = true;
            this.clientesActivosToolStripMenuItem.CheckOnClick = true;
            this.clientesActivosToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.clientesActivosToolStripMenuItem.Name = "clientesActivosToolStripMenuItem";
            this.clientesActivosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesActivosToolStripMenuItem.Tag = "1";
            this.clientesActivosToolStripMenuItem.Text = "Clientes activos";
            this.clientesActivosToolStripMenuItem.Click += new System.EventHandler(this.ItemToolStripMenu);
            // 
            // clientesInactivosToolStripMenuItem
            // 
            this.clientesInactivosToolStripMenuItem.CheckOnClick = true;
            this.clientesInactivosToolStripMenuItem.Name = "clientesInactivosToolStripMenuItem";
            this.clientesInactivosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesInactivosToolStripMenuItem.Tag = "2";
            this.clientesInactivosToolStripMenuItem.Text = "Clientes inactivos";
            this.clientesInactivosToolStripMenuItem.Click += new System.EventHandler(this.ItemToolStripMenu);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // BtnRefrescar
            // 
            this.BtnRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("BtnRefrescar.Image")));
            this.BtnRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnRefrescar.Name = "BtnRefrescar";
            this.BtnRefrescar.Size = new System.Drawing.Size(79, 22);
            this.BtnRefrescar.Text = "Actualizar";
            this.BtnRefrescar.ToolTipText = "Actualiza o refresca el contenido del formulario";
            this.BtnRefrescar.Click += new System.EventHandler(this.BtnRefrescar_Click);
            // 
            // bindnavClientes
            // 
            this.bindnavClientes.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindnavClientes.CountItem = this.bindingNavigatorCountItem;
            this.bindnavClientes.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindnavClientes.Dock = System.Windows.Forms.DockStyle.None;
            this.bindnavClientes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.tstrbtnEditar,
            this.bindingNavigatorDeleteItem});
            this.bindnavClientes.Location = new System.Drawing.Point(3, 25);
            this.bindnavClientes.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindnavClientes.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindnavClientes.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindnavClientes.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindnavClientes.Name = "bindnavClientes";
            this.bindnavClientes.PositionItem = this.bindingNavigatorPositionItem;
            this.bindnavClientes.Size = new System.Drawing.Size(280, 25);
            this.bindnavClientes.TabIndex = 4;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tstrbtnEditar
            // 
            this.tstrbtnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstrbtnEditar.Image = ((System.Drawing.Image)(resources.GetObject("tstrbtnEditar.Image")));
            this.tstrbtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstrbtnEditar.Name = "tstrbtnEditar";
            this.tstrbtnEditar.Size = new System.Drawing.Size(23, 22);
            this.tstrbtnEditar.ToolTipText = "Edita el cliente del registro seleccionado";
            this.tstrbtnEditar.Click += new System.EventHandler(this.tstrbtnEditar_Click);
            // 
            // timerRefresh
            // 
            this.timerRefresh.Enabled = true;
            this.timerRefresh.Interval = 300000;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "frmClientes";
            this.Text = "frmClientes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmClientes_FormClosed);
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.Shown += new System.EventHandler(this.frmClientes_Shown);
            this.panelBuscar.ResumeLayout(false);
            this.panelBuscar.PerformLayout();
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindnavClientes)).EndInit();
            this.bindnavClientes.ResumeLayout(false);
            this.bindnavClientes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panelBuscar;
        private System.Windows.Forms.ComboBox cboxCriterios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxIndices;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxSelFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.DataGridView grdClientes;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tstrbtnActivarBuscar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton tstrddbtnConsultas;
        private System.Windows.Forms.ToolStripMenuItem todosLosClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesActivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesInactivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton BtnRefrescar;
        private System.Windows.Forms.BindingNavigator bindnavClientes;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tstrbtnEditar;
        private System.Windows.Forms.Timer timerRefresh;
    }
}
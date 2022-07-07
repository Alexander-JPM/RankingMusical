namespace RankingMusical
{
    partial class TopMusic
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopMusic));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tvDirectorios = new System.Windows.Forms.TreeView();
            this.dgvCanciones = new System.Windows.Forms.DataGridView();
            this.Ranking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cancion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsArchivo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEliminarArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMover = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsCarpeta = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAgregarArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEliminarCarpeta = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCarpeta = new System.Windows.Forms.TextBox();
            this.btnCrearCarpeta = new System.Windows.Forms.Button();
            this.panArchivo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelarCaerpeta = new System.Windows.Forms.Button();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnArriba = new System.Windows.Forms.Button();
            this.btnAbajo = new System.Windows.Forms.Button();
            this.panDestinoArchivo = new System.Windows.Forms.Panel();
            this.btnCancelarArchivo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCarpetas = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtBuscarArtista = new System.Windows.Forms.TextBox();
            this.btnDescargarTXT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanciones)).BeginInit();
            this.cmsArchivo.SuspendLayout();
            this.cmsCarpeta.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panArchivo.SuspendLayout();
            this.panDestinoArchivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvDirectorios
            // 
            this.tvDirectorios.BackColor = System.Drawing.Color.PowderBlue;
            resources.ApplyResources(this.tvDirectorios, "tvDirectorios");
            this.tvDirectorios.HideSelection = false;
            this.tvDirectorios.LabelEdit = true;
            this.tvDirectorios.Name = "tvDirectorios";
            this.tvDirectorios.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.tvDirectorios_AfterLabelEdit);
            this.tvDirectorios.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvDirectorios_AfterSelect);
            this.tvDirectorios.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvDirectorios_NodeMouseClick);
            this.tvDirectorios.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tvDirectorios_MouseClick);
            // 
            // dgvCanciones
            // 
            this.dgvCanciones.AllowUserToDeleteRows = false;
            this.dgvCanciones.AllowUserToResizeRows = false;
            this.dgvCanciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCanciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCanciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCanciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCanciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCanciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ranking,
            this.Cancion,
            this.Artista});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCanciones.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvCanciones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvCanciones.GridColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.dgvCanciones, "dgvCanciones");
            this.dgvCanciones.MultiSelect = false;
            this.dgvCanciones.Name = "dgvCanciones";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCanciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvCanciones.RowHeadersVisible = false;
            this.dgvCanciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCanciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCanciones_CellClick);
            this.dgvCanciones.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCanciones_CellEndEdit);
            this.dgvCanciones.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvCanciones_RowsAdded);
            // 
            // Ranking
            // 
            this.Ranking.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ranking.DefaultCellStyle = dataGridViewCellStyle8;
            resources.ApplyResources(this.Ranking, "Ranking");
            this.Ranking.Name = "Ranking";
            this.Ranking.ReadOnly = true;
            this.Ranking.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Cancion
            // 
            this.Cancion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancion.DefaultCellStyle = dataGridViewCellStyle9;
            this.Cancion.FillWeight = 145.9854F;
            resources.ApplyResources(this.Cancion, "Cancion");
            this.Cancion.Name = "Cancion";
            this.Cancion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Artista
            // 
            this.Artista.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Artista.DefaultCellStyle = dataGridViewCellStyle10;
            this.Artista.FillWeight = 54.0146F;
            resources.ApplyResources(this.Artista, "Artista");
            this.Artista.Name = "Artista";
            this.Artista.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // cmsArchivo
            // 
            this.cmsArchivo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsArchivo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEliminarArchivo,
            this.tsmiMover});
            this.cmsArchivo.Name = "cmsArchivo";
            resources.ApplyResources(this.cmsArchivo, "cmsArchivo");
            // 
            // tsmiEliminarArchivo
            // 
            this.tsmiEliminarArchivo.Name = "tsmiEliminarArchivo";
            resources.ApplyResources(this.tsmiEliminarArchivo, "tsmiEliminarArchivo");
            this.tsmiEliminarArchivo.Click += new System.EventHandler(this.tsmiEliminarArchivo_Click);
            // 
            // tsmiMover
            // 
            this.tsmiMover.Name = "tsmiMover";
            resources.ApplyResources(this.tsmiMover, "tsmiMover");
            this.tsmiMover.Click += new System.EventHandler(this.tsmiMover_Click);
            // 
            // cmsCarpeta
            // 
            this.cmsCarpeta.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsCarpeta.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAgregarArchivo,
            this.tsmiEliminarCarpeta});
            this.cmsCarpeta.Name = "cmsCarpeta";
            resources.ApplyResources(this.cmsCarpeta, "cmsCarpeta");
            // 
            // tsmiAgregarArchivo
            // 
            this.tsmiAgregarArchivo.Name = "tsmiAgregarArchivo";
            resources.ApplyResources(this.tsmiAgregarArchivo, "tsmiAgregarArchivo");
            this.tsmiAgregarArchivo.Click += new System.EventHandler(this.tsmiAgregarArchivo_Click);
            // 
            // tsmiEliminarCarpeta
            // 
            this.tsmiEliminarCarpeta.Name = "tsmiEliminarCarpeta";
            resources.ApplyResources(this.tsmiEliminarCarpeta, "tsmiEliminarCarpeta");
            this.tsmiEliminarCarpeta.Click += new System.EventHandler(this.tsmiEliminarCarpeta_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCarpeta);
            this.panel1.Controls.Add(this.btnCrearCarpeta);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // txtCarpeta
            // 
            resources.ApplyResources(this.txtCarpeta, "txtCarpeta");
            this.txtCarpeta.Name = "txtCarpeta";
            this.txtCarpeta.TextChanged += new System.EventHandler(this.txtCarpeta_TextChanged);
            // 
            // btnCrearCarpeta
            // 
            resources.ApplyResources(this.btnCrearCarpeta, "btnCrearCarpeta");
            this.btnCrearCarpeta.Name = "btnCrearCarpeta";
            this.btnCrearCarpeta.UseVisualStyleBackColor = true;
            this.btnCrearCarpeta.Click += new System.EventHandler(this.btnCrearCarpeta_Click);
            // 
            // panArchivo
            // 
            this.panArchivo.Controls.Add(this.label1);
            this.panArchivo.Controls.Add(this.btnCancelarCaerpeta);
            this.panArchivo.Controls.Add(this.txtArchivo);
            this.panArchivo.Controls.Add(this.btnAceptar);
            resources.ApplyResources(this.panArchivo, "panArchivo");
            this.panArchivo.Name = "panArchivo";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnCancelarCaerpeta
            // 
            resources.ApplyResources(this.btnCancelarCaerpeta, "btnCancelarCaerpeta");
            this.btnCancelarCaerpeta.Name = "btnCancelarCaerpeta";
            this.btnCancelarCaerpeta.UseVisualStyleBackColor = true;
            this.btnCancelarCaerpeta.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtArchivo
            // 
            resources.ApplyResources(this.txtArchivo, "txtArchivo");
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.TextChanged += new System.EventHandler(this.txtArchivo_TextChanged);
            // 
            // btnAceptar
            // 
            resources.ApplyResources(this.btnAceptar, "btnAceptar");
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnArriba
            // 
            this.btnArriba.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnArriba, "btnArriba");
            this.btnArriba.ForeColor = System.Drawing.Color.White;
            this.btnArriba.Image = global::RankingMusical.Properties.Resources.FlechaArriba;
            this.btnArriba.Name = "btnArriba";
            this.btnArriba.UseVisualStyleBackColor = false;
            this.btnArriba.Click += new System.EventHandler(this.btnArriba_Click);
            // 
            // btnAbajo
            // 
            this.btnAbajo.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnAbajo, "btnAbajo");
            this.btnAbajo.ForeColor = System.Drawing.Color.White;
            this.btnAbajo.Image = global::RankingMusical.Properties.Resources.FlechaAbajo;
            this.btnAbajo.Name = "btnAbajo";
            this.btnAbajo.UseVisualStyleBackColor = false;
            this.btnAbajo.Click += new System.EventHandler(this.btnAbajo_Click);
            // 
            // panDestinoArchivo
            // 
            this.panDestinoArchivo.Controls.Add(this.btnCancelarArchivo);
            this.panDestinoArchivo.Controls.Add(this.label2);
            this.panDestinoArchivo.Controls.Add(this.cboCarpetas);
            resources.ApplyResources(this.panDestinoArchivo, "panDestinoArchivo");
            this.panDestinoArchivo.Name = "panDestinoArchivo";
            // 
            // btnCancelarArchivo
            // 
            resources.ApplyResources(this.btnCancelarArchivo, "btnCancelarArchivo");
            this.btnCancelarArchivo.Name = "btnCancelarArchivo";
            this.btnCancelarArchivo.UseVisualStyleBackColor = true;
            this.btnCancelarArchivo.Click += new System.EventHandler(this.btnCancelarArchivo_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // cboCarpetas
            // 
            this.cboCarpetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCarpetas.FormattingEnabled = true;
            resources.ApplyResources(this.cboCarpetas, "cboCarpetas");
            this.cboCarpetas.Name = "cboCarpetas";
            this.cboCarpetas.SelectionChangeCommitted += new System.EventHandler(this.cboCarpetas_SelectionChangeCommitted);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnEliminar, "btnEliminar");
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = global::RankingMusical.Properties.Resources.eliminar;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtBuscador
            // 
            resources.ApplyResources(this.txtBuscador, "txtBuscador");
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.TextChanged += new System.EventHandler(this.txtBuscador_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.BackgroundImage = global::RankingMusical.Properties.Resources.Agregar;
            resources.ApplyResources(this.btnAgregar, "btnAgregar");
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtBuscarArtista
            // 
            resources.ApplyResources(this.txtBuscarArtista, "txtBuscarArtista");
            this.txtBuscarArtista.Name = "txtBuscarArtista";
            this.txtBuscarArtista.TextChanged += new System.EventHandler(this.txtBuscarArtista_TextChanged);
            // 
            // btnDescargarTXT
            // 
            this.btnDescargarTXT.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnDescargarTXT, "btnDescargarTXT");
            this.btnDescargarTXT.ForeColor = System.Drawing.Color.White;
            this.btnDescargarTXT.Image = global::RankingMusical.Properties.Resources.down;
            this.btnDescargarTXT.Name = "btnDescargarTXT";
            this.btnDescargarTXT.UseVisualStyleBackColor = false;
            this.btnDescargarTXT.Click += new System.EventHandler(this.btnDescargarTXT_Click);
            // 
            // TopMusic
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RankingMusical.Properties.Resources.Fondo;
            this.Controls.Add(this.btnDescargarTXT);
            this.Controls.Add(this.txtBuscarArtista);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtBuscador);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.panDestinoArchivo);
            this.Controls.Add(this.btnAbajo);
            this.Controls.Add(this.btnArriba);
            this.Controls.Add(this.panArchivo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvCanciones);
            this.Controls.Add(this.tvDirectorios);
            this.Name = "TopMusic";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TopMusic_Load);
            this.Shown += new System.EventHandler(this.TopMusic_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanciones)).EndInit();
            this.cmsArchivo.ResumeLayout(false);
            this.cmsCarpeta.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panArchivo.ResumeLayout(false);
            this.panArchivo.PerformLayout();
            this.panDestinoArchivo.ResumeLayout(false);
            this.panDestinoArchivo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvDirectorios;
        private System.Windows.Forms.DataGridView dgvCanciones;
        private System.Windows.Forms.ContextMenuStrip cmsArchivo;
        private System.Windows.Forms.ToolStripMenuItem tsmiEliminarArchivo;
        private System.Windows.Forms.ContextMenuStrip cmsCarpeta;
        private System.Windows.Forms.ToolStripMenuItem tsmiAgregarArchivo;
        private System.Windows.Forms.ToolStripMenuItem tsmiEliminarCarpeta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCarpeta;
        private System.Windows.Forms.Button btnCrearCarpeta;
        private System.Windows.Forms.Panel panArchivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelarCaerpeta;
        private System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnArriba;
        private System.Windows.Forms.Button btnAbajo;
        private System.Windows.Forms.ToolStripMenuItem tsmiMover;
        private System.Windows.Forms.Panel panDestinoArchivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCarpetas;
        private System.Windows.Forms.Button btnCancelarArchivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ranking;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cancion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artista;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtBuscarArtista;
        private System.Windows.Forms.Button btnDescargarTXT;
    }
}


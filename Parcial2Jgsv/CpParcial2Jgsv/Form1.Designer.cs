namespace CpParcial2Jgsv
{
	partial class FrmSerie
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.gbxDatos = new System.Windows.Forms.GroupBox();
			this.cbbCategoria = new System.Windows.Forms.ComboBox();
			this.lblCategoria = new System.Windows.Forms.Label();
			this.rtbSinopsis = new System.Windows.Forms.RichTextBox();
			this.dtpFechaEstreno = new System.Windows.Forms.DateTimePicker();
			this.txtDirector = new System.Windows.Forms.TextBox();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.nudEpisodios = new System.Windows.Forms.NumericUpDown();
			this.lblFechaEstreno = new System.Windows.Forms.Label();
			this.lblEpisodios = new System.Windows.Forms.Label();
			this.txtTitulo = new System.Windows.Forms.TextBox();
			this.lblDirector = new System.Windows.Forms.Label();
			this.lblSinopsis = new System.Windows.Forms.Label();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.pnlAcciones = new System.Windows.Forms.Panel();
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.gbxLista = new System.Windows.Forms.GroupBox();
			this.dgvLista = new System.Windows.Forms.DataGridView();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.txtParametro = new System.Windows.Forms.TextBox();
			this.lblParametro = new System.Windows.Forms.Label();
			this.lblTituloPrincipal = new System.Windows.Forms.Label();
			this.erpTitulo = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpSinopsis = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpDirector = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpEpisodios = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpFechaEstreno = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpCategoria = new System.Windows.Forms.ErrorProvider(this.components);
			this.gbxDatos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudEpisodios)).BeginInit();
			this.pnlAcciones.SuspendLayout();
			this.gbxLista.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpTitulo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpSinopsis)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpDirector)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpEpisodios)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpFechaEstreno)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpCategoria)).BeginInit();
			this.SuspendLayout();
			// 
			// gbxDatos
			// 
			this.gbxDatos.Controls.Add(this.cbbCategoria);
			this.gbxDatos.Controls.Add(this.lblCategoria);
			this.gbxDatos.Controls.Add(this.rtbSinopsis);
			this.gbxDatos.Controls.Add(this.dtpFechaEstreno);
			this.gbxDatos.Controls.Add(this.txtDirector);
			this.gbxDatos.Controls.Add(this.btnCancelar);
			this.gbxDatos.Controls.Add(this.btnGuardar);
			this.gbxDatos.Controls.Add(this.nudEpisodios);
			this.gbxDatos.Controls.Add(this.lblFechaEstreno);
			this.gbxDatos.Controls.Add(this.lblEpisodios);
			this.gbxDatos.Controls.Add(this.txtTitulo);
			this.gbxDatos.Controls.Add(this.lblDirector);
			this.gbxDatos.Controls.Add(this.lblSinopsis);
			this.gbxDatos.Controls.Add(this.lblTitulo);
			this.gbxDatos.Location = new System.Drawing.Point(51, 302);
			this.gbxDatos.Name = "gbxDatos";
			this.gbxDatos.Size = new System.Drawing.Size(820, 282);
			this.gbxDatos.TabIndex = 20;
			this.gbxDatos.TabStop = false;
			this.gbxDatos.Text = "Datos";
			// 
			// cbbCategoria
			// 
			this.cbbCategoria.FormattingEnabled = true;
			this.cbbCategoria.Items.AddRange(new object[] {
			"Terror",
			"Comedia",
			"Animada",
			"Acción"});
			this.cbbCategoria.Location = new System.Drawing.Point(528, 81);
			this.cbbCategoria.Name = "cbbCategoria";
			this.cbbCategoria.Size = new System.Drawing.Size(242, 24);
			this.cbbCategoria.TabIndex = 12;
			// 
			// lblCategoria
			// 
			this.lblCategoria.AutoSize = true;
			this.lblCategoria.Location = new System.Drawing.Point(407, 82);
			this.lblCategoria.Name = "lblCategoria";
			this.lblCategoria.Size = new System.Drawing.Size(69, 16);
			this.lblCategoria.TabIndex = 18;
			this.lblCategoria.Text = "Categoría:";
			// 
			// rtbSinopsis
			// 
			this.rtbSinopsis.Location = new System.Drawing.Point(139, 50);
			this.rtbSinopsis.Name = "rtbSinopsis";
			this.rtbSinopsis.Size = new System.Drawing.Size(238, 151);
			this.rtbSinopsis.TabIndex = 8;
			this.rtbSinopsis.Text = "";
			// 
			// dtpFechaEstreno
			// 
			this.dtpFechaEstreno.Location = new System.Drawing.Point(528, 50);
			this.dtpFechaEstreno.Name = "dtpFechaEstreno";
			this.dtpFechaEstreno.Size = new System.Drawing.Size(242, 22);
			this.dtpFechaEstreno.TabIndex = 11;
			this.dtpFechaEstreno.Value = new System.DateTime(2024, 6, 3, 0, 0, 0, 0);
			// 
			// txtDirector
			// 
			this.txtDirector.Location = new System.Drawing.Point(139, 207);
			this.txtDirector.Name = "txtDirector";
			this.txtDirector.Size = new System.Drawing.Size(238, 22);
			this.txtDirector.TabIndex = 9;
			// 
			// btnCancelar
			// 
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancelar.Location = new System.Drawing.Point(703, 236);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(111, 40);
			this.btnCancelar.TabIndex = 16;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancelar.UseVisualStyleBackColor = true;
			// 
			// btnGuardar
			// 
			this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardar.Location = new System.Drawing.Point(586, 236);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(111, 40);
			this.btnGuardar.TabIndex = 15;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnGuardar.UseVisualStyleBackColor = true;
			// 
			// nudEpisodios
			// 
			this.nudEpisodios.Location = new System.Drawing.Point(528, 19);
			this.nudEpisodios.Maximum = new decimal(new int[] {
			1000,
			0,
			0,
			0});
			this.nudEpisodios.Name = "nudEpisodios";
			this.nudEpisodios.Size = new System.Drawing.Size(120, 22);
			this.nudEpisodios.TabIndex = 10;
			// 
			// lblFechaEstreno
			// 
			this.lblFechaEstreno.AutoSize = true;
			this.lblFechaEstreno.Location = new System.Drawing.Point(407, 50);
			this.lblFechaEstreno.Name = "lblFechaEstreno";
			this.lblFechaEstreno.Size = new System.Drawing.Size(116, 16);
			this.lblFechaEstreno.TabIndex = 11;
			this.lblFechaEstreno.Text = "Fecha de Estreno:";
			// 
			// lblEpisodios
			// 
			this.lblEpisodios.AutoSize = true;
			this.lblEpisodios.Location = new System.Drawing.Point(407, 21);
			this.lblEpisodios.Name = "lblEpisodios";
			this.lblEpisodios.Size = new System.Drawing.Size(71, 16);
			this.lblEpisodios.TabIndex = 10;
			this.lblEpisodios.Text = "Episodios:";
			// 
			// txtTitulo
			// 
			this.txtTitulo.Location = new System.Drawing.Point(139, 18);
			this.txtTitulo.Name = "txtTitulo";
			this.txtTitulo.Size = new System.Drawing.Size(238, 22);
			this.txtTitulo.TabIndex = 7;
			// 
			// lblDirector
			// 
			this.lblDirector.AutoSize = true;
			this.lblDirector.Location = new System.Drawing.Point(6, 212);
			this.lblDirector.Name = "lblDirector";
			this.lblDirector.Size = new System.Drawing.Size(57, 16);
			this.lblDirector.TabIndex = 2;
			this.lblDirector.Text = "Director:";
			// 
			// lblSinopsis
			// 
			this.lblSinopsis.AutoSize = true;
			this.lblSinopsis.Location = new System.Drawing.Point(8, 50);
			this.lblSinopsis.Name = "lblSinopsis";
			this.lblSinopsis.Size = new System.Drawing.Size(62, 16);
			this.lblSinopsis.TabIndex = 1;
			this.lblSinopsis.Text = "Sinopsis:";
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Location = new System.Drawing.Point(8, 21);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(43, 16);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Título:";
			// 
			// pnlAcciones
			// 
			this.pnlAcciones.Controls.Add(this.btnSalir);
			this.pnlAcciones.Controls.Add(this.btnEliminar);
			this.pnlAcciones.Controls.Add(this.btnEditar);
			this.pnlAcciones.Controls.Add(this.btnNuevo);
			this.pnlAcciones.Location = new System.Drawing.Point(51, 249);
			this.pnlAcciones.Name = "pnlAcciones";
			this.pnlAcciones.Size = new System.Drawing.Size(820, 47);
			this.pnlAcciones.TabIndex = 19;
			// 
			// btnSalir
			// 
			this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSalir.Location = new System.Drawing.Point(510, 3);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(83, 40);
			this.btnSalir.TabIndex = 9;
			this.btnSalir.Text = "Salir";
			this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEliminar.Location = new System.Drawing.Point(403, 4);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(101, 40);
			this.btnEliminar.TabIndex = 8;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEditar.Location = new System.Drawing.Point(309, 4);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(88, 40);
			this.btnEditar.TabIndex = 7;
			this.btnEditar.Text = "Editar";
			this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnNuevo
			// 
			this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNuevo.Location = new System.Drawing.Point(212, 3);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(91, 40);
			this.btnNuevo.TabIndex = 6;
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnNuevo.UseVisualStyleBackColor = true;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// gbxLista
			// 
			this.gbxLista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.gbxLista.Controls.Add(this.dgvLista);
			this.gbxLista.Location = new System.Drawing.Point(51, 69);
			this.gbxLista.Name = "gbxLista";
			this.gbxLista.Size = new System.Drawing.Size(822, 180);
			this.gbxLista.TabIndex = 18;
			this.gbxLista.TabStop = false;
			this.gbxLista.Text = "Lista de Series";
			// 
			// dgvLista
			// 
			this.dgvLista.AllowUserToAddRows = false;
			this.dgvLista.AllowUserToDeleteRows = false;
			this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLista.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvLista.Location = new System.Drawing.Point(3, 18);
			this.dgvLista.Name = "dgvLista";
			this.dgvLista.ReadOnly = true;
			this.dgvLista.RowHeadersWidth = 51;
			this.dgvLista.RowTemplate.Height = 24;
			this.dgvLista.Size = new System.Drawing.Size(816, 159);
			this.dgvLista.TabIndex = 0;
			// 
			// btnBuscar
			// 
			this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBuscar.Location = new System.Drawing.Point(771, 26);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(100, 40);
			this.btnBuscar.TabIndex = 17;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// txtParametro
			// 
			this.txtParametro.Location = new System.Drawing.Point(173, 34);
			this.txtParametro.Name = "txtParametro";
			this.txtParametro.Size = new System.Drawing.Size(584, 22);
			this.txtParametro.TabIndex = 16;
			// 
			// lblParametro
			// 
			this.lblParametro.AutoSize = true;
			this.lblParametro.Location = new System.Drawing.Point(51, 37);
			this.lblParametro.Name = "lblParametro";
			this.lblParametro.Size = new System.Drawing.Size(82, 16);
			this.lblParametro.TabIndex = 15;
			this.lblParametro.Text = "Buscar título:";
			// 
			// lblTituloPrincipal
			// 
			this.lblTituloPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.lblTituloPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTituloPrincipal.Location = new System.Drawing.Point(184, 2);
			this.lblTituloPrincipal.Name = "lblTituloPrincipal";
			this.lblTituloPrincipal.Size = new System.Drawing.Size(562, 29);
			this.lblTituloPrincipal.TabIndex = 14;
			this.lblTituloPrincipal.Text = "Series";
			this.lblTituloPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// erpTitulo
			// 
			this.erpTitulo.ContainerControl = this;
			// 
			// erpSinopsis
			// 
			this.erpSinopsis.ContainerControl = this;
			// 
			// erpDirector
			// 
			this.erpDirector.ContainerControl = this;
			// 
			// erpEpisodios
			// 
			this.erpEpisodios.ContainerControl = this;
			// 
			// erpFechaEstreno
			// 
			this.erpFechaEstreno.ContainerControl = this;
			// 
			// erpCategoria
			// 
			this.erpCategoria.ContainerControl = this;
			// 
			// FrmSerie
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(925, 587);
			this.Controls.Add(this.gbxDatos);
			this.Controls.Add(this.pnlAcciones);
			this.Controls.Add(this.gbxLista);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.txtParametro);
			this.Controls.Add(this.lblParametro);
			this.Controls.Add(this.lblTituloPrincipal);
			this.Name = "FrmSerie";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.FrmSerie_Load_1);
			this.gbxDatos.ResumeLayout(false);
			this.gbxDatos.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudEpisodios)).EndInit();
			this.pnlAcciones.ResumeLayout(false);
			this.gbxLista.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpTitulo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpSinopsis)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpDirector)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpEpisodios)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpFechaEstreno)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpCategoria)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox gbxDatos;
		private System.Windows.Forms.ComboBox cbbCategoria;
		private System.Windows.Forms.Label lblCategoria;
		private System.Windows.Forms.RichTextBox rtbSinopsis;
		private System.Windows.Forms.DateTimePicker dtpFechaEstreno;
		private System.Windows.Forms.TextBox txtDirector;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.NumericUpDown nudEpisodios;
		private System.Windows.Forms.Label lblFechaEstreno;
		private System.Windows.Forms.Label lblEpisodios;
		private System.Windows.Forms.TextBox txtTitulo;
		private System.Windows.Forms.Label lblDirector;
		private System.Windows.Forms.Label lblSinopsis;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Panel pnlAcciones;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.GroupBox gbxLista;
		private System.Windows.Forms.DataGridView dgvLista;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.TextBox txtParametro;
		private System.Windows.Forms.Label lblParametro;
		private System.Windows.Forms.Label lblTituloPrincipal;
		private System.Windows.Forms.ErrorProvider erpTitulo;
		private System.Windows.Forms.ErrorProvider erpSinopsis;
		private System.Windows.Forms.ErrorProvider erpDirector;
		private System.Windows.Forms.ErrorProvider erpEpisodios;
		private System.Windows.Forms.ErrorProvider erpFechaEstreno;
		private System.Windows.Forms.ErrorProvider erpCategoria;
	}
}


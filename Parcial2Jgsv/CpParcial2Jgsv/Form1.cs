
using CadParcial2Jgsv;
using ClnParcial2Jgsv;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpParcial2Jgsv
{
	public partial class FrmSerie : Form
	{
		private bool esNuevo = false;
		public FrmSerie()
		{
			InitializeComponent();
		}

		private void FrmSerie_Load(object sender, EventArgs e)
		{
			Size = new Size(860, 351);
			listar();
		}

		private void listar()
		{
			var lista = SerieCln.listarPa(txtParametro.Text.Trim());
			dgvLista.DataSource = lista;
			dgvLista.Columns["id"].Visible = false;
			dgvLista.Columns["estado"].Visible = false;
			dgvLista.Columns["titulo"].HeaderText = "Título";
			dgvLista.Columns["sinopsis"].HeaderText = "Sinopsis";
			dgvLista.Columns["director"].HeaderText = "Director";
			dgvLista.Columns["episodios"].HeaderText = "Episodios";
			dgvLista.Columns["fechaEstreno"].HeaderText = "Fecha Estreno";
			dgvLista.Columns["categoria"].HeaderText = "Categoría";
			btnEditar.Enabled = lista.Count > 0;
			btnEliminar.Enabled = lista.Count > 0;
			if (lista.Count > 0) dgvLista.Rows[0].Cells["titulo"].Selected = true;
		}

		private void btnNuevo_Click(object sender, EventArgs e)
		{
			esNuevo = true;
			Size = new Size(860, 650);
			txtTitulo.Focus();
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			esNuevo = false;
			Size = new Size(860, 650);

			int index = dgvLista.CurrentCell.RowIndex;
			int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
			var serie = SerieCln.obtenerUno(id);
			txtTitulo.Text = serie.titulo;
			rtbSinopsis.Text = serie.sinopsis;
			txtDirector.Text = serie.director;
			nudEpisodios.Value = serie.episodios;
			dtpFechaEstreno.Value = serie.fechaEstreno;
			cbbCategoria.Text = serie.categoria;
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			Size = new Size(860, 351);
			limpiar();
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			listar();
		}

		private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter) listar();
		}

		private bool validar()
		{
			bool esValido = true;
			erpTitulo.SetError(txtTitulo, "");
			erpSinopsis.SetError(rtbSinopsis, "");
			erpDirector.SetError(txtDirector, "");
			erpEpisodios.SetError(nudEpisodios, "");
			erpFechaEstreno.SetError(dtpFechaEstreno, "");
			erpCategoria.SetError(cbbCategoria, "");

			if (string.IsNullOrEmpty(txtTitulo.Text))
			{
				esValido = false;
				erpTitulo.SetError(txtTitulo, "El campo Título es obligatorio");
			}
			if (string.IsNullOrEmpty(rtbSinopsis.Text))
			{
				esValido = false;
				erpSinopsis.SetError(rtbSinopsis, "El campo Sinopsis es obligatorio");
			}
			if (string.IsNullOrEmpty(txtDirector.Text))
			{
				esValido = false;
				erpDirector.SetError(txtDirector, "El campo Director es obligatorio");
			}
			if (string.IsNullOrEmpty(nudEpisodios.Text))
			{
				esValido = false;
				erpEpisodios.SetError(nudEpisodios, "El campo Episodios es obligatorio");
			}
			if (nudEpisodios.Value <= 0)
			{
				esValido = false;
				erpEpisodios.SetError(nudEpisodios, "El campo Episodios debe ser mayor a Cero");
			}
			if (string.IsNullOrEmpty(dtpFechaEstreno.Text))
			{
				esValido = false;
				erpFechaEstreno.SetError(dtpFechaEstreno, "El campo Fecha de Estreno es obligatorio");
			}
			if (string.IsNullOrEmpty(cbbCategoria.Text))
			{
				esValido = false;
				erpCategoria.SetError(cbbCategoria, "El campo Categoría de Estreno es obligatorio");
			}
			return esValido;
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			if (validar())
			{
				var serie = new Serie();
				serie.titulo = txtTitulo.Text.Trim();
				serie.sinopsis = rtbSinopsis.Text.Trim();
				serie.director = txtDirector.Text.Trim();
				serie.episodios = (int)nudEpisodios.Value;
				serie.fechaEstreno = dtpFechaEstreno.Value;
				serie.categoria = cbbCategoria.Text;

				if (esNuevo)
				{
					serie.estado = 1;
					SerieCln.insertar(serie);
				}
				else
				{
					int index = dgvLista.CurrentCell.RowIndex;
					serie.id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
					SerieCln.actualizar(serie);
				}
				listar();
				btnCancelar.PerformClick();
				MessageBox.Show("Serie guardada correctamente", "::: Parcial2 - Mensaje :::",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void limpiar()
		{
			txtTitulo.Text = string.Empty;
			rtbSinopsis.Text = string.Empty;
			txtDirector.Text = string.Empty;
			nudEpisodios.Value = 0;
			dtpFechaEstreno.Value = dtpFechaEstreno.MinDate;
			cbbCategoria.SelectedIndex = -1;
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			int index = dgvLista.CurrentCell.RowIndex;
			int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
			string titulo = dgvLista.Rows[index].Cells["titulo"].Value.ToString();
			DialogResult dialog = MessageBox.Show($"¿Está seguro que desea dar de baja la serie con título {titulo}?",
				"::: Parcial2 - Mensaje :::", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (dialog == DialogResult.OK)
			{
				SerieCln.eliminar(id);
				listar();
				MessageBox.Show("Serie dado de baja correctamente", "::: Parcial2 - Mensaje :::",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void pnlAcciones_Paint(object sender, PaintEventArgs e)
		{

		}

		private void gbxLista_Enter(object sender, EventArgs e)
		{

		}

		private void gbxDatos_Enter(object sender, EventArgs e)
		{

		}

		private void txtParametro_TextChanged(object sender, EventArgs e)
		{

		}

		private void lblParametro_Click(object sender, EventArgs e)
		{

		}

		private void lblTituloPrincipal_Click(object sender, EventArgs e)
		{

		}

		private void FrmSerie_Load_1(object sender, EventArgs e)
		{

		}
	}
}

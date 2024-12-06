using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Dominio;
using MetroFramework.Forms;

namespace TPFinalNivel2_Apellido
{
    public partial class Form1 : MetroForm
    {
        private List<Articulos> listaArticulos; // Guardo aca mis datos
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(31, 30, 68);
            cargar();
            comboBoxcampo.Items.Add("Nombre");
            comboBoxcampo.Items.Add("Precio");
            comboBoxcampo.Items.Add("Descripcion");

        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {

                listaArticulos = negocio.listar();
                dgv.DataSource = listaArticulos;
                dgv.Columns["Precio"].DefaultCellStyle.Format = "N0";
                // No mostrar la celda "Imagen" en el DataView
                ocultarColumnas();
                

                pictureboxarticulos.Load(listaArticulos[0].Imagen);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ocultarColumnas()
        {
            dgv.Columns["Imagen"].Visible = false;
            dgv.Columns["Id"].Visible = false;
        }


        // Cuando cambia la seleccion de la grilla cambia la imagen
        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if(dgv.CurrentRow != null)
            {
                Articulos seleccionado = (Articulos)dgv.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.Imagen);
            }

        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pictureboxarticulos.Load(imagen);
            }
            catch (Exception ex)
            {

                pictureboxarticulos.Load("https://miro.medium.com/max/978/1*pUEZd8z__1p-7ICIO1NZFA.png");
            }
        }




        private bool validarFiltro()
        {
            if(comboBoxcampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el campo para filtrar.");
                return true;
            }

            if(comboBoxcriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el criterio para filtrar.");
                return true;
            }
            if(comboBoxcampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(textBoxfiltroavanzado.Text))
                {
                    MessageBox.Show("Debes cargar el filtro para numericos..");
                    return true;
                }
                if (!(soloNumeros(txtfiltro.Text))) ;
                {
                    MessageBox.Show("Solo numeros para filtrar");
                    return true;
                }
            }
            return false;
               
        }

        private bool soloNumeros(string cadena)
        {
            foreach(char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        private void buttonbuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (validarFiltro())
                    return;
                string campo = comboBoxcampo.SelectedItem.ToString();
                string criterio = comboBoxcriterio.SelectedItem.ToString();
                string filtro = textBoxfiltroavanzado.Text;
                dgv.DataSource = negocio.filtrar(campo, criterio, filtro);  


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }


        private void txtfiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulos> listaFiltro;

            string filtro = txtfiltro.Text;

            if (filtro.Length >= 3)
            {
                listaFiltro = listaArticulos.FindAll(x => x.Nombre.ToLower().Contains(filtro.ToLower()) || x.Nombre.ToLower().Contains(filtro.ToLower()));
            }
            else
            {
                listaFiltro = listaArticulos;
            }

            dgv.DataSource = null;
            dgv.DataSource = listaFiltro;
            ocultarColumnas();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            // Instancia formulario de alta
            frmanuevoarticulo alta = new frmanuevoarticulo();
            alta.ShowDialog();
            cargar();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            // Instancia formulario de alta modificar
            Articulos seleccionado;
            seleccionado = (Articulos)dgv.CurrentRow.DataBoundItem;


            frmanuevoarticulo modificar = new frmanuevoarticulo(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulos seleccionado;
            try
            {
                DialogResult resultado = MessageBox.Show("De verdad queres eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    seleccionado = (Articulos)dgv.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    cargar();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBoxcampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = comboBoxcampo.SelectedItem.ToString();
            if(opcion == "Precio")
            {
                comboBoxcriterio.Items.Clear();
                comboBoxcriterio.Items.Add("Mayor a");
                comboBoxcriterio.Items.Add("Menor a");
                comboBoxcriterio.Items.Add("Igual a");
            }
            else
            {
                comboBoxcriterio.Items.Clear();
                comboBoxcriterio.Items.Add("Comienza con");
                comboBoxcriterio.Items.Add("Termina con");
                comboBoxcriterio.Items.Add("Contiene");
            }
        }
    }
}

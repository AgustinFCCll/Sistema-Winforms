using System;
using System.Windows.Forms;
using Dominio;
using MetroFramework.Forms;
using Negocio;

namespace TPFinalNivel2_Apellido
{
    public partial class frmanuevoarticulo : MetroForm
    {
        private Articulos articulo = null;

        public frmanuevoarticulo()
        {
            InitializeComponent();
        }

        public frmanuevoarticulo(Articulos articulos)
        {
            InitializeComponent();
            this.articulo = articulos;
            Text = "";
;        }



        // Cargar desplegables
        private void frmanuevoarticulo_Load(object sender, EventArgs e)
        {
            marcaNegocio marcaNegocio = new marcaNegocio();
            categoriaNegocio categoriaNegocio = new categoriaNegocio();
            try
            {
                comboboxmarca.DataSource = marcaNegocio.listar();
                comboboxmarca.ValueMember = "id";
                comboboxmarca.DisplayMember = "Decripcion";

                comboboxcategoria.DataSource = categoriaNegocio.listar();
                comboboxcategoria.ValueMember = "Id";
                comboboxcategoria.DisplayMember = "Descripcion";


                // Validacion
                if(articulo != null)
                {
                    txtnombre.Text = articulo.Nombre;
                    txtdescripcion.Text = articulo.Descripcion;

                    txtcodigoarticulo.Text = articulo.codigoArticulo;
                    txtimagen.Text = articulo.Imagen;

                    txtprecio.Text = articulo.precio.ToString();
                    cargarImagen(articulo.Imagen);

                    comboboxmarca.SelectedValue = articulo.Marca.id;
                    comboboxcategoria.SelectedValue = articulo.Categoria.Id;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtimagen_Leave(object sender, EventArgs e)
        {
            // Cargar la imagen
            cargarImagen(txtimagen.Text);
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pictureBoxarticulos.Load(imagen);
            }
            catch (Exception ex)
            {

                pictureBoxarticulos.Load("https://miro.medium.com/max/978/1*pUEZd8z__1p-7ICIO1NZFA.png");
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            // Capturar datos y transformarlo en objeto tipo articulo
            // Articulos articulo = new Articulos();   
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (articulo == null)
                    articulo = new Articulos();

                articulo.Nombre = txtnombre.Text;
                articulo.precio = decimal.Parse(txtprecio.Text);
                articulo.Imagen = txtimagen.Text;
                articulo.Descripcion = txtdescripcion.Text;
                articulo.codigoArticulo = txtcodigoarticulo.Text;

                // Seleccion de elementos
                articulo.Marca = (Marca)comboboxmarca.SelectedItem;
                articulo.Categoria = (Categoria)comboboxcategoria.SelectedItem;


                if (articulo.Id != 0)
                {
                    // enviarlo a BD
                    negocio.modificar(articulo);
                    MessageBox.Show("Modificado exitosamente");

                }
                else
                {

                    negocio.agregar(articulo);
                    MessageBox.Show("Agregado exitosamente");
                }

                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

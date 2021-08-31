using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica_2_EjerProp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitArtefactos();
            }
        }

        protected void InitArtefactos()
        {
            Artefactos.Items.Add("Seleccionar");
            Artefactos.Items.Add("Televisor");
            Artefactos.Items.Add("Refrigerador");
            Artefactos.Items.Add("Microondas");
            Artefactos.Items.Add("Licuadora");
            Artefactos.Items.Add("Tostadora");
            Artefactos.Items.Add("Cafetera");
            Artefactos.Items.Add("Lavadora");
        }

        protected void SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Artefactos.Items[0].Selected == true)
            {
                Codigo.Enabled = false;
                Codigo.Text = "";
                Nombre.Enabled = false;
                Nombre.Text = "";
                Descripcion.Enabled = false;
                Descripcion.Text = "";
                Marca.Enabled = false;
                Marca.Text = "";
                Image1.ImageUrl = "";
            }
            if (Artefactos.Items[1].Selected == true)
            {
                Codigo.Enabled = false;
                Codigo.Text = "23021";
                Nombre.Enabled = false;
                Nombre.Text = "Televisor";
                Descripcion.Enabled = false;
                Descripcion.Text = "Smart tv 60' OLED";
                Marca.Enabled = false;
                Marca.Text = "LG";
                Image1.Height = 350;
                Image1.Width = 530;
                Image1.ImageUrl = "~/Resources/des_1_n.jpg";
            }
            if (Artefactos.Items[2].Selected == true)
            {
                Codigo.Enabled = false;
                Codigo.Text = "23022";
                Nombre.Enabled = false;
                Nombre.Text = "Refrigerador";
                Descripcion.Enabled = false;
                Descripcion.Text = "Refrigerador con dispensador";
                Marca.Enabled = false;
                Marca.Text = "Samsung";
                Image1.Height = 300;
                Image1.Width = 300;
                Image1.ImageUrl = "~/Resources/16754100_1.jpg";
            }
            if (Artefactos.Items[3].Selected == true)
            {
                Codigo.Enabled = false;
                Codigo.Text = "23023";
                Nombre.Enabled = false;
                Nombre.Text = "Microondas";
                Descripcion.Enabled = false;
                Descripcion.Text = "Microondas con dorador EasyClean";
                Marca.Enabled = false;
                Marca.Text = "LG";
                Image1.Height = 350;
                Image1.Width = 370;
                Image1.ImageUrl = "~/Resources/15768826_1.jpg";
            }
            if (Artefactos.Items[4].Selected == true)
            {
                Codigo.Enabled = false;
                Codigo.Text = "23024";
                Nombre.Enabled = false;
                Nombre.Text = "Licuadora";
                Descripcion.Enabled = false;
                Descripcion.Text = "Licuadora 550W 2 velocidades";
                Marca.Enabled = false;
                Marca.Text = "Oster";
                Image1.Height = 300;
                Image1.Width = 300;
                Image1.ImageUrl = "~/Resources/ac0cdf781827ac14cae9cdb4b80f97f8-product.jpg";
            }
            if (Artefactos.Items[5].Selected == true)
            {
                Codigo.Enabled = false;
                Codigo.Text = "23025";
                Nombre.Enabled = false;
                Nombre.Text = "Tostadora";
                Descripcion.Enabled = false;
                Descripcion.Text = "Tostadora 750W Holstein";
                Marca.Enabled = false;
                Marca.Text = "Holstein";
                Image1.Height = 300;
                Image1.Width = 300;
                Image1.ImageUrl = "~/Resources/tostadora-holstein-2-rebanadas-roja-1.jpg";
            }
            if (Artefactos.Items[6].Selected == true)
            {
                Codigo.Enabled = false;
                Codigo.Text = "23026";
                Nombre.Enabled = false;
                Nombre.Text = "Cafetera";
                Descripcion.Enabled = false;
                Descripcion.Text = "Cafetera Oster PrimaLatte";
                Marca.Enabled = false;
                Marca.Text = "Oster";
                Image1.Height = 300;
                Image1.Width = 370;
                Image1.ImageUrl = "~/Resources/2019148956993_2.jpg";
            }
            if (Artefactos.Items[7].Selected == true)
            {
                Codigo.Enabled = false;
                Codigo.Text = "23027";
                Nombre.Enabled = false;
                Nombre.Text = "Lavadora";
                Descripcion.Enabled = false;
                Descripcion.Text = "Lavadora LG Miniwash con secadora";
                Marca.Enabled = false;
                Marca.Text = "LG";
                Image1.Height = 350;
                Image1.Width = 300;
                Image1.ImageUrl = "~/Resources/14933874_1.jpg";
            }
        }
    }
}
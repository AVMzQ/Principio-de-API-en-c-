using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Runtime.Remoting;
using Newtonsoft.Json.Linq;
using System.Security.Policy;
using System.Dynamic;
using System.Text.RegularExpressions;

namespace Consumo_de_API
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool ValidacionData(TableLayoutPanel tlp)
        {
            bool status = true;
            foreach (Control control in tlp.Controls)
            {
                if (control.GetType() == typeof(TextBox)){
                    if(control.Text.TrimEnd().Length == 0)
                    {
                        errorProvider1.SetError(control, "Ingresa los datos adecuadamente!");
                        status = false; 
                    }
                }
            }
            return status;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ConsumoAPI_Publica api = new ConsumoAPI_Publica("https://jsonplaceholder.typicode.com/posts/1");
                dynamic res = api.GetDefaultData();
                txtRespuestaGet.Text = res.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidacionData(tlpPost))
                {
                    ConsumoAPI_Publica api = new ConsumoAPI_Publica("https://jsonplaceholder.typicode.com/posts");
                    dynamic res = api.PostDataAPI(txtTitulo.Text, txtDescripcion.Text, txtId.Text);
                    txtRespuestaPost.Text = res.ToString();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void clear(TableLayoutPanel tlp)
        {
            foreach(Control control in tlp.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    control.Text = "";
                }
            }
        }
        private void tbControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tbControl.SelectedIndex)
            {
                case 1:
                    clear(tlpPost);
                    txtRespuestaPost.Text = "{}";
                    txtId.Text = new Random().Next(1, 9999).ToString();
                    break;
                case 2:
                    try
                    {
                        clear(tlpPut);
                        txtResPut.Text = "{}";

                        using (HttpClient cliente = new HttpClient())//Crea el cliente
                        {
                            var Get = cliente.GetAsync("https://jsonplaceholder.typicode.com/posts/1").Result;//Utilizando un Get optiene la info de la apli.
                            var resGet = Get.Content.ReadAsStringAsync().Result;//lee el contenido solicitado y lo almacena.

                            data dt = JsonConvert.DeserializeObject<data>(resGet);
                            txtIdPut.Text = dt.userId;
                            txtTituloPut.Text = dt.title;
                            txtDesPut.Text = dt.body;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidacionData(tlpPut))
                {
                    ConsumoAPI_Publica api = new ConsumoAPI_Publica("https://jsonplaceholder.typicode.com/posts/1");
                    dynamic res = api.PutDataAPI(txtTituloPut.Text, txtDesPut.Text, txtIdPut.Text);
                    txtResPut.Text = res.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

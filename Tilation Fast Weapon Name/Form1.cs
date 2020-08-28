using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Tilation_Fast_Weapon_Name
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            richTextBoxApellidos.Text = Buscador.Apellidos;
            richTextBoxNombres.Text = Buscador.Nombres;
        }

        void Filtrar()
        {
            string pista = textBoxPistas.Text;
            string pistaNombre = "";
            string pistaApellido = "";

            if (pista.Contains(' '))
            {
                string[] partes = pista.Split(' ');
                pistaNombre = partes[0];
                pistaApellido = partes[1];
                listBoxApellidos.Items.Clear();
                listBoxApellidos.Items.AddRange(Buscador.BuscarApellidos(pistaApellido).ToArray());
            }
            else
            {
                pistaNombre = pista;
            }

            listBoxNombres.Items.Clear();
            listBoxNombres.Items.AddRange(Buscador.BuscarNombres(pistaNombre).ToArray());
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Filtrar();
        }
    }
}

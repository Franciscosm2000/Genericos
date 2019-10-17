using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Genericos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int tamano = listBox1.Items.Count;

            ClaseObjeto clase = new ClaseObjeto(tamano);

            foreach (Object ob in listBox1.Items)
            {
                clase.Add(ob);
            }

            for (int i=0; i<tamano; i++)
            {
                String dat = (String)clase.getElemento(i);
                listBox2.Items.Add(dat);
            }

        }
    }
}

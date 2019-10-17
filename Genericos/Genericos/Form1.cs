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

        //Metodo para agregar a la lista
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text +","+ textBox2.Text);
        }

        //este metodo agrega los datos a la clase Objeto y tambien imprime el objeto
        private void button2_Click(object sender, EventArgs e)
        {
            int tamano = listBox1.Items.Count;

            /*
            ClaseObjeto clase = new ClaseObjeto(tamano);

            foreach (Object ob in listBox1.Items)
            {
                String text = (String) ob;

                String[] pal = text.Split(','); 

                clase.Add(new Empleado(pal[0],double.Parse(pal[1])));
            }

            for (int i=0; i<tamano; i++)
            {
                Empleado dat = (Empleado) clase.getElemento(i);
                String nom = dat.getNombre();
                double sal = dat.getSalario();
                listBox2.Items.Add(nom+","+sal);
            }
            */

            Clase_Generica<Empleado> clase = new Clase_Generica<Empleado>(tamano);

            foreach (Object ob in listBox1.Items)
            {
                String text = (String)ob;

                String[] pal = text.Split(',');

                clase.Add(new Empleado(pal[0], double.Parse(pal[1])));
            }

            for (int i = 0; i < tamano; i++)
            {
                Empleado dat = clase.getElemento(i);
                String nom = dat.getNombre();
                double sal = dat.getSalario();
                listBox2.Items.Add(nom + "," + sal);
            }

        }
    }
}

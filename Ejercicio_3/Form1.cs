using Ejercicio_3.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ejercicio_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Persona> personas = new List<Persona>();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormDatos vtn = new FormDatos();

            bool cerrar = false;
            vtn.ShowDialog();
            while (vtn.DialogResult == DialogResult.OK && cerrar == false)
            {
                string nombre = vtn.textBox1.Text;
               

                Persona p = null;
                if (vtn.radioButton1.Checked)
                {
                    p = new Persona(nombre);
                   
                }
                else if(vtn.radioButton2.Checked)
                {
                    string cuit = vtn.textBox2.Text;
                    p = new PersonaJuridica(nombre,cuit);
                }
                if (p !=null)
                {
                    personas.Add(p);
                    cerrar = true;
                }
                else
                {
                    MessageBox.Show("Debe elegir el tipo.");
                    vtn.ShowDialog();
                }
              
            }

            Actualizar();

        }

        protected void Actualizar()
        {

            listBox1.Items.Clear();
            foreach (Persona p in personas)
            {
                listBox1.Items.Add(p.Describir());
            }
           

        }
    }
}



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
                string cuit = vtn.textBox2.Text;

                Persona p = null;

                try
                {
                    if (vtn.radioButton1.Checked)
                    {
                        p = new Persona(nombre);

                    }
                    else if (vtn.radioButton2.Checked)
                    {

                        p = new PersonaJuridica(nombre, cuit);
                    }
                    if (p != null)
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
                catch (FormatoNombreNoValidoException ex)
                {

                    vtn.lbMensajeNombre.Visible = true;
                    vtn.lbMensajeNombre.Text = ex.Message;
                }
                catch (FormatoCuitNoValidoExeption ex)
                {
                    vtn.lbMensajeCUIT.Visible = true;
                    vtn.lbMensajeCUIT.Text = ex.Message;
                }

                if (cerrar)
                    vtn.ShowDialog();
            }

        }

        protected void Actualizar()
        {
            personas.Sort();
            listBox1.Items.Clear();
            foreach (Persona p in personas)
            {
                listBox1.Items.Add(p.Describir());
            }
           

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Persona persona = listBox1.SelectedItem as Persona;
            if (persona != null)
            {
                personas.Remove(persona);
                Actualizar();
            }
        }
    }
}



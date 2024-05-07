using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CajeroATM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Método para limpiar los campos de cuenta y NIP
        private void button12_Click(object sender, EventArgs e)
        {
            tbCta.Clear();
            tbNip.Clear();
        }
        // Método para cancelar la operación y cerrar el formulario
        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operación cancelada", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        // Evento de carga del formulario, se usa en este caso para hacer uso del reloj
        private void Form1_Load(object sender, EventArgs e)
        {
            // Iniciar el temporizador para mostrar la fecha y hora
            timer1.Start();
        }
         
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        // Evento que se ejecuta cada vez que se hace clic en el botón 2
        private void button5_Click(object sender, EventArgs e)
        {
            if (tbCta.Text.Length < 8)// Si el campo de cuenta no ha alcanzado su longitud máxima
            {
                tbCta.Text = tbCta.Text + "2";
                if (tbNip.Text.Length < 4) // Si el campo NIP no ha alcanzado su longitud máxima, se limpia
                {
                    tbNip.Text = "";
                }
            }
            else if (tbNip.Text.Length < 4)// Si el campo de cuenta ha alcanzado su longitud máxima pero el NIP no
            {
                tbNip.Text += "2";
            }
        }
        //ESTE EVENTO SE REALIZA DE MANERA SIMILAR AL RESTO DE NUMEROS

        private void tbCta_TextChanged(object sender, EventArgs e)
        {
            //Restringe la entrada de datos por teclado
            tbCta.ReadOnly = true;
            //tbCta.MaxLength = 8;
        }

        private void tbNip_TextChanged(object sender, EventArgs e)
        {
            //Restringe la entrada de datos por teclado
            tbNip.ReadOnly = true;
            //tbNip.MaxLength = 4;
        }

        //Boton 0
        private void button_0_Click(object sender, EventArgs e)
        {
            if (tbCta.Text.Length < 8)
            {
                tbCta.Text = tbCta.Text + "0";
                if (tbNip.Text.Length < 4)
                {
                    tbNip.Text = "";
                }
            }
            else if (tbNip.Text.Length < 4)
            {
                tbNip.Text += "0";
            }
        }
        //Boton 1
        private void button_1_Click(object sender, EventArgs e)
        {
            if (tbCta.Text.Length < 8)
            {
                tbCta.Text = tbCta.Text + "1";
                if(tbNip.Text.Length < 4)
                {
                    tbNip.Text = "";
                }
            }
            else if(tbNip.Text.Length < 4)
            {
                tbNip.Text += "1";
            }
        }
        //Boton 3
        private void button_3_Click(object sender, EventArgs e)
        {
            if (tbCta.Text.Length < 8)
            {
                tbCta.Text = tbCta.Text + "3";
                if (tbNip.Text.Length < 4)
                {
                    tbNip.Text = "";
                }
            }
            else if (tbNip.Text.Length < 4)
            {
                tbNip.Text += "3";
            }
        }
        //Boton 4
        private void button_4_Click(object sender, EventArgs e)
        {
            if (tbCta.Text.Length < 8)
            {
                tbCta.Text = tbCta.Text + "4";
                if (tbNip.Text.Length < 4)
                {
                    tbNip.Text = "";
                }
            }
            else if (tbNip.Text.Length < 4)
            {
                tbNip.Text += "4";
            }
        }
        //Boton 5
        private void button_5_Click(object sender, EventArgs e)
        {
            if (tbCta.Text.Length < 8)
            {
                tbCta.Text = tbCta.Text + "5";
                if (tbNip.Text.Length < 4)
                {
                    tbNip.Text = "";
                }
            }
            else if (tbNip.Text.Length < 4)
            {
                tbNip.Text += "5";
            }
        }
        //Boton 6
        private void button_6_Click(object sender, EventArgs e)
        {
            if (tbCta.Text.Length < 8)
            {
                tbCta.Text = tbCta.Text + "6";
                if (tbNip.Text.Length < 4)
                {
                    tbNip.Text = "";
                }
            }
            else if (tbNip.Text.Length < 4)
            {
                tbNip.Text += "6";
            }
        }
        //Boton 7
        private void button_7_Click(object sender, EventArgs e)
        {
            if (tbCta.Text.Length < 8)
            {
                tbCta.Text = tbCta.Text + "7";
                if (tbNip.Text.Length < 4)
                {
                    tbNip.Text = "";
                }
            }
            else if (tbNip.Text.Length < 4)
            {
                tbNip.Text += "7";
            }
        }
        //Boton 8
        private void button_8_Click(object sender, EventArgs e)
        {
            if (tbCta.Text.Length < 8)
            {
                tbCta.Text = tbCta.Text + "8";
                if (tbNip.Text.Length < 4)
                {
                    tbNip.Text = "";
                }
            }
            else if (tbNip.Text.Length < 4)
            {
                tbNip.Text += "8";
            }
        }
        //Boton 9
        private void button_9_Click(object sender, EventArgs e)
        {
            if (tbCta.Text.Length < 8)
            {
                tbCta.Text = tbCta.Text + "9";
                if (tbNip.Text.Length < 4)
                {
                    tbNip.Text = "";
                }
            }
            else if (tbNip.Text.Length < 4)
            {
                tbNip.Text += "9";
            }
        }
        // Evento para borrar el último dígito ingresado en los campos de cuenta y NIP
        private void borrar_Click(object sender, EventArgs e)
        {
            if (tbNip.Text.Length == 0)// Si no hay dígitos en el campo de NIP, se borra un dígito del campo de cuenta
            {
                tbNip.Text = "";
                if (tbCta.Text.Length == 0)// Si no hay dígitos en el campo de cuenta, no se hace nada
                {
                    tbCta.Text = "";
                }
                else
                {
                    tbCta.Text = tbCta.Text.Substring(0, tbCta.Text.Length - 1);// Si hay dígitos en el campo de cuenta, se borra el último dígito
                }
            }
            else
            {
                tbNip.Text = tbNip.Text.Substring(0, tbNip.Text.Length - 1);
            } 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void enter_Click(object sender, EventArgs e)
        {

        }

        private void Date_Click(object sender, EventArgs e)
        {

        }
        // Evento que se ejecuta cada vez que el temporizador avanza
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Actualizar los campos de fecha y hora con la fecha y hora actual con formatos
            Date.Text = DateTime.Now.ToString("hh:mm:ss");
            date2.Text = DateTime.Now.ToString("dd/MMM/yy");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
    }

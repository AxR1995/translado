using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using translado;


namespace Mante_translado
{
    public partial class Form2 : Form
    {
        MySqlCommand cmd;
        MySqlCommand comando;
        string efecto;
        string estatus;
        
        public Form2()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            efecto = "Si";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            efecto = "No";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            estatus = "Inactivo";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            estatus = "Activo";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

     


              private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }
        
       
             
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                cmd = new MySqlCommand("insert into transaccionnomina(nombre,efecto,status,fecha,cuentacontabilidad_nomenclatura) values('" + txtnombre.Text + "','" + efecto + "','" + estatus + "','" + dateTimePicker1.Value.ToString("yyyy/MM/dd") + "','" + Convert.ToInt32(comboBox1.ValueMember) + "');", bdcomun.conexion());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Guardado");
            }
            catch (Exception ex){
                MessageBox.Show("Error" + ex.ToString());
            }
            }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

  

      


    }
}

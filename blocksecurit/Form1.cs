using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace blocksecurit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       SqlConnection con = new SqlConnection(@"Data source = DESKTOP-C3EBMR8; Initial Catalog = BlogSecurity; Integrated Security = True");

        public void logear (string user, string password) 
        {

            try 
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT name, Type_User FROM users WHERE user = @User AND Password = @pas", con);
                cmd.Parameters.AddWithValue("User", user);
                cmd.Parameters.AddWithValue("pas", password);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if(dt.Rows.Count == 1)
                {
                    this.Hide();
                    if (dt.Rows[0][1].ToString() == "Administrador")
                    {
                        new admin(dt.Rows[0][0].ToString()).Show();
                    }
                    else if (dt.Rows[0][1].ToString() == "Usuario") 
                    { 
                        new Usuario(dt.Rows[0][0].ToString()).Show(); 
                    }
                }
                else 
                {
                    MessageBox.Show("Usuario y/o contraseña incorrecta");
                }
            }catch(Exception e) 
            {
                MessageBox.Show(e.Message);
            }
            finally 
            {
                con.Close();
            }
        
        
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logear(this.textBox1.Text, this.textBox2.Text);
        }
    }
}

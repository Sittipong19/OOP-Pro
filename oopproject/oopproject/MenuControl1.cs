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

namespace oopproject
{
    public partial class MenuControl1 : UserControl
    {
        public MenuControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Menu b = new Menu(this.textBox1.Text, this.textBox2.Text, this.textBox3.Text);

                MySqlConnection MyConn2 = new MySqlConnection(b.getMycon());

                MySqlCommand MyCommand2 = new MySqlCommand(b.AddMenu(), MyConn2);

                MySqlDataReader MyReader2;

                MyConn2.Open();

                MyReader2 = MyCommand2.ExecuteReader();

                MessageBox.Show("Save Data");

                while (MyReader2.Read())
                {



                }

                MyConn2.Close();

            }

            catch (Exception ex)
            {



                MessageBox.Show(ex.Message);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                Menu b = new Menu(this.textBox1.Text, this.textBox2.Text, this.textBox3.Text);



                MySqlConnection MyConn2 = new MySqlConnection(b.getMycon());

                MySqlCommand MyCommand2 = new MySqlCommand(b.DeMenu(), MyConn2);

                MySqlDataReader MyReader2;

                MyConn2.Open();

                MyReader2 = MyCommand2.ExecuteReader();

                MessageBox.Show("Data Deleted");

                while (MyReader2.Read())
                {



                }

                MyConn2.Close();

            }

            catch (Exception ex)
            {



                MessageBox.Show(ex.Message);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Menu a = new Menu(this.textBox1.Text, this.textBox2.Text, this.textBox3.Text);


                MySqlConnection MyConn2 = new MySqlConnection(a.getMycon());

                MySqlCommand MyCommand2 = new MySqlCommand(a.UpMenu(), MyConn2);

                MySqlDataReader MyReader2;

                MyConn2.Open();

                MyReader2 = MyCommand2.ExecuteReader();

                MessageBox.Show("Data Updated");

                while (MyReader2.Read())
                {



                }

                MyConn2.Close();//Connection closed here 

            }

            catch (Exception ex)
            {



                MessageBox.Show(ex.Message);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Menu b = new Menu();
                MySqlConnection MyConn2 = new MySqlConnection(b.getMycon());
                MySqlCommand MyCommand2 = new MySqlCommand(b.getQuery(), MyConn2);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;

                DataTable dTable = new DataTable();

                MyAdapter.Fill(dTable);

                dataGridView1.DataSource = dTable;



                // MyConn2.Close(); 

            }

            catch (Exception ex)
            {



                MessageBox.Show(ex.Message);

            }
        }
    }
}

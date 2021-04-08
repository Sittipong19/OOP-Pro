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
    public partial class BeveragesControl1 : UserControl
    {
        public BeveragesControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Beverages b = new Beverages(this.textBox1.Text, this.textBox2.Text);
                
                MySqlConnection MyConn2 = new MySqlConnection(b.getMycon());

                MySqlCommand MyCommand2 = new MySqlCommand(b.AddBeverages(), MyConn2);

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

                Beverages b = new Beverages(this.textBox1.Text, this.textBox2.Text);

                // string Query = "delete from user where a_id=" + this.textBox1.Text + ";";

                MySqlConnection MyConn2 = new MySqlConnection(b.getMycon());

                MySqlCommand MyCommand2 = new MySqlCommand(b.DeBeverages(), MyConn2);

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
                Beverages a = new Beverages(this.textBox1.Text, this.textBox2.Text);


                MySqlConnection MyConn2 = new MySqlConnection(a.getMycon());

                MySqlCommand MyCommand2 = new MySqlCommand(a.UpBeverages(), MyConn2);

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
                Beverages b = new Beverages();
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

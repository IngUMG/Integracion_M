using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;


namespace PrototipoSeguridad
{
    public partial class AsignacionaPerfiles : Form
    { string MyConnection2 = "Driver ={ MySQL ODBC 3.51 Driver }; Dsn=servidor_seguridad; UID=root; PWD = ; Database=bd_seguridad; ";

        public AsignacionaPerfiles()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dataGridView2.Columns[0].Visible = false;
            
            try
            {
               
                //Display query  
                string Query = "select * from bd_seguridad.aplicacion ;";
                OdbcConnection MyConn2 = new OdbcConnection(MyConnection2);
                OdbcCommand MyCommand2 = new OdbcCommand(Query, MyConn2);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                OdbcDataAdapter MyAdapter = new OdbcDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                                                   // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            OdbcConnection conector = new OdbcConnection("Driver ={ MySQL ODBC 3.51 Driver }; Dsn=servidor_seguridad; UID=root; PWD = ; Database=bd_seguridad; ");
            conector.Open();
           
           
            try
            {



                OdbcCommand sentencia = new OdbcCommand();
                sentencia.Connection = conector;
                sentencia.CommandText = "SELECT * from bd_seguridad.perfil";

                OdbcDataAdapter da1 = new OdbcDataAdapter(sentencia);
                DataTable dt = new DataTable();
                da1.Fill(dt);


                comboBox1.ValueMember = "nombre_perfil";
                comboBox1.DisplayMember = "nombre_perfil";
                comboBox2.ValueMember = "id_perfil";
                comboBox2.DisplayMember = "id_perfil";
                comboBox1.DataSource = dt;
                comboBox2.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("no encntrado. " + ex);
            }
            finally
            {
                conector.Close();
            }
            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[3].Visible = false;
            this.dataGridView1.Columns[4].Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

           /* int selectedIndex = comboBox1.SelectedIndex;







            string sql = "SELECT nombre_perfil from bd_seguridad.perfil where '" + selectedIndex.ToString() + "' = perfil.id_perfil; ";
            OdbcConnection conn = new OdbcConnection();
            conn = new OdbcConnection(MyConnection2);
            conn.Open();

            OdbcCommand cmd = new OdbcCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(selectedIndex.ToString()));
            OdbcDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr["nombre_perfil"].ToString();
                

            }*/
        }

        private void button4_Click(object sender, EventArgs e)
        {

            dataGridView2.Rows.Add(new string[] {
                 Convert.ToString(dataGridView1[0, dataGridView1.CurrentRow.Index].Value),
                Convert.ToString(dataGridView1[1, dataGridView1.CurrentRow.Index].Value)
            });
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int counter = 0; counter < (dataGridView1.Rows.Count)-1;
         counter++)
            {
                dataGridView2.Rows.Add(new string[] {
                     Convert.ToString(dataGridView1[0, counter].Value),
                Convert.ToString(dataGridView1[1, counter].Value)
            });
                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            AsignacionaPerfiles p1 = new AsignacionaPerfiles();
            p1.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;
            try
            {
                string Query = "delete from  bd_seguridad.detalle_perfil_aplicacion where id_perfil='" + comboBox2.SelectedValue.ToString() + "';";
                OdbcConnection MyConn2 = new OdbcConnection(MyConnection2);
                OdbcCommand MyCommand2 = new OdbcCommand(Query, MyConn2);
                OdbcDataReader MyReader2;
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

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            Frm_MantenimientoApp maplicaciones = new Frm_MantenimientoApp();
            //Principal fa = new Principal();
            //maplicaciones.MdiParent = fa;
            maplicaciones.Show();


        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex ;

            for (int counter = 0; counter < (dataGridView2.Rows.Count) - 1;
         counter++)
            {
                try
                {
                    //This is my connection string i have assigned the database file address path  

                    //This is my insert query in which i am taking input from the user through windows forms  
                    string Query = 
                    "insert into bd_seguridad.detalle_perfil_aplicacion(id_perfil,id_aplicacion) " +
                    "values('" + comboBox2.SelectedValue.ToString() + "','" + Convert.ToString(dataGridView2[0, counter].Value) + "');";
                    //This is  MySqlConnection here i have created the object and pass my connection string.  
                    OdbcConnection MyConn2 = new OdbcConnection(MyConnection2);
                    //This is command class which will handle the query and connection object.  
                    OdbcCommand MyCommand2 = new OdbcCommand(Query, MyConn2);
                    OdbcDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
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

        }
    }
}




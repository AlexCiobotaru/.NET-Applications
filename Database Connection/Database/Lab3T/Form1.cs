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

namespace Lab3T
{
    public partial class Form1 : Form
    {
        SqlConnection myCon = new SqlConnection();
        DataSet dsUniv;
        DataSet dsFac;
        SqlCommand cmd;
        SqlDataAdapter adapt;
        

        public Form1()
        {
            
            InitializeComponent();
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            myCon.Open();
            dsUniv = new DataSet();
            dsFac = new DataSet();
            SqlDataAdapter daUniv = new SqlDataAdapter("SELECT * FROM Universitati", myCon);
            daUniv.Fill(dsUniv, "Universitati");
            SqlDataAdapter daFac = new SqlDataAdapter("SELECT * FROM Facultati", myCon);
            daFac.Fill(dsFac, "Facultati");

            foreach (DataRow dr in dsUniv.Tables["Universitati"].Rows)
            {
                String name = dr.ItemArray.GetValue(1).ToString();
                listBoxUniv.Items.Add(name);
            }
            myCon.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxFac.Items.Clear();
            textBox2.Clear();

            int code = 0;
            String UnivSelected = listBoxUniv.SelectedItem.ToString();
            foreach (DataRow dr in dsUniv.Tables["Universitati"].Rows)
            {
                if (UnivSelected == dr.ItemArray.GetValue(1).ToString())
                {
                    textBox2.Text = dr.ItemArray.GetValue(2).ToString();
                    code = Convert.ToInt16(dr.ItemArray.GetValue(3));
                    textBox1.Text = code.ToString();
                }
            }
            foreach (DataRow dr in dsFac.Tables["Facultati"].Rows)
            {
                if (code == Convert.ToInt16(dr.ItemArray.GetValue(1)))
                {
                    String nameFac = dr.ItemArray.GetValue(2).ToString();
                    listBoxFac.Items.Add(nameFac);
                }
            }

        }

        private void insert_Click(object sender, EventArgs e)
        {
            myCon.Open();
            SqlCommand cmd = new SqlCommand("INSERT into Universitati(Id, NameUniv, City, Code) values('" + textBoxId.Text + "', '" 
                                             + textBoxName.Text + "', '" + textBoxCity.Text + "', '" + textBoxCode.Text + "')", myCon);

            SqlDataAdapter daUniv = new SqlDataAdapter(cmd);
            DataSet dcUniv = new DataSet();
            daUniv.Fill(dcUniv, "Universitati");
            myCon.Close();

            textBoxId.Text = "";
            textBoxName.Text = "";
            textBoxCode.Text = "";
            textBoxCity.Text = "";
        }

        private void delete_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand("DELETE FROM Universitati WHERE Code = ' " + Convert.ToInt32(textBoxCode.Text) + " ' ", myCon);
            
            myCon.Open();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.ExecuteNonQuery();
            myCon.Close();

        }

        private void update_Click(object sender, EventArgs e)
        {
            myCon.Open();
            SqlCommand cmd = new SqlCommand("Update UNIVERSITATI SET Id = '" + Convert.ToInt32(textBoxId.Text) + 
                                            "', NameUniv = '" + textBoxName.Text + "', City = '" + textBoxCity.Text + "'where Code = '" 
                                            + textBoxCode.Text + " '", myCon);

            cmd.CommandType = System.Data.CommandType.Text;
            cmd.ExecuteNonQuery();
            myCon.Close();
        }


        private void add_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sAdapter = new SqlDataAdapter("SELECT * FROM Facultati", myCon);
            myCon.Open();
            DataSet ds = new DataSet();
            sAdapter.Fill(ds, "Facultati");
            DataTable sTable = ds.Tables["Facultati"];
            myCon.Close();

            sTable.Rows.Add(Convert.ToInt32(idFac.Text), Convert.ToInt32(codeFac.Text), numeFac.Text);
            dataGridView.DataSource = ds.Tables["Facultati"];
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if(this.dataGridView.SelectedRows.Count >= 0)
            {
                dataGridView.Rows.RemoveAt(this.dataGridView.SelectedRows[0].Index);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Facultati' table. You can move, or remove it, as needed.
            this.facultatiTableAdapter.Fill(this.database1DataSet.Facultati);

        }
    }
}

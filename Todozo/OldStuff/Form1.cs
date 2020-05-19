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

namespace Todozo
{
    public partial class Form1 : Form
    {
        string connectionString = @"server=localhost;database=todozodb;uid=root;pwd=jvnT1997,;";
        private int taskID = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("TaskAddOrEdit", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_TaskID", taskID);
                mySqlCmd.Parameters.AddWithValue("_Name", txtName.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_Description", txtDescription.Text.Trim());
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show(@"Task submitted successfully!");
                Clear();
                GridFill();
            };
        }

        void GridFill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("TaskViewAll", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblTask = new DataTable();
                sqlDa.Fill(dtblTask);
                dgvTask.DataSource = dtblTask;
                dgvTask.Columns[0].Visible = false;
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
            GridFill();
        }

        void Clear()
        {
            txtName.Text = txtDescription.Text = txtSearch.Text = "";
            taskID = 0;
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
        }

        private void dgvTask_DoubleClick(object sender, EventArgs e)
        {
            if (dgvTask.CurrentRow.Index != -1)
            {
                txtName.Text = dgvTask.CurrentRow.Cells[1].Value.ToString();
                txtDescription.Text = dgvTask.CurrentRow.Cells[2].Value.ToString();
                taskID = Convert.ToInt32(dgvTask.CurrentRow.Cells[0].Value.ToString());
                btnSave.Text = "Update";
                btnDelete.Enabled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("TaskSearchByValue", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_SearchValue", txtSearch.Text);
                DataTable dtblTask = new DataTable();
                sqlDa.Fill(dtblTask);
                dgvTask.DataSource = dtblTask;
                dgvTask.Columns[0].Visible = false;
            };
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("TaskDeleteByID", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_TaskID", taskID);
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show(@"Task deleted successfully!");
                Clear();
                GridFill();
            };
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

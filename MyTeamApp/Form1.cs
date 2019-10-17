using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyTeamApp;

namespace MyTeamApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tabControl1.Selecting += new TabControlCancelEventHandler(tabControl1_Selecting);
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs args)
        {
            TabPage current = (sender as TabControl).SelectedTab;

            if (string.IsNullOrEmpty(MyExcel.DB_PATH))
            {
                MessageBox.Show(" Please provide the team excel file ..", "Error !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                args.Cancel = true;
            }
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {
            TabControl tc = sender as TabControl;
            if (tc.SelectedIndex == 1)
            {
                dataGridEmpList.DataSource = (BindingList<Votante>)MyExcel.EmpList;
                dataGridEmpList.AutoResizeColumns();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Votante emp = new Votante
            {
                Nombres = textName.Text.ToString(),
                Cedula_ID = textCedulaID.Text.ToString(),
                Apellidos = txtApellidos.Text.ToString(),
                Candidato = cbxCandidato.SelectedItem.ToString()
            };
            MyExcel.WriteToExcel(emp);
            clearAllFields();
            textName.Focus();
        }

        public void clearAllFields()
        {
            txtApellidos.Text = "";
            textName.Text = "";
            textCedulaID.Text = "";
            cbxCandidato.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        protected override void OnFormClosing(System.Windows.Forms.FormClosingEventArgs e)
        {
            if (!string.IsNullOrEmpty(MyExcel.DB_PATH))
                MyExcel.CloseExcel();
        }

        private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearchExpr.ReadOnly = false;
        }

        private void txtSearchExpr_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearchExpr.Text))
            {
                dataGridEmpList.DataSource = MyExcel.FilterEmpList(cmbSearch.Text.ToString(), txtSearchExpr.Text.ToLower());
            }
            else
            {
                dataGridEmpList.DataSource = MyExcel.EmpList;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ExcelDialog = new OpenFileDialog();
            ExcelDialog.Filter = "Excel Files (*.xlsx) | *.xlsx";
            ExcelDialog.InitialDirectory = @"D:\";
            ExcelDialog.Title = "Select your team excel";
            if (ExcelDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MyExcel.DB_PATH = ExcelDialog.FileName;
                txtFileName.Text = ExcelDialog.FileName;
                txtFileName.ReadOnly = true;
                txtFileName.Click -= btnLoad_Click;
                tabControl1.Selecting -= tabControl1_Selecting;
                btnLoad.Enabled = false;
                MyExcel.InitializeExcel();
                dataGridEmpList.DataSource = MyExcel.ReadMyExcel();
                tblLytAddMem.Visible = true;
            }
        }

    }
}

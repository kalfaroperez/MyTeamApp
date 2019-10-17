namespace MyTeamApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlFileHeader = new System.Windows.Forms.Panel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tblLytAddMem = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbxCandidato = new System.Windows.Forms.ComboBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.textCedulaID = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtSearchExpr = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridEmpList = new System.Windows.Forms.DataGridView();
            this.empConstantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlFileHeader.SuspendLayout();
            this.tblLytAddMem.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmpList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empConstantsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(604, 363);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlFileHeader);
            this.tabPage1.Controls.Add(this.tblLytAddMem);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(596, 337);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add New Member";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnlFileHeader
            // 
            this.pnlFileHeader.Controls.Add(this.btnLoad);
            this.pnlFileHeader.Controls.Add(this.txtFileName);
            this.pnlFileHeader.Controls.Add(this.label13);
            this.pnlFileHeader.Location = new System.Drawing.Point(8, 6);
            this.pnlFileHeader.Name = "pnlFileHeader";
            this.pnlFileHeader.Size = new System.Drawing.Size(512, 44);
            this.pnlFileHeader.TabIndex = 3;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(414, 9);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(229, 10);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(178, 23);
            this.txtFileName.TabIndex = 1;
            this.txtFileName.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(197, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Seleccione la lista excel : ";
            // 
            // tblLytAddMem
            // 
            this.tblLytAddMem.ColumnCount = 2;
            this.tblLytAddMem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.91954F));
            this.tblLytAddMem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.08046F));
            this.tblLytAddMem.Controls.Add(this.panel1, 0, 0);
            this.tblLytAddMem.Controls.Add(this.panel2, 1, 0);
            this.tblLytAddMem.Controls.Add(this.panel3, 1, 1);
            this.tblLytAddMem.Location = new System.Drawing.Point(6, 53);
            this.tblLytAddMem.Name = "tblLytAddMem";
            this.tblLytAddMem.RowCount = 2;
            this.tblLytAddMem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.21673F));
            this.tblLytAddMem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.78327F));
            this.tblLytAddMem.Size = new System.Drawing.Size(515, 263);
            this.tblLytAddMem.TabIndex = 2;
            this.tblLytAddMem.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 154);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Candidato";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cedula";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbxCandidato);
            this.panel2.Controls.Add(this.txtApellidos);
            this.panel2.Controls.Add(this.textCedulaID);
            this.panel2.Controls.Add(this.textName);
            this.panel2.Location = new System.Drawing.Point(187, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 154);
            this.panel2.TabIndex = 1;
            // 
            // cbxCandidato
            // 
            this.cbxCandidato.FormattingEnabled = true;
            this.cbxCandidato.Items.AddRange(new object[] {
            "Seleccione..",
            "Blacho Lascarro -> (Concejo)",
            "Jorge Redondo (Diputado) ",
            "Millo (Alcaldia)"});
            this.cbxCandidato.Location = new System.Drawing.Point(14, 110);
            this.cbxCandidato.Name = "cbxCandidato";
            this.cbxCandidato.Size = new System.Drawing.Size(261, 24);
            this.cbxCandidato.TabIndex = 3;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(14, 46);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(261, 23);
            this.txtApellidos.TabIndex = 1;
            // 
            // textCedulaID
            // 
            this.textCedulaID.Location = new System.Drawing.Point(14, 75);
            this.textCedulaID.Name = "textCedulaID";
            this.textCedulaID.Size = new System.Drawing.Size(261, 23);
            this.textCedulaID.TabIndex = 1;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(14, 19);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(261, 23);
            this.textName.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(187, 163);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(309, 97);
            this.panel3.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtSearchExpr);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.cmbSearch);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.dataGridEmpList);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(596, 337);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manage Details";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtSearchExpr
            // 
            this.txtSearchExpr.Location = new System.Drawing.Point(422, 32);
            this.txtSearchExpr.Name = "txtSearchExpr";
            this.txtSearchExpr.ReadOnly = true;
            this.txtSearchExpr.Size = new System.Drawing.Size(126, 20);
            this.txtSearchExpr.TabIndex = 4;
            this.txtSearchExpr.TextChanged += new System.EventHandler(this.txtSearchExpr_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(265, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "Search Expression : ";
            // 
            // cmbSearch
            // 
            this.cmbSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Items.AddRange(new object[] {
            "Apellidos",
            "Candidato",
            "Cedula_ID",
            "Nombres"});
            this.cmbSearch.Location = new System.Drawing.Point(122, 32);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(121, 21);
            this.cmbSearch.Sorted = true;
            this.cmbSearch.TabIndex = 2;
            this.cmbSearch.SelectedIndexChanged += new System.EventHandler(this.cmbSearch_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Search By : ";
            // 
            // dataGridEmpList
            // 
            this.dataGridEmpList.AllowUserToAddRows = false;
            this.dataGridEmpList.AllowUserToOrderColumns = true;
            this.dataGridEmpList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridEmpList.Location = new System.Drawing.Point(28, 92);
            this.dataGridEmpList.Name = "dataGridEmpList";
            this.dataGridEmpList.ReadOnly = true;
            this.dataGridEmpList.RowHeadersWidth = 50;
            this.dataGridEmpList.Size = new System.Drawing.Size(520, 210);
            this.dataGridEmpList.TabIndex = 0;
            // 
            // empConstantsBindingSource
            // 
            this.empConstantsBindingSource.DataSource = typeof(MyTeamApp.EmpConstants);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 397);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "TeamApp - Nanda";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pnlFileHeader.ResumeLayout(false);
            this.pnlFileHeader.PerformLayout();
            this.tblLytAddMem.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmpList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empConstantsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tblLytAddMem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textCedulaID;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridEmpList;
        private System.Windows.Forms.TextBox txtSearchExpr;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource empConstantsBindingSource;
        private System.Windows.Forms.Panel pnlFileHeader;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxCandidato;
        private System.Windows.Forms.TextBox txtApellidos;
    }
}


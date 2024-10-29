namespace WinFormsApp2
{
    partial class StoredProcedure
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
            txtempname = new TextBox();
            EMPLBL = new Label();
            BTNINSERT = new Button();
            txtempdoj = new TextBox();
            txtempsal = new TextBox();
            txtempid = new TextBox();
            txtEmpDesig = new TextBox();
            txtempdept = new TextBox();
            LBLEmpid = new Label();
            LBLEmpDesig = new Label();
            LBLEmpdoj = new Label();
            LBLEmpSal = new Label();
            LBLEmpDept = new Label();
            BTNUPDATE = new Button();
            BTNCLEAR = new Button();
            BTNDELETE = new Button();
            BTNFind = new Button();
            SuspendLayout();
            // 
            // txtempname
            // 
            txtempname.Location = new Point(349, 132);
            txtempname.Name = "txtempname";
            txtempname.Size = new Size(100, 23);
            txtempname.TabIndex = 0;
            // 
            // EMPLBL
            // 
            EMPLBL.AutoSize = true;
            EMPLBL.Location = new Point(234, 140);
            EMPLBL.Name = "EMPLBL";
            EMPLBL.Size = new Size(94, 15);
            EMPLBL.TabIndex = 1;
            EMPLBL.Text = "Employee Name";
            // 
            // BTNINSERT
            // 
            BTNINSERT.Location = new Point(253, 346);
            BTNINSERT.Name = "BTNINSERT";
            BTNINSERT.Size = new Size(75, 23);
            BTNINSERT.TabIndex = 2;
            BTNINSERT.Text = "INSERT";
            BTNINSERT.UseVisualStyleBackColor = true;
            BTNINSERT.Click += BTNINSERT_Click;
            // 
            // txtempdoj
            // 
            txtempdoj.Location = new Point(349, 219);
            txtempdoj.Name = "txtempdoj";
            txtempdoj.Size = new Size(100, 23);
            txtempdoj.TabIndex = 3;
            // 
            // txtempsal
            // 
            txtempsal.Location = new Point(349, 262);
            txtempsal.Name = "txtempsal";
            txtempsal.Size = new Size(100, 23);
            txtempsal.TabIndex = 4;
            // 
            // txtempid
            // 
            txtempid.Location = new Point(349, 87);
            txtempid.Name = "txtempid";
            txtempid.Size = new Size(100, 23);
            txtempid.TabIndex = 5;
            // 
            // txtEmpDesig
            // 
            txtEmpDesig.Location = new Point(349, 177);
            txtEmpDesig.Name = "txtEmpDesig";
            txtEmpDesig.Size = new Size(100, 23);
            txtEmpDesig.TabIndex = 6;
            // 
            // txtempdept
            // 
            txtempdept.Location = new Point(349, 303);
            txtempdept.Name = "txtempdept";
            txtempdept.Size = new Size(100, 23);
            txtempdept.TabIndex = 7;
            // 
            // LBLEmpid
            // 
            LBLEmpid.AutoSize = true;
            LBLEmpid.Location = new Point(234, 95);
            LBLEmpid.Name = "LBLEmpid";
            LBLEmpid.Size = new Size(41, 15);
            LBLEmpid.TabIndex = 8;
            LBLEmpid.Text = "EmpId";
            // 
            // LBLEmpDesig
            // 
            LBLEmpDesig.AutoSize = true;
            LBLEmpDesig.Location = new Point(234, 180);
            LBLEmpDesig.Name = "LBLEmpDesig";
            LBLEmpDesig.Size = new Size(97, 15);
            LBLEmpDesig.TabIndex = 9;
            LBLEmpDesig.Text = "Emp Designation";
            // 
            // LBLEmpdoj
            // 
            LBLEmpdoj.AutoSize = true;
            LBLEmpdoj.Location = new Point(234, 222);
            LBLEmpdoj.Name = "LBLEmpdoj";
            LBLEmpdoj.Size = new Size(52, 15);
            LBLEmpdoj.TabIndex = 10;
            LBLEmpdoj.Text = "EmpDOJ";
            // 
            // LBLEmpSal
            // 
            LBLEmpSal.AutoSize = true;
            LBLEmpSal.Location = new Point(234, 270);
            LBLEmpSal.Name = "LBLEmpSal";
            LBLEmpSal.Size = new Size(65, 15);
            LBLEmpSal.TabIndex = 11;
            LBLEmpSal.Text = "Emp Salary";
            // 
            // LBLEmpDept
            // 
            LBLEmpDept.AutoSize = true;
            LBLEmpDept.Location = new Point(234, 311);
            LBLEmpDept.Name = "LBLEmpDept";
            LBLEmpDept.Size = new Size(59, 15);
            LBLEmpDept.TabIndex = 12;
            LBLEmpDept.Text = "Emp Dept";
            // 
            // BTNUPDATE
            // 
            BTNUPDATE.Location = new Point(334, 346);
            BTNUPDATE.Name = "BTNUPDATE";
            BTNUPDATE.Size = new Size(75, 23);
            BTNUPDATE.TabIndex = 13;
            BTNUPDATE.Text = "UPDATE";
            BTNUPDATE.UseVisualStyleBackColor = true;
            BTNUPDATE.Click += BTNUPDATE_Click;
            // 
            // BTNCLEAR
            // 
            BTNCLEAR.Location = new Point(334, 385);
            BTNCLEAR.Name = "BTNCLEAR";
            BTNCLEAR.Size = new Size(75, 23);
            BTNCLEAR.TabIndex = 14;
            BTNCLEAR.Text = "CLEAR";
            BTNCLEAR.UseVisualStyleBackColor = true;
            BTNCLEAR.Click += BTNCLEAR_Click;
            // 
            // BTNDELETE
            // 
            BTNDELETE.Location = new Point(253, 385);
            BTNDELETE.Name = "BTNDELETE";
            BTNDELETE.Size = new Size(75, 23);
            BTNDELETE.TabIndex = 15;
            BTNDELETE.Text = "DELETE";
            BTNDELETE.UseVisualStyleBackColor = true;
            BTNDELETE.Click += BTNDELETE_Click;
            // 
            // BTNFind
            // 
            BTNFind.Location = new Point(322, 422);
            BTNFind.Name = "BTNFind";
            BTNFind.Size = new Size(75, 23);
            BTNFind.TabIndex = 16;
            BTNFind.Text = "Find";
            BTNFind.UseVisualStyleBackColor = true;
            BTNFind.Click += BTNFind_Click;
            // 
            // StoredProcedure
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BTNFind);
            Controls.Add(BTNDELETE);
            Controls.Add(BTNCLEAR);
            Controls.Add(BTNUPDATE);
            Controls.Add(LBLEmpDept);
            Controls.Add(LBLEmpSal);
            Controls.Add(LBLEmpdoj);
            Controls.Add(LBLEmpDesig);
            Controls.Add(LBLEmpid);
            Controls.Add(txtempdept);
            Controls.Add(txtEmpDesig);
            Controls.Add(txtempid);
            Controls.Add(txtempsal);
            Controls.Add(txtempdoj);
            Controls.Add(BTNINSERT);
            Controls.Add(EMPLBL);
            Controls.Add(txtempname);
            Name = "StoredProcedure";
            Text = "StoredProcedure";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtempname;
        private Label EMPLBL;
        private Button BTNINSERT;
        private TextBox txtempdoj;
        private TextBox txtempsal;
        private TextBox txtempid;
        private TextBox txtEmpDesig;
        private TextBox txtempdept;
        private Label LBLEmpid;
        private Label LBLEmpDesig;
        private Label LBLEmpdoj;
        private Label LBLEmpSal;
        private Label LBLEmpDept;
        private Button BTNUPDATE;
        private Button BTNCLEAR;
        private Button BTNDELETE;
        private Button BTNFind;
    }
}
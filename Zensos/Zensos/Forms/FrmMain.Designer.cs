namespace Zensos
{
    partial class FrmMain
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
            this.excelFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnGenerateStudents = new System.Windows.Forms.Button();
            this.btnShowClasses = new System.Windows.Forms.Button();
            this.btnGenerateJGKZ = new System.Windows.Forms.Button();
            this.btnSortAfterClass = new System.Windows.Forms.Button();
            this.btnSortAfterJGKZ = new System.Windows.Forms.Button();
            this.btnSortAfterName = new System.Windows.Forms.Button();
            this.btnSortAfterClassAndName = new System.Windows.Forms.Button();
            this.btnOutputStudents = new System.Windows.Forms.Button();
            this.btnAssign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(12, 12);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(120, 23);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Open Excel File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(138, 15);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(332, 20);
            this.txtPath.TabIndex = 2;
            // 
            // btnGenerateStudents
            // 
            this.btnGenerateStudents.Location = new System.Drawing.Point(12, 41);
            this.btnGenerateStudents.Name = "btnGenerateStudents";
            this.btnGenerateStudents.Size = new System.Drawing.Size(458, 23);
            this.btnGenerateStudents.TabIndex = 3;
            this.btnGenerateStudents.Text = "Generate Students";
            this.btnGenerateStudents.UseVisualStyleBackColor = true;
            this.btnGenerateStudents.Click += new System.EventHandler(this.btnGenerateStudents_Click);
            // 
            // btnShowClasses
            // 
            this.btnShowClasses.Location = new System.Drawing.Point(12, 99);
            this.btnShowClasses.Name = "btnShowClasses";
            this.btnShowClasses.Size = new System.Drawing.Size(458, 23);
            this.btnShowClasses.TabIndex = 4;
            this.btnShowClasses.Text = "Show classes";
            this.btnShowClasses.UseVisualStyleBackColor = true;
            this.btnShowClasses.Click += new System.EventHandler(this.btnShowClasses_Click);
            // 
            // btnGenerateJGKZ
            // 
            this.btnGenerateJGKZ.Location = new System.Drawing.Point(12, 128);
            this.btnGenerateJGKZ.Name = "btnGenerateJGKZ";
            this.btnGenerateJGKZ.Size = new System.Drawing.Size(458, 23);
            this.btnGenerateJGKZ.TabIndex = 5;
            this.btnGenerateJGKZ.Text = "Generate JGKZ for Students";
            this.btnGenerateJGKZ.UseVisualStyleBackColor = true;
            this.btnGenerateJGKZ.Click += new System.EventHandler(this.btnGenerateJGKZ_Click);
            // 
            // btnSortAfterClass
            // 
            this.btnSortAfterClass.Location = new System.Drawing.Point(12, 186);
            this.btnSortAfterClass.Name = "btnSortAfterClass";
            this.btnSortAfterClass.Size = new System.Drawing.Size(458, 23);
            this.btnSortAfterClass.TabIndex = 6;
            this.btnSortAfterClass.Text = "Sort students after class";
            this.btnSortAfterClass.UseVisualStyleBackColor = true;
            this.btnSortAfterClass.Click += new System.EventHandler(this.btnSortAfterClass_Click);
            // 
            // btnSortAfterJGKZ
            // 
            this.btnSortAfterJGKZ.Location = new System.Drawing.Point(12, 215);
            this.btnSortAfterJGKZ.Name = "btnSortAfterJGKZ";
            this.btnSortAfterJGKZ.Size = new System.Drawing.Size(458, 23);
            this.btnSortAfterJGKZ.TabIndex = 7;
            this.btnSortAfterJGKZ.Text = "Sort students after JGKZ";
            this.btnSortAfterJGKZ.UseVisualStyleBackColor = true;
            this.btnSortAfterJGKZ.Click += new System.EventHandler(this.btnSortAfterJGKZ_Click);
            // 
            // btnSortAfterName
            // 
            this.btnSortAfterName.Location = new System.Drawing.Point(12, 244);
            this.btnSortAfterName.Name = "btnSortAfterName";
            this.btnSortAfterName.Size = new System.Drawing.Size(458, 23);
            this.btnSortAfterName.TabIndex = 8;
            this.btnSortAfterName.Text = "Sort students after Name";
            this.btnSortAfterName.UseVisualStyleBackColor = true;
            this.btnSortAfterName.Click += new System.EventHandler(this.btnSortAfterName_Click);
            // 
            // btnSortAfterClassAndName
            // 
            this.btnSortAfterClassAndName.Location = new System.Drawing.Point(12, 273);
            this.btnSortAfterClassAndName.Name = "btnSortAfterClassAndName";
            this.btnSortAfterClassAndName.Size = new System.Drawing.Size(458, 23);
            this.btnSortAfterClassAndName.TabIndex = 9;
            this.btnSortAfterClassAndName.Text = "Sort students after Class and then Name";
            this.btnSortAfterClassAndName.UseVisualStyleBackColor = true;
            this.btnSortAfterClassAndName.Click += new System.EventHandler(this.btnSortAfterClassAndName_Click);
            // 
            // btnOutputStudents
            // 
            this.btnOutputStudents.Location = new System.Drawing.Point(12, 70);
            this.btnOutputStudents.Name = "btnOutputStudents";
            this.btnOutputStudents.Size = new System.Drawing.Size(458, 23);
            this.btnOutputStudents.TabIndex = 10;
            this.btnOutputStudents.Text = "Output Students";
            this.btnOutputStudents.UseVisualStyleBackColor = true;
            this.btnOutputStudents.Click += new System.EventHandler(this.btnOutputStudents_Click);
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(12, 157);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(458, 23);
            this.btnAssign.TabIndex = 11;
            this.btnAssign.Text = "Assign Class JGKZ";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 304);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.btnOutputStudents);
            this.Controls.Add(this.btnSortAfterClassAndName);
            this.Controls.Add(this.btnSortAfterName);
            this.Controls.Add(this.btnSortAfterJGKZ);
            this.Controls.Add(this.btnSortAfterClass);
            this.Controls.Add(this.btnGenerateJGKZ);
            this.Controls.Add(this.btnShowClasses);
            this.Controls.Add(this.btnGenerateStudents);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnOpenFile);
            this.Name = "FrmMain";
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog excelFileDialog;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnGenerateStudents;
        private System.Windows.Forms.Button btnShowClasses;
        private System.Windows.Forms.Button btnGenerateJGKZ;
        private System.Windows.Forms.Button btnSortAfterClass;
        private System.Windows.Forms.Button btnSortAfterJGKZ;
        private System.Windows.Forms.Button btnSortAfterName;
        private System.Windows.Forms.Button btnSortAfterClassAndName;
        private System.Windows.Forms.Button btnOutputStudents;
        private System.Windows.Forms.Button btnAssign;
    }
}
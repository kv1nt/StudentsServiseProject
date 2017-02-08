namespace StudentsApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonShowAllStud = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.findStudent_btn = new System.Windows.Forms.Button();
            this.removeStud_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.about_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.addStudent_btn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeInfoStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewInfoAboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonShowAllStud
            // 
            this.buttonShowAllStud.Image = global::StudentsApp.Properties.Resources.database_3;
            this.buttonShowAllStud.Location = new System.Drawing.Point(12, 25);
            this.buttonShowAllStud.Name = "buttonShowAllStud";
            this.buttonShowAllStud.Size = new System.Drawing.Size(39, 34);
            this.buttonShowAllStud.TabIndex = 0;
            this.buttonShowAllStud.UseVisualStyleBackColor = true;
            this.buttonShowAllStud.Click += new System.EventHandler(this.buttonShowAllStud_Click);
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(12, 65);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1037, 444);
            this.panel.TabIndex = 1;
            // 
            // findStudent_btn
            // 
            this.findStudent_btn.Location = new System.Drawing.Point(19, 69);
            this.findStudent_btn.Name = "findStudent_btn";
            this.findStudent_btn.Size = new System.Drawing.Size(64, 42);
            this.findStudent_btn.TabIndex = 2;
            this.findStudent_btn.Text = "Find student";
            this.findStudent_btn.UseVisualStyleBackColor = true;
            this.findStudent_btn.Click += new System.EventHandler(this.findStudent_btn_Click);
            // 
            // removeStud_btn
            // 
            this.removeStud_btn.Location = new System.Drawing.Point(19, 117);
            this.removeStud_btn.Name = "removeStud_btn";
            this.removeStud_btn.Size = new System.Drawing.Size(64, 42);
            this.removeStud_btn.TabIndex = 3;
            this.removeStud_btn.Text = "Remove student";
            this.removeStud_btn.UseVisualStyleBackColor = true;
            this.removeStud_btn.Click += new System.EventHandler(this.removeStud_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.about_btn);
            this.groupBox1.Controls.Add(this.exit_btn);
            this.groupBox1.Controls.Add(this.addStudent_btn);
            this.groupBox1.Controls.Add(this.removeStud_btn);
            this.groupBox1.Controls.Add(this.findStudent_btn);
            this.groupBox1.Location = new System.Drawing.Point(1063, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(103, 317);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // about_btn
            // 
            this.about_btn.Location = new System.Drawing.Point(19, 261);
            this.about_btn.Name = "about_btn";
            this.about_btn.Size = new System.Drawing.Size(64, 42);
            this.about_btn.TabIndex = 6;
            this.about_btn.Text = "About";
            this.about_btn.UseVisualStyleBackColor = true;
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(19, 213);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(64, 42);
            this.exit_btn.TabIndex = 5;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            // 
            // addStudent_btn
            // 
            this.addStudent_btn.Location = new System.Drawing.Point(19, 165);
            this.addStudent_btn.Name = "addStudent_btn";
            this.addStudent_btn.Size = new System.Drawing.Size(64, 42);
            this.addStudent_btn.TabIndex = 4;
            this.addStudent_btn.Text = "Add student";
            this.addStudent_btn.UseVisualStyleBackColor = true;
            this.addStudent_btn.Click += new System.EventHandler(this.addStudent_btn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Azure;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1192, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAllStudentsToolStripMenuItem,
            this.findStudentToolStripMenuItem,
            this.addStudentToolStripMenuItem,
            this.removeStudentToolStripMenuItem,
            this.changeInfoStudentToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // showAllStudentsToolStripMenuItem
            // 
            this.showAllStudentsToolStripMenuItem.Name = "showAllStudentsToolStripMenuItem";
            this.showAllStudentsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.showAllStudentsToolStripMenuItem.Text = "Show all students";
            // 
            // findStudentToolStripMenuItem
            // 
            this.findStudentToolStripMenuItem.Name = "findStudentToolStripMenuItem";
            this.findStudentToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.findStudentToolStripMenuItem.Text = "Find student";
            // 
            // addStudentToolStripMenuItem
            // 
            this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.addStudentToolStripMenuItem.Text = "Add student";
            // 
            // removeStudentToolStripMenuItem
            // 
            this.removeStudentToolStripMenuItem.Name = "removeStudentToolStripMenuItem";
            this.removeStudentToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.removeStudentToolStripMenuItem.Text = "Remove student";
            // 
            // changeInfoStudentToolStripMenuItem
            // 
            this.changeInfoStudentToolStripMenuItem.Name = "changeInfoStudentToolStripMenuItem";
            this.changeInfoStudentToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.changeInfoStudentToolStripMenuItem.Text = "Change info student";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.viewHelpToolStripMenuItem.Text = "View help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewInfoAboutProgramToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // viewInfoAboutProgramToolStripMenuItem
            // 
            this.viewInfoAboutProgramToolStripMenuItem.Name = "viewInfoAboutProgramToolStripMenuItem";
            this.viewInfoAboutProgramToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.viewInfoAboutProgramToolStripMenuItem.Text = "View info about program";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1192, 531);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonShowAllStud);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Students Data Base Service";
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonShowAllStud;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button findStudent_btn;
        private System.Windows.Forms.Button removeStud_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button about_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button addStudent_btn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewInfoAboutProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeInfoStudentToolStripMenuItem;
    }
}


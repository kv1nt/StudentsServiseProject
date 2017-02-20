namespace StudentsApp
{
    partial class RemoveStudPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FindStud_btn = new System.Windows.Forms.Button();
            this.FindStudField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RemoveStud_btn = new System.Windows.Forms.Button();
            this.RemoveStudByIdField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RemoveList = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.сolName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateofbirth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mobphone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FindStud_btn);
            this.groupBox1.Controls.Add(this.FindStudField);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 71);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пошук студента по Прізвищу";
            // 
            // FindStud_btn
            // 
            this.FindStud_btn.Location = new System.Drawing.Point(384, 21);
            this.FindStud_btn.Name = "FindStud_btn";
            this.FindStud_btn.Size = new System.Drawing.Size(95, 28);
            this.FindStud_btn.TabIndex = 2;
            this.FindStud_btn.Text = "Пошук";
            this.FindStud_btn.UseVisualStyleBackColor = true;
            this.FindStud_btn.Click += new System.EventHandler(this.FindStud_btn_Click);
            // 
            // FindStudField
            // 
            this.FindStudField.Location = new System.Drawing.Point(119, 26);
            this.FindStudField.Name = "FindStudField";
            this.FindStudField.Size = new System.Drawing.Size(250, 20);
            this.FindStudField.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть прізвище";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(567, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "та";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RemoveStud_btn);
            this.groupBox2.Controls.Add(this.RemoveStudByIdField);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(656, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(512, 71);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Видалення студента по ID";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // RemoveStud_btn
            // 
            this.RemoveStud_btn.Location = new System.Drawing.Point(409, 21);
            this.RemoveStud_btn.Name = "RemoveStud_btn";
            this.RemoveStud_btn.Size = new System.Drawing.Size(90, 28);
            this.RemoveStud_btn.TabIndex = 2;
            this.RemoveStud_btn.Text = "Видалити";
            this.RemoveStud_btn.UseVisualStyleBackColor = true;
            // 
            // RemoveStudByIdField
            // 
            this.RemoveStudByIdField.Location = new System.Drawing.Point(136, 26);
            this.RemoveStudByIdField.Name = "RemoveStudByIdField";
            this.RemoveStudByIdField.Size = new System.Drawing.Size(253, 20);
            this.RemoveStudByIdField.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Введіть ID";
            // 
            // RemoveList
            // 
            this.RemoveList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.сolName,
            this.lastName,
            this.surname,
            this.sex,
            this.age,
            this.dateofbirth,
            this.mobphone});
            this.RemoveList.GridLines = true;
            this.RemoveList.Location = new System.Drawing.Point(0, 99);
            this.RemoveList.Name = "RemoveList";
            this.RemoveList.Size = new System.Drawing.Size(1165, 352);
            this.RemoveList.TabIndex = 9;
            this.RemoveList.UseCompatibleStateImageBehavior = false;
            this.RemoveList.View = System.Windows.Forms.View.Details;
            this.RemoveList.SelectedIndexChanged += new System.EventHandler(this.RemoveList_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 51;
            // 
            // сolName
            // 
            this.сolName.Text = "Ім\'я";
            this.сolName.Width = 124;
            // 
            // lastName
            // 
            this.lastName.Text = "По батькові";
            this.lastName.Width = 130;
            // 
            // surname
            // 
            this.surname.Text = "Прізвище";
            this.surname.Width = 172;
            // 
            // sex
            // 
            this.sex.Text = "Стать";
            // 
            // age
            // 
            this.age.Text = "Вік";
            // 
            // dateofbirth
            // 
            this.dateofbirth.Text = "Дата народження";
            this.dateofbirth.Width = 159;
            // 
            // mobphone
            // 
            this.mobphone.Text = "Номер мобільного";
            this.mobphone.Width = 405;
            // 
            // RemoveStudPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RemoveList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RemoveStudPanel";
            this.Size = new System.Drawing.Size(1168, 451);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button FindStud_btn;
        private System.Windows.Forms.TextBox FindStudField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button RemoveStud_btn;
        private System.Windows.Forms.TextBox RemoveStudByIdField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView RemoveList;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader сolName;
        private System.Windows.Forms.ColumnHeader lastName;
        private System.Windows.Forms.ColumnHeader surname;
        private System.Windows.Forms.ColumnHeader sex;
        private System.Windows.Forms.ColumnHeader age;
        private System.Windows.Forms.ColumnHeader dateofbirth;
        private System.Windows.Forms.ColumnHeader mobphone;
    }
}

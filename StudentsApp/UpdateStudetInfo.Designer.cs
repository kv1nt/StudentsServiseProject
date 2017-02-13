namespace StudentsApp
{
    partial class UpdateStudetInfo
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
            this.UpdateStudentGridView = new System.Windows.Forms.DataGridView();
            this.Name_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mob_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SaveChangeStuD_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.FindStud_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FMPhones_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateStudentGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // UpdateStudentGridView
            // 
            this.UpdateStudentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UpdateStudentGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_col,
            this.lastName_col,
            this.Surname_col,
            this.Sex_col,
            this.Age_col,
            this.DateOfBirth,
            this.Mob_tel});
            this.UpdateStudentGridView.Location = new System.Drawing.Point(0, 108);
            this.UpdateStudentGridView.Name = "UpdateStudentGridView";
            this.UpdateStudentGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.UpdateStudentGridView.Size = new System.Drawing.Size(1089, 81);
            this.UpdateStudentGridView.TabIndex = 0;
            // 
            // Name_col
            // 
            this.Name_col.HeaderText = "Ім\'я";
            this.Name_col.Name = "Name_col";
            // 
            // lastName_col
            // 
            this.lastName_col.HeaderText = "Прізвище";
            this.lastName_col.Name = "lastName_col";
            // 
            // Surname_col
            // 
            this.Surname_col.HeaderText = "По батькові";
            this.Surname_col.Name = "Surname_col";
            // 
            // Sex_col
            // 
            this.Sex_col.HeaderText = "Стать";
            this.Sex_col.Name = "Sex_col";
            // 
            // Age_col
            // 
            this.Age_col.HeaderText = "Вік";
            this.Age_col.Name = "Age_col";
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.HeaderText = "Дата народження";
            this.DateOfBirth.Name = "DateOfBirth";
            // 
            // Mob_tel
            // 
            this.Mob_tel.HeaderText = "Мобільний телефон";
            this.Mob_tel.Name = "Mob_tel";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FindStud_btn);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 65);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пошук студента по ID";
            // 
            // SaveChangeStuD_Btn
            // 
            this.SaveChangeStuD_Btn.Location = new System.Drawing.Point(1102, 108);
            this.SaveChangeStuD_Btn.Name = "SaveChangeStuD_Btn";
            this.SaveChangeStuD_Btn.Size = new System.Drawing.Size(63, 81);
            this.SaveChangeStuD_Btn.TabIndex = 0;
            this.SaveChangeStuD_Btn.Text = "Зберегти";
            this.SaveChangeStuD_Btn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введіть ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 20);
            this.textBox1.TabIndex = 2;
            // 
            // FindStud_btn
            // 
            this.FindStud_btn.Location = new System.Drawing.Point(333, 22);
            this.FindStud_btn.Name = "FindStud_btn";
            this.FindStud_btn.Size = new System.Drawing.Size(75, 28);
            this.FindStud_btn.TabIndex = 3;
            this.FindStud_btn.Text = "Пошук";
            this.FindStud_btn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.FMPhones_col});
            this.dataGridView1.Location = new System.Drawing.Point(0, 314);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(1089, 80);
            this.dataGridView1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1102, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 80);
            this.button1.TabIndex = 3;
            this.button1.Text = "Зберегти";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(528, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(125, 89);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 54);
            this.button2.TabIndex = 4;
            this.button2.Text = "Показати додаткову інформацію";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер студенського";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Адреса";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Сер.оцінка";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Матір";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Спеціальність";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Батько";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Спеціальність";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // FMPhones_col
            // 
            this.FMPhones_col.HeaderText = "Телефони";
            this.FMPhones_col.Name = "FMPhones_col";
            // 
            // UpdateStudetInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UpdateStudentGridView);
            this.Controls.Add(this.SaveChangeStuD_Btn);
            this.Name = "UpdateStudetInfo";
            this.Size = new System.Drawing.Size(1168, 451);
            ((System.ComponentModel.ISupportInitialize)(this.UpdateStudentGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView UpdateStudentGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mob_tel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveChangeStuD_Btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button FindStud_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn FMPhones_col;
    }
}

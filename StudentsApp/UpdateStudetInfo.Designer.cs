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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.findStudentById_btn = new System.Windows.Forms.Button();
            this.InputIDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.infoStud = new System.Windows.Forms.GroupBox();
            this.ShowIdField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GroupStudField = new System.Windows.Forms.TextBox();
            this.BirthDateStudField = new System.Windows.Forms.TextBox();
            this.ProgressStudField = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.AgeStudField = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AddressStudField = new System.Windows.Forms.TextBox();
            this.NumbStudCertificateField = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SurnameStudField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NameStudField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LastNameStudField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.phoneStud_col = new System.Windows.Forms.GroupBox();
            this.StPhoneGridView = new System.Windows.Forms.DataGridView();
            this.editPhoneStudGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RelPhonesTable = new System.Windows.Forms.ListView();
            this.phoneStud_colum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.EditRelInfoGridView = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.SaveChanges_btn = new System.Windows.Forms.Button();
            this.EditAdditionalRelGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_rel_col_noVisible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.infoStud.SuspendLayout();
            this.phoneStud_col.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StPhoneGridView)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditRelInfoGridView)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditAdditionalRelGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.findStudentById_btn);
            this.groupBox1.Controls.Add(this.InputIDTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 65);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пошук студента по ID";
            // 
            // findStudentById_btn
            // 
            this.findStudentById_btn.BackColor = System.Drawing.Color.White;
            this.findStudentById_btn.Image = global::StudentsApp.Properties.Resources.search;
            this.findStudentById_btn.Location = new System.Drawing.Point(288, 19);
            this.findStudentById_btn.Name = "findStudentById_btn";
            this.findStudentById_btn.Size = new System.Drawing.Size(37, 34);
            this.findStudentById_btn.TabIndex = 3;
            this.findStudentById_btn.UseVisualStyleBackColor = false;
            this.findStudentById_btn.Click += new System.EventHandler(this.findStudentById_btn_Click);
            // 
            // InputIDTextBox
            // 
            this.InputIDTextBox.Location = new System.Drawing.Point(123, 26);
            this.InputIDTextBox.Name = "InputIDTextBox";
            this.InputIDTextBox.Size = new System.Drawing.Size(159, 20);
            this.InputIDTextBox.TabIndex = 2;
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
            // infoStud
            // 
            this.infoStud.Controls.Add(this.ShowIdField);
            this.infoStud.Controls.Add(this.label2);
            this.infoStud.Controls.Add(this.GroupStudField);
            this.infoStud.Controls.Add(this.BirthDateStudField);
            this.infoStud.Controls.Add(this.ProgressStudField);
            this.infoStud.Controls.Add(this.label9);
            this.infoStud.Controls.Add(this.label13);
            this.infoStud.Controls.Add(this.AgeStudField);
            this.infoStud.Controls.Add(this.label14);
            this.infoStud.Controls.Add(this.label8);
            this.infoStud.Controls.Add(this.AddressStudField);
            this.infoStud.Controls.Add(this.NumbStudCertificateField);
            this.infoStud.Controls.Add(this.label15);
            this.infoStud.Controls.Add(this.label6);
            this.infoStud.Controls.Add(this.SurnameStudField);
            this.infoStud.Controls.Add(this.label5);
            this.infoStud.Controls.Add(this.NameStudField);
            this.infoStud.Controls.Add(this.label4);
            this.infoStud.Controls.Add(this.LastNameStudField);
            this.infoStud.Controls.Add(this.label3);
            this.infoStud.Location = new System.Drawing.Point(3, 74);
            this.infoStud.Name = "infoStud";
            this.infoStud.Size = new System.Drawing.Size(331, 374);
            this.infoStud.TabIndex = 5;
            this.infoStud.TabStop = false;
            this.infoStud.Text = "Дані про студента";
            // 
            // ShowIdField
            // 
            this.ShowIdField.Location = new System.Drawing.Point(120, 24);
            this.ShowIdField.Name = "ShowIdField";
            this.ShowIdField.ReadOnly = true;
            this.ShowIdField.Size = new System.Drawing.Size(176, 20);
            this.ShowIdField.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "ID";
            // 
            // GroupStudField
            // 
            this.GroupStudField.Location = new System.Drawing.Point(120, 303);
            this.GroupStudField.Name = "GroupStudField";
            this.GroupStudField.Size = new System.Drawing.Size(176, 20);
            this.GroupStudField.TabIndex = 33;
            // 
            // BirthDateStudField
            // 
            this.BirthDateStudField.Location = new System.Drawing.Point(120, 199);
            this.BirthDateStudField.Name = "BirthDateStudField";
            this.BirthDateStudField.Size = new System.Drawing.Size(176, 20);
            this.BirthDateStudField.TabIndex = 23;
            // 
            // ProgressStudField
            // 
            this.ProgressStudField.Location = new System.Drawing.Point(120, 269);
            this.ProgressStudField.Name = "ProgressStudField";
            this.ProgressStudField.Size = new System.Drawing.Size(176, 20);
            this.ProgressStudField.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Дата народження";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 306);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Група";
            // 
            // AgeStudField
            // 
            this.AgeStudField.Location = new System.Drawing.Point(120, 164);
            this.AgeStudField.Name = "AgeStudField";
            this.AgeStudField.Size = new System.Drawing.Size(176, 20);
            this.AgeStudField.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 272);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Сер. оцінка";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Вік";
            // 
            // AddressStudField
            // 
            this.AddressStudField.Location = new System.Drawing.Point(120, 234);
            this.AddressStudField.Name = "AddressStudField";
            this.AddressStudField.Size = new System.Drawing.Size(176, 20);
            this.AddressStudField.TabIndex = 31;
            // 
            // NumbStudCertificateField
            // 
            this.NumbStudCertificateField.Location = new System.Drawing.Point(120, 336);
            this.NumbStudCertificateField.Name = "NumbStudCertificateField";
            this.NumbStudCertificateField.Size = new System.Drawing.Size(176, 20);
            this.NumbStudCertificateField.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 237);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "Адреса";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "№ студенського";
            // 
            // SurnameStudField
            // 
            this.SurnameStudField.Location = new System.Drawing.Point(120, 134);
            this.SurnameStudField.Name = "SurnameStudField";
            this.SurnameStudField.Size = new System.Drawing.Size(176, 20);
            this.SurnameStudField.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "По батькові";
            // 
            // NameStudField
            // 
            this.NameStudField.Location = new System.Drawing.Point(120, 99);
            this.NameStudField.Name = "NameStudField";
            this.NameStudField.Size = new System.Drawing.Size(176, 20);
            this.NameStudField.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ім\'я";
            // 
            // LastNameStudField
            // 
            this.LastNameStudField.Location = new System.Drawing.Point(120, 62);
            this.LastNameStudField.Name = "LastNameStudField";
            this.LastNameStudField.Size = new System.Drawing.Size(176, 20);
            this.LastNameStudField.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Прізвище";
            // 
            // phoneStud_col
            // 
            this.phoneStud_col.Controls.Add(this.StPhoneGridView);
            this.phoneStud_col.Location = new System.Drawing.Point(340, 218);
            this.phoneStud_col.Name = "phoneStud_col";
            this.phoneStud_col.Size = new System.Drawing.Size(330, 229);
            this.phoneStud_col.TabIndex = 39;
            this.phoneStud_col.TabStop = false;
            this.phoneStud_col.Text = "Телефони студента";
            // 
            // StPhoneGridView
            // 
            this.StPhoneGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StPhoneGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.editPhoneStudGridView});
            this.StPhoneGridView.Location = new System.Drawing.Point(17, 23);
            this.StPhoneGridView.Name = "StPhoneGridView";
            this.StPhoneGridView.Size = new System.Drawing.Size(297, 185);
            this.StPhoneGridView.TabIndex = 3;
            // 
            // editPhoneStudGridView
            // 
            this.editPhoneStudGridView.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.editPhoneStudGridView.HeaderText = "Номера телефонів студента";
            this.editPhoneStudGridView.Name = "editPhoneStudGridView";
            this.editPhoneStudGridView.Width = 260;
            // 
            // RelPhonesTable
            // 
            this.RelPhonesTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.phoneStud_colum});
            this.RelPhonesTable.GridLines = true;
            this.RelPhonesTable.Location = new System.Drawing.Point(6, 19);
            this.RelPhonesTable.Name = "RelPhonesTable";
            this.RelPhonesTable.Size = new System.Drawing.Size(229, 201);
            this.RelPhonesTable.TabIndex = 3;
            this.RelPhonesTable.UseCompatibleStateImageBehavior = false;
            this.RelPhonesTable.View = System.Windows.Forms.View.Details;
            // 
            // phoneStud_colum
            // 
            this.phoneStud_colum.Text = "Номери телефонів";
            this.phoneStud_colum.Width = 224;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.EditAdditionalRelGridView);
            this.groupBox4.Controls.Add(this.EditRelInfoGridView);
            this.groupBox4.Location = new System.Drawing.Point(340, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(825, 208);
            this.groupBox4.TabIndex = 40;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Відомості про рідних";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // EditRelInfoGridView
            // 
            this.EditRelInfoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EditRelInfoGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.EditRelInfoGridView.Location = new System.Drawing.Point(17, 19);
            this.EditRelInfoGridView.Name = "EditRelInfoGridView";
            this.EditRelInfoGridView.Size = new System.Drawing.Size(785, 88);
            this.EditRelInfoGridView.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Controls.Add(this.RelPhonesTable);
            this.groupBox5.Controls.Add(this.button5);
            this.groupBox5.Controls.Add(this.button12);
            this.groupBox5.Location = new System.Drawing.Point(748, 214);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(330, 233);
            this.groupBox5.TabIndex = 40;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Телефони батьків";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(248, 77);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Видалити";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(248, 48);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Змінити";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(248, 19);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 7;
            this.button12.Text = "Додати";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // SaveChanges_btn
            // 
            this.SaveChanges_btn.BackColor = System.Drawing.Color.White;
            this.SaveChanges_btn.Image = global::StudentsApp.Properties.Resources.Apply1;
            this.SaveChanges_btn.Location = new System.Drawing.Point(1097, 401);
            this.SaveChanges_btn.Name = "SaveChanges_btn";
            this.SaveChanges_btn.Size = new System.Drawing.Size(71, 50);
            this.SaveChanges_btn.TabIndex = 38;
            this.SaveChanges_btn.UseVisualStyleBackColor = false;
            this.SaveChanges_btn.Click += new System.EventHandler(this.SaveChanges_btn_Click);
            // 
            // EditAdditionalRelGridView
            // 
            this.EditAdditionalRelGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EditAdditionalRelGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.id_rel_col_noVisible});
            this.EditAdditionalRelGridView.Location = new System.Drawing.Point(17, 122);
            this.EditAdditionalRelGridView.Name = "EditAdditionalRelGridView";
            this.EditAdditionalRelGridView.Size = new System.Drawing.Size(785, 80);
            this.EditAdditionalRelGridView.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Прізвища Батьків";
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Імена Батьків";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Спіціальності Батьків";
            this.Column3.Name = "Column3";
            this.Column3.Width = 340;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Дані про найближчих родичів";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 740;
            // 
            // id_rel_col_noVisible
            // 
            this.id_rel_col_noVisible.HeaderText = "Column5";
            this.id_rel_col_noVisible.Name = "id_rel_col_noVisible";
            this.id_rel_col_noVisible.Visible = false;
            // 
            // UpdateStudetInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.phoneStud_col);
            this.Controls.Add(this.SaveChanges_btn);
            this.Controls.Add(this.infoStud);
            this.Controls.Add(this.groupBox1);
            this.Name = "UpdateStudetInfo";
            this.Size = new System.Drawing.Size(1168, 451);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.infoStud.ResumeLayout(false);
            this.infoStud.PerformLayout();
            this.phoneStud_col.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StPhoneGridView)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EditRelInfoGridView)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EditAdditionalRelGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputIDTextBox;
        private System.Windows.Forms.GroupBox infoStud;
        private System.Windows.Forms.TextBox BirthDateStudField;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox AgeStudField;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NumbStudCertificateField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SurnameStudField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NameStudField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LastNameStudField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox GroupStudField;
        private System.Windows.Forms.TextBox ProgressStudField;
        private System.Windows.Forms.TextBox AddressStudField;
        private System.Windows.Forms.Button SaveChanges_btn;
        private System.Windows.Forms.GroupBox phoneStud_col;
        private System.Windows.Forms.ListView RelPhonesTable;
        private System.Windows.Forms.ColumnHeader phoneStud_colum;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button findStudentById_btn;
        private System.Windows.Forms.TextBox ShowIdField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView StPhoneGridView;
        private System.Windows.Forms.DataGridView EditRelInfoGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn editPhoneStudGridView;
        private System.Windows.Forms.DataGridView EditAdditionalRelGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_rel_col_noVisible;
    }
}

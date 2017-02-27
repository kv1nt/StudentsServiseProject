namespace StudentsApp
{
    partial class FindStudentPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FindStudentByLastName = new System.Windows.Forms.Button();
            this.IDStudTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listViewStud = new System.Windows.Forms.ListView();
            this.id_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.patronymic_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.surname_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sex_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.age_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.birthday_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mphone_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.secondRow = new System.Windows.Forms.ListView();
            this.numbBook_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.address_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GPA_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.group_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.motherInfoList = new System.Windows.Forms.ListView();
            this.motherName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.motherLname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.motherSpec = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fatherInfo = new System.Windows.Forms.ListView();
            this.fatherName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fatherLname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fatherSpec = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.additionalRel = new System.Windows.Forms.ListView();
            this.relations = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.relationsPhones = new System.Windows.Forms.ListView();
            this.relPhones = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studPhoto = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studPhoto)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FindStudentByLastName);
            this.groupBox1.Controls.Add(this.IDStudTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 62);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пошук студента за прізвищем";
            // 
            // FindStudentByLastName
            // 
            this.FindStudentByLastName.Location = new System.Drawing.Point(364, 21);
            this.FindStudentByLastName.Name = "FindStudentByLastName";
            this.FindStudentByLastName.Size = new System.Drawing.Size(78, 28);
            this.FindStudentByLastName.TabIndex = 2;
            this.FindStudentByLastName.Text = "Пошук";
            this.FindStudentByLastName.UseVisualStyleBackColor = true;
            this.FindStudentByLastName.Click += new System.EventHandler(this.FindStudentByLastName_Click);
            // 
            // IDStudTextBox
            // 
            this.IDStudTextBox.Location = new System.Drawing.Point(118, 26);
            this.IDStudTextBox.Name = "IDStudTextBox";
            this.IDStudTextBox.Size = new System.Drawing.Size(231, 20);
            this.IDStudTextBox.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(661, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(507, 71);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Пошук студента по ID";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(404, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Пошук";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(134, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(250, 20);
            this.textBox2.TabIndex = 1;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(556, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "або";
            // 
            // listViewStud
            // 
            this.listViewStud.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id_col,
            this.name_col,
            this.patronymic_col,
            this.surname_col,
            this.sex_col,
            this.age_col,
            this.birthday_col,
            this.mphone_col});
            this.listViewStud.GridLines = true;
            this.listViewStud.Location = new System.Drawing.Point(0, 72);
            this.listViewStud.Name = "listViewStud";
            this.listViewStud.Size = new System.Drawing.Size(1168, 63);
            this.listViewStud.TabIndex = 4;
            this.listViewStud.UseCompatibleStateImageBehavior = false;
            this.listViewStud.View = System.Windows.Forms.View.Details;
            // 
            // id_col
            // 
            this.id_col.Text = "ID";
            // 
            // name_col
            // 
            this.name_col.Text = "Ім\'я";
            this.name_col.Width = 191;
            // 
            // patronymic_col
            // 
            this.patronymic_col.Text = "Прізвище";
            this.patronymic_col.Width = 199;
            // 
            // surname_col
            // 
            this.surname_col.Text = "По батькові";
            this.surname_col.Width = 215;
            // 
            // sex_col
            // 
            this.sex_col.Text = "Стать";
            this.sex_col.Width = 70;
            // 
            // age_col
            // 
            this.age_col.Text = "Вік";
            this.age_col.Width = 52;
            // 
            // birthday_col
            // 
            this.birthday_col.Text = "Дата народження";
            this.birthday_col.Width = 143;
            // 
            // mphone_col
            // 
            this.mphone_col.Text = "Мобільнй телефон";
            this.mphone_col.Width = 230;
            // 
            // secondRow
            // 
            this.secondRow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.numbBook_col,
            this.address_col,
            this.GPA_col,
            this.group_col});
            this.secondRow.GridLines = true;
            this.secondRow.Location = new System.Drawing.Point(0, 141);
            this.secondRow.Name = "secondRow";
            this.secondRow.Size = new System.Drawing.Size(667, 53);
            this.secondRow.TabIndex = 5;
            this.secondRow.UseCompatibleStateImageBehavior = false;
            this.secondRow.View = System.Windows.Forms.View.Details;
            // 
            // numbBook_col
            // 
            this.numbBook_col.Text = "Номер студенського";
            this.numbBook_col.Width = 80;
            // 
            // address_col
            // 
            this.address_col.Text = "Адреса";
            this.address_col.Width = 366;
            // 
            // GPA_col
            // 
            this.GPA_col.Text = "Сер.оцінка";
            this.GPA_col.Width = 75;
            // 
            // group_col
            // 
            this.group_col.Text = "Група";
            this.group_col.Width = 142;
            // 
            // motherInfoList
            // 
            this.motherInfoList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.motherName,
            this.motherLname,
            this.motherSpec});
            this.motherInfoList.GridLines = true;
            this.motherInfoList.Location = new System.Drawing.Point(0, 219);
            this.motherInfoList.Name = "motherInfoList";
            this.motherInfoList.Size = new System.Drawing.Size(667, 54);
            this.motherInfoList.TabIndex = 8;
            this.motherInfoList.UseCompatibleStateImageBehavior = false;
            this.motherInfoList.View = System.Windows.Forms.View.Details;
            // 
            // motherName
            // 
            this.motherName.Text = "Матір Ім\'я";
            this.motherName.Width = 165;
            // 
            // motherLname
            // 
            this.motherLname.Text = "Прізвище";
            this.motherLname.Width = 199;
            // 
            // motherSpec
            // 
            this.motherSpec.Text = "Спеціальність";
            this.motherSpec.Width = 299;
            // 
            // fatherInfo
            // 
            this.fatherInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fatherName,
            this.fatherLname,
            this.fatherSpec});
            this.fatherInfo.GridLines = true;
            this.fatherInfo.Location = new System.Drawing.Point(0, 279);
            this.fatherInfo.Name = "fatherInfo";
            this.fatherInfo.Size = new System.Drawing.Size(667, 53);
            this.fatherInfo.TabIndex = 9;
            this.fatherInfo.UseCompatibleStateImageBehavior = false;
            this.fatherInfo.View = System.Windows.Forms.View.Details;
            // 
            // fatherName
            // 
            this.fatherName.Text = "Батько Ім\'я";
            this.fatherName.Width = 165;
            // 
            // fatherLname
            // 
            this.fatherLname.Text = "Прізвище";
            this.fatherLname.Width = 199;
            // 
            // fatherSpec
            // 
            this.fatherSpec.Text = "Спеціальність";
            this.fatherSpec.Width = 299;
            // 
            // additionalRel
            // 
            this.additionalRel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.relations});
            this.additionalRel.GridLines = true;
            this.additionalRel.Location = new System.Drawing.Point(0, 338);
            this.additionalRel.Name = "additionalRel";
            this.additionalRel.Size = new System.Drawing.Size(667, 54);
            this.additionalRel.TabIndex = 10;
            this.additionalRel.UseCompatibleStateImageBehavior = false;
            this.additionalRel.View = System.Windows.Forms.View.Details;
            // 
            // relations
            // 
            this.relations.Text = "Найближчі родичі ФІП";
            this.relations.Width = 663;
            // 
            // relationsPhones
            // 
            this.relationsPhones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.relPhones});
            this.relationsPhones.GridLines = true;
            this.relationsPhones.Location = new System.Drawing.Point(0, 395);
            this.relationsPhones.Name = "relationsPhones";
            this.relationsPhones.Size = new System.Drawing.Size(667, 56);
            this.relationsPhones.TabIndex = 11;
            this.relationsPhones.UseCompatibleStateImageBehavior = false;
            this.relationsPhones.View = System.Windows.Forms.View.Details;
            this.relationsPhones.SelectedIndexChanged += new System.EventHandler(this.listView5_SelectedIndexChanged);
            // 
            // relPhones
            // 
            this.relPhones.Text = "Контактні телефони батьків та родичів";
            this.relPhones.Width = 663;
            // 
            // studPhoto
            // 
            this.studPhoto.BackColor = System.Drawing.Color.White;
            this.studPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.studPhoto.Location = new System.Drawing.Point(16, 19);
            this.studPhoto.Name = "studPhoto";
            this.studPhoto.Size = new System.Drawing.Size(217, 211);
            this.studPhoto.TabIndex = 12;
            this.studPhoto.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.studPhoto);
            this.groupBox3.Location = new System.Drawing.Point(795, 173);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 246);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Фото";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(214, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Інформація про родичів студента";
            // 
            // FindStudentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.relationsPhones);
            this.Controls.Add(this.additionalRel);
            this.Controls.Add(this.fatherInfo);
            this.Controls.Add(this.motherInfoList);
            this.Controls.Add(this.secondRow);
            this.Controls.Add(this.listViewStud);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FindStudentPanel";
            this.Size = new System.Drawing.Size(1168, 451);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studPhoto)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button FindStudentByLastName;
        private System.Windows.Forms.TextBox IDStudTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listViewStud;
        private System.Windows.Forms.ColumnHeader id_col;
        private System.Windows.Forms.ColumnHeader name_col;
        private System.Windows.Forms.ColumnHeader patronymic_col;
        private System.Windows.Forms.ColumnHeader surname_col;
        private System.Windows.Forms.ColumnHeader sex_col;
        private System.Windows.Forms.ColumnHeader age_col;
        private System.Windows.Forms.ColumnHeader birthday_col;
        private System.Windows.Forms.ColumnHeader mphone_col;
        private System.Windows.Forms.ListView secondRow;
        private System.Windows.Forms.ColumnHeader numbBook_col;
        private System.Windows.Forms.ColumnHeader address_col;
        private System.Windows.Forms.ColumnHeader GPA_col;
        private System.Windows.Forms.ListView motherInfoList;
        private System.Windows.Forms.ColumnHeader motherName;
        private System.Windows.Forms.ColumnHeader motherLname;
        private System.Windows.Forms.ColumnHeader motherSpec;
        private System.Windows.Forms.ColumnHeader group_col;
        private System.Windows.Forms.ListView fatherInfo;
        private System.Windows.Forms.ColumnHeader fatherName;
        private System.Windows.Forms.ColumnHeader fatherLname;
        private System.Windows.Forms.ColumnHeader fatherSpec;
        private System.Windows.Forms.ListView additionalRel;
        private System.Windows.Forms.ColumnHeader relations;
        private System.Windows.Forms.ListView relationsPhones;
        private System.Windows.Forms.ColumnHeader relPhones;
        private System.Windows.Forms.PictureBox studPhoto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
    }
}

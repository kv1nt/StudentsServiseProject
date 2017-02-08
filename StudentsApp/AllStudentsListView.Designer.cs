namespace StudentsApp
{
    partial class panelAllStud
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
            this.listViewAllStud = new System.Windows.Forms.ListView();
            this.id_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.patronymic_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.surname_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sex_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.age_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.birthday_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mphone_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewAllStud
            // 
            this.listViewAllStud.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id_col,
            this.name_col,
            this.patronymic_col,
            this.surname_col,
            this.sex_col,
            this.age_col,
            this.birthday_col,
            this.mphone_col});
            this.listViewAllStud.GridLines = true;
            this.listViewAllStud.Location = new System.Drawing.Point(3, 3);
            this.listViewAllStud.Name = "listViewAllStud";
            this.listViewAllStud.Size = new System.Drawing.Size(1165, 451);
            this.listViewAllStud.TabIndex = 0;
            this.listViewAllStud.UseCompatibleStateImageBehavior = false;
            this.listViewAllStud.View = System.Windows.Forms.View.Details;
            // 
            // id_col
            // 
            this.id_col.Text = "ID";
            this.id_col.Width = 32;
            // 
            // name_col
            // 
            this.name_col.Text = "Ім\'я";
            this.name_col.Width = 196;
            // 
            // patronymic_col
            // 
            this.patronymic_col.Text = "По батькові";
            this.patronymic_col.Width = 239;
            // 
            // surname_col
            // 
            this.surname_col.Text = "Фамілія";
            this.surname_col.Width = 209;
            // 
            // sex_col
            // 
            this.sex_col.Text = "Стать";
            this.sex_col.Width = 91;
            // 
            // age_col
            // 
            this.age_col.Text = "Вік";
            this.age_col.Width = 68;
            // 
            // birthday_col
            // 
            this.birthday_col.Text = "Дата народження";
            this.birthday_col.Width = 112;
            // 
            // mphone_col
            // 
            this.mphone_col.Text = "Мобільний номер телефона";
            this.mphone_col.Width = 214;
            // 
            // panelAllStud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listViewAllStud);
            this.Location = new System.Drawing.Point(13, 13);
            this.Name = "panelAllStud";
            this.Size = new System.Drawing.Size(1168, 451);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewAllStud;
        private System.Windows.Forms.ColumnHeader id_col;
        private System.Windows.Forms.ColumnHeader name_col;
        private System.Windows.Forms.ColumnHeader patronymic_col;
        private System.Windows.Forms.ColumnHeader surname_col;
        private System.Windows.Forms.ColumnHeader sex_col;
        private System.Windows.Forms.ColumnHeader age_col;
        private System.Windows.Forms.ColumnHeader birthday_col;
        private System.Windows.Forms.ColumnHeader mphone_col;
    }
}

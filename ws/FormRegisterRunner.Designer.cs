namespace ws
{
    partial class FormRegisterRunner
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
            this.panelDesign1 = new System.Windows.Forms.Panel();
            this.panelDesign2 = new System.Windows.Forms.Panel();
            this.panelDesign4 = new System.Windows.Forms.Panel();
            this.panelDesign3 = new System.Windows.Forms.Panel();
            this.ib_contry = new System.Windows.Forms.Label();
            this.lb_dateofbrith = new System.Windows.Forms.Label();
            this.dtp_data = new System.Windows.Forms.DateTimePicker();
            this.cb_country = new System.Windows.Forms.ComboBox();
            this.gender = new System.Windows.Forms.Label();
            this.lb_lname = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_rpass = new System.Windows.Forms.Label();
            this.lb_pass = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.cb_gender = new System.Windows.Forms.ComboBox();
            this.genderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wsDataSet = new ws.wsDataSet();
            this.tb_lname = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_rpass = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.tb_mail = new System.Windows.Forms.TextBox();
            this.labelRegister = new System.Windows.Forms.Label();
            this.buttonCancle = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.genderTableAdapter = new ws.wsDataSetTableAdapters.genderTableAdapter();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countryTableAdapter = new ws.wsDataSetTableAdapters.countryTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDesign1
            // 
            this.panelDesign1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelDesign1.Location = new System.Drawing.Point(1, 1);
            this.panelDesign1.Name = "panelDesign1";
            this.panelDesign1.Size = new System.Drawing.Size(55, 397);
            this.panelDesign1.TabIndex = 8;
            // 
            // panelDesign2
            // 
            this.panelDesign2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelDesign2.Location = new System.Drawing.Point(106, 1);
            this.panelDesign2.Name = "panelDesign2";
            this.panelDesign2.Size = new System.Drawing.Size(55, 397);
            this.panelDesign2.TabIndex = 9;
            // 
            // panelDesign4
            // 
            this.panelDesign4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelDesign4.Location = new System.Drawing.Point(693, 1);
            this.panelDesign4.Name = "panelDesign4";
            this.panelDesign4.Size = new System.Drawing.Size(55, 397);
            this.panelDesign4.TabIndex = 11;
            // 
            // panelDesign3
            // 
            this.panelDesign3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelDesign3.Location = new System.Drawing.Point(588, 1);
            this.panelDesign3.Name = "panelDesign3";
            this.panelDesign3.Size = new System.Drawing.Size(55, 397);
            this.panelDesign3.TabIndex = 10;
            // 
            // ib_contry
            // 
            this.ib_contry.AutoSize = true;
            this.ib_contry.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ib_contry.Location = new System.Drawing.Point(502, 291);
            this.ib_contry.Name = "ib_contry";
            this.ib_contry.Size = new System.Drawing.Size(0, 25);
            this.ib_contry.TabIndex = 52;
            // 
            // lb_dateofbrith
            // 
            this.lb_dateofbrith.AutoSize = true;
            this.lb_dateofbrith.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_dateofbrith.Location = new System.Drawing.Point(364, 141);
            this.lb_dateofbrith.Name = "lb_dateofbrith";
            this.lb_dateofbrith.Size = new System.Drawing.Size(140, 26);
            this.lb_dateofbrith.TabIndex = 51;
            this.lb_dateofbrith.Text = "Дата рождения : ";
            // 
            // dtp_data
            // 
            this.dtp_data.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtp_data.Location = new System.Drawing.Point(369, 170);
            this.dtp_data.Name = "dtp_data";
            this.dtp_data.Size = new System.Drawing.Size(200, 33);
            this.dtp_data.TabIndex = 48;
            // 
            // cb_country
            // 
            this.cb_country.DisplayMember = "CountryCode";
            this.cb_country.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_country.FormattingEnabled = true;
            this.cb_country.Location = new System.Drawing.Point(369, 241);
            this.cb_country.Name = "cb_country";
            this.cb_country.Size = new System.Drawing.Size(141, 33);
            this.cb_country.TabIndex = 47;
            this.cb_country.ValueMember = "CountryCode";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gender.Location = new System.Drawing.Point(108, 291);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(53, 26);
            this.gender.TabIndex = 44;
            this.gender.Text = "Пол : ";
            // 
            // lb_lname
            // 
            this.lb_lname.AutoSize = true;
            this.lb_lname.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_lname.Location = new System.Drawing.Point(66, 253);
            this.lb_lname.Name = "lb_lname";
            this.lb_lname.Size = new System.Drawing.Size(93, 26);
            this.lb_lname.TabIndex = 43;
            this.lb_lname.Text = "Фамилия : ";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_name.Location = new System.Drawing.Point(97, 215);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(56, 26);
            this.lb_name.TabIndex = 42;
            this.lb_name.Text = "Имя : ";
            // 
            // lb_rpass
            // 
            this.lb_rpass.AutoSize = true;
            this.lb_rpass.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_rpass.Location = new System.Drawing.Point(1, 175);
            this.lb_rpass.Name = "lb_rpass";
            this.lb_rpass.Size = new System.Drawing.Size(158, 26);
            this.lb_rpass.TabIndex = 41;
            this.lb_rpass.Text = "Повторите пароль : ";
            // 
            // lb_pass
            // 
            this.lb_pass.AutoSize = true;
            this.lb_pass.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_pass.Location = new System.Drawing.Point(79, 137);
            this.lb_pass.Name = "lb_pass";
            this.lb_pass.Size = new System.Drawing.Size(76, 26);
            this.lb_pass.TabIndex = 40;
            this.lb_pass.Text = "Пароль : ";
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_email.Location = new System.Drawing.Point(87, 99);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(69, 26);
            this.lb_email.TabIndex = 39;
            this.lb_email.Text = "Email : ";
            // 
            // cb_gender
            // 
            this.cb_gender.DataSource = this.genderBindingSource;
            this.cb_gender.DisplayMember = "Gender";
            this.cb_gender.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_gender.FormattingEnabled = true;
            this.cb_gender.Location = new System.Drawing.Point(173, 288);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(141, 33);
            this.cb_gender.TabIndex = 38;
            this.cb_gender.ValueMember = "Gender";
            // 
            // genderBindingSource
            // 
            this.genderBindingSource.DataMember = "gender";
            this.genderBindingSource.DataSource = this.wsDataSet;
            // 
            // wsDataSet
            // 
            this.wsDataSet.DataSetName = "wsDataSet";
            this.wsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_lname
            // 
            this.tb_lname.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_lname.Location = new System.Drawing.Point(173, 250);
            this.tb_lname.Name = "tb_lname";
            this.tb_lname.Size = new System.Drawing.Size(160, 33);
            this.tb_lname.TabIndex = 37;
            this.tb_lname.Text = "Фамилия";
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_name.Location = new System.Drawing.Point(173, 212);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(160, 33);
            this.tb_name.TabIndex = 36;
            this.tb_name.Text = "Имя";
            // 
            // tb_rpass
            // 
            this.tb_rpass.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_rpass.Location = new System.Drawing.Point(173, 172);
            this.tb_rpass.Name = "tb_rpass";
            this.tb_rpass.Size = new System.Drawing.Size(160, 33);
            this.tb_rpass.TabIndex = 35;
            this.tb_rpass.Text = "Повторите пароль";
            // 
            // tb_pass
            // 
            this.tb_pass.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_pass.Location = new System.Drawing.Point(173, 134);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(178, 33);
            this.tb_pass.TabIndex = 34;
            this.tb_pass.Text = "Пароль";
            // 
            // tb_mail
            // 
            this.tb_mail.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_mail.Location = new System.Drawing.Point(173, 96);
            this.tb_mail.Name = "tb_mail";
            this.tb_mail.Size = new System.Drawing.Size(203, 33);
            this.tb_mail.TabIndex = 33;
            this.tb_mail.Text = "Email";
            // 
            // labelRegister
            // 
            this.labelRegister.AutoSize = true;
            this.labelRegister.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRegister.Location = new System.Drawing.Point(101, 31);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(489, 26);
            this.labelRegister.TabIndex = 32;
            this.labelRegister.Text = "Пожалуйста заполните всю информацию, чтобы изменть данные.";
            // 
            // buttonCancle
            // 
            this.buttonCancle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonCancle.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancle.Location = new System.Drawing.Point(382, 348);
            this.buttonCancle.Name = "buttonCancle";
            this.buttonCancle.Size = new System.Drawing.Size(122, 37);
            this.buttonCancle.TabIndex = 54;
            this.buttonCancle.Text = "Отмена";
            this.buttonCancle.UseVisualStyleBackColor = false;
            this.buttonCancle.Click += new System.EventHandler(this.buttonCancle_Click);
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonRegister.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegister.Location = new System.Drawing.Point(246, 348);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(130, 37);
            this.buttonRegister.TabIndex = 53;
            this.buttonRegister.Text = "Регистрация";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.bt_reg_Click);
            // 
            // genderTableAdapter
            // 
            this.genderTableAdapter.ClearBeforeFill = true;
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataMember = "country";
            this.countryBindingSource.DataSource = this.wsDataSet;
            // 
            // countryTableAdapter
            // 
            this.countryTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(366, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 26);
            this.label1.TabIndex = 55;
            this.label1.Text = "Страна";
            // 
            // FormRegisterRunner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(748, 394);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancle);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.ib_contry);
            this.Controls.Add(this.lb_dateofbrith);
            this.Controls.Add(this.dtp_data);
            this.Controls.Add(this.cb_country);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.lb_lname);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.lb_rpass);
            this.Controls.Add(this.lb_pass);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.cb_gender);
            this.Controls.Add(this.tb_lname);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_rpass);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_mail);
            this.Controls.Add(this.labelRegister);
            this.Controls.Add(this.panelDesign4);
            this.Controls.Add(this.panelDesign2);
            this.Controls.Add(this.panelDesign3);
            this.Controls.Add(this.panelDesign1);
            this.Name = "FormRegisterRunner";
            this.Text = "Регистрация бегуна";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDesign1;
        private System.Windows.Forms.Panel panelDesign2;
        private System.Windows.Forms.Panel panelDesign4;
        private System.Windows.Forms.Panel panelDesign3;
        private System.Windows.Forms.Label ib_contry;
        private System.Windows.Forms.Label lb_dateofbrith;
        private System.Windows.Forms.DateTimePicker dtp_data;
        private System.Windows.Forms.ComboBox cb_country;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label lb_lname;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_rpass;
        private System.Windows.Forms.Label lb_pass;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.ComboBox cb_gender;
        private System.Windows.Forms.TextBox tb_lname;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_rpass;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.TextBox tb_mail;
        private System.Windows.Forms.Label labelRegister;
        private System.Windows.Forms.Button buttonCancle;
        private System.Windows.Forms.Button buttonRegister;
        private wsDataSet wsDataSet;
        private System.Windows.Forms.BindingSource genderBindingSource;
        private wsDataSetTableAdapters.genderTableAdapter genderTableAdapter;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private wsDataSetTableAdapters.countryTableAdapter countryTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}
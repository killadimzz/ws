namespace ws
{
    partial class FormRunner
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewRunner = new System.Windows.Forms.DataGridView();
            this.runnerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.runnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wsDataSet = new ws.wsDataSet();
            this.textBoxPoisk = new System.Windows.Forms.TextBox();
            this.buttonPoisk = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.runnerTableAdapter = new ws.wsDataSetTableAdapters.runnerTableAdapter();
            this.panelDesign1 = new System.Windows.Forms.Panel();
            this.panelDesign2 = new System.Windows.Forms.Panel();
            this.panelDesign4 = new System.Windows.Forms.Panel();
            this.panelDesign3 = new System.Windows.Forms.Panel();
            this.buttonRegistrRunner = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRunner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.runnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRunner
            // 
            this.dataGridViewRunner.AutoGenerateColumns = false;
            this.dataGridViewRunner.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Mistral", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRunner.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewRunner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRunner.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.runnerIdDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.countryCodeDataGridViewTextBoxColumn});
            this.dataGridViewRunner.DataSource = this.runnerBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Mistral", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRunner.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewRunner.Location = new System.Drawing.Point(167, 99);
            this.dataGridViewRunner.Name = "dataGridViewRunner";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Mistral", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRunner.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewRunner.Size = new System.Drawing.Size(448, 150);
            this.dataGridViewRunner.TabIndex = 0;
            // 
            // runnerIdDataGridViewTextBoxColumn
            // 
            this.runnerIdDataGridViewTextBoxColumn.DataPropertyName = "RunnerId";
            this.runnerIdDataGridViewTextBoxColumn.HeaderText = "ID Бегуна";
            this.runnerIdDataGridViewTextBoxColumn.Name = "runnerIdDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Пол";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            // 
            // countryCodeDataGridViewTextBoxColumn
            // 
            this.countryCodeDataGridViewTextBoxColumn.DataPropertyName = "CountryCode";
            this.countryCodeDataGridViewTextBoxColumn.HeaderText = "Код страны";
            this.countryCodeDataGridViewTextBoxColumn.Name = "countryCodeDataGridViewTextBoxColumn";
            // 
            // runnerBindingSource
            // 
            this.runnerBindingSource.DataMember = "runner";
            this.runnerBindingSource.DataSource = this.wsDataSet;
            // 
            // wsDataSet
            // 
            this.wsDataSet.DataSetName = "wsDataSet";
            this.wsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxPoisk
            // 
            this.textBoxPoisk.Location = new System.Drawing.Point(167, 70);
            this.textBoxPoisk.Name = "textBoxPoisk";
            this.textBoxPoisk.Size = new System.Drawing.Size(277, 20);
            this.textBoxPoisk.TabIndex = 1;
            // 
            // buttonPoisk
            // 
            this.buttonPoisk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonPoisk.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPoisk.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPoisk.Location = new System.Drawing.Point(450, 67);
            this.buttonPoisk.Name = "buttonPoisk";
            this.buttonPoisk.Size = new System.Drawing.Size(75, 23);
            this.buttonPoisk.TabIndex = 2;
            this.buttonPoisk.Text = "Поиск";
            this.buttonPoisk.UseVisualStyleBackColor = false;
            this.buttonPoisk.Click += new System.EventHandler(this.buttonPoisk_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonRefresh.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRefresh.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonRefresh.Location = new System.Drawing.Point(531, 68);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(84, 23);
            this.buttonRefresh.TabIndex = 3;
            this.buttonRefresh.Text = "Обновить";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // runnerTableAdapter
            // 
            this.runnerTableAdapter.ClearBeforeFill = true;
            // 
            // panelDesign1
            // 
            this.panelDesign1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelDesign1.Location = new System.Drawing.Point(1, 2);
            this.panelDesign1.Name = "panelDesign1";
            this.panelDesign1.Size = new System.Drawing.Size(55, 379);
            this.panelDesign1.TabIndex = 7;
            // 
            // panelDesign2
            // 
            this.panelDesign2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelDesign2.Location = new System.Drawing.Point(106, 2);
            this.panelDesign2.Name = "panelDesign2";
            this.panelDesign2.Size = new System.Drawing.Size(55, 379);
            this.panelDesign2.TabIndex = 8;
            // 
            // panelDesign4
            // 
            this.panelDesign4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelDesign4.Location = new System.Drawing.Point(728, 2);
            this.panelDesign4.Name = "panelDesign4";
            this.panelDesign4.Size = new System.Drawing.Size(55, 379);
            this.panelDesign4.TabIndex = 9;
            // 
            // panelDesign3
            // 
            this.panelDesign3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelDesign3.Location = new System.Drawing.Point(621, 2);
            this.panelDesign3.Name = "panelDesign3";
            this.panelDesign3.Size = new System.Drawing.Size(55, 379);
            this.panelDesign3.TabIndex = 8;
            // 
            // buttonRegistrRunner
            // 
            this.buttonRegistrRunner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonRegistrRunner.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegistrRunner.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonRegistrRunner.Location = new System.Drawing.Point(325, 255);
            this.buttonRegistrRunner.Name = "buttonRegistrRunner";
            this.buttonRegistrRunner.Size = new System.Drawing.Size(189, 28);
            this.buttonRegistrRunner.TabIndex = 10;
            this.buttonRegistrRunner.Text = "Регистрация бегуна";
            this.buttonRegistrRunner.UseVisualStyleBackColor = false;
            this.buttonRegistrRunner.Click += new System.EventHandler(this.buttonIzmenenieDannych_Click);
            // 
            // FormRunner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(784, 363);
            this.Controls.Add(this.buttonRegistrRunner);
            this.Controls.Add(this.panelDesign4);
            this.Controls.Add(this.panelDesign1);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonPoisk);
            this.Controls.Add(this.textBoxPoisk);
            this.Controls.Add(this.dataGridViewRunner);
            this.Controls.Add(this.panelDesign2);
            this.Controls.Add(this.panelDesign3);
            this.Name = "FormRunner";
            this.Text = "Бегун";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRunner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.runnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRunner;
        private wsDataSet wsDataSet;
        private System.Windows.Forms.TextBox textBoxPoisk;
        private System.Windows.Forms.Button buttonPoisk;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.BindingSource runnerBindingSource;
        private wsDataSetTableAdapters.runnerTableAdapter runnerTableAdapter;
        private System.Windows.Forms.Panel panelDesign1;
        private System.Windows.Forms.Panel panelDesign2;
        private System.Windows.Forms.Panel panelDesign4;
        private System.Windows.Forms.Panel panelDesign3;
        private System.Windows.Forms.DataGridViewTextBoxColumn runnerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonRegistrRunner;
    }
}
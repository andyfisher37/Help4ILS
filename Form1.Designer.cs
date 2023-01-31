
namespace Help4ILS
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.conn_text = new System.Windows.Forms.TextBox();
            this.check_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.fAMILIYADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMYADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oTCHECTVODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAROZDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kEY1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getList4ILSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iASDataSet = new Help4ILS.IASDataSet();
            this.getList4ILSTableAdapter = new Help4ILS.IASDataSetTableAdapters.getList4ILSTableAdapter();
            this.get_data_button = new System.Windows.Forms.Button();
            this.make_list_button1 = new System.Windows.Forms.Button();
            this.make_list_button2 = new System.Windows.Forms.Button();
            this.make_list_button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.gridView2 = new System.Windows.Forms.DataGridView();
            this.fAMILIYADataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMYADataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oTCHECTVODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAROZDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bORNPLACEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lEAVPLACEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTREETDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hOUSEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fLATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getList4ICBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iASDataSet1 = new Help4ILS.IASDataSet1();
            this.getList4ICTableAdapter = new Help4ILS.IASDataSet1TableAdapters.getList4ICTableAdapter();
            this.convert_button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.progress = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getList4ILSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iASDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getList4ICBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iASDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // conn_text
            // 
            this.conn_text.Enabled = false;
            this.conn_text.Location = new System.Drawing.Point(12, 22);
            this.conn_text.Name = "conn_text";
            this.conn_text.Size = new System.Drawing.Size(544, 20);
            this.conn_text.TabIndex = 0;
            this.conn_text.Text = "Data Source=urls_server;Initial Catalog=IAS;Persist Security Info=True;User ID=sa" +
    ";Password=rkthbr";
            // 
            // check_button
            // 
            this.check_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.check_button.Location = new System.Drawing.Point(579, 20);
            this.check_button.Name = "check_button";
            this.check_button.Size = new System.Drawing.Size(201, 23);
            this.check_button.TabIndex = 1;
            this.check_button.Text = "Проверить...";
            this.check_button.UseVisualStyleBackColor = false;
            this.check_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Проверка соединения с БД КАДРЫ:";
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToDeleteRows = false;
            this.gridView.AutoGenerateColumns = false;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fAMILIYADataGridViewTextBoxColumn,
            this.iMYADataGridViewTextBoxColumn,
            this.oTCHECTVODataGridViewTextBoxColumn,
            this.dATAROZDDataGridViewTextBoxColumn,
            this.kEY1DataGridViewTextBoxColumn});
            this.gridView.DataSource = this.getList4ILSBindingSource;
            this.gridView.Location = new System.Drawing.Point(13, 48);
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.Size = new System.Drawing.Size(543, 118);
            this.gridView.TabIndex = 3;
            // 
            // fAMILIYADataGridViewTextBoxColumn
            // 
            this.fAMILIYADataGridViewTextBoxColumn.DataPropertyName = "FAMILIYA";
            this.fAMILIYADataGridViewTextBoxColumn.HeaderText = "FAMILIYA";
            this.fAMILIYADataGridViewTextBoxColumn.Name = "fAMILIYADataGridViewTextBoxColumn";
            this.fAMILIYADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iMYADataGridViewTextBoxColumn
            // 
            this.iMYADataGridViewTextBoxColumn.DataPropertyName = "IMYA";
            this.iMYADataGridViewTextBoxColumn.HeaderText = "IMYA";
            this.iMYADataGridViewTextBoxColumn.Name = "iMYADataGridViewTextBoxColumn";
            this.iMYADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oTCHECTVODataGridViewTextBoxColumn
            // 
            this.oTCHECTVODataGridViewTextBoxColumn.DataPropertyName = "OTCHECTVO";
            this.oTCHECTVODataGridViewTextBoxColumn.HeaderText = "OTCHECTVO";
            this.oTCHECTVODataGridViewTextBoxColumn.Name = "oTCHECTVODataGridViewTextBoxColumn";
            this.oTCHECTVODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATAROZDDataGridViewTextBoxColumn
            // 
            this.dATAROZDDataGridViewTextBoxColumn.DataPropertyName = "DATA_ROZD";
            this.dATAROZDDataGridViewTextBoxColumn.HeaderText = "DATA_ROZD";
            this.dATAROZDDataGridViewTextBoxColumn.Name = "dATAROZDDataGridViewTextBoxColumn";
            this.dATAROZDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kEY1DataGridViewTextBoxColumn
            // 
            this.kEY1DataGridViewTextBoxColumn.DataPropertyName = "KEY_1";
            this.kEY1DataGridViewTextBoxColumn.HeaderText = "KEY_1";
            this.kEY1DataGridViewTextBoxColumn.Name = "kEY1DataGridViewTextBoxColumn";
            this.kEY1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getList4ILSBindingSource
            // 
            this.getList4ILSBindingSource.DataMember = "getList4ILS";
            this.getList4ILSBindingSource.DataSource = this.iASDataSet;
            // 
            // iASDataSet
            // 
            this.iASDataSet.DataSetName = "IASDataSet";
            this.iASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getList4ILSTableAdapter
            // 
            this.getList4ILSTableAdapter.ClearBeforeFill = true;
            // 
            // get_data_button
            // 
            this.get_data_button.Enabled = false;
            this.get_data_button.Location = new System.Drawing.Point(579, 49);
            this.get_data_button.Name = "get_data_button";
            this.get_data_button.Size = new System.Drawing.Size(201, 23);
            this.get_data_button.TabIndex = 4;
            this.get_data_button.Text = "Выбрать данные для списков";
            this.get_data_button.UseVisualStyleBackColor = true;
            this.get_data_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // make_list_button1
            // 
            this.make_list_button1.Enabled = false;
            this.make_list_button1.Location = new System.Drawing.Point(579, 78);
            this.make_list_button1.Name = "make_list_button1";
            this.make_list_button1.Size = new System.Drawing.Size(201, 42);
            this.make_list_button1.TabIndex = 5;
            this.make_list_button1.Text = "Сформировать список для проверки в ЦАФАП";
            this.make_list_button1.UseVisualStyleBackColor = true;
            this.make_list_button1.Click += new System.EventHandler(this.make_list_button1_Click);
            // 
            // make_list_button2
            // 
            this.make_list_button2.Enabled = false;
            this.make_list_button2.Location = new System.Drawing.Point(579, 127);
            this.make_list_button2.Name = "make_list_button2";
            this.make_list_button2.Size = new System.Drawing.Size(201, 39);
            this.make_list_button2.TabIndex = 6;
            this.make_list_button2.Text = "Сформировать список (TXT) для проверки по ФИС ГИБДД";
            this.make_list_button2.UseVisualStyleBackColor = true;
            this.make_list_button2.Click += new System.EventHandler(this.make_list_button2_Click);
            // 
            // make_list_button3
            // 
            this.make_list_button3.Enabled = false;
            this.make_list_button3.Location = new System.Drawing.Point(579, 193);
            this.make_list_button3.Name = "make_list_button3";
            this.make_list_button3.Size = new System.Drawing.Size(201, 35);
            this.make_list_button3.TabIndex = 7;
            this.make_list_button3.Text = "Сформировать список для проверки по учетам ИЦ";
            this.make_list_button3.UseVisualStyleBackColor = true;
            this.make_list_button3.Click += new System.EventHandler(this.make_list_button3_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(579, 341);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(201, 33);
            this.button6.TabIndex = 8;
            this.button6.Text = "В ы х о д";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(560, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "1.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(560, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "2.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(560, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "3.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(560, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "4.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(560, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "5.";
            // 
            // folderBrowser
            // 
            this.folderBrowser.Description = "Выберите папку для сохранения результата";
            // 
            // gridView2
            // 
            this.gridView2.AllowUserToAddRows = false;
            this.gridView2.AllowUserToDeleteRows = false;
            this.gridView2.AutoGenerateColumns = false;
            this.gridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fAMILIYADataGridViewTextBoxColumn1,
            this.iMYADataGridViewTextBoxColumn1,
            this.oTCHECTVODataGridViewTextBoxColumn1,
            this.dATAROZDDataGridViewTextBoxColumn1,
            this.bORNPLACEDataGridViewTextBoxColumn,
            this.lEAVPLACEDataGridViewTextBoxColumn,
            this.sTREETDataGridViewTextBoxColumn,
            this.hOUSEDataGridViewTextBoxColumn,
            this.fLATDataGridViewTextBoxColumn});
            this.gridView2.DataSource = this.getList4ICBindingSource;
            this.gridView2.Location = new System.Drawing.Point(12, 193);
            this.gridView2.Name = "gridView2";
            this.gridView2.ReadOnly = true;
            this.gridView2.Size = new System.Drawing.Size(542, 150);
            this.gridView2.TabIndex = 14;
            // 
            // fAMILIYADataGridViewTextBoxColumn1
            // 
            this.fAMILIYADataGridViewTextBoxColumn1.DataPropertyName = "FAMILIYA";
            this.fAMILIYADataGridViewTextBoxColumn1.HeaderText = "FAMILIYA";
            this.fAMILIYADataGridViewTextBoxColumn1.Name = "fAMILIYADataGridViewTextBoxColumn1";
            this.fAMILIYADataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // iMYADataGridViewTextBoxColumn1
            // 
            this.iMYADataGridViewTextBoxColumn1.DataPropertyName = "IMYA";
            this.iMYADataGridViewTextBoxColumn1.HeaderText = "IMYA";
            this.iMYADataGridViewTextBoxColumn1.Name = "iMYADataGridViewTextBoxColumn1";
            this.iMYADataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // oTCHECTVODataGridViewTextBoxColumn1
            // 
            this.oTCHECTVODataGridViewTextBoxColumn1.DataPropertyName = "OTCHECTVO";
            this.oTCHECTVODataGridViewTextBoxColumn1.HeaderText = "OTCHECTVO";
            this.oTCHECTVODataGridViewTextBoxColumn1.Name = "oTCHECTVODataGridViewTextBoxColumn1";
            this.oTCHECTVODataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dATAROZDDataGridViewTextBoxColumn1
            // 
            this.dATAROZDDataGridViewTextBoxColumn1.DataPropertyName = "DATA_ROZD";
            this.dATAROZDDataGridViewTextBoxColumn1.HeaderText = "DATA_ROZD";
            this.dATAROZDDataGridViewTextBoxColumn1.Name = "dATAROZDDataGridViewTextBoxColumn1";
            this.dATAROZDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bORNPLACEDataGridViewTextBoxColumn
            // 
            this.bORNPLACEDataGridViewTextBoxColumn.DataPropertyName = "BORN_PLACE";
            this.bORNPLACEDataGridViewTextBoxColumn.HeaderText = "BORN_PLACE";
            this.bORNPLACEDataGridViewTextBoxColumn.Name = "bORNPLACEDataGridViewTextBoxColumn";
            this.bORNPLACEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lEAVPLACEDataGridViewTextBoxColumn
            // 
            this.lEAVPLACEDataGridViewTextBoxColumn.DataPropertyName = "LEAV_PLACE";
            this.lEAVPLACEDataGridViewTextBoxColumn.HeaderText = "LEAV_PLACE";
            this.lEAVPLACEDataGridViewTextBoxColumn.Name = "lEAVPLACEDataGridViewTextBoxColumn";
            this.lEAVPLACEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTREETDataGridViewTextBoxColumn
            // 
            this.sTREETDataGridViewTextBoxColumn.DataPropertyName = "STREET";
            this.sTREETDataGridViewTextBoxColumn.HeaderText = "STREET";
            this.sTREETDataGridViewTextBoxColumn.Name = "sTREETDataGridViewTextBoxColumn";
            this.sTREETDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hOUSEDataGridViewTextBoxColumn
            // 
            this.hOUSEDataGridViewTextBoxColumn.DataPropertyName = "HOUSE";
            this.hOUSEDataGridViewTextBoxColumn.HeaderText = "HOUSE";
            this.hOUSEDataGridViewTextBoxColumn.Name = "hOUSEDataGridViewTextBoxColumn";
            this.hOUSEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fLATDataGridViewTextBoxColumn
            // 
            this.fLATDataGridViewTextBoxColumn.DataPropertyName = "FLAT";
            this.fLATDataGridViewTextBoxColumn.HeaderText = "FLAT";
            this.fLATDataGridViewTextBoxColumn.Name = "fLATDataGridViewTextBoxColumn";
            this.fLATDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getList4ICBindingSource
            // 
            this.getList4ICBindingSource.DataMember = "getList4IC";
            this.getList4ICBindingSource.DataSource = this.iASDataSet1;
            // 
            // iASDataSet1
            // 
            this.iASDataSet1.DataSetName = "IASDataSet1";
            this.iASDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getList4ICTableAdapter
            // 
            this.getList4ICTableAdapter.ClearBeforeFill = true;
            // 
            // convert_button
            // 
            this.convert_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.convert_button.Location = new System.Drawing.Point(579, 246);
            this.convert_button.Name = "convert_button";
            this.convert_button.Size = new System.Drawing.Size(201, 37);
            this.convert_button.TabIndex = 15;
            this.convert_button.Text = "Обработка ответа ЦАФАП";
            this.convert_button.UseVisualStyleBackColor = false;
            this.convert_button.Click += new System.EventHandler(this.convert_button_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(560, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "6.";
            // 
            // openFile
            // 
            this.openFile.Title = "Выберите файл ответа ЦАФАП";
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(12, 364);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(542, 10);
            this.progress.Step = 1;
            this.progress.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 384);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.convert_button);
            this.Controls.Add(this.gridView2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.make_list_button3);
            this.Controls.Add(this.make_list_button2);
            this.Controls.Add(this.make_list_button1);
            this.Controls.Add(this.get_data_button);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.check_button);
            this.Controls.Add(this.conn_text);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Формирование и обработка списков для ИЛС";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getList4ILSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iASDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getList4ICBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iASDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox conn_text;
        private System.Windows.Forms.Button check_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridView;
        private IASDataSet iASDataSet;
        private System.Windows.Forms.BindingSource getList4ILSBindingSource;
        private IASDataSetTableAdapters.getList4ILSTableAdapter getList4ILSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fAMILIYADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMYADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oTCHECTVODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAROZDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kEY1DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button get_data_button;
        private System.Windows.Forms.Button make_list_button1;
        private System.Windows.Forms.Button make_list_button2;
        private System.Windows.Forms.Button make_list_button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.DataGridView gridView2;
        private IASDataSet1 iASDataSet1;
        private System.Windows.Forms.BindingSource getList4ICBindingSource;
        private IASDataSet1TableAdapters.getList4ICTableAdapter getList4ICTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fAMILIYADataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMYADataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn oTCHECTVODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAROZDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bORNPLACEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lEAVPLACEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTREETDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hOUSEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fLATDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button convert_button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.ProgressBar progress;
    }
}


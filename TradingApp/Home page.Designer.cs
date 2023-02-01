namespace TradingApp
{
    partial class Form2
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
            this.roleTC = new System.Windows.Forms.TabControl();
            this.productsTP = new System.Windows.Forms.TabPage();
            this.addButt = new System.Windows.Forms.Button();
            this.delButt = new System.Windows.Forms.Button();
            this.changeButt = new System.Windows.Forms.Button();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.артикулТовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.единицаИзмеренияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.розничнаяЦенаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.товарыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tradingUPDataSet = new TradingApp.TradingUPDataSet();
            this.ordersTP = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.delButt2 = new System.Windows.Forms.Button();
            this.addButt2 = new System.Windows.Forms.Button();
            this.changeButt2 = new System.Windows.Forms.Button();
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОЗаведующегоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.объемРеализацииВДеньDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отделыViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.versionsTP = new System.Windows.Forms.TabPage();
            this.orderL = new System.Windows.Forms.Label();
            this.staffL = new System.Windows.Forms.Label();
            this.addButt4 = new System.Windows.Forms.Button();
            this.versionsDataGridView = new System.Windows.Forms.DataGridView();
            this.артикулТовараDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отделDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаПродажиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.продажиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.delButt4 = new System.Windows.Forms.Button();
            this.changeButt4 = new System.Windows.Forms.Button();
            this.staffTP = new System.Windows.Forms.TabPage();
            this.addButt3 = new System.Windows.Forms.Button();
            this.delButt3 = new System.Windows.Forms.Button();
            this.changeButt3 = new System.Windows.Forms.Button();
            this.staffDataGridView = new System.Windows.Forms.DataGridView();
            this.логинDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.парольDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exitBtn = new System.Windows.Forms.Button();
            this.roleL = new System.Windows.Forms.Label();
            this.nameL = new System.Windows.Forms.Label();
            this.defRoleL = new System.Windows.Forms.Label();
            this.defNameL = new System.Windows.Forms.Label();
            this.товарыTableAdapter = new TradingApp.TradingUPDataSetTableAdapters.ТоварыTableAdapter();
            this.отделыViewTableAdapter = new TradingApp.TradingUPDataSetTableAdapters.ОтделыViewTableAdapter();
            this.продажиTableAdapter = new TradingApp.TradingUPDataSetTableAdapters.ПродажиTableAdapter();
            this.сотрудникиTableAdapter = new TradingApp.TradingUPDataSetTableAdapters.СотрудникиTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.roleTC.SuspendLayout();
            this.productsTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradingUPDataSet)).BeginInit();
            this.ordersTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отделыViewBindingSource)).BeginInit();
            this.versionsTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.versionsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продажиBindingSource)).BeginInit();
            this.staffTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // roleTC
            // 
            this.roleTC.Controls.Add(this.productsTP);
            this.roleTC.Controls.Add(this.ordersTP);
            this.roleTC.Controls.Add(this.versionsTP);
            this.roleTC.Controls.Add(this.staffTP);
            this.roleTC.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roleTC.Location = new System.Drawing.Point(12, 101);
            this.roleTC.Name = "roleTC";
            this.roleTC.SelectedIndex = 0;
            this.roleTC.Size = new System.Drawing.Size(776, 333);
            this.roleTC.TabIndex = 38;
            // 
            // productsTP
            // 
            this.productsTP.Controls.Add(this.addButt);
            this.productsTP.Controls.Add(this.delButt);
            this.productsTP.Controls.Add(this.changeButt);
            this.productsTP.Controls.Add(this.productsDataGridView);
            this.productsTP.Location = new System.Drawing.Point(4, 24);
            this.productsTP.Name = "productsTP";
            this.productsTP.Padding = new System.Windows.Forms.Padding(3);
            this.productsTP.Size = new System.Drawing.Size(768, 305);
            this.productsTP.TabIndex = 0;
            this.productsTP.Text = "Товары";
            this.productsTP.UseVisualStyleBackColor = true;
            // 
            // addButt
            // 
            this.addButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.addButt.Location = new System.Drawing.Point(662, 6);
            this.addButt.Margin = new System.Windows.Forms.Padding(2);
            this.addButt.Name = "addButt";
            this.addButt.Size = new System.Drawing.Size(104, 37);
            this.addButt.TabIndex = 13;
            this.addButt.Text = "Добавить запись";
            this.addButt.UseVisualStyleBackColor = false;
            this.addButt.Click += new System.EventHandler(this.addButt_Click);
            // 
            // delButt
            // 
            this.delButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.delButt.Location = new System.Drawing.Point(661, 90);
            this.delButt.Margin = new System.Windows.Forms.Padding(2);
            this.delButt.Name = "delButt";
            this.delButt.Size = new System.Drawing.Size(104, 37);
            this.delButt.TabIndex = 14;
            this.delButt.Text = "Удалить запись";
            this.delButt.UseVisualStyleBackColor = false;
            this.delButt.Click += new System.EventHandler(this.delButt_Click);
            // 
            // changeButt
            // 
            this.changeButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.changeButt.Location = new System.Drawing.Point(661, 48);
            this.changeButt.Name = "changeButt";
            this.changeButt.Size = new System.Drawing.Size(104, 37);
            this.changeButt.TabIndex = 15;
            this.changeButt.Text = "Изменить запись";
            this.changeButt.UseVisualStyleBackColor = false;
            this.changeButt.Click += new System.EventHandler(this.changeButt_Click);
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AutoGenerateColumns = false;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.артикулТовараDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.единицаИзмеренияDataGridViewTextBoxColumn,
            this.розничнаяЦенаDataGridViewTextBoxColumn});
            this.productsDataGridView.DataSource = this.товарыBindingSource;
            this.productsDataGridView.Location = new System.Drawing.Point(6, 6);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.Size = new System.Drawing.Size(449, 293);
            this.productsDataGridView.TabIndex = 0;
            // 
            // артикулТовараDataGridViewTextBoxColumn
            // 
            this.артикулТовараDataGridViewTextBoxColumn.DataPropertyName = "Артикул товара";
            this.артикулТовараDataGridViewTextBoxColumn.HeaderText = "Артикул товара";
            this.артикулТовараDataGridViewTextBoxColumn.Name = "артикулТовараDataGridViewTextBoxColumn";
            this.артикулТовараDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            // 
            // единицаИзмеренияDataGridViewTextBoxColumn
            // 
            this.единицаИзмеренияDataGridViewTextBoxColumn.DataPropertyName = "Единица измерения";
            this.единицаИзмеренияDataGridViewTextBoxColumn.HeaderText = "Единица измерения";
            this.единицаИзмеренияDataGridViewTextBoxColumn.Name = "единицаИзмеренияDataGridViewTextBoxColumn";
            // 
            // розничнаяЦенаDataGridViewTextBoxColumn
            // 
            this.розничнаяЦенаDataGridViewTextBoxColumn.DataPropertyName = "Розничная цена";
            this.розничнаяЦенаDataGridViewTextBoxColumn.HeaderText = "Розничная цена";
            this.розничнаяЦенаDataGridViewTextBoxColumn.Name = "розничнаяЦенаDataGridViewTextBoxColumn";
            // 
            // товарыBindingSource
            // 
            this.товарыBindingSource.DataMember = "Товары";
            this.товарыBindingSource.DataSource = this.tradingUPDataSet;
            // 
            // tradingUPDataSet
            // 
            this.tradingUPDataSet.DataSetName = "TradingUPDataSet";
            this.tradingUPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTP
            // 
            this.ordersTP.Controls.Add(this.label1);
            this.ordersTP.Controls.Add(this.delButt2);
            this.ordersTP.Controls.Add(this.addButt2);
            this.ordersTP.Controls.Add(this.changeButt2);
            this.ordersTP.Controls.Add(this.ordersDataGridView);
            this.ordersTP.Location = new System.Drawing.Point(4, 24);
            this.ordersTP.Name = "ordersTP";
            this.ordersTP.Padding = new System.Windows.Forms.Padding(3);
            this.ordersTP.Size = new System.Drawing.Size(768, 305);
            this.ordersTP.TabIndex = 1;
            this.ordersTP.Text = "Отделы";
            this.ordersTP.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(556, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 45);
            this.label1.TabIndex = 20;
            this.label1.Text = "При добавлении и изменении \r\nв колонке ФИО заведующего укажите \r\nлогин сотрудника" +
    "\r\n";
            // 
            // delButt2
            // 
            this.delButt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.delButt2.Location = new System.Drawing.Point(658, 89);
            this.delButt2.Margin = new System.Windows.Forms.Padding(2);
            this.delButt2.Name = "delButt2";
            this.delButt2.Size = new System.Drawing.Size(104, 37);
            this.delButt2.TabIndex = 19;
            this.delButt2.Text = "Удалить запись";
            this.delButt2.UseVisualStyleBackColor = false;
            this.delButt2.Click += new System.EventHandler(this.delButt2_Click);
            // 
            // addButt2
            // 
            this.addButt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.addButt2.Location = new System.Drawing.Point(659, 5);
            this.addButt2.Margin = new System.Windows.Forms.Padding(2);
            this.addButt2.Name = "addButt2";
            this.addButt2.Size = new System.Drawing.Size(104, 37);
            this.addButt2.TabIndex = 16;
            this.addButt2.Text = "Добавить запись";
            this.addButt2.UseVisualStyleBackColor = false;
            this.addButt2.Click += new System.EventHandler(this.addButt2_Click);
            // 
            // changeButt2
            // 
            this.changeButt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.changeButt2.Location = new System.Drawing.Point(658, 47);
            this.changeButt2.Name = "changeButt2";
            this.changeButt2.Size = new System.Drawing.Size(104, 37);
            this.changeButt2.TabIndex = 18;
            this.changeButt2.Text = "Изменить запись";
            this.changeButt2.UseVisualStyleBackColor = false;
            this.changeButt2.Click += new System.EventHandler(this.changeButt2_Click);
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.AutoGenerateColumns = false;
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn1,
            this.фИОЗаведующегоDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn,
            this.объемРеализацииВДеньDataGridViewTextBoxColumn});
            this.ordersDataGridView.DataSource = this.отделыViewBindingSource;
            this.ordersDataGridView.Location = new System.Drawing.Point(6, 6);
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.Size = new System.Drawing.Size(544, 293);
            this.ordersDataGridView.TabIndex = 0;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            // 
            // наименованиеDataGridViewTextBoxColumn1
            // 
            this.наименованиеDataGridViewTextBoxColumn1.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn1.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn1.Name = "наименованиеDataGridViewTextBoxColumn1";
            // 
            // фИОЗаведующегоDataGridViewTextBoxColumn
            // 
            this.фИОЗаведующегоDataGridViewTextBoxColumn.DataPropertyName = "ФИО заведующего";
            this.фИОЗаведующегоDataGridViewTextBoxColumn.HeaderText = "ФИО заведующего";
            this.фИОЗаведующегоDataGridViewTextBoxColumn.Name = "фИОЗаведующегоDataGridViewTextBoxColumn";
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            // 
            // объемРеализацииВДеньDataGridViewTextBoxColumn
            // 
            this.объемРеализацииВДеньDataGridViewTextBoxColumn.DataPropertyName = "Объем реализации в день";
            this.объемРеализацииВДеньDataGridViewTextBoxColumn.HeaderText = "Объем реализации в день";
            this.объемРеализацииВДеньDataGridViewTextBoxColumn.Name = "объемРеализацииВДеньDataGridViewTextBoxColumn";
            // 
            // отделыViewBindingSource
            // 
            this.отделыViewBindingSource.DataMember = "ОтделыView";
            this.отделыViewBindingSource.DataSource = this.tradingUPDataSet;
            // 
            // versionsTP
            // 
            this.versionsTP.Controls.Add(this.button1);
            this.versionsTP.Controls.Add(this.orderL);
            this.versionsTP.Controls.Add(this.staffL);
            this.versionsTP.Controls.Add(this.addButt4);
            this.versionsTP.Controls.Add(this.versionsDataGridView);
            this.versionsTP.Controls.Add(this.delButt4);
            this.versionsTP.Controls.Add(this.changeButt4);
            this.versionsTP.Location = new System.Drawing.Point(4, 24);
            this.versionsTP.Name = "versionsTP";
            this.versionsTP.Size = new System.Drawing.Size(768, 305);
            this.versionsTP.TabIndex = 2;
            this.versionsTP.Text = "Продажи";
            this.versionsTP.UseVisualStyleBackColor = true;
            // 
            // orderL
            // 
            this.orderL.AutoSize = true;
            this.orderL.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderL.ForeColor = System.Drawing.Color.Black;
            this.orderL.Location = new System.Drawing.Point(452, 179);
            this.orderL.Name = "orderL";
            this.orderL.Size = new System.Drawing.Size(48, 18);
            this.orderL.TabIndex = 23;
            this.orderL.Text = "<name>";
            this.orderL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // staffL
            // 
            this.staffL.AutoSize = true;
            this.staffL.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.staffL.ForeColor = System.Drawing.Color.Black;
            this.staffL.Location = new System.Drawing.Point(452, 45);
            this.staffL.Name = "staffL";
            this.staffL.Size = new System.Drawing.Size(48, 18);
            this.staffL.TabIndex = 22;
            this.staffL.Text = "<name>";
            this.staffL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addButt4
            // 
            this.addButt4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.addButt4.Location = new System.Drawing.Point(662, 3);
            this.addButt4.Margin = new System.Windows.Forms.Padding(2);
            this.addButt4.Name = "addButt4";
            this.addButt4.Size = new System.Drawing.Size(104, 37);
            this.addButt4.TabIndex = 16;
            this.addButt4.Text = "Добавить запись";
            this.addButt4.UseVisualStyleBackColor = false;
            this.addButt4.Click += new System.EventHandler(this.addButt4_Click);
            // 
            // versionsDataGridView
            // 
            this.versionsDataGridView.AutoGenerateColumns = false;
            this.versionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.versionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.артикулТовараDataGridViewTextBoxColumn1,
            this.отделDataGridViewTextBoxColumn,
            this.датаПродажиDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn});
            this.versionsDataGridView.DataSource = this.продажиBindingSource;
            this.versionsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.versionsDataGridView.Name = "versionsDataGridView";
            this.versionsDataGridView.Size = new System.Drawing.Size(443, 299);
            this.versionsDataGridView.TabIndex = 0;
            this.versionsDataGridView.Click += new System.EventHandler(this.versionsDataGridView_Click);
            // 
            // артикулТовараDataGridViewTextBoxColumn1
            // 
            this.артикулТовараDataGridViewTextBoxColumn1.DataPropertyName = "Артикул товара";
            this.артикулТовараDataGridViewTextBoxColumn1.HeaderText = "Артикул товара";
            this.артикулТовараDataGridViewTextBoxColumn1.Name = "артикулТовараDataGridViewTextBoxColumn1";
            // 
            // отделDataGridViewTextBoxColumn
            // 
            this.отделDataGridViewTextBoxColumn.DataPropertyName = "Отдел";
            this.отделDataGridViewTextBoxColumn.HeaderText = "Отдел";
            this.отделDataGridViewTextBoxColumn.Name = "отделDataGridViewTextBoxColumn";
            // 
            // датаПродажиDataGridViewTextBoxColumn
            // 
            this.датаПродажиDataGridViewTextBoxColumn.DataPropertyName = "Дата продажи";
            this.датаПродажиDataGridViewTextBoxColumn.HeaderText = "Дата продажи";
            this.датаПродажиDataGridViewTextBoxColumn.Name = "датаПродажиDataGridViewTextBoxColumn";
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            // 
            // продажиBindingSource
            // 
            this.продажиBindingSource.DataMember = "Продажи";
            this.продажиBindingSource.DataSource = this.tradingUPDataSet;
            // 
            // delButt4
            // 
            this.delButt4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.delButt4.Location = new System.Drawing.Point(661, 87);
            this.delButt4.Margin = new System.Windows.Forms.Padding(2);
            this.delButt4.Name = "delButt4";
            this.delButt4.Size = new System.Drawing.Size(104, 37);
            this.delButt4.TabIndex = 17;
            this.delButt4.Text = "Удалить запись";
            this.delButt4.UseVisualStyleBackColor = false;
            this.delButt4.Click += new System.EventHandler(this.delButt4_Click);
            // 
            // changeButt4
            // 
            this.changeButt4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.changeButt4.Location = new System.Drawing.Point(661, 45);
            this.changeButt4.Name = "changeButt4";
            this.changeButt4.Size = new System.Drawing.Size(104, 37);
            this.changeButt4.TabIndex = 18;
            this.changeButt4.Text = "Изменить запись";
            this.changeButt4.UseVisualStyleBackColor = false;
            this.changeButt4.Click += new System.EventHandler(this.changeButt4_Click);
            // 
            // staffTP
            // 
            this.staffTP.Controls.Add(this.addButt3);
            this.staffTP.Controls.Add(this.delButt3);
            this.staffTP.Controls.Add(this.changeButt3);
            this.staffTP.Controls.Add(this.staffDataGridView);
            this.staffTP.Location = new System.Drawing.Point(4, 24);
            this.staffTP.Name = "staffTP";
            this.staffTP.Size = new System.Drawing.Size(768, 305);
            this.staffTP.TabIndex = 3;
            this.staffTP.Text = "Сотрудники";
            this.staffTP.UseVisualStyleBackColor = true;
            // 
            // addButt3
            // 
            this.addButt3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.addButt3.Location = new System.Drawing.Point(662, 2);
            this.addButt3.Margin = new System.Windows.Forms.Padding(2);
            this.addButt3.Name = "addButt3";
            this.addButt3.Size = new System.Drawing.Size(104, 37);
            this.addButt3.TabIndex = 16;
            this.addButt3.Text = "Добавить запись";
            this.addButt3.UseVisualStyleBackColor = false;
            this.addButt3.Click += new System.EventHandler(this.addButt3_Click);
            // 
            // delButt3
            // 
            this.delButt3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.delButt3.Location = new System.Drawing.Point(661, 86);
            this.delButt3.Margin = new System.Windows.Forms.Padding(2);
            this.delButt3.Name = "delButt3";
            this.delButt3.Size = new System.Drawing.Size(104, 37);
            this.delButt3.TabIndex = 17;
            this.delButt3.Text = "Удалить запись";
            this.delButt3.UseVisualStyleBackColor = false;
            this.delButt3.Click += new System.EventHandler(this.delButt3_Click);
            // 
            // changeButt3
            // 
            this.changeButt3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.changeButt3.Location = new System.Drawing.Point(661, 44);
            this.changeButt3.Name = "changeButt3";
            this.changeButt3.Size = new System.Drawing.Size(104, 37);
            this.changeButt3.TabIndex = 18;
            this.changeButt3.Text = "Изменить запись";
            this.changeButt3.UseVisualStyleBackColor = false;
            this.changeButt3.Click += new System.EventHandler(this.changeButt3_Click);
            // 
            // staffDataGridView
            // 
            this.staffDataGridView.AutoGenerateColumns = false;
            this.staffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.логинDataGridViewTextBoxColumn,
            this.парольDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn});
            this.staffDataGridView.DataSource = this.сотрудникиBindingSource;
            this.staffDataGridView.Location = new System.Drawing.Point(3, 3);
            this.staffDataGridView.Name = "staffDataGridView";
            this.staffDataGridView.Size = new System.Drawing.Size(543, 299);
            this.staffDataGridView.TabIndex = 0;
            // 
            // логинDataGridViewTextBoxColumn
            // 
            this.логинDataGridViewTextBoxColumn.DataPropertyName = "Логин";
            this.логинDataGridViewTextBoxColumn.HeaderText = "Логин";
            this.логинDataGridViewTextBoxColumn.Name = "логинDataGridViewTextBoxColumn";
            // 
            // парольDataGridViewTextBoxColumn
            // 
            this.парольDataGridViewTextBoxColumn.DataPropertyName = "Пароль";
            this.парольDataGridViewTextBoxColumn.HeaderText = "Пароль";
            this.парольDataGridViewTextBoxColumn.Name = "парольDataGridViewTextBoxColumn";
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            // 
            // должностьDataGridViewTextBoxColumn
            // 
            this.должностьDataGridViewTextBoxColumn.DataPropertyName = "Должность";
            this.должностьDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.должностьDataGridViewTextBoxColumn.Name = "должностьDataGridViewTextBoxColumn";
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.tradingUPDataSet;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.exitBtn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitBtn.ForeColor = System.Drawing.Color.Black;
            this.exitBtn.Location = new System.Drawing.Point(729, 16);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(61, 35);
            this.exitBtn.TabIndex = 37;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // roleL
            // 
            this.roleL.AutoSize = true;
            this.roleL.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roleL.ForeColor = System.Drawing.Color.Black;
            this.roleL.Location = new System.Drawing.Point(64, 55);
            this.roleL.Name = "roleL";
            this.roleL.Size = new System.Drawing.Size(42, 18);
            this.roleL.TabIndex = 36;
            this.roleL.Text = "<role>";
            this.roleL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameL
            // 
            this.nameL.AutoSize = true;
            this.nameL.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameL.ForeColor = System.Drawing.Color.Black;
            this.nameL.Location = new System.Drawing.Point(64, 24);
            this.nameL.Name = "nameL";
            this.nameL.Size = new System.Drawing.Size(48, 18);
            this.nameL.TabIndex = 35;
            this.nameL.Text = "<name>";
            this.nameL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // defRoleL
            // 
            this.defRoleL.AutoSize = true;
            this.defRoleL.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.defRoleL.ForeColor = System.Drawing.Color.Black;
            this.defRoleL.Location = new System.Drawing.Point(19, 55);
            this.defRoleL.Name = "defRoleL";
            this.defRoleL.Size = new System.Drawing.Size(44, 19);
            this.defRoleL.TabIndex = 34;
            this.defRoleL.Text = "Роль:";
            this.defRoleL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // defNameL
            // 
            this.defNameL.AutoSize = true;
            this.defNameL.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.defNameL.ForeColor = System.Drawing.Color.Black;
            this.defNameL.Location = new System.Drawing.Point(20, 24);
            this.defNameL.Name = "defNameL";
            this.defNameL.Size = new System.Drawing.Size(43, 19);
            this.defNameL.TabIndex = 33;
            this.defNameL.Text = "ФИО:";
            this.defNameL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // товарыTableAdapter
            // 
            this.товарыTableAdapter.ClearBeforeFill = true;
            // 
            // отделыViewTableAdapter
            // 
            this.отделыViewTableAdapter.ClearBeforeFill = true;
            // 
            // продажиTableAdapter
            // 
            this.продажиTableAdapter.ClearBeforeFill = true;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.button1.Location = new System.Drawing.Point(451, 256);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 46);
            this.button1.TabIndex = 24;
            this.button1.Text = "Обновить таблицу";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roleTC);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.roleL);
            this.Controls.Add(this.nameL);
            this.Controls.Add(this.defRoleL);
            this.Controls.Add(this.defNameL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная страница";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.roleTC.ResumeLayout(false);
            this.productsTP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradingUPDataSet)).EndInit();
            this.ordersTP.ResumeLayout(false);
            this.ordersTP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отделыViewBindingSource)).EndInit();
            this.versionsTP.ResumeLayout(false);
            this.versionsTP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.versionsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продажиBindingSource)).EndInit();
            this.staffTP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.staffDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl roleTC;
        private System.Windows.Forms.TabPage productsTP;
        private System.Windows.Forms.Button addButt;
        private System.Windows.Forms.Button delButt;
        private System.Windows.Forms.Button changeButt;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.TabPage ordersTP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delButt2;
        private System.Windows.Forms.Button addButt2;
        private System.Windows.Forms.Button changeButt2;
        private System.Windows.Forms.DataGridView ordersDataGridView;
        private System.Windows.Forms.TabPage versionsTP;
        private System.Windows.Forms.Label orderL;
        private System.Windows.Forms.Label staffL;
        private System.Windows.Forms.Button addButt4;
        private System.Windows.Forms.DataGridView versionsDataGridView;
        private System.Windows.Forms.Button delButt4;
        private System.Windows.Forms.Button changeButt4;
        private System.Windows.Forms.TabPage staffTP;
        private System.Windows.Forms.Button addButt3;
        private System.Windows.Forms.Button delButt3;
        private System.Windows.Forms.Button changeButt3;
        private System.Windows.Forms.DataGridView staffDataGridView;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label roleL;
        private System.Windows.Forms.Label nameL;
        private System.Windows.Forms.Label defRoleL;
        private System.Windows.Forms.Label defNameL;
        private TradingUPDataSet tradingUPDataSet;
        private System.Windows.Forms.BindingSource товарыBindingSource;
        private TradingUPDataSetTableAdapters.ТоварыTableAdapter товарыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn артикулТовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn единицаИзмеренияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn розничнаяЦенаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource отделыViewBindingSource;
        private TradingUPDataSetTableAdapters.ОтделыViewTableAdapter отделыViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОЗаведующегоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn объемРеализацииВДеньDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource продажиBindingSource;
        private TradingUPDataSetTableAdapters.ПродажиTableAdapter продажиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn артикулТовараDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn отделDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаПродажиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private TradingUPDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn логинDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn парольDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}
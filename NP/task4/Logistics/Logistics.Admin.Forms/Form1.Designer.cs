namespace Logistics.Admin.Forms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            comboBoxAddShippingType = new ComboBox();
            labelShippings = new Label();
            dataGridViewShippings = new DataGridView();
            tabPageAdd = new TabPage();
            panelAdd = new Panel();
            labelAddDestinationWarehouseCapacity = new Label();
            textBoxAddDestinationWarehouseCapacity = new TextBox();
            labelAddDestinationWarehouseCity = new Label();
            textBoxAddDestinationWarehouseCity = new TextBox();
            labelAddDestinationWarehouseName = new Label();
            textBoxAddDestinationWarehouseName = new TextBox();
            labelAddDriverAge = new Label();
            textBoxAddDriverAge = new TextBox();
            labelAddDriverSurname = new Label();
            textBoxAddDriverSurname = new TextBox();
            labelAddDriverName = new Label();
            textBoxAddDriverName = new TextBox();
            labelAddShippingType = new Label();
            labelAddDuration = new Label();
            textBoxAddDuration = new TextBox();
            labelAddDepartureWarehouseCapacity = new Label();
            textBoxAddDepartureWarehouseCapacity = new TextBox();
            labelAddDepartureWarehouseCity = new Label();
            textBoxAddDepartureWarehouseCity = new TextBox();
            labelAddDepartureWarehouseName = new Label();
            textBoxAddDepartureWarehouseName = new TextBox();
            labelAddGoodsQuantity = new Label();
            textBoxAddGoodsQuantity = new TextBox();
            labelAddGoodsName = new Label();
            textBoxAddGoodsName = new TextBox();
            labelAddId = new Label();
            buttonAddShipping = new Button();
            textBoxAddId = new TextBox();
            labelAdd = new Label();
            tabControlMode = new TabControl();
            tabPageEdit = new TabPage();
            panelEdit = new Panel();
            labelEditDestinationWarehouseCapacity = new Label();
            textBoxEditDestinationWarehouseCapacity = new TextBox();
            labelEditDestinationWarehouseCity = new Label();
            textBoxEditDestinationWarehouseCity = new TextBox();
            labelEditDestinationWarehouseName = new Label();
            textBoxEditDestinationWarehouseName = new TextBox();
            comboBoxEditShippingType = new ComboBox();
            labelEditDriverAge = new Label();
            textBoxEditDriverAge = new TextBox();
            labelEditDriverSurname = new Label();
            textBoxEditDriverSurname = new TextBox();
            labelEditDriverName = new Label();
            textBoxEditDriverName = new TextBox();
            labelEditShippingType = new Label();
            labelEditDuration = new Label();
            textBoxEditDuration = new TextBox();
            labelEditDepartureWarehouseCapacity = new Label();
            textBoxEditDepartureWarehouseCapacity = new TextBox();
            labelEditDepartureWarehouseCity = new Label();
            textBoxEditDepartureWarehouseCity = new TextBox();
            labelEditDepartureWarehouseName = new Label();
            textBoxEditDepartureWarehouseName = new TextBox();
            labelEditGoodsQuantity = new Label();
            textBoxEditGoodsQuantity = new TextBox();
            labelEditGoodsName = new Label();
            textBoxEditGoodsName = new TextBox();
            labelEditId = new Label();
            buttonEditShipping = new Button();
            textBoxEditId = new TextBox();
            labelEdit = new Label();
            buttonReload = new Button();
            buttonDelete = new Button();
            labelFilter = new Label();
            comboBoxFilter = new ComboBox();
            labelTotal = new Label();
            labelTotalQuantity = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewShippings).BeginInit();
            tabPageAdd.SuspendLayout();
            panelAdd.SuspendLayout();
            tabControlMode.SuspendLayout();
            tabPageEdit.SuspendLayout();
            panelEdit.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxAddShippingType
            // 
            comboBoxAddShippingType.AllowDrop = true;
            comboBoxAddShippingType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAddShippingType.FormattingEnabled = true;
            comboBoxAddShippingType.Items.AddRange(new object[] { "Air", "Rail", "Road", "Sea" });
            comboBoxAddShippingType.Location = new Point(164, 77);
            comboBoxAddShippingType.Name = "comboBoxAddShippingType";
            comboBoxAddShippingType.Size = new Size(121, 38);
            comboBoxAddShippingType.TabIndex = 35;
            // 
            // labelShippings
            // 
            labelShippings.AutoSize = true;
            labelShippings.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelShippings.Location = new Point(1, 0);
            labelShippings.Name = "labelShippings";
            labelShippings.Size = new Size(169, 37);
            labelShippings.TabIndex = 4;
            labelShippings.Text = "All shippings";
            // 
            // dataGridViewShippings
            // 
            dataGridViewShippings.AllowUserToAddRows = false;
            dataGridViewShippings.AllowUserToDeleteRows = false;
            dataGridViewShippings.AllowUserToResizeRows = false;
            dataGridViewShippings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewShippings.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewShippings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewShippings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewShippings.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewShippings.Location = new Point(1, 40);
            dataGridViewShippings.MultiSelect = false;
            dataGridViewShippings.Name = "dataGridViewShippings";
            dataGridViewShippings.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewShippings.RowTemplate.Height = 25;
            dataGridViewShippings.Size = new Size(1261, 277);
            dataGridViewShippings.TabIndex = 5;
            dataGridViewShippings.SelectionChanged += dataGridViewShippings_SelectionChanged;
            // 
            // tabPageAdd
            // 
            tabPageAdd.Controls.Add(panelAdd);
            tabPageAdd.Controls.Add(labelAdd);
            tabPageAdd.Location = new Point(4, 39);
            tabPageAdd.Name = "tabPageAdd";
            tabPageAdd.Padding = new Padding(3);
            tabPageAdd.Size = new Size(1253, 315);
            tabPageAdd.TabIndex = 0;
            tabPageAdd.Text = "Add";
            tabPageAdd.UseVisualStyleBackColor = true;
            // 
            // panelAdd
            // 
            panelAdd.BorderStyle = BorderStyle.FixedSingle;
            panelAdd.Controls.Add(labelAddDestinationWarehouseCapacity);
            panelAdd.Controls.Add(textBoxAddDestinationWarehouseCapacity);
            panelAdd.Controls.Add(labelAddDestinationWarehouseCity);
            panelAdd.Controls.Add(textBoxAddDestinationWarehouseCity);
            panelAdd.Controls.Add(labelAddDestinationWarehouseName);
            panelAdd.Controls.Add(textBoxAddDestinationWarehouseName);
            panelAdd.Controls.Add(comboBoxAddShippingType);
            panelAdd.Controls.Add(labelAddDriverAge);
            panelAdd.Controls.Add(textBoxAddDriverAge);
            panelAdd.Controls.Add(labelAddDriverSurname);
            panelAdd.Controls.Add(textBoxAddDriverSurname);
            panelAdd.Controls.Add(labelAddDriverName);
            panelAdd.Controls.Add(textBoxAddDriverName);
            panelAdd.Controls.Add(labelAddShippingType);
            panelAdd.Controls.Add(labelAddDuration);
            panelAdd.Controls.Add(textBoxAddDuration);
            panelAdd.Controls.Add(labelAddDepartureWarehouseCapacity);
            panelAdd.Controls.Add(textBoxAddDepartureWarehouseCapacity);
            panelAdd.Controls.Add(labelAddDepartureWarehouseCity);
            panelAdd.Controls.Add(textBoxAddDepartureWarehouseCity);
            panelAdd.Controls.Add(labelAddDepartureWarehouseName);
            panelAdd.Controls.Add(textBoxAddDepartureWarehouseName);
            panelAdd.Controls.Add(labelAddGoodsQuantity);
            panelAdd.Controls.Add(textBoxAddGoodsQuantity);
            panelAdd.Controls.Add(labelAddGoodsName);
            panelAdd.Controls.Add(textBoxAddGoodsName);
            panelAdd.Controls.Add(labelAddId);
            panelAdd.Controls.Add(buttonAddShipping);
            panelAdd.Controls.Add(textBoxAddId);
            panelAdd.Location = new Point(7, 43);
            panelAdd.Name = "panelAdd";
            panelAdd.Size = new Size(1240, 264);
            panelAdd.TabIndex = 8;
            // 
            // labelAddDestinationWarehouseCapacity
            // 
            labelAddDestinationWarehouseCapacity.AutoSize = true;
            labelAddDestinationWarehouseCapacity.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelAddDestinationWarehouseCapacity.Location = new Point(326, 230);
            labelAddDestinationWarehouseCapacity.Name = "labelAddDestinationWarehouseCapacity";
            labelAddDestinationWarehouseCapacity.Size = new Size(296, 25);
            labelAddDestinationWarehouseCapacity.TabIndex = 41;
            labelAddDestinationWarehouseCapacity.Text = "destination warehouse capacity, t:";
            // 
            // textBoxAddDestinationWarehouseCapacity
            // 
            textBoxAddDestinationWarehouseCapacity.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAddDestinationWarehouseCapacity.Location = new Point(628, 227);
            textBoxAddDestinationWarehouseCapacity.Name = "textBoxAddDestinationWarehouseCapacity";
            textBoxAddDestinationWarehouseCapacity.Size = new Size(177, 32);
            textBoxAddDestinationWarehouseCapacity.TabIndex = 40;
            // 
            // labelAddDestinationWarehouseCity
            // 
            labelAddDestinationWarehouseCity.AutoSize = true;
            labelAddDestinationWarehouseCity.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelAddDestinationWarehouseCity.Location = new Point(326, 192);
            labelAddDestinationWarehouseCity.Name = "labelAddDestinationWarehouseCity";
            labelAddDestinationWarehouseCity.Size = new Size(241, 25);
            labelAddDestinationWarehouseCity.TabIndex = 39;
            labelAddDestinationWarehouseCity.Text = "destination warehouse city:";
            // 
            // textBoxAddDestinationWarehouseCity
            // 
            textBoxAddDestinationWarehouseCity.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAddDestinationWarehouseCity.Location = new Point(628, 189);
            textBoxAddDestinationWarehouseCity.Name = "textBoxAddDestinationWarehouseCity";
            textBoxAddDestinationWarehouseCity.Size = new Size(177, 32);
            textBoxAddDestinationWarehouseCity.TabIndex = 38;
            // 
            // labelAddDestinationWarehouseName
            // 
            labelAddDestinationWarehouseName.AutoSize = true;
            labelAddDestinationWarehouseName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelAddDestinationWarehouseName.Location = new Point(326, 154);
            labelAddDestinationWarehouseName.Name = "labelAddDestinationWarehouseName";
            labelAddDestinationWarehouseName.Size = new Size(259, 25);
            labelAddDestinationWarehouseName.TabIndex = 37;
            labelAddDestinationWarehouseName.Text = "destination warehouse name:";
            // 
            // textBoxAddDestinationWarehouseName
            // 
            textBoxAddDestinationWarehouseName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAddDestinationWarehouseName.Location = new Point(628, 151);
            textBoxAddDestinationWarehouseName.Name = "textBoxAddDestinationWarehouseName";
            textBoxAddDestinationWarehouseName.Size = new Size(177, 32);
            textBoxAddDestinationWarehouseName.TabIndex = 36;
            // 
            // labelAddDriverAge
            // 
            labelAddDriverAge.AutoSize = true;
            labelAddDriverAge.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelAddDriverAge.Location = new Point(828, 82);
            labelAddDriverAge.Name = "labelAddDriverAge";
            labelAddDriverAge.Size = new Size(166, 25);
            labelAddDriverAge.TabIndex = 34;
            labelAddDriverAge.Text = "driver's age, years:";
            // 
            // textBoxAddDriverAge
            // 
            textBoxAddDriverAge.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAddDriverAge.Location = new Point(1000, 79);
            textBoxAddDriverAge.Name = "textBoxAddDriverAge";
            textBoxAddDriverAge.Size = new Size(177, 32);
            textBoxAddDriverAge.TabIndex = 33;
            // 
            // labelAddDriverSurname
            // 
            labelAddDriverSurname.AutoSize = true;
            labelAddDriverSurname.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelAddDriverSurname.Location = new Point(828, 44);
            labelAddDriverSurname.Name = "labelAddDriverSurname";
            labelAddDriverSurname.Size = new Size(155, 25);
            labelAddDriverSurname.TabIndex = 32;
            labelAddDriverSurname.Text = "driver's surname:";
            // 
            // textBoxAddDriverSurname
            // 
            textBoxAddDriverSurname.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAddDriverSurname.Location = new Point(1000, 41);
            textBoxAddDriverSurname.Name = "textBoxAddDriverSurname";
            textBoxAddDriverSurname.Size = new Size(177, 32);
            textBoxAddDriverSurname.TabIndex = 31;
            // 
            // labelAddDriverName
            // 
            labelAddDriverName.AutoSize = true;
            labelAddDriverName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelAddDriverName.Location = new Point(828, 6);
            labelAddDriverName.Name = "labelAddDriverName";
            labelAddDriverName.Size = new Size(129, 25);
            labelAddDriverName.TabIndex = 30;
            labelAddDriverName.Text = "driver's name:";
            // 
            // textBoxAddDriverName
            // 
            textBoxAddDriverName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAddDriverName.Location = new Point(1000, 3);
            textBoxAddDriverName.Name = "textBoxAddDriverName";
            textBoxAddDriverName.Size = new Size(177, 32);
            textBoxAddDriverName.TabIndex = 29;
            // 
            // labelAddShippingType
            // 
            labelAddShippingType.AutoSize = true;
            labelAddShippingType.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelAddShippingType.Location = new Point(3, 82);
            labelAddShippingType.Name = "labelAddShippingType";
            labelAddShippingType.Size = new Size(130, 25);
            labelAddShippingType.TabIndex = 28;
            labelAddShippingType.Text = "shipping type:";
            // 
            // labelAddDuration
            // 
            labelAddDuration.AutoSize = true;
            labelAddDuration.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelAddDuration.Location = new Point(3, 44);
            labelAddDuration.Name = "labelAddDuration";
            labelAddDuration.Size = new Size(135, 25);
            labelAddDuration.TabIndex = 26;
            labelAddDuration.Text = "duration, days:";
            // 
            // textBoxAddDuration
            // 
            textBoxAddDuration.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAddDuration.Location = new Point(164, 41);
            textBoxAddDuration.Name = "textBoxAddDuration";
            textBoxAddDuration.Size = new Size(121, 32);
            textBoxAddDuration.TabIndex = 25;
            // 
            // labelAddDepartureWarehouseCapacity
            // 
            labelAddDepartureWarehouseCapacity.AutoSize = true;
            labelAddDepartureWarehouseCapacity.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelAddDepartureWarehouseCapacity.Location = new Point(326, 82);
            labelAddDepartureWarehouseCapacity.Name = "labelAddDepartureWarehouseCapacity";
            labelAddDepartureWarehouseCapacity.Size = new Size(285, 25);
            labelAddDepartureWarehouseCapacity.TabIndex = 18;
            labelAddDepartureWarehouseCapacity.Text = "departure warehouse capacity, t:";
            // 
            // textBoxAddDepartureWarehouseCapacity
            // 
            textBoxAddDepartureWarehouseCapacity.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAddDepartureWarehouseCapacity.Location = new Point(628, 79);
            textBoxAddDepartureWarehouseCapacity.Name = "textBoxAddDepartureWarehouseCapacity";
            textBoxAddDepartureWarehouseCapacity.Size = new Size(177, 32);
            textBoxAddDepartureWarehouseCapacity.TabIndex = 17;
            // 
            // labelAddDepartureWarehouseCity
            // 
            labelAddDepartureWarehouseCity.AutoSize = true;
            labelAddDepartureWarehouseCity.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelAddDepartureWarehouseCity.Location = new Point(326, 44);
            labelAddDepartureWarehouseCity.Name = "labelAddDepartureWarehouseCity";
            labelAddDepartureWarehouseCity.Size = new Size(230, 25);
            labelAddDepartureWarehouseCity.TabIndex = 16;
            labelAddDepartureWarehouseCity.Text = "departure warehouse city:";
            // 
            // textBoxAddDepartureWarehouseCity
            // 
            textBoxAddDepartureWarehouseCity.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAddDepartureWarehouseCity.Location = new Point(628, 41);
            textBoxAddDepartureWarehouseCity.Name = "textBoxAddDepartureWarehouseCity";
            textBoxAddDepartureWarehouseCity.Size = new Size(177, 32);
            textBoxAddDepartureWarehouseCity.TabIndex = 15;
            // 
            // labelAddDepartureWarehouseName
            // 
            labelAddDepartureWarehouseName.AutoSize = true;
            labelAddDepartureWarehouseName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelAddDepartureWarehouseName.Location = new Point(326, 6);
            labelAddDepartureWarehouseName.Name = "labelAddDepartureWarehouseName";
            labelAddDepartureWarehouseName.Size = new Size(248, 25);
            labelAddDepartureWarehouseName.TabIndex = 14;
            labelAddDepartureWarehouseName.Text = "departure warehouse name:";
            // 
            // textBoxAddDepartureWarehouseName
            // 
            textBoxAddDepartureWarehouseName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAddDepartureWarehouseName.Location = new Point(628, 3);
            textBoxAddDepartureWarehouseName.Name = "textBoxAddDepartureWarehouseName";
            textBoxAddDepartureWarehouseName.Size = new Size(177, 32);
            textBoxAddDepartureWarehouseName.TabIndex = 13;
            // 
            // labelAddGoodsQuantity
            // 
            labelAddGoodsQuantity.AutoSize = true;
            labelAddGoodsQuantity.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelAddGoodsQuantity.Location = new Point(3, 192);
            labelAddGoodsQuantity.Name = "labelAddGoodsQuantity";
            labelAddGoodsQuantity.Size = new Size(157, 25);
            labelAddGoodsQuantity.TabIndex = 12;
            labelAddGoodsQuantity.Text = "goods quantity, t:";
            // 
            // textBoxAddGoodsQuantity
            // 
            textBoxAddGoodsQuantity.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAddGoodsQuantity.Location = new Point(164, 189);
            textBoxAddGoodsQuantity.Name = "textBoxAddGoodsQuantity";
            textBoxAddGoodsQuantity.Size = new Size(121, 32);
            textBoxAddGoodsQuantity.TabIndex = 11;
            // 
            // labelAddGoodsName
            // 
            labelAddGoodsName.AutoSize = true;
            labelAddGoodsName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelAddGoodsName.Location = new Point(3, 154);
            labelAddGoodsName.Name = "labelAddGoodsName";
            labelAddGoodsName.Size = new Size(120, 25);
            labelAddGoodsName.TabIndex = 10;
            labelAddGoodsName.Text = "goods name:";
            // 
            // textBoxAddGoodsName
            // 
            textBoxAddGoodsName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAddGoodsName.Location = new Point(164, 151);
            textBoxAddGoodsName.Name = "textBoxAddGoodsName";
            textBoxAddGoodsName.Size = new Size(121, 32);
            textBoxAddGoodsName.TabIndex = 9;
            // 
            // labelAddId
            // 
            labelAddId.AutoSize = true;
            labelAddId.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelAddId.Location = new Point(3, 6);
            labelAddId.Name = "labelAddId";
            labelAddId.Size = new Size(32, 25);
            labelAddId.TabIndex = 8;
            labelAddId.Text = "id:";
            // 
            // buttonAddShipping
            // 
            buttonAddShipping.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddShipping.Location = new Point(1000, 181);
            buttonAddShipping.Name = "buttonAddShipping";
            buttonAddShipping.Size = new Size(235, 78);
            buttonAddShipping.TabIndex = 7;
            buttonAddShipping.Text = "Add";
            buttonAddShipping.UseVisualStyleBackColor = true;
            buttonAddShipping.Click += buttonAddShipping_Click;
            // 
            // textBoxAddId
            // 
            textBoxAddId.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAddId.Location = new Point(164, 3);
            textBoxAddId.Name = "textBoxAddId";
            textBoxAddId.Size = new Size(121, 32);
            textBoxAddId.TabIndex = 5;
            // 
            // labelAdd
            // 
            labelAdd.AutoSize = true;
            labelAdd.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelAdd.Location = new Point(7, 3);
            labelAdd.Name = "labelAdd";
            labelAdd.Size = new Size(176, 37);
            labelAdd.TabIndex = 9;
            labelAdd.Text = "Add shipping";
            // 
            // tabControlMode
            // 
            tabControlMode.Controls.Add(tabPageAdd);
            tabControlMode.Controls.Add(tabPageEdit);
            tabControlMode.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            tabControlMode.Location = new Point(1, 323);
            tabControlMode.Name = "tabControlMode";
            tabControlMode.SelectedIndex = 0;
            tabControlMode.Size = new Size(1261, 358);
            tabControlMode.TabIndex = 8;
            // 
            // tabPageEdit
            // 
            tabPageEdit.Controls.Add(panelEdit);
            tabPageEdit.Controls.Add(labelEdit);
            tabPageEdit.Location = new Point(4, 39);
            tabPageEdit.Name = "tabPageEdit";
            tabPageEdit.Padding = new Padding(3);
            tabPageEdit.Size = new Size(1253, 315);
            tabPageEdit.TabIndex = 1;
            tabPageEdit.Text = "Edit";
            tabPageEdit.UseVisualStyleBackColor = true;
            // 
            // panelEdit
            // 
            panelEdit.BorderStyle = BorderStyle.FixedSingle;
            panelEdit.Controls.Add(labelEditDestinationWarehouseCapacity);
            panelEdit.Controls.Add(textBoxEditDestinationWarehouseCapacity);
            panelEdit.Controls.Add(labelEditDestinationWarehouseCity);
            panelEdit.Controls.Add(textBoxEditDestinationWarehouseCity);
            panelEdit.Controls.Add(labelEditDestinationWarehouseName);
            panelEdit.Controls.Add(textBoxEditDestinationWarehouseName);
            panelEdit.Controls.Add(comboBoxEditShippingType);
            panelEdit.Controls.Add(labelEditDriverAge);
            panelEdit.Controls.Add(textBoxEditDriverAge);
            panelEdit.Controls.Add(labelEditDriverSurname);
            panelEdit.Controls.Add(textBoxEditDriverSurname);
            panelEdit.Controls.Add(labelEditDriverName);
            panelEdit.Controls.Add(textBoxEditDriverName);
            panelEdit.Controls.Add(labelEditShippingType);
            panelEdit.Controls.Add(labelEditDuration);
            panelEdit.Controls.Add(textBoxEditDuration);
            panelEdit.Controls.Add(labelEditDepartureWarehouseCapacity);
            panelEdit.Controls.Add(textBoxEditDepartureWarehouseCapacity);
            panelEdit.Controls.Add(labelEditDepartureWarehouseCity);
            panelEdit.Controls.Add(textBoxEditDepartureWarehouseCity);
            panelEdit.Controls.Add(labelEditDepartureWarehouseName);
            panelEdit.Controls.Add(textBoxEditDepartureWarehouseName);
            panelEdit.Controls.Add(labelEditGoodsQuantity);
            panelEdit.Controls.Add(textBoxEditGoodsQuantity);
            panelEdit.Controls.Add(labelEditGoodsName);
            panelEdit.Controls.Add(textBoxEditGoodsName);
            panelEdit.Controls.Add(labelEditId);
            panelEdit.Controls.Add(buttonEditShipping);
            panelEdit.Controls.Add(textBoxEditId);
            panelEdit.Location = new Point(7, 43);
            panelEdit.Name = "panelEdit";
            panelEdit.Size = new Size(1240, 264);
            panelEdit.TabIndex = 8;
            // 
            // labelEditDestinationWarehouseCapacity
            // 
            labelEditDestinationWarehouseCapacity.AutoSize = true;
            labelEditDestinationWarehouseCapacity.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelEditDestinationWarehouseCapacity.Location = new Point(326, 230);
            labelEditDestinationWarehouseCapacity.Name = "labelEditDestinationWarehouseCapacity";
            labelEditDestinationWarehouseCapacity.Size = new Size(296, 25);
            labelEditDestinationWarehouseCapacity.TabIndex = 41;
            labelEditDestinationWarehouseCapacity.Text = "destination warehouse capacity, t:";
            // 
            // textBoxEditDestinationWarehouseCapacity
            // 
            textBoxEditDestinationWarehouseCapacity.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEditDestinationWarehouseCapacity.Location = new Point(628, 227);
            textBoxEditDestinationWarehouseCapacity.Name = "textBoxEditDestinationWarehouseCapacity";
            textBoxEditDestinationWarehouseCapacity.Size = new Size(177, 32);
            textBoxEditDestinationWarehouseCapacity.TabIndex = 40;
            // 
            // labelEditDestinationWarehouseCity
            // 
            labelEditDestinationWarehouseCity.AutoSize = true;
            labelEditDestinationWarehouseCity.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelEditDestinationWarehouseCity.Location = new Point(326, 192);
            labelEditDestinationWarehouseCity.Name = "labelEditDestinationWarehouseCity";
            labelEditDestinationWarehouseCity.Size = new Size(241, 25);
            labelEditDestinationWarehouseCity.TabIndex = 39;
            labelEditDestinationWarehouseCity.Text = "destination warehouse city:";
            // 
            // textBoxEditDestinationWarehouseCity
            // 
            textBoxEditDestinationWarehouseCity.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEditDestinationWarehouseCity.Location = new Point(628, 189);
            textBoxEditDestinationWarehouseCity.Name = "textBoxEditDestinationWarehouseCity";
            textBoxEditDestinationWarehouseCity.Size = new Size(177, 32);
            textBoxEditDestinationWarehouseCity.TabIndex = 38;
            // 
            // labelEditDestinationWarehouseName
            // 
            labelEditDestinationWarehouseName.AutoSize = true;
            labelEditDestinationWarehouseName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelEditDestinationWarehouseName.Location = new Point(326, 154);
            labelEditDestinationWarehouseName.Name = "labelEditDestinationWarehouseName";
            labelEditDestinationWarehouseName.Size = new Size(259, 25);
            labelEditDestinationWarehouseName.TabIndex = 37;
            labelEditDestinationWarehouseName.Text = "destination warehouse name:";
            // 
            // textBoxEditDestinationWarehouseName
            // 
            textBoxEditDestinationWarehouseName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEditDestinationWarehouseName.Location = new Point(628, 151);
            textBoxEditDestinationWarehouseName.Name = "textBoxEditDestinationWarehouseName";
            textBoxEditDestinationWarehouseName.Size = new Size(177, 32);
            textBoxEditDestinationWarehouseName.TabIndex = 36;
            // 
            // comboBoxEditShippingType
            // 
            comboBoxEditShippingType.AllowDrop = true;
            comboBoxEditShippingType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEditShippingType.FormattingEnabled = true;
            comboBoxEditShippingType.Items.AddRange(new object[] { "Air", "Rail", "Road", "Sea" });
            comboBoxEditShippingType.Location = new Point(164, 77);
            comboBoxEditShippingType.Name = "comboBoxEditShippingType";
            comboBoxEditShippingType.Size = new Size(121, 38);
            comboBoxEditShippingType.TabIndex = 35;
            // 
            // labelEditDriverAge
            // 
            labelEditDriverAge.AutoSize = true;
            labelEditDriverAge.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelEditDriverAge.Location = new Point(828, 82);
            labelEditDriverAge.Name = "labelEditDriverAge";
            labelEditDriverAge.Size = new Size(166, 25);
            labelEditDriverAge.TabIndex = 34;
            labelEditDriverAge.Text = "driver's age, years:";
            // 
            // textBoxEditDriverAge
            // 
            textBoxEditDriverAge.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEditDriverAge.Location = new Point(1000, 79);
            textBoxEditDriverAge.Name = "textBoxEditDriverAge";
            textBoxEditDriverAge.Size = new Size(177, 32);
            textBoxEditDriverAge.TabIndex = 33;
            // 
            // labelEditDriverSurname
            // 
            labelEditDriverSurname.AutoSize = true;
            labelEditDriverSurname.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelEditDriverSurname.Location = new Point(828, 44);
            labelEditDriverSurname.Name = "labelEditDriverSurname";
            labelEditDriverSurname.Size = new Size(155, 25);
            labelEditDriverSurname.TabIndex = 32;
            labelEditDriverSurname.Text = "driver's surname:";
            // 
            // textBoxEditDriverSurname
            // 
            textBoxEditDriverSurname.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEditDriverSurname.Location = new Point(1000, 41);
            textBoxEditDriverSurname.Name = "textBoxEditDriverSurname";
            textBoxEditDriverSurname.Size = new Size(177, 32);
            textBoxEditDriverSurname.TabIndex = 31;
            // 
            // labelEditDriverName
            // 
            labelEditDriverName.AutoSize = true;
            labelEditDriverName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelEditDriverName.Location = new Point(828, 6);
            labelEditDriverName.Name = "labelEditDriverName";
            labelEditDriverName.Size = new Size(129, 25);
            labelEditDriverName.TabIndex = 30;
            labelEditDriverName.Text = "driver's name:";
            // 
            // textBoxEditDriverName
            // 
            textBoxEditDriverName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEditDriverName.Location = new Point(1000, 3);
            textBoxEditDriverName.Name = "textBoxEditDriverName";
            textBoxEditDriverName.Size = new Size(177, 32);
            textBoxEditDriverName.TabIndex = 29;
            // 
            // labelEditShippingType
            // 
            labelEditShippingType.AutoSize = true;
            labelEditShippingType.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelEditShippingType.Location = new Point(3, 82);
            labelEditShippingType.Name = "labelEditShippingType";
            labelEditShippingType.Size = new Size(130, 25);
            labelEditShippingType.TabIndex = 28;
            labelEditShippingType.Text = "shipping type:";
            // 
            // labelEditDuration
            // 
            labelEditDuration.AutoSize = true;
            labelEditDuration.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelEditDuration.Location = new Point(3, 44);
            labelEditDuration.Name = "labelEditDuration";
            labelEditDuration.Size = new Size(135, 25);
            labelEditDuration.TabIndex = 26;
            labelEditDuration.Text = "duration, days:";
            // 
            // textBoxEditDuration
            // 
            textBoxEditDuration.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEditDuration.Location = new Point(164, 41);
            textBoxEditDuration.Name = "textBoxEditDuration";
            textBoxEditDuration.Size = new Size(121, 32);
            textBoxEditDuration.TabIndex = 25;
            // 
            // labelEditDepartureWarehouseCapacity
            // 
            labelEditDepartureWarehouseCapacity.AutoSize = true;
            labelEditDepartureWarehouseCapacity.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelEditDepartureWarehouseCapacity.Location = new Point(326, 82);
            labelEditDepartureWarehouseCapacity.Name = "labelEditDepartureWarehouseCapacity";
            labelEditDepartureWarehouseCapacity.Size = new Size(285, 25);
            labelEditDepartureWarehouseCapacity.TabIndex = 18;
            labelEditDepartureWarehouseCapacity.Text = "departure warehouse capacity, t:";
            // 
            // textBoxEditDepartureWarehouseCapacity
            // 
            textBoxEditDepartureWarehouseCapacity.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEditDepartureWarehouseCapacity.Location = new Point(628, 79);
            textBoxEditDepartureWarehouseCapacity.Name = "textBoxEditDepartureWarehouseCapacity";
            textBoxEditDepartureWarehouseCapacity.Size = new Size(177, 32);
            textBoxEditDepartureWarehouseCapacity.TabIndex = 17;
            // 
            // labelEditDepartureWarehouseCity
            // 
            labelEditDepartureWarehouseCity.AutoSize = true;
            labelEditDepartureWarehouseCity.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelEditDepartureWarehouseCity.Location = new Point(326, 44);
            labelEditDepartureWarehouseCity.Name = "labelEditDepartureWarehouseCity";
            labelEditDepartureWarehouseCity.Size = new Size(230, 25);
            labelEditDepartureWarehouseCity.TabIndex = 16;
            labelEditDepartureWarehouseCity.Text = "departure warehouse city:";
            // 
            // textBoxEditDepartureWarehouseCity
            // 
            textBoxEditDepartureWarehouseCity.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEditDepartureWarehouseCity.Location = new Point(628, 41);
            textBoxEditDepartureWarehouseCity.Name = "textBoxEditDepartureWarehouseCity";
            textBoxEditDepartureWarehouseCity.Size = new Size(177, 32);
            textBoxEditDepartureWarehouseCity.TabIndex = 15;
            // 
            // labelEditDepartureWarehouseName
            // 
            labelEditDepartureWarehouseName.AutoSize = true;
            labelEditDepartureWarehouseName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelEditDepartureWarehouseName.Location = new Point(326, 6);
            labelEditDepartureWarehouseName.Name = "labelEditDepartureWarehouseName";
            labelEditDepartureWarehouseName.Size = new Size(248, 25);
            labelEditDepartureWarehouseName.TabIndex = 14;
            labelEditDepartureWarehouseName.Text = "departure warehouse name:";
            // 
            // textBoxEditDepartureWarehouseName
            // 
            textBoxEditDepartureWarehouseName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEditDepartureWarehouseName.Location = new Point(628, 3);
            textBoxEditDepartureWarehouseName.Name = "textBoxEditDepartureWarehouseName";
            textBoxEditDepartureWarehouseName.Size = new Size(177, 32);
            textBoxEditDepartureWarehouseName.TabIndex = 13;
            // 
            // labelEditGoodsQuantity
            // 
            labelEditGoodsQuantity.AutoSize = true;
            labelEditGoodsQuantity.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelEditGoodsQuantity.Location = new Point(3, 192);
            labelEditGoodsQuantity.Name = "labelEditGoodsQuantity";
            labelEditGoodsQuantity.Size = new Size(157, 25);
            labelEditGoodsQuantity.TabIndex = 12;
            labelEditGoodsQuantity.Text = "goods quantity, t:";
            // 
            // textBoxEditGoodsQuantity
            // 
            textBoxEditGoodsQuantity.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEditGoodsQuantity.Location = new Point(164, 189);
            textBoxEditGoodsQuantity.Name = "textBoxEditGoodsQuantity";
            textBoxEditGoodsQuantity.Size = new Size(121, 32);
            textBoxEditGoodsQuantity.TabIndex = 11;
            // 
            // labelEditGoodsName
            // 
            labelEditGoodsName.AutoSize = true;
            labelEditGoodsName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelEditGoodsName.Location = new Point(3, 154);
            labelEditGoodsName.Name = "labelEditGoodsName";
            labelEditGoodsName.Size = new Size(120, 25);
            labelEditGoodsName.TabIndex = 10;
            labelEditGoodsName.Text = "goods name:";
            // 
            // textBoxEditGoodsName
            // 
            textBoxEditGoodsName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEditGoodsName.Location = new Point(164, 151);
            textBoxEditGoodsName.Name = "textBoxEditGoodsName";
            textBoxEditGoodsName.Size = new Size(121, 32);
            textBoxEditGoodsName.TabIndex = 9;
            // 
            // labelEditId
            // 
            labelEditId.AutoSize = true;
            labelEditId.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelEditId.Location = new Point(3, 6);
            labelEditId.Name = "labelEditId";
            labelEditId.Size = new Size(32, 25);
            labelEditId.TabIndex = 8;
            labelEditId.Text = "id:";
            // 
            // buttonEditShipping
            // 
            buttonEditShipping.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEditShipping.Location = new Point(1000, 181);
            buttonEditShipping.Name = "buttonEditShipping";
            buttonEditShipping.Size = new Size(235, 78);
            buttonEditShipping.TabIndex = 7;
            buttonEditShipping.Text = "Edit";
            buttonEditShipping.UseVisualStyleBackColor = true;
            buttonEditShipping.Click += buttonEditShipping_Click;
            // 
            // textBoxEditId
            // 
            textBoxEditId.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEditId.Location = new Point(164, 3);
            textBoxEditId.Name = "textBoxEditId";
            textBoxEditId.ReadOnly = true;
            textBoxEditId.Size = new Size(121, 32);
            textBoxEditId.TabIndex = 5;
            // 
            // labelEdit
            // 
            labelEdit.AutoSize = true;
            labelEdit.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelEdit.Location = new Point(6, 3);
            labelEdit.Name = "labelEdit";
            labelEdit.Size = new Size(173, 37);
            labelEdit.TabIndex = 9;
            labelEdit.Text = "Edit shipping";
            // 
            // buttonReload
            // 
            buttonReload.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonReload.Location = new Point(339, 3);
            buttonReload.Name = "buttonReload";
            buttonReload.Size = new Size(121, 34);
            buttonReload.TabIndex = 9;
            buttonReload.Text = "Reload";
            buttonReload.UseVisualStyleBackColor = true;
            buttonReload.Click += buttonReload_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelete.Location = new Point(177, 4);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(121, 34);
            buttonDelete.TabIndex = 10;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // labelFilter
            // 
            labelFilter.AutoSize = true;
            labelFilter.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelFilter.Location = new Point(501, 6);
            labelFilter.Name = "labelFilter";
            labelFilter.Size = new Size(156, 30);
            labelFilter.TabIndex = 11;
            labelFilter.Text = "Shipping Type:";
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.AllowDrop = true;
            comboBoxFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilter.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxFilter.FormattingEnabled = true;
            comboBoxFilter.Items.AddRange(new object[] { "All", "Air", "Rail", "Road", "Sea" });
            comboBoxFilter.Location = new Point(663, 2);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(121, 38);
            comboBoxFilter.TabIndex = 42;
            comboBoxFilter.SelectedValueChanged += comboBox_Filter_SelectedValueChanged;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotal.Location = new Point(814, 6);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(152, 30);
            labelTotal.TabIndex = 43;
            labelTotal.Text = "Total Quantity:";
            // 
            // labelTotalQuantity
            // 
            labelTotalQuantity.AutoSize = true;
            labelTotalQuantity.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotalQuantity.Location = new Point(972, 6);
            labelTotalQuantity.Name = "labelTotalQuantity";
            labelTotalQuantity.Size = new Size(38, 30);
            labelTotalQuantity.TabIndex = 44;
            labelTotalQuantity.Text = "0 t";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(labelTotalQuantity);
            Controls.Add(labelTotal);
            Controls.Add(comboBoxFilter);
            Controls.Add(labelFilter);
            Controls.Add(buttonDelete);
            Controls.Add(buttonReload);
            Controls.Add(tabControlMode);
            Controls.Add(labelShippings);
            Controls.Add(dataGridViewShippings);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form1";
            Text = "Logistics (Admin)";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewShippings).EndInit();
            tabPageAdd.ResumeLayout(false);
            tabPageAdd.PerformLayout();
            panelAdd.ResumeLayout(false);
            panelAdd.PerformLayout();
            tabControlMode.ResumeLayout(false);
            tabPageEdit.ResumeLayout(false);
            tabPageEdit.PerformLayout();
            panelEdit.ResumeLayout(false);
            panelEdit.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelShippings;
        private DataGridView dataGridViewShippings;
        private TabPage tabPageAdd;
        private Panel panelAdd;
        private Label labelAddDriverAge;
        private TextBox textBoxAddDriverAge;
        private Label labelAddDriverSurname;
        private TextBox textBoxAddDriverSurname;
        private Label labelAddDriverName;
        private TextBox textBoxAddDriverName;
        private Label labelAddShippingType;
        private Label labelAddDuration;
        private TextBox textBoxAddDuration;
        private Label labelAddDepartureWarehouseCapacity;
        private TextBox textBoxAddDepartureWarehouseCapacity;
        private Label labelAddDepartureWarehouseCity;
        private TextBox textBoxAddDepartureWarehouseCity;
        private Label labelAddDepartureWarehouseName;
        private TextBox textBoxAddDepartureWarehouseName;
        private Label labelAddGoodsQuantity;
        private TextBox textBoxAddGoodsQuantity;
        private Label labelAddGoodsName;
        private TextBox textBoxAddGoodsName;
        private Label labelAddId;
        private Button buttonAddShipping;
        private TextBox textBoxAddId;
        private Label labelAdd;
        private TabControl tabControlMode;
        private ComboBox comboBoxAddShippingType;
        private Label labelAddDestinationWarehouseCapacity;
        private TextBox textBoxAddDestinationWarehouseCapacity;
        private Label labelAddDestinationWarehouseCity;
        private TextBox textBoxAddDestinationWarehouseCity;
        private Label labelAddDestinationWarehouseName;
        private TextBox textBoxAddDestinationWarehouseName;
        private TabPage tabPageEdit;
        private Panel panelEdit;
        private Label labelEditDestinationWarehouseCapacity;
        private TextBox textBoxEditDestinationWarehouseCapacity;
        private Label labelEditDestinationWarehouseCity;
        private TextBox textBoxEditDestinationWarehouseCity;
        private Label labelEditDestinationWarehouseName;
        private TextBox textBoxEditDestinationWarehouseName;
        private Label labelEditDriverAge;
        private TextBox textBoxEditDriverAge;
        private Label labelEditDriverSurname;
        private TextBox textBoxEditDriverSurname;
        private Label labelEditDriverName;
        private TextBox textBoxEditDriverName;
        private Label labelEditShippingType;
        private Label labelEditDuration;
        private TextBox textBoxEditDuration;
        private Label labelEditDepartureWarehouseCapacity;
        private TextBox textBoxEditDepartureWarehouseCapacity;
        private Label labelEditDepartureWarehouseCity;
        private TextBox textBoxEditDepartureWarehouseCity;
        private Label labelEditDepartureWarehouseName;
        private TextBox textBoxEditDepartureWarehouseName;
        private Label labelEditGoodsQuantity;
        private TextBox textBoxEditGoodsQuantity;
        private Label labelEditGoodsName;
        private TextBox textBoxEditGoodsName;
        private Label labelEditId;
        private Button buttonEditShipping;
        private TextBox textBoxEditId;
        private Label labelEdit;
        private ComboBox comboBoxEditShippingType;
        private Button buttonReload;
        private Button buttonDelete;
        private Label labelFilter;
        private ComboBox comboBoxFilter;
        private Label labelTotal;
        private Label labelTotalQuantity;
    }
}
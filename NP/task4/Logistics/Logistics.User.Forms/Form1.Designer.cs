namespace Logistics.User.Forms
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            buttonReload = new Button();
            labelShippings = new Label();
            dataGridViewShippings = new DataGridView();
            labelTotal = new Label();
            comboBoxFilter = new ComboBox();
            labelFilter = new Label();
            labelTotalQuantity = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewShippings).BeginInit();
            SuspendLayout();
            // 
            // buttonReload
            // 
            buttonReload.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonReload.Location = new Point(336, 2);
            buttonReload.Name = "buttonReload";
            buttonReload.Size = new Size(121, 34);
            buttonReload.TabIndex = 12;
            buttonReload.Text = "Reload";
            buttonReload.UseVisualStyleBackColor = true;
            buttonReload.Click += buttonReload_Click;
            // 
            // labelShippings
            // 
            labelShippings.AutoSize = true;
            labelShippings.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelShippings.Location = new Point(-2, -1);
            labelShippings.Name = "labelShippings";
            labelShippings.Size = new Size(169, 37);
            labelShippings.TabIndex = 10;
            labelShippings.Text = "All shippings";
            // 
            // dataGridViewShippings
            // 
            dataGridViewShippings.AllowUserToAddRows = false;
            dataGridViewShippings.AllowUserToDeleteRows = false;
            dataGridViewShippings.AllowUserToResizeRows = false;
            dataGridViewShippings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewShippings.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewShippings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewShippings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridViewShippings.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewShippings.Location = new Point(-2, 39);
            dataGridViewShippings.MultiSelect = false;
            dataGridViewShippings.Name = "dataGridViewShippings";
            dataGridViewShippings.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewShippings.RowTemplate.Height = 25;
            dataGridViewShippings.Size = new Size(1261, 277);
            dataGridViewShippings.TabIndex = 11;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotal.Location = new Point(831, 5);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(152, 30);
            labelTotal.TabIndex = 46;
            labelTotal.Text = "Total Quantity:";
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.AllowDrop = true;
            comboBoxFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilter.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxFilter.FormattingEnabled = true;
            comboBoxFilter.Items.AddRange(new object[] { "All", "Air", "Rail", "Road", "Sea" });
            comboBoxFilter.Location = new Point(680, 1);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(121, 38);
            comboBoxFilter.TabIndex = 45;
            comboBoxFilter.SelectedValueChanged += comboBoxFilter_SelectedValueChanged;
            // 
            // labelFilter
            // 
            labelFilter.AutoSize = true;
            labelFilter.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelFilter.Location = new Point(518, 5);
            labelFilter.Name = "labelFilter";
            labelFilter.Size = new Size(156, 30);
            labelFilter.TabIndex = 44;
            labelFilter.Text = "Shipping Type:";
            // 
            // labelTotalQuantity
            // 
            labelTotalQuantity.AutoSize = true;
            labelTotalQuantity.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotalQuantity.Location = new Point(989, 6);
            labelTotalQuantity.Name = "labelTotalQuantity";
            labelTotalQuantity.Size = new Size(38, 30);
            labelTotalQuantity.TabIndex = 47;
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
            Controls.Add(buttonReload);
            Controls.Add(labelShippings);
            Controls.Add(dataGridViewShippings);
            Name = "Form1";
            Text = "Logistics (User)";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewShippings).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonReload;
        private Label labelShippings;
        private DataGridView dataGridViewShippings;
        private Label labelTotal;
        private ComboBox comboBoxFilter;
        private Label labelFilter;
        private Label labelTotalQuantity;
    }
}
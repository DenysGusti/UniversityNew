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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            buttonReload = new Button();
            labelShippings = new Label();
            dataGridViewShippings = new DataGridView();
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
            dataGridViewShippings.Location = new Point(-2, 39);
            dataGridViewShippings.MultiSelect = false;
            dataGridViewShippings.Name = "dataGridViewShippings";
            dataGridViewShippings.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewShippings.RowTemplate.Height = 25;
            dataGridViewShippings.Size = new Size(1261, 277);
            dataGridViewShippings.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
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
    }
}
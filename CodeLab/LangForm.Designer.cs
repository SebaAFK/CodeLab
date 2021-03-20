namespace CodeLab
{
    partial class LangForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Langs_dataGridViewX = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.LangAr_textBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LangEn_textBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Add_button = new DevComponents.DotNetBar.ButtonX();
            this.Edit_button = new DevComponents.DotNetBar.ButtonX();
            this.Delete_button = new DevComponents.DotNetBar.ButtonX();
            this.Save_button = new DevComponents.DotNetBar.ButtonX();
            this.Cancel_button = new DevComponents.DotNetBar.ButtonX();
            this.languagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCodeLab = new CodeLab.DataSetCodeLab();
            this.languageNameArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.languageNameEnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.languagesTableAdapter = new CodeLab.DataSetCodeLabTableAdapters.LanguagesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Langs_dataGridViewX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.languagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCodeLab)).BeginInit();
            this.SuspendLayout();
            // 
            // Langs_dataGridViewX
            // 
            this.Langs_dataGridViewX.AllowUserToAddRows = false;
            this.Langs_dataGridViewX.AllowUserToDeleteRows = false;
            this.Langs_dataGridViewX.AllowUserToOrderColumns = true;
            this.Langs_dataGridViewX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Langs_dataGridViewX.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Langs_dataGridViewX.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Langs_dataGridViewX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Langs_dataGridViewX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.languageNameArDataGridViewTextBoxColumn,
            this.languageNameEnDataGridViewTextBoxColumn});
            this.Langs_dataGridViewX.DataSource = this.languagesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Langs_dataGridViewX.DefaultCellStyle = dataGridViewCellStyle2;
            this.Langs_dataGridViewX.EnableHeadersVisualStyles = false;
            this.Langs_dataGridViewX.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.Langs_dataGridViewX.Location = new System.Drawing.Point(12, 54);
            this.Langs_dataGridViewX.MultiSelect = false;
            this.Langs_dataGridViewX.Name = "Langs_dataGridViewX";
            this.Langs_dataGridViewX.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Langs_dataGridViewX.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Langs_dataGridViewX.Size = new System.Drawing.Size(776, 351);
            this.Langs_dataGridViewX.TabIndex = 0;
            // 
            // LangAr_textBox
            // 
            this.LangAr_textBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.LangAr_textBox.Border.Class = "TextBoxBorder";
            this.LangAr_textBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LangAr_textBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.languagesBindingSource, "Language_NameAr", true));
            this.LangAr_textBox.Location = new System.Drawing.Point(105, 23);
            this.LangAr_textBox.Name = "LangAr_textBox";
            this.LangAr_textBox.PreventEnterBeep = true;
            this.LangAr_textBox.Size = new System.Drawing.Size(242, 20);
            this.LangAr_textBox.TabIndex = 1;
            this.LangAr_textBox.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.LangAr_textBox.WatermarkText = "Language Name Ar";
            // 
            // LangEn_textBox
            // 
            this.LangEn_textBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.LangEn_textBox.Border.Class = "TextBoxBorder";
            this.LangEn_textBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LangEn_textBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.languagesBindingSource, "Language_NameEn", true));
            this.LangEn_textBox.Location = new System.Drawing.Point(432, 23);
            this.LangEn_textBox.Name = "LangEn_textBox";
            this.LangEn_textBox.PreventEnterBeep = true;
            this.LangEn_textBox.Size = new System.Drawing.Size(249, 20);
            this.LangEn_textBox.TabIndex = 2;
            this.LangEn_textBox.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.LangEn_textBox.WatermarkText = "Language Name En";
            // 
            // Add_button
            // 
            this.Add_button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Add_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Add_button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Add_button.Location = new System.Drawing.Point(636, 413);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(75, 23);
            this.Add_button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Add_button.TabIndex = 3;
            this.Add_button.Text = "Add";
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Edit_button
            // 
            this.Edit_button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Edit_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Edit_button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Edit_button.Location = new System.Drawing.Point(555, 413);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(75, 23);
            this.Edit_button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Edit_button.TabIndex = 4;
            this.Edit_button.Text = "Edit";
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Delete_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Delete_button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Delete_button.Location = new System.Drawing.Point(474, 413);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(75, 23);
            this.Delete_button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Delete_button.TabIndex = 5;
            this.Delete_button.Text = "Delete";
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Save_button
            // 
            this.Save_button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Save_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Save_button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Save_button.Location = new System.Drawing.Point(69, 413);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(75, 23);
            this.Save_button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Save_button.TabIndex = 7;
            this.Save_button.Text = "Save";
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Cancel_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Cancel_button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Cancel_button.Location = new System.Drawing.Point(150, 413);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Cancel_button.TabIndex = 6;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // languagesBindingSource
            // 
            this.languagesBindingSource.DataMember = "Languages";
            this.languagesBindingSource.DataSource = this.dataSetCodeLab;
            // 
            // dataSetCodeLab
            // 
            this.dataSetCodeLab.DataSetName = "DataSetCodeLab";
            this.dataSetCodeLab.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // languageNameArDataGridViewTextBoxColumn
            // 
            this.languageNameArDataGridViewTextBoxColumn.DataPropertyName = "Language_NameAr";
            this.languageNameArDataGridViewTextBoxColumn.HeaderText = "Language_NameAr";
            this.languageNameArDataGridViewTextBoxColumn.Name = "languageNameArDataGridViewTextBoxColumn";
            this.languageNameArDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // languageNameEnDataGridViewTextBoxColumn
            // 
            this.languageNameEnDataGridViewTextBoxColumn.DataPropertyName = "Language_NameEn";
            this.languageNameEnDataGridViewTextBoxColumn.HeaderText = "Language_NameEn";
            this.languageNameEnDataGridViewTextBoxColumn.Name = "languageNameEnDataGridViewTextBoxColumn";
            this.languageNameEnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // languagesTableAdapter
            // 
            this.languagesTableAdapter.ClearBeforeFill = true;
            // 
            // LangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Edit_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.LangEn_textBox);
            this.Controls.Add(this.LangAr_textBox);
            this.Controls.Add(this.Langs_dataGridViewX);
            this.DoubleBuffered = true;
            this.Name = "LangForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Language";
            this.Load += new System.EventHandler(this.LangForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Langs_dataGridViewX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.languagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCodeLab)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX Langs_dataGridViewX;
        private DataSetCodeLab dataSetCodeLab;
        private System.Windows.Forms.BindingSource languagesBindingSource;
        private DataSetCodeLabTableAdapters.LanguagesTableAdapter languagesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn languageNameArDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn languageNameEnDataGridViewTextBoxColumn;
        private DevComponents.DotNetBar.Controls.TextBoxX LangAr_textBox;
        private DevComponents.DotNetBar.Controls.TextBoxX LangEn_textBox;
        private DevComponents.DotNetBar.ButtonX Add_button;
        private DevComponents.DotNetBar.ButtonX Edit_button;
        private DevComponents.DotNetBar.ButtonX Delete_button;
        private DevComponents.DotNetBar.ButtonX Save_button;
        private DevComponents.DotNetBar.ButtonX Cancel_button;
    }
}
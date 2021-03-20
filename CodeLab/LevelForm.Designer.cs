namespace CodeLab
{
    partial class LevelForm
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
            this.Levels_dataGridViewX = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.levelNameArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelNameEnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCodeLab = new CodeLab.DataSetCodeLab();
            this.LevelAr_textBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LevelEn_textBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Add_button = new DevComponents.DotNetBar.ButtonX();
            this.Edit_button = new DevComponents.DotNetBar.ButtonX();
            this.Delete_button = new DevComponents.DotNetBar.ButtonX();
            this.Save_button = new DevComponents.DotNetBar.ButtonX();
            this.Cancel_button = new DevComponents.DotNetBar.ButtonX();
            this.LevelNo_textBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.levelsTableAdapter = new CodeLab.DataSetCodeLabTableAdapters.LevelsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Levels_dataGridViewX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCodeLab)).BeginInit();
            this.SuspendLayout();
            // 
            // Levels_dataGridViewX
            // 
            this.Levels_dataGridViewX.AllowUserToAddRows = false;
            this.Levels_dataGridViewX.AllowUserToDeleteRows = false;
            this.Levels_dataGridViewX.AllowUserToOrderColumns = true;
            this.Levels_dataGridViewX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Levels_dataGridViewX.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Levels_dataGridViewX.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Levels_dataGridViewX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Levels_dataGridViewX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.levelNameArDataGridViewTextBoxColumn,
            this.levelNameEnDataGridViewTextBoxColumn,
            this.levelNoDataGridViewTextBoxColumn});
            this.Levels_dataGridViewX.DataSource = this.levelsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Levels_dataGridViewX.DefaultCellStyle = dataGridViewCellStyle2;
            this.Levels_dataGridViewX.EnableHeadersVisualStyles = false;
            this.Levels_dataGridViewX.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.Levels_dataGridViewX.Location = new System.Drawing.Point(12, 90);
            this.Levels_dataGridViewX.MultiSelect = false;
            this.Levels_dataGridViewX.Name = "Levels_dataGridViewX";
            this.Levels_dataGridViewX.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Levels_dataGridViewX.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Levels_dataGridViewX.Size = new System.Drawing.Size(776, 315);
            this.Levels_dataGridViewX.TabIndex = 0;
            // 
            // levelNameArDataGridViewTextBoxColumn
            // 
            this.levelNameArDataGridViewTextBoxColumn.DataPropertyName = "Level_NameAr";
            this.levelNameArDataGridViewTextBoxColumn.HeaderText = "Level_NameAr";
            this.levelNameArDataGridViewTextBoxColumn.Name = "levelNameArDataGridViewTextBoxColumn";
            this.levelNameArDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // levelNameEnDataGridViewTextBoxColumn
            // 
            this.levelNameEnDataGridViewTextBoxColumn.DataPropertyName = "Level_NameEn";
            this.levelNameEnDataGridViewTextBoxColumn.HeaderText = "Level_NameEn";
            this.levelNameEnDataGridViewTextBoxColumn.Name = "levelNameEnDataGridViewTextBoxColumn";
            this.levelNameEnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // levelNoDataGridViewTextBoxColumn
            // 
            this.levelNoDataGridViewTextBoxColumn.DataPropertyName = "Level_No";
            this.levelNoDataGridViewTextBoxColumn.HeaderText = "Level_No";
            this.levelNoDataGridViewTextBoxColumn.Name = "levelNoDataGridViewTextBoxColumn";
            this.levelNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // levelsBindingSource
            // 
            this.levelsBindingSource.DataMember = "Levels";
            this.levelsBindingSource.DataSource = this.dataSetCodeLab;
            // 
            // dataSetCodeLab
            // 
            this.dataSetCodeLab.DataSetName = "DataSetCodeLab";
            this.dataSetCodeLab.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LevelAr_textBox
            // 
            this.LevelAr_textBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.LevelAr_textBox.Border.Class = "TextBoxBorder";
            this.LevelAr_textBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LevelAr_textBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.levelsBindingSource, "Level_NameAr", true));
            this.LevelAr_textBox.Location = new System.Drawing.Point(105, 23);
            this.LevelAr_textBox.Name = "LevelAr_textBox";
            this.LevelAr_textBox.PreventEnterBeep = true;
            this.LevelAr_textBox.Size = new System.Drawing.Size(249, 20);
            this.LevelAr_textBox.TabIndex = 1;
            this.LevelAr_textBox.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.LevelAr_textBox.WatermarkText = "Level Name Ar";
            // 
            // LevelEn_textBox
            // 
            this.LevelEn_textBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.LevelEn_textBox.Border.Class = "TextBoxBorder";
            this.LevelEn_textBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LevelEn_textBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.levelsBindingSource, "Level_NameEn", true));
            this.LevelEn_textBox.Location = new System.Drawing.Point(105, 56);
            this.LevelEn_textBox.Name = "LevelEn_textBox";
            this.LevelEn_textBox.PreventEnterBeep = true;
            this.LevelEn_textBox.Size = new System.Drawing.Size(249, 20);
            this.LevelEn_textBox.TabIndex = 2;
            this.LevelEn_textBox.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.LevelEn_textBox.WatermarkText = "Level Name En";
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
            // LevelNo_textBox
            // 
            this.LevelNo_textBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.LevelNo_textBox.Border.Class = "TextBoxBorder";
            this.LevelNo_textBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LevelNo_textBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.levelsBindingSource, "Level_No", true));
            this.LevelNo_textBox.Location = new System.Drawing.Point(474, 23);
            this.LevelNo_textBox.Name = "LevelNo_textBox";
            this.LevelNo_textBox.PreventEnterBeep = true;
            this.LevelNo_textBox.Size = new System.Drawing.Size(183, 20);
            this.LevelNo_textBox.TabIndex = 8;
            this.LevelNo_textBox.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.LevelNo_textBox.WatermarkText = "Level No";
            this.LevelNo_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LevelNo_textBox_KeyPress);
            // 
            // levelsTableAdapter
            // 
            this.levelsTableAdapter.ClearBeforeFill = true;
            // 
            // LevelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.LevelNo_textBox);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Edit_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.LevelEn_textBox);
            this.Controls.Add(this.LevelAr_textBox);
            this.Controls.Add(this.Levels_dataGridViewX);
            this.DoubleBuffered = true;
            this.Name = "LevelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Levels";
            this.Load += new System.EventHandler(this.LevelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Levels_dataGridViewX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCodeLab)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX Levels_dataGridViewX;
        private DataSetCodeLab dataSetCodeLab;
        private DevComponents.DotNetBar.Controls.TextBoxX LevelAr_textBox;
        private DevComponents.DotNetBar.Controls.TextBoxX LevelEn_textBox;
        private DevComponents.DotNetBar.ButtonX Add_button;
        private DevComponents.DotNetBar.ButtonX Edit_button;
        private DevComponents.DotNetBar.ButtonX Delete_button;
        private DevComponents.DotNetBar.ButtonX Save_button;
        private DevComponents.DotNetBar.ButtonX Cancel_button;
        private DevComponents.DotNetBar.Controls.TextBoxX LevelNo_textBox;
        private System.Windows.Forms.BindingSource levelsBindingSource;
        private DataSetCodeLabTableAdapters.LevelsTableAdapter levelsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelNameArDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelNameEnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelNoDataGridViewTextBoxColumn;
    }
}
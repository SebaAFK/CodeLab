namespace CodeLab
{
    partial class LessonForm
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
            this.Lessons_dataGridViewX = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.lessonLevelNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lessonTitleArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.languageNameArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelNameArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lessonTitleEnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.languageNameEnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelNameEnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lessonsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCodeLab = new CodeLab.DataSetCodeLab();
            this.levelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LessonAr_textBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LessonEn_textBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Add_button = new DevComponents.DotNetBar.ButtonX();
            this.Edit_button = new DevComponents.DotNetBar.ButtonX();
            this.Delete_button = new DevComponents.DotNetBar.ButtonX();
            this.Save_button = new DevComponents.DotNetBar.ButtonX();
            this.Cancel_button = new DevComponents.DotNetBar.ButtonX();
            this.LessonNo_textBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.levelsTableAdapter = new CodeLab.DataSetCodeLabTableAdapters.LevelsTableAdapter();
            this.Lang_comboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.languagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.languagesTableAdapter = new CodeLab.DataSetCodeLabTableAdapters.LanguagesTableAdapter();
            this.Level_comboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lessonsTableAdapter = new CodeLab.DataSetCodeLabTableAdapters.LessonsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Lessons_dataGridViewX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCodeLab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.languagesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Lessons_dataGridViewX
            // 
            this.Lessons_dataGridViewX.AllowUserToAddRows = false;
            this.Lessons_dataGridViewX.AllowUserToDeleteRows = false;
            this.Lessons_dataGridViewX.AllowUserToOrderColumns = true;
            this.Lessons_dataGridViewX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lessons_dataGridViewX.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Lessons_dataGridViewX.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Lessons_dataGridViewX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Lessons_dataGridViewX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lessonLevelNoDataGridViewTextBoxColumn,
            this.lessonTitleArDataGridViewTextBoxColumn,
            this.languageNameArDataGridViewTextBoxColumn,
            this.levelNameArDataGridViewTextBoxColumn,
            this.lessonTitleEnDataGridViewTextBoxColumn,
            this.languageNameEnDataGridViewTextBoxColumn,
            this.levelNameEnDataGridViewTextBoxColumn,
            this.levelNoDataGridViewTextBoxColumn});
            this.Lessons_dataGridViewX.DataSource = this.lessonsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Lessons_dataGridViewX.DefaultCellStyle = dataGridViewCellStyle2;
            this.Lessons_dataGridViewX.EnableHeadersVisualStyles = false;
            this.Lessons_dataGridViewX.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.Lessons_dataGridViewX.Location = new System.Drawing.Point(12, 90);
            this.Lessons_dataGridViewX.MultiSelect = false;
            this.Lessons_dataGridViewX.Name = "Lessons_dataGridViewX";
            this.Lessons_dataGridViewX.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Lessons_dataGridViewX.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Lessons_dataGridViewX.Size = new System.Drawing.Size(776, 315);
            this.Lessons_dataGridViewX.TabIndex = 0;
            // 
            // lessonLevelNoDataGridViewTextBoxColumn
            // 
            this.lessonLevelNoDataGridViewTextBoxColumn.DataPropertyName = "Lesson_Level_No";
            this.lessonLevelNoDataGridViewTextBoxColumn.HeaderText = "Lesson_Level_No";
            this.lessonLevelNoDataGridViewTextBoxColumn.Name = "lessonLevelNoDataGridViewTextBoxColumn";
            this.lessonLevelNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lessonTitleArDataGridViewTextBoxColumn
            // 
            this.lessonTitleArDataGridViewTextBoxColumn.DataPropertyName = "Lesson_TitleAr";
            this.lessonTitleArDataGridViewTextBoxColumn.HeaderText = "Lesson_TitleAr";
            this.lessonTitleArDataGridViewTextBoxColumn.Name = "lessonTitleArDataGridViewTextBoxColumn";
            this.lessonTitleArDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // languageNameArDataGridViewTextBoxColumn
            // 
            this.languageNameArDataGridViewTextBoxColumn.DataPropertyName = "Language_NameAr";
            this.languageNameArDataGridViewTextBoxColumn.HeaderText = "Language_NameAr";
            this.languageNameArDataGridViewTextBoxColumn.Name = "languageNameArDataGridViewTextBoxColumn";
            this.languageNameArDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // levelNameArDataGridViewTextBoxColumn
            // 
            this.levelNameArDataGridViewTextBoxColumn.DataPropertyName = "Level_NameAr";
            this.levelNameArDataGridViewTextBoxColumn.HeaderText = "Level_NameAr";
            this.levelNameArDataGridViewTextBoxColumn.Name = "levelNameArDataGridViewTextBoxColumn";
            this.levelNameArDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lessonTitleEnDataGridViewTextBoxColumn
            // 
            this.lessonTitleEnDataGridViewTextBoxColumn.DataPropertyName = "Lesson_TitleEn";
            this.lessonTitleEnDataGridViewTextBoxColumn.HeaderText = "Lesson_TitleEn";
            this.lessonTitleEnDataGridViewTextBoxColumn.Name = "lessonTitleEnDataGridViewTextBoxColumn";
            this.lessonTitleEnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // languageNameEnDataGridViewTextBoxColumn
            // 
            this.languageNameEnDataGridViewTextBoxColumn.DataPropertyName = "Language_NameEn";
            this.languageNameEnDataGridViewTextBoxColumn.HeaderText = "Language_NameEn";
            this.languageNameEnDataGridViewTextBoxColumn.Name = "languageNameEnDataGridViewTextBoxColumn";
            this.languageNameEnDataGridViewTextBoxColumn.ReadOnly = true;
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
            // lessonsBindingSource
            // 
            this.lessonsBindingSource.DataMember = "Lessons";
            this.lessonsBindingSource.DataSource = this.dataSetCodeLab;
            // 
            // dataSetCodeLab
            // 
            this.dataSetCodeLab.DataSetName = "DataSetCodeLab";
            this.dataSetCodeLab.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // levelsBindingSource
            // 
            this.levelsBindingSource.DataMember = "Levels";
            this.levelsBindingSource.DataSource = this.dataSetCodeLab;
            // 
            // LessonAr_textBox
            // 
            this.LessonAr_textBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.LessonAr_textBox.Border.Class = "TextBoxBorder";
            this.LessonAr_textBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LessonAr_textBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lessonsBindingSource, "Lesson_TitleAr", true));
            this.LessonAr_textBox.Location = new System.Drawing.Point(39, 23);
            this.LessonAr_textBox.Name = "LessonAr_textBox";
            this.LessonAr_textBox.PreventEnterBeep = true;
            this.LessonAr_textBox.Size = new System.Drawing.Size(249, 20);
            this.LessonAr_textBox.TabIndex = 1;
            this.LessonAr_textBox.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.LessonAr_textBox.WatermarkText = "Lesson Title Ar";
            // 
            // LessonEn_textBox
            // 
            this.LessonEn_textBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.LessonEn_textBox.Border.Class = "TextBoxBorder";
            this.LessonEn_textBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LessonEn_textBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lessonsBindingSource, "Lesson_TitleEn", true));
            this.LessonEn_textBox.Location = new System.Drawing.Point(339, 23);
            this.LessonEn_textBox.Name = "LessonEn_textBox";
            this.LessonEn_textBox.PreventEnterBeep = true;
            this.LessonEn_textBox.Size = new System.Drawing.Size(249, 20);
            this.LessonEn_textBox.TabIndex = 2;
            this.LessonEn_textBox.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.LessonEn_textBox.WatermarkText = "Lesson Title En";
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
            // LessonNo_textBox
            // 
            this.LessonNo_textBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.LessonNo_textBox.Border.Class = "TextBoxBorder";
            this.LessonNo_textBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LessonNo_textBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lessonsBindingSource, "Lesson_Level_No", true));
            this.LessonNo_textBox.Location = new System.Drawing.Point(633, 23);
            this.LessonNo_textBox.Name = "LessonNo_textBox";
            this.LessonNo_textBox.PreventEnterBeep = true;
            this.LessonNo_textBox.Size = new System.Drawing.Size(137, 20);
            this.LessonNo_textBox.TabIndex = 8;
            this.LessonNo_textBox.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.LessonNo_textBox.WatermarkText = "Lesson No";
            this.LessonNo_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LessonNo_textBox_KeyPress);
            // 
            // levelsTableAdapter
            // 
            this.levelsTableAdapter.ClearBeforeFill = true;
            // 
            // Lang_comboBox
            // 
            this.Lang_comboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lang_comboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.lessonsBindingSource, "Language_ID", true));
            this.Lang_comboBox.DataSource = this.languagesBindingSource;
            this.Lang_comboBox.DisplayMember = "Language_NameAr";
            this.Lang_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Lang_comboBox.FormattingEnabled = true;
            this.Lang_comboBox.ItemHeight = 14;
            this.Lang_comboBox.Location = new System.Drawing.Point(339, 59);
            this.Lang_comboBox.Name = "Lang_comboBox";
            this.Lang_comboBox.Size = new System.Drawing.Size(249, 20);
            this.Lang_comboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Lang_comboBox.TabIndex = 10;
            this.Lang_comboBox.ValueMember = "ID";
            this.Lang_comboBox.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.Lang_comboBox.WatermarkText = "Language";
            // 
            // languagesBindingSource
            // 
            this.languagesBindingSource.DataMember = "Languages";
            this.languagesBindingSource.DataSource = this.dataSetCodeLab;
            // 
            // languagesTableAdapter
            // 
            this.languagesTableAdapter.ClearBeforeFill = true;
            // 
            // Level_comboBox
            // 
            this.Level_comboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Level_comboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.lessonsBindingSource, "Level_ID", true));
            this.Level_comboBox.DataSource = this.levelsBindingSource;
            this.Level_comboBox.DisplayMember = "Level_NameAr";
            this.Level_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Level_comboBox.FormattingEnabled = true;
            this.Level_comboBox.ItemHeight = 14;
            this.Level_comboBox.Location = new System.Drawing.Point(39, 59);
            this.Level_comboBox.Name = "Level_comboBox";
            this.Level_comboBox.Size = new System.Drawing.Size(249, 20);
            this.Level_comboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Level_comboBox.TabIndex = 11;
            this.Level_comboBox.ValueMember = "ID";
            this.Level_comboBox.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.Level_comboBox.WatermarkText = "Level";
            // 
            // lessonsTableAdapter
            // 
            this.lessonsTableAdapter.ClearBeforeFill = true;
            // 
            // LessonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.Level_comboBox);
            this.Controls.Add(this.Lang_comboBox);
            this.Controls.Add(this.LessonNo_textBox);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Edit_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.LessonEn_textBox);
            this.Controls.Add(this.LessonAr_textBox);
            this.Controls.Add(this.Lessons_dataGridViewX);
            this.DoubleBuffered = true;
            this.Name = "LessonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lessons";
            this.Load += new System.EventHandler(this.LessonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Lessons_dataGridViewX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCodeLab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.languagesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX Lessons_dataGridViewX;
        private DataSetCodeLab dataSetCodeLab;
        private DevComponents.DotNetBar.Controls.TextBoxX LessonAr_textBox;
        private DevComponents.DotNetBar.Controls.TextBoxX LessonEn_textBox;
        private DevComponents.DotNetBar.ButtonX Add_button;
        private DevComponents.DotNetBar.ButtonX Edit_button;
        private DevComponents.DotNetBar.ButtonX Delete_button;
        private DevComponents.DotNetBar.ButtonX Save_button;
        private DevComponents.DotNetBar.ButtonX Cancel_button;
        private DevComponents.DotNetBar.Controls.TextBoxX LessonNo_textBox;
        private System.Windows.Forms.BindingSource levelsBindingSource;
        private DataSetCodeLabTableAdapters.LevelsTableAdapter levelsTableAdapter;
        private DevComponents.DotNetBar.Controls.ComboBoxEx Lang_comboBox;
        private System.Windows.Forms.BindingSource languagesBindingSource;
        private DataSetCodeLabTableAdapters.LanguagesTableAdapter languagesTableAdapter;
        private DevComponents.DotNetBar.Controls.ComboBoxEx Level_comboBox;
        private System.Windows.Forms.BindingSource lessonsBindingSource;
        private DataSetCodeLabTableAdapters.LessonsTableAdapter lessonsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn lessonLevelNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lessonTitleArDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn languageNameArDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelNameArDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lessonTitleEnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn languageNameEnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelNameEnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelNoDataGridViewTextBoxColumn;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeLab
{
    public partial class LessonForm : DevComponents.DotNetBar.OfficeForm
    {
        private int operation = 0;
        public LessonForm()
        {
            InitializeComponent();
        }

        private void LessonForm_Load(object sender, EventArgs e)
        {
            LoadForm(true);
        }
        private void LoadForm(bool WithData)
        {
            operation = 0;
            if (WithData)
            {
                this.languagesTableAdapter.FillByIs_Deleted(this.dataSetCodeLab.Languages, false);
                this.levelsTableAdapter.FillByIs_Deleted(this.dataSetCodeLab.Levels, false);
                this.lessonsTableAdapter.FillByIs_Deleted(this.dataSetCodeLab.Lessons, false);
            }
            LessonAr_textBox.ReadOnly = true;
            LessonEn_textBox.ReadOnly = true;
            LessonNo_textBox.ReadOnly = true;
            Level_comboBox.Enabled = false;
            Lang_comboBox.Enabled = false;
            Lessons_dataGridViewX.Enabled = true;
            Add_button.Enabled = true;
            if (this.dataSetCodeLab.Lessons.Count > 0)
            {
                Delete_button.Enabled = true;
                Edit_button.Enabled = true;
            }
            else
            {
                Delete_button.Enabled = false;
                Edit_button.Enabled = false;
            }
            Save_button.Enabled = false;
            Cancel_button.Enabled = false;
        }
        private void ClearInputs()
        {
            LessonAr_textBox.Text = "";
            LessonEn_textBox.Text = "";
            LessonNo_textBox.Text = "";
            Level_comboBox.SelectedIndex = -1;
            Lang_comboBox.SelectedIndex = -1;
        }
        private void Add_button_Click(object sender, EventArgs e)
        {
            operation = 1;
            ClearInputs();
            LessonAr_textBox.ReadOnly = false;
            LessonEn_textBox.ReadOnly = false;
            LessonNo_textBox.ReadOnly = false;
            Level_comboBox.Enabled = true;
            Lang_comboBox.Enabled = true;
            Lessons_dataGridViewX.Enabled = false;
            Add_button.Enabled = false;
            Delete_button.Enabled = false;
            Edit_button.Enabled = false;
            Save_button.Enabled = true;
            Cancel_button.Enabled = true;
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            int upated_id = 0;
            if (LessonAr_textBox.Text.Trim() == "")
            {
                ModuleClass.ShowMessage(null, "Enter Value", LessonAr_textBox);
                return;
            }
            if (LessonEn_textBox.Text.Trim() == "")
            {
                ModuleClass.ShowMessage(null, "Enter Value", LessonEn_textBox);
                return;
            }
            int levelno = 0;
            try
            {
                levelno = int.Parse(LessonNo_textBox.Text);
            }
            catch
            {
                ModuleClass.ShowMessage(null, "Must Be Number", LessonNo_textBox);
            }
            if (levelno <= 0)
            {
                ModuleClass.ShowMessage(null, "Must Be Number More Than Zero", LessonNo_textBox);
            }
            int langid = 0;
            try
            {
                langid = (int)Lang_comboBox.SelectedValue;
            }
            catch
            {
            }
            int levelid = 0;
            try
            {
                levelid = (int)Level_comboBox.SelectedValue;
            }
            catch
            {
            }
            if (langid <= 0)
            {
                ModuleClass.ShowMessage(null, "Must Select Language", Lang_comboBox);
            }
            if (levelid <= 0)
            {
                ModuleClass.ShowMessage(null, "Must Select Level", Level_comboBox);
            }
            if (operation == 1)
            {
                try
                {
                    this.lessonsTableAdapter.Insert1(LessonAr_textBox.Text, LessonEn_textBox.Text, langid, levelid, levelno, false);
                    ModuleClass.ShowMessage(null, "Saved", Save_button);
                    lessonsBindingSource.MoveLast();
                }
                catch (Exception ex)
                {
                    ModuleClass.ShowMessage(null, ex.Message, Save_button);
                    return;
                }
            }
            else
            {
                upated_id = ((DataSetCodeLab.LessonsRow)((DataRowView)lessonsBindingSource.Current).Row).ID;
                try
                {
                    this.lessonsTableAdapter.UpdateLesson(LessonAr_textBox.Text, LessonEn_textBox.Text, langid, levelid, levelno, false, upated_id);
                    ModuleClass.ShowMessage(null, "Updated", Save_button);
                }
                catch (Exception ex)
                {
                    ModuleClass.ShowMessage(null, ex.Message, Save_button);
                    return;
                }
            }
            int temp_operation = operation;
            LoadForm(true);
            if (temp_operation == 1)
            {
                lessonsBindingSource.MoveLast();
            }
            else
            {
                lessonsBindingSource.Position = lessonsBindingSource.Find("ID", upated_id);
            }
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            operation = 2;
            LessonAr_textBox.ReadOnly = false;
            LessonEn_textBox.ReadOnly = false;
            LessonNo_textBox.ReadOnly = false;
            Lang_comboBox.Enabled = true;
            Level_comboBox.Enabled = true;
            Lessons_dataGridViewX.Enabled = false;
            Add_button.Enabled = false;
            Delete_button.Enabled = false;
            Edit_button.Enabled = false;
            Save_button.Enabled = true;
            Cancel_button.Enabled = true;
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            int position_Now = 0;
            try
            {
                position_Now = lessonsBindingSource.Position;
                position_Now = position_Now - 1;
                int deleted_id = ((DataSetCodeLab.LessonsRow)((DataRowView)lessonsBindingSource.Current).Row).ID;
                this.lessonsTableAdapter.UpdateLesson(LessonAr_textBox.Text, LessonEn_textBox.Text, (int)Lang_comboBox.SelectedValue, (int)Level_comboBox.SelectedValue, int.Parse(LessonNo_textBox.Text), true, deleted_id);
                ModuleClass.ShowMessage(null, "Deleted", Delete_button);
            }
            catch (Exception ex)
            {
                ModuleClass.ShowMessage(null, ex.Message, Delete_button);
                return;
            }
            LoadForm(true);
            try
            {
                lessonsBindingSource.Position = position_Now;
            }
            catch
            {
            }
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            lessonsBindingSource.CancelEdit();
            LoadForm(false);
        }

        private void LessonNo_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '\b':
                    {
                        e.Handled = false;
                        break;
                    }

                default:
                    {
                        e.Handled = true;
                        break;
                    }
            }
        }
    }
}

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
    public partial class LevelForm : DevComponents.DotNetBar.OfficeForm
    {
        private int operation = 0;
        public LevelForm()
        {
            InitializeComponent();
        }

        private void LevelForm_Load(object sender, EventArgs e)
        {
            LoadForm(true);
        }
        private void LoadForm(bool WithData)
        {
            operation = 0;
            if (WithData)
            {
                this.levelsTableAdapter.FillByIs_Deleted(this.dataSetCodeLab.Levels,false);
            }
            LevelAr_textBox.ReadOnly = true;
            LevelEn_textBox.ReadOnly = true;
            LevelNo_textBox.ReadOnly = true;
            Levels_dataGridViewX.Enabled = true;
            Add_button.Enabled = true;
            if (this.dataSetCodeLab.Levels.Count > 0)
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
            LevelAr_textBox.Text = "";
            LevelEn_textBox.Text = "";
            LevelNo_textBox.Text = "";
        }
        private void Add_button_Click(object sender, EventArgs e)
        {
            operation = 1;
            ClearInputs();
            LevelAr_textBox.ReadOnly = false;
            LevelEn_textBox.ReadOnly = false;
            LevelNo_textBox.ReadOnly = false;
            Levels_dataGridViewX.Enabled = false;
            Add_button.Enabled = false;
            Delete_button.Enabled = false;
            Edit_button.Enabled = false;
            Save_button.Enabled = true;
            Cancel_button.Enabled = true;
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            int upated_id = 0;
            if (LevelAr_textBox.Text.Trim() == "")
            {
                ModuleClass.ShowMessage(null, "Enter Value", LevelAr_textBox);
                return;
            }
            if (LevelEn_textBox.Text.Trim() == "")
            {
                ModuleClass.ShowMessage(null, "Enter Value", LevelEn_textBox);
                return;
            }
            int levelno = 0;
            try
            {
                levelno = int.Parse(LevelNo_textBox.Text);
            }
            catch
            {
                ModuleClass.ShowMessage(null, "Must Be Number", LevelNo_textBox);
            }
            if (levelno <= 0)
            {
                ModuleClass.ShowMessage(null, "Must Be Number More Than Zero", LevelNo_textBox);
            }
            if (operation == 1)
            {
                try
                {
                    this.levelsTableAdapter.Insert(LevelAr_textBox.Text, LevelEn_textBox.Text, levelno, false);
                    ModuleClass.ShowMessage(null, "Saved", Save_button);
                    levelsBindingSource.MoveLast();
                }
                catch (Exception ex)
                {
                    ModuleClass.ShowMessage(null, ex.Message, Save_button);
                    return;
                }
            }
            else
            {
                upated_id = ((DataSetCodeLab.LessonsRow)((DataRowView)levelsBindingSource.Current).Row).ID;
                try
                {
                    this.levelsTableAdapter.UpdateLevel(LevelAr_textBox.Text, LevelEn_textBox.Text, levelno,false, upated_id);
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
                levelsBindingSource.MoveLast();
            }
            else
            {
                levelsBindingSource.Position = levelsBindingSource.Find("ID", upated_id);
            }
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            operation = 2;
            LevelAr_textBox.ReadOnly = false;
            LevelEn_textBox.ReadOnly = false;
            LevelNo_textBox.ReadOnly = false;
            Levels_dataGridViewX.Enabled = false;
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
                position_Now = levelsBindingSource.Position;
                position_Now = position_Now - 1;
                int deleted_id = ((DataSetCodeLab.LevelsRow)((DataRowView)levelsBindingSource.Current).Row).ID;
                this.levelsTableAdapter.UpdateLevel(LevelAr_textBox.Text, LevelEn_textBox.Text, int.Parse(LevelNo_textBox.Text),true, deleted_id);
                ModuleClass.ShowMessage(null, "Deleted", Save_button);
            }
            catch (Exception ex)
            {
                ModuleClass.ShowMessage(null, ex.Message, Save_button);
                return;
            }
            LoadForm(true);
            try
            {
                levelsBindingSource.Position = position_Now;
            }
            catch
            {
            }
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            levelsBindingSource.CancelEdit();
            LoadForm(false);
        }

        private void LevelNo_textBox_KeyPress(object sender, KeyPressEventArgs e)
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

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
    public partial class LangForm : DevComponents.DotNetBar.OfficeForm
    {
        private int operation = 0;
        public LangForm()
        {
            InitializeComponent();
        }

        private void LangForm_Load(object sender, EventArgs e)
        {
            LoadForm(true);
        }
        private void LoadForm(bool WithData)
        {
            operation = 0;
            if (WithData)
            {
                this.languagesTableAdapter.FillByIs_Deleted(this.dataSetCodeLab.Languages, false);
            }
            LangAr_textBox.ReadOnly = true;
            LangEn_textBox.ReadOnly = true;
            Langs_dataGridViewX.Enabled = true;
            Add_button.Enabled = true;
            if (this.dataSetCodeLab.Languages.Count > 0)
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
            LangAr_textBox.Text = "";
            LangEn_textBox.Text = "";
        }
        private void Add_button_Click(object sender, EventArgs e)
        {
            operation = 1;
            ClearInputs();
            LangAr_textBox.ReadOnly = false;
            LangEn_textBox.ReadOnly = false;
            Langs_dataGridViewX.Enabled = false;
            Add_button.Enabled = false;
            Delete_button.Enabled = false;
            Edit_button.Enabled = false;
            Save_button.Enabled = true;
            Cancel_button.Enabled = true;
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            int upated_id = 0;
            if (LangAr_textBox.Text.Trim() == "")
            {
                ModuleClass.ShowMessage(null, "Enter Value", LangAr_textBox);
                return;
            }
            if (LangEn_textBox.Text.Trim() == "")
            {
                ModuleClass.ShowMessage(null, "Enter Value", LangEn_textBox);
                return;
            }
            if (operation == 1)
            {
                try
                {
                    this.languagesTableAdapter.Insert(LangAr_textBox.Text, LangEn_textBox.Text, false);
                    ModuleClass.ShowMessage(null, "Saved", Save_button);
                    languagesBindingSource.MoveLast();
                }
                catch (Exception ex)
                {
                    ModuleClass.ShowMessage(null, ex.Message, Save_button);
                    return;
                }
            }
            else
            {
                upated_id = ((DataSetCodeLab.LanguagesRow)((DataRowView)languagesBindingSource.Current).Row).ID;
                try
                {
                    this.languagesTableAdapter.UpdateLanguage(LangAr_textBox.Text, LangEn_textBox.Text,false, upated_id);
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
                languagesBindingSource.MoveLast();
            }
            else
            {
                languagesBindingSource.Position = languagesBindingSource.Find("ID", upated_id);
            }
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            operation = 2;
            LangAr_textBox.ReadOnly = false;
            LangEn_textBox.ReadOnly = false;
            Langs_dataGridViewX.Enabled = false;
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
                position_Now = languagesBindingSource.Position;
                position_Now = position_Now - 1;
                int deleted_id = ((DataSetCodeLab.LanguagesRow)((DataRowView)languagesBindingSource.Current).Row).ID;
                this.languagesTableAdapter.UpdateLanguage(LangAr_textBox.Text, LangEn_textBox.Text, true, deleted_id);
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
                languagesBindingSource.Position = position_Now;
            }
            catch
            {
            }
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            languagesBindingSource.CancelEdit();
            LoadForm(false);
        }
    }
}

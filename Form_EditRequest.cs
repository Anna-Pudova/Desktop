using System;
using System.Windows.Forms;

namespace MongoDB_Base
{
    public partial class Form_EditRequest : Form
    {
        MongoDB_Class _Obj = MongoDB_Class.GetObject();
        Class_Request StuObj_;
        public Form_EditRequest(Class_Request StuObj)
        {
            InitializeComponent();
            StuObj_ = StuObj;
        }

        private void LoadData()
        {
            StuObj_.Id = int.Parse(TBID.Text.ToString().Trim());
            StuObj_.AccountCD = comboBoxAbonent.SelectedItem.ToString();
            StuObj_.ExecutorCD = comboBoxexecutor.SelectedItem.ToString();
            StuObj_.FailureCD = comboBoxdisrepair.SelectedItem.ToString();
            StuObj_.ExecutionDate = dateTimePickerdateV.Value;
            StuObj_.IncomingDate = dateTimePickerdateP.Value;
            if (StuObj_.Executed)
                radioButtonYes.Checked = true;
            else
                radioButtonNo.Checked = true;
        }

        private void DataLoad()
        {
            TBID.Text = StuObj_.Id.ToString();
            comboBoxAbonent.Text = StuObj_.AccountCD;
            comboBoxexecutor.Text = StuObj_.ExecutorCD;
            comboBoxdisrepair.Text = StuObj_.FailureCD;
            dateTimePickerdateV.Value = StuObj_.ExecutionDate;
            dateTimePickerdateP.Value = StuObj_.IncomingDate;
            if (radioButtonYes.Checked)
                radioButtonYes.Checked = StuObj_.Executed;
            else
                radioButtonNo.Checked = StuObj_.Executed;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (TBID.Text != "" && comboBoxAbonent.Text != "" && comboBoxexecutor.Text != "" && comboBoxdisrepair.Text != "")
            {
                LoadData();
                if (TBID.Modified == false)
                    _Obj.Update_Request_Information(StuObj_);
                else
                    _Obj.Insert_Request_Information(StuObj_);
            }
            else
                MessageBox.Show("Поля заполнены неверно");
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void TBID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Введите целое число");
            }
        }

        private void Form_EditRequest_Load(object sender, EventArgs e)
        {
            DataLoad();
        }
    }
}
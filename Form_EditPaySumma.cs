using System;
using System.Windows.Forms;

namespace MongoDB_Base
{
    public partial class Form_EditPaySumma : Form
    {
        MongoDB_Class _Obj = MongoDB_Class.GetObject();
        Class_PaySumma StuObj_;
        public Form_EditPaySumma(Class_PaySumma StuObj)
        {
            InitializeComponent();
            StuObj_ = StuObj;
        }

        private void LoadData()
        {
                StuObj_.Id = int.Parse(TBID.Text.ToString().Trim());
                StuObj_.AccountCD = comboBoxAbonent.SelectedItem.ToString();
                StuObj_.ServiceCD = comboBoxService.SelectedItem.ToString();
                StuObj_.PaySum = double.Parse(TBSum.Text.ToString().Trim());
                StuObj_.PayDate = dateTimePickerDate.Value;
                StuObj_.PayMonth = TBMonth.Text.ToString().Trim();
                StuObj_.PayYear = int.Parse(TBYear.Text.ToString().Trim());
        }

        private void DataLoad()
        {
            TBID.Text = StuObj_.Id.ToString();
            comboBoxAbonent.Text = StuObj_.AccountCD;
            comboBoxService.Text = StuObj_.ServiceCD;
            TBSum.Text = StuObj_.PaySum.ToString();
            TBMonth.Text = StuObj_.PayMonth.ToString();
            TBYear.Text = StuObj_.PayYear.ToString();
            dateTimePickerDate.Value = StuObj_.PayDate;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (TBID.Text != "" && TBSum.Text != "" && TBMonth.Text != "" && TBYear.Text != "" && comboBoxAbonent.Text != "" && comboBoxService.Text != "")
            {
                LoadData();
                if (TBID.Modified == false)
                    _Obj.Update_PaySumma_Information(StuObj_);
                else
                    _Obj.Insert_PaySumma_Information(StuObj_);
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

        private void TBSum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8 && e.KeyChar != 44)
            {
                e.Handled = true;
                MessageBox.Show("Число пишется через запятую");
            }
        }

        private void Form_EditPaySumma_Load(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void TBMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TBMonth.Text.Length == 1)
                TBMonth.Text = TBMonth.Text.ToUpper();
            TBMonth.Select(TBMonth.Text.Length, 0);
            if (e.KeyChar != 8 && (e.KeyChar < 'А' || e.KeyChar > 'я'))
            {
                e.Handled = true;
                MessageBox.Show("Название месяца пишется на кириллице");
            }
        }
    }
}

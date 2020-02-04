using System;
using System.Windows.Forms;

namespace MongoDB_Base
{
    public partial class Form_EditDisrepair : Form
    {
        MongoDB_Class _Obj = MongoDB_Class.GetObject();
        Class_Disrepair StuObj_;

        public Form_EditDisrepair(Class_Disrepair StuObj)
        {
            InitializeComponent();
            StuObj_ = StuObj;
        }

        private void LoadData()
        {
            StuObj_.Id = int.Parse(TBID.Text.ToString().Trim());
            StuObj_.FAILURENM = TBName.Text.ToString().Trim();
        }

        private void DataLoad()
        {
            TBID.Text = StuObj_.Id.ToString();
            TBName.Text = StuObj_.FAILURENM;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (TBID.Text != "" && TBName.Text != "")
            {
                LoadData();
                if (TBID.Modified == false)
                    _Obj.Update_Disrepair_Information(StuObj_);
                else
                    _Obj.Insert_Disrepair_Information(StuObj_);
            }
            else
                MessageBox.Show("Поля заполнены неверно");
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            LoadData();
            _Obj.Delete_Disrepair_Infromation(StuObj_);
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

        private void TBName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TBName.Text.Length == 1)
                TBName.Text = TBName.Text.ToUpper();
            TBName.Select(TBName.Text.Length, 0);
            if (e.KeyChar != 8 && e.KeyChar != 32 && (e.KeyChar < 'А' || e.KeyChar > 'я'))
            {
                e.Handled = true;
                MessageBox.Show("Название пишется на кириллице");
            }
        }

        private void Form_EditDisrepair_Load(object sender, EventArgs e)
        {
            DataLoad();
        }
    }
}

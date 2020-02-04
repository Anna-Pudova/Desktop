using System;
using System.Windows.Forms;

namespace MongoDB_Base
{
    public partial class Form_EditStreet : Form
    {
        MongoDB_Class _Obj = MongoDB_Class.GetObject();
        Class_Street StuObj_;
        public Form_EditStreet(Class_Street StuObj)
        {
            InitializeComponent();
            StuObj_ = StuObj;
        }

        private void LoadData()
        {
            StuObj_.Id = int.Parse(TBID.Text.ToString().Trim());
            StuObj_.STREETNM = TBName.Text.ToString().Trim();
        }

        private void DataLoad()
        {
            TBID.Text = StuObj_.Id.ToString();
            TBName.Text = StuObj_.STREETNM;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (TBID.Text != "" && TBName.Text != "")
            {
                LoadData();
                if (TBID.Modified == false)
                    _Obj.Update_Street_Information(StuObj_);
                else
                    _Obj.Insert_Street_Information(StuObj_);
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

        private void TBName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && e.KeyChar != 32 && (e.KeyChar < 'А' || e.KeyChar > 'Я'))
            {
                e.Handled = true;
                MessageBox.Show("Название улицы пишется прописными буквами и на кириллице");
            }
        }

        private void Form_EditStreet_Load(object sender, EventArgs e)
        {
            DataLoad();
        }
    }
}

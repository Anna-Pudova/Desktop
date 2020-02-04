using System;
using System.Windows.Forms;

namespace MongoDB_Base
{
    public partial class Form_EditServices : Form
    {
        MongoDB_Class _Obj = MongoDB_Class.GetObject();
        Class_Services StuObj_;
        public Form_EditServices(Class_Services StuObj)
        {
            InitializeComponent();
            StuObj_ = StuObj;
        }

        private void LoadData()
        {
            StuObj_.Id = int.Parse(TBID.Text.ToString().Trim());
            StuObj_.SERVICENM = TBName.Text.ToString().Trim();
        }

        private void DataLoad()
        {
            TBID.Text = StuObj_.Id.ToString();
            TBName.Text = StuObj_.SERVICENM;
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (TBID.Text != "" && TBName.Text != "")
            {
                LoadData();
                if (TBID.Modified == false)
                    _Obj.Update_Services_Information(StuObj_);
                else
                    _Obj.Insert_Services_Information(StuObj_);
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
            if (TBName.Text.Length == 1)
                TBName.Text = TBName.Text.ToUpper();
            TBName.Select(TBName.Text.Length, 0);
            if (e.KeyChar != 8 && (e.KeyChar < 'А' || e.KeyChar > 'я'))
            {
                e.Handled = true;
                MessageBox.Show("Название пишется на кириллице");
            }
        }

        private void Form_EditServices_Load(object sender, EventArgs e)
        {
            DataLoad();
        }
    }
}

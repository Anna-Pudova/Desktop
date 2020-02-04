using System;
using System.Windows.Forms;

namespace MongoDB_Base
{
    public partial class Form_EditAbonent : Form
    {
        MongoDB_Class _Obj = MongoDB_Class.GetObject();
        private Class_Abonent StuObj_;
        SBindingList<Class_Abonent> doclist = new SBindingList<Class_Abonent>();
        public Form_EditAbonent(Class_Abonent StuObj)
        {
            InitializeComponent();
            StuObj_ = StuObj;
        }

        private void LoadData()
        {
            StuObj_.Id = TBID.Text.ToString().Trim();
            StuObj_.StreetCD = comboBoxstreet.SelectedItem.ToString();
            StuObj_.HouseNo = int.Parse(TBHouse.Text.ToString().Trim());
            StuObj_.FlatNo = int.Parse(TBFlat.Text.ToString().Trim());
            StuObj_.Fio = TBFio.Text.ToString().Trim();
            StuObj_.Phone = TBPhone.Text.ToString().Trim();
        }

        private void DataLoad()
        {
            TBID.Text = StuObj_.Id;
            comboBoxstreet.Text = StuObj_.StreetCD;
            TBHouse.Text = StuObj_.HouseNo.ToString();
            TBFlat.Text = StuObj_.FlatNo.ToString();
            TBFio.Text = StuObj_.Fio;
            TBPhone.Text = StuObj_.Phone;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (TBID.Text != "" && comboBoxstreet.Text != "" && TBHouse.Text != ""
                && TBFlat.Text != "" && TBFio.Text != "" && TBPhone.Text != "")
            {
                LoadData();
                if (TBID.Modified == false)
                    _Obj.Update_Abonent_Information(StuObj_);
                else
                    _Obj.Insert_Abonent_Information(StuObj_);
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

        private void TBFio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TBFio.Text.Length == 1)
               TBFio.Text = TBFio.Text.ToUpper();
            TBFio.Select(TBFio.Text.Length, 0);
            if (e.KeyChar != 8 && e.KeyChar != 32 && e.KeyChar != 46 && (e.KeyChar < 'А' || e.KeyChar > 'я'))
            {
                e.Handled = true;
                MessageBox.Show("ФИО абонента пишется на кириллице");
            }
        }

        private void Form_EditAbonent_Load(object sender, EventArgs e)
        {
            DataLoad();
        }
    }
}

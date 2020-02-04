using System;
using System.Windows.Forms;
using MongoDB.Driver.Builders;
using MongoDB.Driver;

namespace MongoDB_Base
{
    public partial class Form_Abonent : Form
    {
        MongoDB_Class _Obj = MongoDB_Class.GetObject();
        SBindingList<Class_Abonent> doclist = new SBindingList<Class_Abonent>();
        public Form_Abonent()
        {
            InitializeComponent();
        }

        public void Load_Data()
        {
            doclist = _Obj.Load_Abonent();
            BSAbonent.DataSource = doclist;
            DataAbonent.DataSource = BSAbonent;
        }

        public void FormAbonent_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void BMain_Click(object sender, EventArgs e)
        {
            Form Form = new Form_Main();
            Form.Show();
            this.Visible = false;
        }

        private void toolStripBupdate_Click(object sender, EventArgs e)
        {
            Class_Abonent A = (Class_Abonent)BSAbonent.Current;
            Form_EditAbonent _f = new Form_EditAbonent(A);
            if (A != null)
            {
                _f.ShowDialog();
                Load_Data();
            }
            else
                MessageBox.Show("Выберите абонента");
        }

        private void toolStripTextBoxFilter_TextChanged(object sender, EventArgs e)
        {
            if (CBFilter.SelectedItem == null)
            {
                MessageBox.Show("Выберите поле для фильтрации");
            }
            for (int i = 0; i < DataAbonent.RowCount; i++)
            {
                DataAbonent.CurrentCell = null;
                DataAbonent.Rows[i].Visible = false;
                switch (CBFilter.SelectedIndex)
                {
                    case 0:
                        if ((DataAbonent[0, i].Value.ToString().ToLower().IndexOf(toolStripTextBoxFilter.Text.ToLower()) != -1))
                        {
                            DataAbonent.Rows[i].Visible = true;
                        }
                        break;
                    case 1:
                        if ((DataAbonent[1, i].Value.ToString().ToLower().IndexOf(toolStripTextBoxFilter.Text.ToLower()) != -1))
                        {
                            DataAbonent.Rows[i].Visible = true;
                        }
                        break;
                    case 2:
                        if ((DataAbonent[2, i].Value.ToString().ToLower().IndexOf(toolStripTextBoxFilter.Text.ToLower()) != -1))
                        {
                            DataAbonent.Rows[i].Visible = true;
                       }
                        break;
                    case 3:
                        if ((DataAbonent[3, i].Value.ToString().ToLower().IndexOf(toolStripTextBoxFilter.Text.ToLower()) != -1))
                        {
                            DataAbonent.Rows[i].Visible = true;
                        }
                        break;
                    case 4:
                        if ((DataAbonent[4, i].Value.ToString().ToLower().IndexOf(toolStripTextBoxFilter.Text.ToLower()) != -1))
                        {
                            DataAbonent.Rows[i].Visible = true;
                        }
                        break;
                }
            }
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            Class_Abonent A = (Class_Abonent)BSAbonent.Current;
            if (A != null)
            {
                DialogResult dr = MessageBox.Show("Удалить абонента " + A.Fio + "?",
                    "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                    _Obj.Delete_Abonent_Infromation(A);
                Load_Data();
            }
            else
                MessageBox.Show("Выберите абонента");
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            Class_Abonent A = new Class_Abonent();
            Form_EditAbonent _f = new Form_EditAbonent(A);
            _f.ShowDialog();
            Load_Data();
        }

        private IMongoQuery InitByMongo()
        {
            var find = Query<Class_Abonent>.Where(a => a.Id == toolStripTextBoxFilter.Text || a.StreetCD == toolStripTextBoxFilter.Text || a.HouseNo == int.Parse(toolStripTextBoxFilter.ToString().Trim()) ||
                a.FlatNo == int.Parse(toolStripTextBoxFilter.ToString().Trim()) || a.Fio == toolStripTextBoxFilter.Text);
            return find;
        }
    }
}


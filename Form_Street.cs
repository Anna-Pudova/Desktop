using System;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace MongoDB_Base
{
    public partial class Form_Street : Form
    {
        SBindingList<Class_Street> doclist = new SBindingList<Class_Street>();
        MongoDB_Class _Obj = MongoDB_Class.GetObject();

        public Form_Street()
        {
            InitializeComponent();
        }

        public void Load_Data()
        {
            doclist = _Obj.Load_DataStreet();
            BSStreet.DataSource = doclist;
            dataGridViewStreet.DataSource = BSStreet;
        }

        public void FormStreet_Load(object sender, EventArgs e)
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
            Class_Street S = (Class_Street)BSStreet.Current;
            Form_EditStreet _f = new Form_EditStreet(S);
            if (S != null)
            {
                _f.ShowDialog();
                Load_Data();
            }
            else
                MessageBox.Show("Выберите улицу");
        }

        private void toolStripTextBoxFilter_TextChanged(object sender, EventArgs e)
        {
            if (CBFilter.SelectedItem == null)
            {
                MessageBox.Show("Выберите поле для фильтрации");
            }
            for (int i = 0; i < dataGridViewStreet.RowCount; i++)
            {
                dataGridViewStreet.CurrentCell = null;
                dataGridViewStreet.Rows[i].Visible = false;
                switch (CBFilter.SelectedIndex)
                {
                    case 0:
                        if ((dataGridViewStreet[0, i].Value.ToString().ToLower().IndexOf(toolStripTextBoxFilter.Text.ToLower()) != -1))
                        {
                            dataGridViewStreet.Rows[i].Visible = true;
                        }
                        break;
                    case 1:
                        if ((dataGridViewStreet[2, i].Value.ToString().ToLower().IndexOf(toolStripTextBoxFilter.Text.ToLower()) != -1))
                        {
                            dataGridViewStreet.Rows[i].Visible = true;
                        }
                        break;
                }
            }
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            Class_Street A = (Class_Street)BSStreet.Current;
            if (A != null)
            {
                DialogResult dr = MessageBox.Show("Удалить улицу " + A.STREETNM + "?",
                    "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                    _Obj.Delete_Street_Infromation(A);
                Load_Data();
            }
            else
                MessageBox.Show("Выберите улицу");
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            Class_Street S = new Class_Street();
            Form_EditStreet _f = new Form_EditStreet(S);
            _f.ShowDialog();
            Load_Data();
        }

        private IMongoQuery InitByMongo()
        {
            var find = Query<Class_Street>.Where(a => a.Id == int.Parse(toolStripTextBoxFilter.ToString().Trim()) || a.STREETNM == toolStripTextBoxFilter.Text);
            return find;
        }
    }
}

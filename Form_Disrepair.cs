using System;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace MongoDB_Base
{
    public partial class Form_Disrepair : Form
    {
        SBindingList<Class_Disrepair> doclist = new SBindingList<Class_Disrepair>();
        MongoDB_Class _Obj = MongoDB_Class.GetObject();
        public Form_Disrepair()
        {
            InitializeComponent();
        }

        public void Load_Data()
        {
            doclist = _Obj.Load_DataDisrepair();
            BSDisrepair.DataSource = doclist;
            DataDisrepair.DataSource = BSDisrepair;
        }

        public void FormDisrepair_Load(object sender, EventArgs e)
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
            Class_Disrepair D = (Class_Disrepair)BSDisrepair.Current;
            Form_EditDisrepair _f = new Form_EditDisrepair(D);
            if (D != null)
            {
                _f.ShowDialog();
                Load_Data();
            }
            else
                MessageBox.Show("Выберите неисправность");
        }

        private void toolStripTextBoxFilter_TextChanged(object sender, EventArgs e)
        {
            if (CBFilter.SelectedItem == null)
            {
                MessageBox.Show("Выберите поле для фильтрации");
            }
            for (int i = 0; i < DataDisrepair.RowCount; i++)
            {
                DataDisrepair.CurrentCell = null;
                DataDisrepair.Rows[i].Visible = false;
                switch (CBFilter.SelectedIndex)
                {
                    case 0:
                        if ((DataDisrepair[0, i].Value.ToString().ToLower().IndexOf(toolStripTextBoxFilter.Text.ToLower()) != -1))
                        {
                            DataDisrepair.Rows[i].Visible = true;
                        }
                        break;
                    case 1:
                        if ((DataDisrepair[2, i].Value.ToString().ToLower().IndexOf(toolStripTextBoxFilter.Text.ToLower()) != -1))
                        {
                            DataDisrepair.Rows[i].Visible = true;
                        }
                        break;
                }
            }
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            Class_Disrepair A = (Class_Disrepair)BSDisrepair.Current;
            if (A != null)
            {
                DialogResult dr = MessageBox.Show("Удалить неисправность " + A.FAILURENM + "?",
                    "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                    _Obj.Delete_Disrepair_Infromation(A);
                Load_Data();
            }
            else
                MessageBox.Show("Выберите неисправность");
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            Class_Disrepair D = new Class_Disrepair();
            Form_EditDisrepair _f = new Form_EditDisrepair(D);
            _f.ShowDialog();
            Load_Data();
        }

        private IMongoQuery InitByMongo()
        {
            var find = Query<Class_Disrepair>.Where(a => a.Id == int.Parse(toolStripTextBoxFilter.ToString().Trim()) || a.FAILURENM == toolStripTextBoxFilter.Text);
            return find;
        }
    }
}

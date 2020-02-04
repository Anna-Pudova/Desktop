using System;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace MongoDB_Base
{
    public partial class Form_Executor : Form
    {
        SBindingList<Class_Executor> doclist = new SBindingList<Class_Executor>();
        MongoDB_Class _Obj = MongoDB_Class.GetObject();
        public Form_Executor()
        {
            InitializeComponent();
        }

        public void Load_Data()
        {
            doclist = _Obj.Load_DataExecutor();
            BSExecutor.DataSource = doclist;
            DataExecutor.DataSource = BSExecutor;
        }

        public void FormExecutor_Load(object sender, EventArgs e)
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
            Class_Executor E = (Class_Executor)BSExecutor.Current;
            Form_EditExecutor _f = new Form_EditExecutor(E);
            if (E != null)
            {
                _f.ShowDialog();
                Load_Data();
            }
            else
                MessageBox.Show("Выберите слесаря");
        }

        private void toolStripTextBoxFilter_TextChanged(object sender, EventArgs e)
        {
            if (CBFilter.SelectedItem == null)
            {
                MessageBox.Show("Выберите поле для фильтрации");
            }
            for (int i = 0; i < DataExecutor.RowCount; i++)
            {
                DataExecutor.CurrentCell = null;
                DataExecutor.Rows[i].Visible = false;
                switch (CBFilter.SelectedIndex)
                {
                    case 0:
                        if ((DataExecutor[0, i].Value.ToString().ToLower().IndexOf(toolStripTextBoxFilter.Text.ToLower()) != -1))
                        {
                            DataExecutor.Rows[i].Visible = true;
                        }
                        break;
                    case 1:
                        if ((DataExecutor[2, i].Value.ToString().ToLower().IndexOf(toolStripTextBoxFilter.Text.ToLower()) != -1))
                        {
                            DataExecutor.Rows[i].Visible = true;
                        }
                        break;
                }
            }
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            Class_Executor A = (Class_Executor)BSExecutor.Current;
            if (A != null)
            {
                DialogResult dr = MessageBox.Show("Удалить слесаря " + A.Fio + "?",
                    "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                    _Obj.Delete_Executor_Infromation(A);
                Load_Data();
            }
            else
                MessageBox.Show("Выберите слесаря");
        
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            Class_Executor E = new Class_Executor();
            Form_EditExecutor _f = new Form_EditExecutor(E);
            _f.ShowDialog();
            Load_Data();
        }

        private IMongoQuery InitByMongo()
        {
            var find = Query<Class_Executor>.Where(a => a.Id == int.Parse(toolStripTextBoxFilter.ToString().Trim()) || a.Fio == toolStripTextBoxFilter.Text);
            return find;
        }
    }
}

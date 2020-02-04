using System;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace MongoDB_Base
{
    public partial class Form_NachislSumma : Form
    {
        SBindingList<Class_NachislSumma> doclist = new SBindingList<Class_NachislSumma>();
        MongoDB_Class _Obj = MongoDB_Class.GetObject();

        public Form_NachislSumma()
        {
            InitializeComponent();
        }

        public void Load_Data()
        {
            doclist = _Obj.Load_DataNachislSumma();
            BSNachislSumma.DataSource = doclist;
            DataNachislSumma.DataSource = BSNachislSumma;
        }

        public void FormNachislSumma_Load(object sender, EventArgs e)
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
            Class_NachislSumma N = (Class_NachislSumma)BSNachislSumma.Current;
            Form_EditNachislSumma _f = new Form_EditNachislSumma(N);
            if (N != null)
            {
                _f.ShowDialog();
                Load_Data();
            }
            else
                MessageBox.Show("Выберите начисление");
        }

        private void toolStripTextBoxFilter_TextChanged(object sender, EventArgs e)
        {
            if (CBFilter.SelectedItem == null)
            {
                MessageBox.Show("Выберите поле для фильтрации");
            }
            for (int i = 0; i < DataNachislSumma.RowCount; i++)
            {
                DataNachislSumma.CurrentCell = null;
                DataNachislSumma.Rows[i].Visible = false;
                switch (CBFilter.SelectedIndex)
                {
                    case 0:
                        if ((DataNachislSumma[0, i].Value.ToString().ToLower().IndexOf(toolStripTextBoxFilter.Text.ToLower()) != -1))
                        {
                            DataNachislSumma.Rows[i].Visible = true;
                        }
                        break;
                    case 1:
                        if ((DataNachislSumma[2, i].Value.ToString().ToLower().IndexOf(toolStripTextBoxFilter.Text.ToLower()) != -1))
                        {
                            DataNachislSumma.Rows[i].Visible = true;
                        }
                        break;
                    case 2:
                        if ((DataNachislSumma[3, i].Value.ToString().ToLower().IndexOf(toolStripTextBoxFilter.Text.ToLower()) != -1))
                        {
                            DataNachislSumma.Rows[i].Visible = true;
                        }
                        break;
                    case 3:
                        if ((DataNachislSumma[4, i].Value.ToString().ToLower().IndexOf(toolStripTextBoxFilter.Text.ToLower()) != -1))
                        {
                            DataNachislSumma.Rows[i].Visible = true;
                        }
                        break;
                    case 4:
                        if ((DataNachislSumma[5, i].Value.ToString().ToLower().IndexOf(toolStripTextBoxFilter.Text.ToLower()) != -1))
                        {
                            DataNachislSumma.Rows[i].Visible = true;
                        }
                        break;
                    case 5:
                        if ((DataNachislSumma[6, i].Value.ToString().ToLower().IndexOf(toolStripTextBoxFilter.Text.ToLower()) != -1))
                        {
                            DataNachislSumma.Rows[i].Visible = true;
                        }
                        break;
                }
            }
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            Class_NachislSumma A = (Class_NachislSumma)BSNachislSumma.Current;
            if (A != null)
            {
                DialogResult dr = MessageBox.Show("Удалить начисление " + A.Id + "?",
                    "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                    _Obj.Delete_NachislSumma_Infromation(A);
                Load_Data();
            }
            else
                MessageBox.Show("Выберите начисление");
        
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            Class_NachislSumma N = new Class_NachislSumma();
            Form_EditNachislSumma _f = new Form_EditNachislSumma(N);
            _f.ShowDialog();
            Load_Data();
        }

        private IMongoQuery InitByMongo()
        {
            var find = Query<Class_NachislSumma>.Where(a => a.Id == int.Parse(toolStripTextBoxFilter.ToString().Trim()) || a.AccountCD == toolStripTextBoxFilter.Text || a.NachislMonth == toolStripTextBoxFilter.Text
                || a.ServiceCD == toolStripTextBoxFilter.Text || a.NachislSum == double.Parse(toolStripTextBoxFilter.ToString().Trim()) || a.NachislYear == int.Parse(toolStripTextBoxFilter.ToString().Trim()));
            return find;
        }
    }
}

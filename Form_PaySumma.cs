using System;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace MongoDB_Base
{
    public partial class Form_PaySumma : Form
    {
        SBindingList<Class_PaySumma> doclist = new SBindingList<Class_PaySumma>();
        MongoDB_Class _Obj = MongoDB_Class.GetObject();

        public Form_PaySumma()
        {
            InitializeComponent();
        }

        public void Load_Data()
        {
            doclist = _Obj.Load_DataPaySumma();
            BSPaySumma.DataSource = doclist;
            DataPaySumma.DataSource = BSPaySumma;
        }
        public void FormPaySumma_Load(object sender, EventArgs e)
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
            Class_PaySumma P = (Class_PaySumma)BSPaySumma.Current;
            Form_EditPaySumma _f = new Form_EditPaySumma(P);
            if (P != null)
            {
                _f.ShowDialog();
                Load_Data();
            }
            else
                MessageBox.Show("Выберите оплату");
        }

        private void toolStripTextBoxFilter_TextChanged(object sender, EventArgs e)
        {
            if (CBFilter.SelectedItem == null)
            {
                MessageBox.Show("Выберите поле для фильтрации");
            }
            for (int i = 0; i < DataPaySumma.RowCount; i++)
            {
                DataPaySumma.CurrentCell = null;
                DataPaySumma.Rows[i].Visible = false;
                switch (CBFilter.SelectedIndex)
                {
                    case 0:
                        if ((DataPaySumma[0, i].Value.ToString().ToLower().IndexOf(toolStripTextBoxFilter.Text.ToLower()) != -1))
                        {
                            DataPaySumma.Rows[i].Visible = true;
                        }
                        break;
                    case 1:
                        if ((DataPaySumma[1, i].Value.ToString().ToLower().IndexOf(toolStripTextBoxFilter.Text.ToLower()) != -1))
                        {
                            DataPaySumma.Rows[i].Visible = true;
                        }
                        break;
                    case 2:
                        if ((DataPaySumma[2, i].Value.ToString().ToLower().IndexOf(toolStripTextBoxFilter.Text.ToLower()) != -1))
                        {
                            DataPaySumma.Rows[i].Visible = true;
                       }
                        break;
                    case 3:
                        if ((DataPaySumma[3, i].Value.ToString().ToLower().IndexOf(toolStripTextBoxFilter.Text.ToLower()) != -1))
                        {
                            DataPaySumma.Rows[i].Visible = true;
                        }
                        break;
                    case 4:
                        if ((DataPaySumma[6, i].Value.ToString().ToLower().IndexOf(toolStripTextBoxFilter.Text.ToLower()) != -1))
                        {
                            DataPaySumma.Rows[i].Visible = true;
                        }
                        break;
                    case 5:
                        if ((DataPaySumma[7, i].Value.ToString().ToLower().IndexOf(toolStripTextBoxFilter.Text.ToLower()) != -1))
                        {
                            DataPaySumma.Rows[i].Visible = true;
                        }
                        break;
                }
            }
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            Class_PaySumma A = (Class_PaySumma)BSPaySumma.Current;
            if (A != null)
            {
                DialogResult dr = MessageBox.Show("Удалить оплату " + A.Id + "?",
                    "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                    _Obj.Delete_PaySumma_Infromation(A);
                Load_Data();
            }
            else
                MessageBox.Show("Выберите оплату");
        
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            Class_PaySumma P = new Class_PaySumma();
            Form_EditPaySumma _f = new Form_EditPaySumma(P);
            _f.ShowDialog();
            Load_Data();
        }

        private IMongoQuery InitByMongo()
        {
            var find = Query<Class_PaySumma>.Where(a => a.Id == int.Parse(toolStripTextBoxFilter.ToString().Trim()) || a.AccountCD == toolStripTextBoxFilter.Text || a.PayMonth == toolStripTextBoxFilter.Text
                || a.ServiceCD == toolStripTextBoxFilter.Text || a.PaySum == double.Parse(toolStripTextBoxFilter.ToString().Trim()) || a.PayYear == int.Parse(toolStripTextBoxFilter.ToString().Trim()));
            return find;
        }
    }
}

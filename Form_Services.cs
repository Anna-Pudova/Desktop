using System;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace MongoDB_Base
{
    public partial class Form_Services : Form
    {
        SBindingList<Class_Services> doclist = new SBindingList<Class_Services>();
        MongoDB_Class _Obj = MongoDB_Class.GetObject();

        public Form_Services()
        {
            InitializeComponent();
        }

        public void Load_Data()
        {
            doclist = _Obj.Load_DataServices();
            BSServices.DataSource = doclist;
            DataServices.DataSource = BSServices;
        }

        public void FormServices_Load(object sender, EventArgs e)
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
            Class_Services S = (Class_Services)BSServices.Current;
            Form_EditServices _f = new Form_EditServices(S);
            if (S != null)
            {
                _f.ShowDialog();
                Load_Data();
            }
            else
                MessageBox.Show("Выберите услугу");
        }

        private void edFilter_TextChanged(object sender, EventArgs e)
        {
            if (CBFilter.SelectedItem == null)
            {
                MessageBox.Show("Выберите поле для фильтрации");
            }
            for (int i = 0; i < DataServices.RowCount; i++)
            {
                DataServices.CurrentCell = null;
                DataServices.Rows[i].Visible = false;
                switch (CBFilter.SelectedIndex)
                {
                    case 0:
                        if ((DataServices[0, i].Value.ToString().ToLower().IndexOf(toolStripTextBoxFilter.Text.ToLower()) != -1))
                        {
                            DataServices.Rows[i].Visible = true;
                        }
                        break;
                    case 1:
                        if ((DataServices[2, i].Value.ToString().ToLower().IndexOf(toolStripTextBoxFilter.Text.ToLower()) != -1))
                        {
                            DataServices.Rows[i].Visible = true;
                        }
                        break;
                }
            }
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            Class_Services A = (Class_Services)BSServices.Current;
            if (A != null)
            {
                DialogResult dr = MessageBox.Show("Удалить услугу " + A.SERVICENM + "?",
                    "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                    _Obj.Delete_Services_Infromation(A);
                Load_Data();
            }
            else
                MessageBox.Show("Выберите услугу");
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            Class_Services S = new Class_Services();
            Form_EditServices _f = new Form_EditServices(S);
            _f.ShowDialog();
            Load_Data();
        }

        private IMongoQuery InitByMongo()
        {
            var find = Query<Class_Services>.Where(a => a.Id == int.Parse(toolStripTextBoxFilter.ToString().Trim()) || a.SERVICENM == toolStripTextBoxFilter.Text);
            return find;
        }
    }
}

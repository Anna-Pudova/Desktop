using System;
using System.Windows.Forms;

namespace MongoDB_Base
{
    public partial class Form_Request : Form
    {
        SBindingList<Class_Request> doclist = new SBindingList<Class_Request>();
        MongoDB_Class _Obj = MongoDB_Class.GetObject();

        public Form_Request()
        {
            InitializeComponent();
        }

        public void Load_Data()
        {
            doclist = _Obj.Load_DataRequest();
            BSRequest.DataSource = doclist;
            DataRequest.DataSource = BSRequest;
        }

        public void FormRequest_Load(object sender, EventArgs e)
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
            Class_Request R = (Class_Request)BSRequest.Current;
            Form_EditRequest _f = new Form_EditRequest(R);
            if (R != null)
            {
                _f.ShowDialog();
                Load_Data();
            }
            else
                MessageBox.Show("Выберите заявку");
        }

        private void toolStripTextBoxFilter_TextChanged(object sender, EventArgs e)
        {
            if (CBFilter.SelectedItem == null)
            {
                MessageBox.Show("Выберите поле для фильтрации");
            }
            for (int i = 0; i < DataRequest.RowCount; i++)
            {
                DataRequest.CurrentCell = null;
                DataRequest.Rows[i].Visible = false;
                switch (CBFilter.SelectedIndex)
                {
                    case 0:
                        if ((DataRequest[0, i].Value.ToString().ToLower().IndexOf(toolStripTextBoxFilter.Text.ToLower()) != -1))
                        {
                            DataRequest.Rows[i].Visible = true;
                        }
                        break;
                    case 1:
                        if ((DataRequest[2, i].Value.ToString().ToLower().IndexOf(toolStripTextBoxFilter.Text.ToLower()) != -1))
                        {
                            DataRequest.Rows[i].Visible = true;
                        }
                        break;
                    case 2:
                        if ((DataRequest[3, i].Value.ToString().ToLower().IndexOf(toolStripTextBoxFilter.Text.ToLower()) != -1))
                        {
                            DataRequest.Rows[i].Visible = true;
                        }
                        break;
                    case 3:
                        if ((DataRequest[4, i].Value.ToString().ToLower().IndexOf(toolStripTextBoxFilter.Text.ToLower()) != -1))
                        {
                            DataRequest.Rows[i].Visible = true;
                        }
                        break;
                    case 4:
                        if ((DataRequest[7, i].Value.ToString().ToLower().IndexOf(toolStripTextBoxFilter.Text.ToLower()) != -1))
                        {
                            DataRequest.Rows[i].Visible = true;
                        }
                        break;
                }
            }
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            Class_Request A = (Class_Request)BSRequest.Current;
            if (A != null)
            {
                DialogResult dr = MessageBox.Show("Удалить заявку " + A.Id + "?",
                    "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                    _Obj.Delete_Request_Infromation(A);
                Load_Data();
            }
            else
                MessageBox.Show("Выберите заявку");
        
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            Class_Request R = new Class_Request();
            Form_EditRequest _f = new Form_EditRequest(R);
            _f.ShowDialog();
            Load_Data();
        }
    }
}

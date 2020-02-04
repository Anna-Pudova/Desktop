using System;
using System.Windows.Forms;

namespace MongoDB_Base
{
    public partial class Form_Diagram : Form
    {
        public Form_Diagram()
        {
            InitializeComponent();
        }

        private void BMain_Click(object sender, EventArgs e)
        {
            Form Form = new Form_Main();
            Form.Show();
            this.Visible = false;
        }
    }
}

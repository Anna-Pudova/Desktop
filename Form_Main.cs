using System;
using System.Windows.Forms;

namespace MongoDB_Base
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void улицыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form = new Form_Street();
            Form.Show();
           this.Visible = false;
        }

        private void схемаДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form = new Form_Diagram();
            Form.Show();
            this.Visible = false;
        }

        private void абонентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form = new Form_Abonent();
            Form.Show();
            this.Visible = false;
        }

        private void журналНачисленийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form = new Form_NachislSumma();
            Form.Show();
            this.Visible = false;
        }

        private void журналОплатToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form = new Form_PaySumma();
            Form.Show();
            this.Visible = false;
        }

        private void журналЗаявокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form = new Form_Request();
            Form.Show();
            this.Visible = false;
        }

        private void неисправностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form = new Form_Disrepair();
            Form.Show();
            this.Visible = false;
        }

        private void слесариToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form = new Form_Executor();
            Form.Show();
            this.Visible = false;
        }

        private void услугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form = new Form_Services();
            Form.Show();
            this.Visible = false;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form = new Form_Registration();
            Form.Show();
            this.Visible = false;
        }

        private void BLogo_Click(object sender, EventArgs e)
        {
            Form Form = new Form_Main();
            Form.Show();
            this.Visible = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointCardManagementSystem_Group4
{
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
            labPlayer.Visible = false;
            lblCardStatus.Visible = false;
            lblCreate.Visible = false;
            lblProblem.Visible = false;
            lblTopup.Visible = false;
            labPlayer.ForeColor = Color.Red;
            lblCardStatus.ForeColor = Color.Red;
            lblCreate.ForeColor = Color.Red;
            lblProblem.ForeColor = Color.Red;
            lblTopup.ForeColor = Color.Red;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Staff_MouseHover(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            labPlayer.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            labPlayer.Visible = false;
        }

        private void btnlCardStatus_MouseHover(object sender, EventArgs e)
        {
            lblCardStatus.Visible = true;
        }

        private void btnlCardStatus_MouseLeave(object sender, EventArgs e)
        {
            lblCardStatus.Visible = false;
        }

        private void btnCreate_MouseHover(object sender, EventArgs e)
        {
            lblCreate.Visible = true;
        }

        private void btnCreate_MouseLeave(object sender, EventArgs e)
        {
            lblCreate.Visible = false;
        }

        private void btnTopup_MouseHover(object sender, EventArgs e)
        {
            lblTopup.Visible = true;
        }

        private void btnTopup_MouseLeave(object sender, EventArgs e)
        {
            lblTopup.Visible = false;
        }

        private void btnProblem_MouseHover(object sender, EventArgs e)
        {
            lblProblem.Visible = true;
        }

        private void btnProblem_MouseLeave(object sender, EventArgs e)
        {
            lblProblem.Visible = false;
        }
    }
}

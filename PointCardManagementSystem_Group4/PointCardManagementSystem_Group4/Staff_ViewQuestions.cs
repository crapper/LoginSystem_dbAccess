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
    public partial class Staff_ViewQuestions : Form
    {
        int va = 3;
        string username;
        public Staff_ViewQuestions(int a, string b)
        {
            InitializeComponent();
            va = a;
            username = b;

        }

        private void feedbackBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.feedbackBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pointCardDatabaseDataSet);

        }

        private void Staff_ViewQuestions_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pointCardDatabaseDataSet.Feedback' table. You can move, or remove it, as needed.
            this.feedbackTableAdapter.Fill(this.pointCardDatabaseDataSet.Feedback);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff a = new Staff(va, username);
            a.Show();
        }
    }
}

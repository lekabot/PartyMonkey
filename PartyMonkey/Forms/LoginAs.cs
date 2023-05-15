using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PartyMonkey.Classes;

namespace PartyMonkey.Forms
{
    public partial class LoginAs : Form
    {
        DataBank dataBank = new DataBank();

        public LoginAs()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void LoginAs_Load(object sender, EventArgs e)
        {

        }
        private void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            DataBank.tableName = button.Name;
            Authorization authorization = new Authorization();
            authorization.Show();
            this.Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.Show();
            this.Hide();
        }
    }
}

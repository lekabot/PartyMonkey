using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyMonkey.Forms
{
    public partial class InformationAboutEvents : Form
    {
        public InformationAboutEvents()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void informationAboutEvents_Load(object sender, EventArgs e)
        {

        }

        private void getEven()
        {
            //SELECT [Events].logo, [Events].[date], [Events].city, [Organizers].[last name], [Organizers].[first name], [Organizers].[patronymic] FROM [Activity log] JOIN [Organizers] ON [Activity log].[organizator_id] = [Organizers].[id] JOIN [Events] ON [Activity log].event_id = [Events].id WHERE [Events].id = 1
        }
    }
}

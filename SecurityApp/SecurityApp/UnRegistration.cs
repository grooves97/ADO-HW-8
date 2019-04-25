using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SecurityApp.DataAcces;
using SecurityApp.Models;

namespace SecurityApp
{
    public partial class UnRegistration : Form
    {
        public UnRegistration()
        {
            InitializeComponent();
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            using (var context = new DataContext())
            {
                try
                {
                    var result = context.Visitors.FirstOrDefault(r => r.Document == maskedTextBoxDocument.Text);
                    result.TimeOut = DateTime.Now;
                    context.SaveChanges();
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("No such visitor");
                }
            }
        }
    }
}

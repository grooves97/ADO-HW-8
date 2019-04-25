using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SecurityApp.Models;
using SecurityApp.DataAcces;

namespace SecurityApp
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            Visitor visitor = new Visitor();

            if (textBoxFullname.Text.Length > 0)
                visitor.Fullname = textBoxFullname.Text;
            else MessageBox.Show("You should to insert NAME");

            if (maskedTextBoxDocument.Text.Length > 0)
                visitor.Document = maskedTextBoxDocument.Text;
            else MessageBox.Show("You should to insert DOCUMENT NUMBER");

            visitor.PurposeOfVisit = textBoxPurpose.Text;
            visitor.TimeIn = DateTime.Now;

            using(var context = new DataContext())
            {
                context.Visitors.Add(visitor);
                context.SaveChanges();
            }
            this.Close();
        }
    }
}

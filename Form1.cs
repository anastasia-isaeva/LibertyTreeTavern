using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibertyTreeTavern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Shown += new EventHandler(Form1_Shown);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            listBoxBreakfast.SelectedIndex = 0;
        }

        private void UpdateTotal()
        {
            double roomPrice = 0;
            double[] breakfastPrices = { 0.0, 6.99, 10.99 };
            int nights = 0;
            int guests = 0;

            if (checkBoxLincoln.Checked)
            {
                roomPrice = 110.00;
            }
            else if (checkBoxContinental.Checked)
            {
                roomPrice = 120.00;
            }
            else if (checkBoxJefferson.Checked)
            {
                roomPrice = 150.00;
            }

            try
            {
                nights = Convert.ToInt32(textBoxNights.Text);
                guests = Convert.ToInt32(textBoxGuests.Text);
            } catch { }

            labelTotal.Text = (roomPrice * nights + breakfastPrices[listBoxBreakfast.SelectedIndex] * nights * guests).ToString("C");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLincoln.Checked) {
                checkBoxContinental.Checked = false;
                checkBoxJefferson.Checked = false;
                UpdateTotal();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form = new Form2();
            form.Visible = true;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 form = new Form3();
            form.Visible = true;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 form = new Form4();
            form.Visible = true;
        }

        private void checkBoxContinental_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxContinental.Checked)
            {
                checkBoxJefferson.Checked = false;
                checkBoxLincoln.Checked = false;
                UpdateTotal();
            }
        }

        private void checkBoxJefferson_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxJefferson.Checked)
            {
                checkBoxContinental.Checked = false;
                checkBoxLincoln.Checked = false;
                UpdateTotal();
            }
        }

        private void textBoxNights_TextChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }

        private void textBoxGuests_TextChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }

        private void listBoxBreakfast_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }
    }
}

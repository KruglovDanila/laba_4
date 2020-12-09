using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba2
{
    public partial class NumberSystemForm : Form, INumberSystemView
    {
        private NumberSystemPresenter presenter;

        public NumberSystemForm()
        {
            InitializeComponent();

            presenter = new NumberSystemPresenter(this, new HandlingNumber());
        }

        private void KeyPressInputNumbers(object sender, KeyPressEventArgs e)
        {
            presenter.CheckInputNumbers(e);
        }

        private void KeyPressInputNumberSystem(object sender, KeyPressEventArgs e)
        {
            presenter.CheckInputNumbers(e);
        }

        public void ShowResultCounting(string result)
        {
            textBox3.Text = result;
        }

        public void ShowIndividualTask(List<string> result)
        {
            ClearTbIndividualTask();
            foreach (string value in result)
            {
                textBox4.Text = textBox4.Text + value;
            }
        }

        private void ClearTbIndividualTask()
        {
            if (textBox4.Text != "")
            {
                {
                    textBox4.Text = "";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            presenter.CountNumberSystem(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            presenter.CountIndividualTask(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
        }
    }
}

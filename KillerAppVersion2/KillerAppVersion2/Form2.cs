using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KillerAppVersion2
{
    public partial class Form2 : Form
    {

        private int selectedset;
        private int selectedserie;

        public Form2(string username, string password)
        {
            Set set1 = new Set("Legendary eagle");
            sets.Add(set1);
            InitializeComponent();
            foreach (Card card in sets[0].series[0].cards)
            {
                listBox1.Items.Add(card.ToString());
            }
            foreach (Serie serie in sets[0].series)
            {
                listBox2.Items.Add(serie.ToString());
            }
            foreach (Set set in sets)
            {
                listBox3.Items.Add(set.ToString());
            }
        }
        List<Set> sets = new List<Set>();

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListbox();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedserie = listBox2.SelectedIndex;
            UpdateListbox();
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedset = listBox3.SelectedIndex;
            UpdateListbox();
        }

        public void UpdateListbox()
        {
            try
            {
                ClearListbox();
                foreach (Card card in sets[selectedset].series[selectedserie].cards)
                {
                    listBox1.Items.Add(card);
                }
                foreach (Serie serie in sets[selectedset].series)
                {
                    listBox2.Items.Add(serie);
                }
                foreach (Set set in sets)
                {
                    listBox3.Items.Add(set);
                    listBox3.Items.Add(set);
                    listBox3.Items.Add(set);
                    listBox3.Items.Add(set);
                    listBox3.Items.Add(set);
                }
            }
            catch
            {
                MessageBox.Show("Alleen op tekst drukken AUB");
                foreach (Card card in sets[0].series[0].cards)
                {
                    listBox1.Items.Add(card.ToString());
                }
                foreach (Serie serie in sets[0].series)
                {
                    listBox2.Items.Add(serie.ToString());
                }
                foreach (Set set in sets)
                {
                    listBox3.Items.Add(set.ToString());
                }
            }
        }

        public void ClearListbox()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
        }
    }
}

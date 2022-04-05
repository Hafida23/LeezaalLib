using LeezaalLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormLeezaalLib
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        ReadingRoom readingRoom = new ReadingRoom();
        Reader reader = new Reader();
        Person Person = new Person();
        Magazine magazine = new Magazine();

        private void Form1_Load(object sender, EventArgs e)
        {
            lstReaders.Items.Add(string.Empty);
            lstReaders.Items.AddRange(readingRoom.Add(10).ToArray());
            cmbHats.Items.Add(string.Empty);
            cmbHats.Items.AddRange(Hat.Hats());
            cmbMagazineColors.Items.Add(string.Empty);
            cmbMagazineColors.Items.AddRange( MagazineColors.Colors());
        }
        private void lstReaders_click(object sender, EventArgs e)
        {
            var listHat = Hat.Hats();
            var list = magazine.ColorList;
            for (int i = 0; i < readingRoom.Readers.Count; i++)
            {
                if (lstReaders.SelectedIndex == i)
                {
                    lblAge.Text = Convert.ToString(Person.Age);
                    lblHat.Text = listHat[reader.HatIndex];
                    lblColor.Text = list[magazine.Kleur];
                }
            }

        }

        private void btnAddReader_Click(object sender, EventArgs e)
        {
            var lastValue = int.Parse(lstReaders.Items[lstReaders.Items.Count -1].ToString());
            var added = int.Parse(txtAmount.Text);
            
            if (added > 0 && added < 11)
            {
                lstReaders.Items.Clear();
                lstReaders.Items.AddRange(readingRoom.Add(lastValue + added).ToArray());
            }
            else
            {
                MessageBox.Show("Amount is not valid number! \n Make sure amount is a number & it is smaller or equal to 10 ");
            }
        }

        private void cmbHats_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listHat = Hat.Hats();
            if (cmbHats.SelectedItem == "Niets") { lblHatCount.Text = Convert.ToString(listHat.Count(s => listHat[reader.HatIndex] == "Niets")); }
            if (cmbHats.SelectedItem == "Bolhoed") { lblHatCount.Text = Convert.ToString(listHat.Count(s => listHat[reader.HatIndex] == "Bolhoed")); }
            if (cmbHats.SelectedItem == "Pet") { lblHatCount.Text = Convert.ToString(listHat.Count(s => listHat[reader.HatIndex] == "Pet")); }
            if (cmbHats.SelectedItem == "Pruik") { lblHatCount.Text = Convert.ToString(listHat.Count(s => listHat[reader.HatIndex] == "Pruik")); }

        }

        private void cmbMagazineColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            var list = magazine.ColorList;
            var listHat = Hat.Hats();
            if (cmbMagazineColors.SelectedItem == "Geel")
            {
                lblMagazine.Text = Convert.ToString(list.Count(s => list[magazine.Kleur] == "Geel"));
                lblBothCount.Text = Convert.ToString(list.Count(s => list[magazine.Kleur] == "Geel" || listHat[reader.HatIndex] == "Niets"));

            }
            if (cmbMagazineColors.SelectedItem == "Orange")
            {
                lblMagazine.Text = Convert.ToString(list.Count(s => list[magazine.Kleur] == "Orange"));
                lblBothCount.Text = Convert.ToString(list.Count(s => list[magazine.Kleur] == "Orange" || listHat[reader.HatIndex] == "Bolhoed"));
            }
            if (cmbMagazineColors.SelectedItem == "Groen")
            {
                lblMagazine.Text = Convert.ToString(list.Count(s => list[magazine.Kleur] == "Groen"));
                lblBothCount.Text = Convert.ToString(list.Count(s => list[magazine.Kleur] == "Groen" || listHat[reader.HatIndex] == "Pet"));
            }
            if (cmbMagazineColors.SelectedItem == "Blauw")
            {
                lblMagazine.Text = Convert.ToString(list.Count(s => list[magazine.Kleur] == "Blauw"));
                lblBothCount.Text = Convert.ToString(list.Count(s => list[magazine.Kleur] == "Blauw" || listHat[reader.HatIndex] == "Pet"));
            }
            if (cmbMagazineColors.SelectedItem == "Rood")
            {
                lblMagazine.Text = Convert.ToString(list.Count(s => list[magazine.Kleur] == "Rood"));
                lblBothCount.Text = Convert.ToString(list.Count(s => list[magazine.Kleur] == "Rood" || listHat[reader.HatIndex] == "Pruik"));
            }

        }

        private void lblBothCount_Click(object sender, EventArgs e)
        {

        }
    }
}

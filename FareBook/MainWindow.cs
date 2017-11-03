using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FareBook.Model;
using FareBook.Service;

namespace FareBook
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            GetClient();
        }

        private void GetClient()
        {
            string error = "";

            var  clients = FareBookService.GetClient(out error);

            if(error != "")
            {
                MessageBox.Show(error, "Error");
            }
            else
            {
                AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();

                clients.ForEach(item =>
                {
                    autoComplete.Add(item.ClientName);
                });

                txtBoxSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;

                txtBoxSearch.AutoCompleteCustomSource = autoComplete;

                txtBoxSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtBoxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtBoxSearch.Text != "")
                    Search();
            }
            else
            {
                Clear();
            }
        }

        private void Clear()
        {
            richTxtBoxLF.Text = richTxtBoxReferenceFare.Text = "";

            lblClientName.Text = "";

            lblNoCar.Visible = lblNoHotel.Visible = lblNoLF.Visible = lblNoRF.Visible =
                lblYesCar.Visible = lblYesHotel.Visible = lblYesLF.Visible = lblYesRF.Visible = false;
        }

        private void Search()
        {
            string error = "";

            var fare = FareBookService.Get(txtBoxSearch.Text, out error);

            if(error != "")
            {
                MessageBox.Show(error, "Error");
            }
            else
            {
                if(fare != null)
                {
                    lblClientName.Text = fare.ClientName;

                    txtBoxSearch.Text = "";
                    //LowFare
                    if (fare.LF == "Y")
                        lblYesLF.Visible = true;
                    else
                        lblNoLF.Visible = true;

                    richTxtBoxLF.Text = fare.LowFare;

                    //RF
                    if (fare.RF == "Y")
                        lblYesRF.Visible = true;
                    else
                        lblNoRF.Visible = true;

                    richTxtBoxReferenceFare.Text = fare.ReferenceFare;

                    //Others
                    if (fare.HotelStandardRate != "N")
                        lblYesHotel.Visible = true;
                    else
                        lblNoHotel.Visible = true;

                    if (fare.CarStandardRate != "N")
                        lblYesCar.Visible = true;
                    else
                        lblNoCar.Visible = true;
                }
                else
                {
                    Clear();

                    MessageBox.Show("No data found for this client", "Error");
                }
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void richTxtBoxOther_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTxtBoxLF_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblClientName_Click(object sender, EventArgs e)
        {

        }
    }
}

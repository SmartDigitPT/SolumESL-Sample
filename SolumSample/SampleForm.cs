using System;
using System.Windows.Forms;
using SolumSample.Provider;
using static SolumSample.Provider.Solus;

namespace SoulumSample
{
    public partial class SampleForm : Form
    {
        public SampleForm()
        {
            InitializeComponent();
        }

        private void SampleForm_Load(object sender, EventArgs e)
        {

        }

        private async void buttonTest_Click(object sender, EventArgs e)
        {
            IProvider solusProvider = new Solus(URL.Text, URL2.Text, User.Text, Password.Text);
            var (accessToken, refreshToken) = await solusProvider.GetToken();

            if (accessToken == "ERROR")
            {
                MessageBox.Show("Error connecting the Solum ESL service. Check credentials.", "SolumSample - " + refreshToken, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Successfully tested credentials.", "SolumSample", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            IProvider solusProvider = new Solus(URL.Text, URL2.Text,User.Text, Password.Text);

            Article articleData = new Article();
            articleData.ITEM_ID = ItemID.Text;
            articleData.ITEM_NAME = ItemDescription.Text;
            articleData.ITEM_DESCRIPTION = ItemDescription.Text;
            articleData.SALE_PRICE = ItemValue.Text;
            articleData.UNIT_PRICE = ItemValue.Text;
            articleData.BRAND = ItemID.Text;
            articleData.CLEARANCE_PRICE = ItemValue.Text;
            articleData.SKU = ItemID.Text;
            articleData.WEIGHT = "0";
            articleData.AISLE_LOCATION = "";
            articleData.LIST_PRICE = ItemValue.Text;
            articleData.UNIT_PRICE_UNIT = ItemValue.Text;
            articleData.WEIGHT_UNIT = "UNI";
            articleData.ITEM_DIMENSIONS = "0";
            articleData.INVENTORY = "0";
            articleData.MODEL = "";
            articleData.COLOR = "";
            articleData.NFC_DATA = "www.smartdigit.pt";
            articleData.START_DATE = DateTime.Now.ToString("yyyyMMdd");
            articleData.END_DATE = DateTime.Now.AddYears(1).ToString("yyyyMMdd");
            articleData.MISC_01 = "";
            articleData.MISC_02 = "";
            articleData.MISC_03 = "";
            articleData.DISPLAY_PAGE_1 = "";
            articleData.DISPLAY_PAGE_2 = "";
            articleData.DISPLAY_PAGE_3 = "";
            articleData.DISPLAY_PAGE_4 = "";
            articleData.DISPLAY_PAGE_5 = "";
            articleData.DISPLAY_PAGE_6 = "";
            articleData.DISPLAY_PAGE_7 = "";
            

            var response = await solusProvider.SendNewItem(articleData, Company.Text, Store.Text, URL2.Text);
            Console.WriteLine($"API Response: {response}");

            if (response.Contains("\"responseCode\":\"200\""))
            {

                MessageBox.Show("Article updated successfully!", "SolumSample", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

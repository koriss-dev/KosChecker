using System;
using System.Windows.Forms;
using System.Net.Http;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;

namespace KosChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void browsefile_Click(object sender, EventArgs e)
        {
            OpenFileDialog filebrowse = new OpenFileDialog();

            filebrowse.Filter = "Text files (*.txt)|*.txt";
            if (filebrowse.ShowDialog() == DialogResult.OK)
            {
                path.Text = filebrowse.FileName;
            }
        }

        private void checktokens_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(path.Text))
            {
                CheckTokensValidity();
            }
            else
            {
                MessageBox.Show("Select a file!");
            }
        }

        private async Task CheckTokensValidity()
        {
            string[] tokens = File.ReadAllLines(path.Text);
            List<string> validTokens = new List<string>();
            bool hasInvalidTokens = false;

            foreach (string token in tokens)
            {
                bool isValid = await IsValidToken(token);
                if (isValid)
                {
                    validTokens.Add(token);
                }
                else
                {
                    hasInvalidTokens = true;
                }
            }
            if (hasInvalidTokens)
            {
                DialogResult result = MessageBox.Show("There are invalid tokens. Do you want to overwrite the file with only valid tokens?", "Invalid tokens", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    File.WriteAllLines(path.Text, validTokens);
                    MessageBox.Show("Successfully!");
                }
            }
            else
            {
                MessageBox.Show("All tokens are valid.");
            }
        }

        private async Task<bool> IsValidToken(string token)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", token);
                HttpResponseMessage response = await client.GetAsync("https://discord.com/api/v9/users/@me");
                return response.IsSuccessStatusCode; //возвращение результата проверки
            }
        }
    }
}

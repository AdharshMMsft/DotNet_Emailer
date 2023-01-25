using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Azure.Communication.Email;
using System.Windows.Forms;
using Azure.Communication.Email.Models;
using Azure.Identity;

namespace Emailer {
    public partial class SendMail : Form {

        public static string connectionString, keyString, endpoint;

        public SendMail(string connString, string keString, string endpt) {
            connectionString = connString;
            keyString = keString;
            endpoint = endpt;
            InitializeComponent();
        }

        private void connStr_Click(object sender, EventArgs e) {
            //connStr.Text = connectionString;
        }

        private void label1_Click(object sender, EventArgs e) {
            //
        }

        private void label5_Click(object sender, EventArgs e) {
            //
        }

        private void textBox2_TextChanged(object sender, EventArgs e) {
            //
        }

        private void label1_Click_1(object sender, EventArgs e) {
            //
        }

        private void button1_Click(object sender, EventArgs e) {

            connectionString = connectionString.ToString();
            //Uri uri = new Uri(endpoint);
            EmailClient client = new EmailClient(connectionString);


            //Replace with your domain and modify the content, recipient details as required

            EmailContent emailContent = new EmailContent(content.Text.ToString());
            emailContent.PlainText = content.Text.ToString();
            List<EmailAddress> emailAddresses = new List<EmailAddress> { new EmailAddress(recipient.Text) };
            EmailRecipients emailRecipients = new EmailRecipients(emailAddresses);
            EmailMessage emailMessage = new EmailMessage(senderid.Text, emailContent, emailRecipients);
            SendEmailResult emailResult = client.Send(emailMessage, CancellationToken.None);


            this.Close();
        }
    }
}

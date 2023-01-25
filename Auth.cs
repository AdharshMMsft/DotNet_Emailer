using System.Configuration;
using System.Security.Cryptography.X509Certificates;

namespace Emailer {
    public partial class Auth : Form {

        public static string connectionString = null;
        public static string keyString = null;
        public static string endPoint = null;

        public Auth() {

            InitializeComponent();
        }

        private void subButton_Click(object sender, EventArgs e) {
            connectionString = conntb.Text;
            keyString = keytb.Text;
            endPoint = endpt.Text;

            Program.closeFlag = true;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e) {
            //
        }
    }
}
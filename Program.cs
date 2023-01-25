namespace Emailer {
    internal static class Program {

        public static bool closeFlag;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
       
        static void Main() {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            closeFlag = false;

            Application.Run(new Auth());

           
            if (closeFlag) {
                Application.Run(new SendMail(Auth.connectionString, Auth.keyString, Auth.endPoint));
            }

        }
    }
}
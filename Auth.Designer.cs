namespace Emailer {
    partial class Auth {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            connStr = new Label();
            keyStr = new Label();
            conntb = new TextBox();
            keytb = new TextBox();
            subButton = new Button();
            endpt = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // connStr
            // 
            connStr.AutoSize = true;
            connStr.Location = new Point(928, 318);
            connStr.Name = "connStr";
            connStr.Size = new Size(332, 48);
            connStr.TabIndex = 0;
            connStr.Text = "Connection String : ";
            // 
            // keyStr
            // 
            keyStr.AutoSize = true;
            keyStr.Location = new Point(928, 478);
            keyStr.Name = "keyStr";
            keyStr.Size = new Size(105, 48);
            keyStr.TabIndex = 1;
            keyStr.Text = "Key : ";
            // 
            // conntb
            // 
            conntb.Location = new Point(1328, 315);
            conntb.Name = "conntb";
            conntb.Size = new Size(1066, 55);
            conntb.TabIndex = 2;
            // 
            // keytb
            // 
            keytb.Location = new Point(1328, 478);
            keytb.Name = "keytb";
            keytb.Size = new Size(1066, 55);
            keytb.TabIndex = 3;
            // 
            // subButton
            // 
            subButton.Location = new Point(1673, 843);
            subButton.Name = "subButton";
            subButton.Size = new Size(319, 72);
            subButton.TabIndex = 4;
            subButton.Text = "Submit";
            subButton.UseVisualStyleBackColor = true;
            subButton.Click += subButton_Click;
            // 
            // endpt
            // 
            endpt.Location = new Point(1328, 626);
            endpt.Name = "endpt";
            endpt.Size = new Size(1066, 55);
            endpt.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(928, 633);
            label1.Name = "label1";
            label1.Size = new Size(170, 48);
            label1.TabIndex = 6;
            label1.Text = "End Point";
            label1.Click += label1_Click;
            // 
            // Auth
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(3581, 1228);
            Controls.Add(label1);
            Controls.Add(endpt);
            Controls.Add(subButton);
            Controls.Add(keytb);
            Controls.Add(conntb);
            Controls.Add(keyStr);
            Controls.Add(connStr);
            Name = "Auth";
            Text = "DotNetMailer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label connStr;
        private Label keyStr;
        private TextBox conntb;
        private TextBox keytb;
        private Button subButton;
        private TextBox endpt;
        private Label label1;
    }
}
namespace Emailer {
    partial class SendMail {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            Sender = new Label();
            senderid = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            recipient = new TextBox();
            label1 = new Label();
            content = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // Sender
            // 
            Sender.AutoSize = true;
            Sender.Location = new Point(337, 159);
            Sender.Name = "Sender";
            Sender.Size = new Size(254, 48);
            Sender.TabIndex = 0;
            Sender.Text = "Sender Email : ";
            Sender.Click += label1_Click;
            // 
            // senderid
            // 
            senderid.Location = new Point(597, 159);
            senderid.Name = "senderid";
            senderid.Size = new Size(950, 55);
            senderid.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(337, 354);
            label3.Name = "label3";
            label3.Size = new Size(84, 48);
            label3.TabIndex = 4;
            label3.Text = "To : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(337, 537);
            label4.Name = "label4";
            label4.Size = new Size(103, 48);
            label4.TabIndex = 5;
            label4.Text = "Bcc : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(337, 446);
            label5.Name = "label5";
            label5.Size = new Size(87, 48);
            label5.TabIndex = 6;
            label5.Text = "Cc : ";
            label5.Click += label5_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(597, 537);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(950, 55);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(597, 446);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(950, 55);
            textBox3.TabIndex = 8;
            // 
            // recipient
            // 
            recipient.Location = new Point(597, 354);
            recipient.Name = "recipient";
            recipient.Size = new Size(950, 55);
            recipient.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(337, 711);
            label1.Name = "label1";
            label1.Size = new Size(187, 48);
            label1.TabIndex = 10;
            label1.Text = "Message : ";
            label1.Click += label1_Click_1;
            // 
            // content
            // 
            content.Location = new Point(597, 708);
            content.Multiline = true;
            content.Name = "content";
            content.Size = new Size(1503, 871);
            content.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(988, 1697);
            button1.Name = "button1";
            button1.Size = new Size(225, 69);
            button1.TabIndex = 12;
            button1.Text = "Send";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SendMail
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2456, 1985);
            Controls.Add(button1);
            Controls.Add(content);
            Controls.Add(label1);
            Controls.Add(recipient);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(senderid);
            Controls.Add(Sender);
            Name = "SendMail";
            Text = "DotNetEmailer";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label Sender;
        private TextBox senderid;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox recipient;
        private Label label1;
        private TextBox content;
        private Button button1;

        #endregion

        // private Label connStr;
    }
}
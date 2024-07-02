namespace PortOpen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ConnectBtn = new Button();
            richTextBox1 = new RichTextBox();
            DisconnectBtn = new Button();
            SuspendLayout();
            // 
            // ConnectBtn
            // 
            ConnectBtn.Location = new Point(70, 58);
            ConnectBtn.Name = "ConnectBtn";
            ConnectBtn.Size = new Size(75, 23);
            ConnectBtn.TabIndex = 0;
            ConnectBtn.Text = "Connect Button";
            ConnectBtn.UseVisualStyleBackColor = true;
            ConnectBtn.Click += ConnectBtn_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(70, 193);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(547, 96);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // DisconnectBtn
            // 
            DisconnectBtn.Location = new Point(151, 58);
            DisconnectBtn.Name = "DisconnectBtn";
            DisconnectBtn.Size = new Size(75, 23);
            DisconnectBtn.TabIndex = 2;
            DisconnectBtn.Text = "Disconnect Button";
            DisconnectBtn.UseVisualStyleBackColor = true;
            DisconnectBtn.Click += DisconnectBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DisconnectBtn);
            Controls.Add(richTextBox1);
            Controls.Add(ConnectBtn);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button ConnectBtn;
        private RichTextBox richTextBox1;
        private Button DisconnectBtn;
    }
}

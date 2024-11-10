using System;
using System.Drawing;
using System.Windows.Forms;

namespace RobloxChatFilterBypass
{
    public partial class GUI : Form
    {
        private Button processButton;
        private TextBox inputArea;
        private TextBox outputArea;


        public GUI()
        {
            InitializeComponent();
        }


        private void InitializeComponent() {
            this.inputArea = new System.Windows.Forms.TextBox();
            this.outputArea = new System.Windows.Forms.TextBox();
            this.processButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputArea
            // 
            this.inputArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.inputArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputArea.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.inputArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.inputArea.Location = new System.Drawing.Point(12, 317);
            this.inputArea.Multiline = true;
            this.inputArea.Name = "inputArea";
            this.inputArea.Size = new System.Drawing.Size(1166, 86);
            this.inputArea.TabIndex = 0;
            this.inputArea.Text = "Type here the message to get a bypass version of it";
            // 
            // outputArea
            // 
            this.outputArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.outputArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputArea.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.outputArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.outputArea.Location = new System.Drawing.Point(12, 12);
            this.outputArea.Multiline = true;
            this.outputArea.Name = "outputArea";
            this.outputArea.ReadOnly = true;
            this.outputArea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputArea.Size = new System.Drawing.Size(1315, 299);
            this.outputArea.TabIndex = 0;
            this.outputArea.TextChanged += new System.EventHandler(this.outputArea_TextChanged);
            // 
            // processButton
            // 
            this.processButton.BackColor = System.Drawing.Color.Red;
            this.processButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.processButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.processButton.ForeColor = System.Drawing.Color.White;
            this.processButton.Location = new System.Drawing.Point(1177, 317);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(150, 86);
            this.processButton.TabIndex = 0;
            this.processButton.Text = "Bypass it!";
            this.processButton.UseVisualStyleBackColor = false;
            this.processButton.Click += new System.EventHandler(this.ProcessButton_Click);
            // 
            // GUI
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1339, 415);
            this.Controls.Add(this.inputArea);
            this.Controls.Add(this.outputArea);
            this.Controls.Add(this.processButton);
            this.Name = "GUI";
            this.Text = "Chat Filter Bypass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void ProcessButton_Click(object sender, EventArgs e)
        {
            String alternatedtext = this.inputArea.Text;
            alternatedtext = alternatedtext .Replace("a", "а").Replace("A", "а")
                                            .Replace("b", "в").Replace("B", "в")
                                            .Replace("c", "с").Replace("C", "с")
                                            .Replace("d", "ԁ").Replace("D", "ԁ")
                                            .Replace("e", "е").Replace("E", "е")
                                            .Replace("g", "ġ").Replace("G", "ġ")
                                            .Replace("h", "һ").Replace("H", "һ")
                                            .Replace("i", "і").Replace("I", "і")
                                            .Replace("j", "ј").Replace("J", "ј")
                                            .Replace("k", "κ").Replace("K", "κ")
                                            .Replace("l", "l").Replace("L", "l")
                                            .Replace("n", "ո").Replace("N", "ո")
                                            .Replace("o", "о").Replace("O", "о")
                                            .Replace("p", "р").Replace("P", "р")
                                            .Replace("q", "զ").Replace("Q", "զ")
                                            .Replace("s", "ʂ").Replace("S", "ʂ")
                                            .Replace("u", "υ").Replace("U", "υ")
                                            .Replace("v", "ν").Replace("V", "ν")
                                            .Replace("x", "х").Replace("X", "х")
                                            .Replace("y", "у").Replace("Y", "у")
                                            .Replace("z", "ʐ").Replace("Z", "ʐ");
            this.outputArea.Text = alternatedtext;
        }
        private void CopyButton_Click(object sender, EventArgs e)
        {

            Clipboard.SetText(outputArea.Text);
            this.outputArea.Text = "";

            MessageBox.Show("Text Copied succesfully!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void outputArea_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

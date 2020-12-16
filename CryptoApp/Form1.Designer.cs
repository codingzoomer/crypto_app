
namespace CryptoApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit_button = new System.Windows.Forms.Button();
            this.check_coin = new System.Windows.Forms.Button();
            this.coin_id = new System.Windows.Forms.TextBox();
            this.coin_name = new System.Windows.Forms.TextBox();
            this.coin_short = new System.Windows.Forms.TextBox();
            this.coin_value_usd = new System.Windows.Forms.TextBox();
            this.coin_value_pln = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.error_message = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.exit_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 50);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // exit_button
            // 
            this.exit_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit_button.BackgroundImage")));
            this.exit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exit_button.FlatAppearance.BorderSize = 0;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Location = new System.Drawing.Point(753, 0);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(47, 49);
            this.exit_button.TabIndex = 1;
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // check_coin
            // 
            this.check_coin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.check_coin.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.check_coin.Location = new System.Drawing.Point(115, 137);
            this.check_coin.Name = "check_coin";
            this.check_coin.Size = new System.Drawing.Size(100, 43);
            this.check_coin.TabIndex = 1;
            this.check_coin.Text = "Lookup";
            this.check_coin.UseVisualStyleBackColor = false;
            this.check_coin.Click += new System.EventHandler(this.check_coin_Click);
            // 
            // coin_id
            // 
            this.coin_id.Location = new System.Drawing.Point(115, 101);
            this.coin_id.Name = "coin_id";
            this.coin_id.Size = new System.Drawing.Size(100, 26);
            this.coin_id.TabIndex = 2;
            // 
            // coin_name
            // 
            this.coin_name.Location = new System.Drawing.Point(396, 98);
            this.coin_name.Name = "coin_name";
            this.coin_name.ReadOnly = true;
            this.coin_name.Size = new System.Drawing.Size(100, 26);
            this.coin_name.TabIndex = 3;
            // 
            // coin_short
            // 
            this.coin_short.Location = new System.Drawing.Point(396, 154);
            this.coin_short.Name = "coin_short";
            this.coin_short.ReadOnly = true;
            this.coin_short.Size = new System.Drawing.Size(100, 26);
            this.coin_short.TabIndex = 4;
            // 
            // coin_value_usd
            // 
            this.coin_value_usd.Location = new System.Drawing.Point(396, 212);
            this.coin_value_usd.Name = "coin_value_usd";
            this.coin_value_usd.ReadOnly = true;
            this.coin_value_usd.Size = new System.Drawing.Size(100, 26);
            this.coin_value_usd.TabIndex = 5;
            // 
            // coin_value_pln
            // 
            this.coin_value_pln.Location = new System.Drawing.Point(396, 267);
            this.coin_value_pln.Name = "coin_value_pln";
            this.coin_value_pln.ReadOnly = true;
            this.coin_value_pln.Size = new System.Drawing.Size(100, 26);
            this.coin_value_pln.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "coin name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(324, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "coin id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(243, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "coin price in USD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(243, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "coin price in PLN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "coin name";
            // 
            // error_message
            // 
            this.error_message.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_message.ForeColor = System.Drawing.Color.DarkRed;
            this.error_message.Location = new System.Drawing.Point(110, 353);
            this.error_message.Name = "error_message";
            this.error_message.Size = new System.Drawing.Size(385, 88);
            this.error_message.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(295, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 31);
            this.label6.TabIndex = 14;
            this.label6.Text = "Last lookup result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.error_message);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.coin_value_pln);
            this.Controls.Add(this.coin_value_usd);
            this.Controls.Add(this.coin_short);
            this.Controls.Add(this.coin_name);
            this.Controls.Add(this.coin_id);
            this.Controls.Add(this.check_coin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button check_coin;
        private System.Windows.Forms.TextBox coin_id;
        private System.Windows.Forms.TextBox coin_name;
        private System.Windows.Forms.TextBox coin_short;
        private System.Windows.Forms.TextBox coin_value_usd;
        private System.Windows.Forms.TextBox coin_value_pln;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label error_message;
        private System.Windows.Forms.Label label6;
    }
}


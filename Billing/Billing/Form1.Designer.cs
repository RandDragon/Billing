namespace Billing
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbIp = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbDogovor = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.Label();
            this.lDogovor = new System.Windows.Forms.Label();
            this.lPort = new System.Windows.Forms.Label();
            this.lIp = new System.Windows.Forms.Label();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.btnFindName = new System.Windows.Forms.Button();
            this.btnFindDogovor = new System.Windows.Forms.Button();
            this.btnFindPort = new System.Windows.Forms.Button();
            this.btnFindIp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(167, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(469, 20);
            this.tbName.TabIndex = 0;
            // 
            // tbIp
            // 
            this.tbIp.Location = new System.Drawing.Point(167, 90);
            this.tbIp.Name = "tbIp";
            this.tbIp.Size = new System.Drawing.Size(469, 20);
            this.tbIp.TabIndex = 5;
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(167, 64);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(469, 20);
            this.tbPort.TabIndex = 6;
            // 
            // tbDogovor
            // 
            this.tbDogovor.Location = new System.Drawing.Point(167, 38);
            this.tbDogovor.Name = "tbDogovor";
            this.tbDogovor.Size = new System.Drawing.Size(469, 20);
            this.tbDogovor.TabIndex = 7;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(12, 19);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(35, 13);
            this.lName.TabIndex = 8;
            this.lName.Text = "Name";
            // 
            // lDogovor
            // 
            this.lDogovor.AutoSize = true;
            this.lDogovor.Location = new System.Drawing.Point(12, 45);
            this.lDogovor.Name = "lDogovor";
            this.lDogovor.Size = new System.Drawing.Size(48, 13);
            this.lDogovor.TabIndex = 9;
            this.lDogovor.Text = "Dogovor";
            // 
            // lPort
            // 
            this.lPort.AutoSize = true;
            this.lPort.Location = new System.Drawing.Point(12, 71);
            this.lPort.Name = "lPort";
            this.lPort.Size = new System.Drawing.Size(26, 13);
            this.lPort.TabIndex = 10;
            this.lPort.Text = "Port";
            // 
            // lIp
            // 
            this.lIp.AutoSize = true;
            this.lIp.Location = new System.Drawing.Point(12, 97);
            this.lIp.Name = "lIp";
            this.lIp.Size = new System.Drawing.Size(16, 13);
            this.lIp.TabIndex = 11;
            this.lIp.Text = "Ip";
            // 
            // dgvClients
            // 
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Location = new System.Drawing.Point(3, 306);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.Size = new System.Drawing.Size(1246, 150);
            this.dgvClients.TabIndex = 12;
            // 
            // btnFindName
            // 
            this.btnFindName.Location = new System.Drawing.Point(643, 12);
            this.btnFindName.Name = "btnFindName";
            this.btnFindName.Size = new System.Drawing.Size(75, 20);
            this.btnFindName.TabIndex = 13;
            this.btnFindName.Text = "Find";
            this.btnFindName.UseVisualStyleBackColor = true;
            this.btnFindName.Click += new System.EventHandler(this.btnFindName_Click);
            // 
            // btnFindDogovor
            // 
            this.btnFindDogovor.Location = new System.Drawing.Point(643, 38);
            this.btnFindDogovor.Name = "btnFindDogovor";
            this.btnFindDogovor.Size = new System.Drawing.Size(75, 20);
            this.btnFindDogovor.TabIndex = 14;
            this.btnFindDogovor.Text = "Find";
            this.btnFindDogovor.UseVisualStyleBackColor = true;
            // 
            // btnFindPort
            // 
            this.btnFindPort.Location = new System.Drawing.Point(643, 64);
            this.btnFindPort.Name = "btnFindPort";
            this.btnFindPort.Size = new System.Drawing.Size(75, 20);
            this.btnFindPort.TabIndex = 15;
            this.btnFindPort.Text = "Find";
            this.btnFindPort.UseVisualStyleBackColor = true;
            // 
            // btnFindIp
            // 
            this.btnFindIp.Location = new System.Drawing.Point(643, 90);
            this.btnFindIp.Name = "btnFindIp";
            this.btnFindIp.Size = new System.Drawing.Size(75, 20);
            this.btnFindIp.TabIndex = 16;
            this.btnFindIp.Text = "Find";
            this.btnFindIp.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 515);
            this.Controls.Add(this.btnFindIp);
            this.Controls.Add(this.btnFindPort);
            this.Controls.Add(this.btnFindDogovor);
            this.Controls.Add(this.btnFindName);
            this.Controls.Add(this.dgvClients);
            this.Controls.Add(this.lIp);
            this.Controls.Add(this.lPort);
            this.Controls.Add(this.lDogovor);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.tbDogovor);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.tbIp);
            this.Controls.Add(this.tbName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbIp;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbDogovor;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lDogovor;
        private System.Windows.Forms.Label lPort;
        private System.Windows.Forms.Label lIp;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.Button btnFindName;
        private System.Windows.Forms.Button btnFindDogovor;
        private System.Windows.Forms.Button btnFindPort;
        private System.Windows.Forms.Button btnFindIp;
    }
}


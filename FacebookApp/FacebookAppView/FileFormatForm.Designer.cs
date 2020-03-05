namespace FacebookApp
{
    partial class FileFormatForm
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
            this.flowLayoutPanelPropOption = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelChooseProp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanelPropOption
            // 
            this.flowLayoutPanelPropOption.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanelPropOption.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flowLayoutPanelPropOption.Location = new System.Drawing.Point(12, 66);
            this.flowLayoutPanelPropOption.Name = "flowLayoutPanelPropOption";
            this.flowLayoutPanelPropOption.Size = new System.Drawing.Size(357, 179);
            this.flowLayoutPanelPropOption.TabIndex = 0;
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOK.Location = new System.Drawing.Point(279, 251);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(91, 31);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelChooseProp
            // 
            this.labelChooseProp.AutoSize = true;
            this.labelChooseProp.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChooseProp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelChooseProp.Location = new System.Drawing.Point(4, 9);
            this.labelChooseProp.Name = "labelChooseProp";
            this.labelChooseProp.Size = new System.Drawing.Size(311, 44);
            this.labelChooseProp.TabIndex = 2;
            this.labelChooseProp.Text = "Please choose the info you would \r\nlike to write into the file";
            // 
            // FileFormatForm
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(382, 294);
            this.Controls.Add(this.labelChooseProp);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.flowLayoutPanelPropOption);
            this.Name = "FileFormatForm";
            this.Text = "Choose file format";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPropOption;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelChooseProp;
    }
}
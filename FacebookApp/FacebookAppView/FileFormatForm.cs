using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacebookApp
{
    public partial class FileFormatForm : Form
    {
        public FileFormatForm(UserProxy i_LoggedInUser)
        {
            this.LoggedInUser = i_LoggedInUser;
            this.ChosenFileFormat = new FileFormat(this.LoggedInUser);
            this.InitializeComponent();
            this.createControls();
        }

        public UserProxy LoggedInUser { get; set; }

        public FileFormat ChosenFileFormat { get; set; }

        private void createControls()
        {
            CheckBox checkBoxItem;
            foreach (PropertiesOptions.ePropertiesOptions propOption in this.ChosenFileFormat.OptionalPropreties)
            {
                checkBoxItem = new CheckBox();
                checkBoxItem.Text = propOption.ToString();
                this.flowLayoutPanelPropOption.Controls.Add(checkBoxItem);
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.flowLayoutPanelPropOption.Controls)
            {
                if ((control is CheckBox) && (control as CheckBox).Checked)
                {
                    this.ChosenFileFormat.ChosenProperties.Add((PropertiesOptions.ePropertiesOptions)Enum.Parse(typeof(PropertiesOptions.ePropertiesOptions), (control as CheckBox).Text));
                }
            }
        }
    }
}

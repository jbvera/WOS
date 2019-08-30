﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryApplication.Controls
{
    public partial class LabeledTextBox : System.Web.UI.UserControl
    {
        public string Label
        {
            get
            {
                return ControlLabel.Text;
            }
            set
            {
                ControlLabel.Text = value;
            }
        }
        public bool Required
        {
            get
            {
                return ControlValidator.Enabled;
            }
            set
            {
                ControlValidator.Enabled = value;
            }
        }
        public string Text
        {
            get
            {
                return ControlTextBox.Text;
            }
            set
            {
                ControlTextBox.Text = value;
            }
        }
        public string ValidationGroup
        {
            get
            {
                return ControlTextBox.ValidationGroup;
            }
            set
            {
                ControlTextBox.ValidationGroup = value;
            }
        }
        public string RequiredErrorMessage
        {
            get
            {
                return ControlValidator.ErrorMessage;
            }
            set
            {
                ControlValidator.ErrorMessage = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}
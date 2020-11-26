﻿using Jcon_Contact_Tracing.Validator;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using LTXJconLibrary;
using FluentValidation.Results;
using Jcon_Contact_Tracing.AppData;

namespace Jcon_Contact_Tracing
{
    public partial class MainForm : Form
    {


        public MainForm()
        {
            InitializeComponent();
            listError.DataSource = DataCollection.Logs;
            lstboxSearchItems.DataSource = DataCollection.SearchItem;
        }

        public void ProcessItem()
        {
            
        }


      
        /*
         *
         *                   ALL EVENTS HANDLER
         *
         */

        private void picboxDownload_MouseHover(object sender, EventArgs e)
        {
            picboxDownload.Image = imageList1.Images[0];
        }

        private void picboxDownload_MouseLeave(object sender, EventArgs e)
        {
            picboxDownload.Image = imageList1.Images[1];
        }

        private void txtboxInput_KeyDown(object sender, KeyEventArgs e)
        {
        
               
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class DisplayQuote : Form
    {
        MainMenu showQuotesToMenu;
        DeskQuote deskQuote;
        public DisplayQuote()
        {
            InitializeComponent();
            deskQuote = new DeskQuote();
            Desk desk = deskQuote.Desk;

            theDate.Text = deskQuote.PurchaseDate;
            theCustomer.Text = $"{deskQuote.FirstName} {deskQuote.LastName}";
            theWidth.Text = desk.Width.ToString();
            theDepth.Text = desk.Depth.ToString();
            theArea.Text = (desk.Width * desk.Depth).ToString();
            theDrawers.Text = desk.DrawerNum.ToString();
            theMaterial.Text = desk.MaterialType.ToString();
            theRush.Text = deskQuote.RushCost.ToString();
            theTotal.Text = deskQuote.TotalCost.ToString();
        }

        private void mainMenu_Click(object sender, EventArgs e)
        {
            if (showQuotesToMenu == null)
            {
                showQuotesToMenu = new MainMenu();
            }
            Hide();
            showQuotesToMenu.Show();
        }

        private void SaveQuote_Click(object sender, EventArgs e)
        {
            try
            {
                deskQuote.storeQuote();
                MessageBox.Show("Quote Saved!", "Notice");
            }
            catch
            {
                MessageBox.Show("Something went wrong with saving the quote. Try again later.", "Error");
            }
        }
    }
}

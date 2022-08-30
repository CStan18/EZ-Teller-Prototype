using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZ_Teller_Prototype
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lnkDeposit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmDeposit frmDeposit = new FrmDeposit();
            this.Hide();
            frmDeposit.ShowDialog();
            this.Visible = true;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            this.Hide();
            frmLogin.ShowDialog();
        }

        private void lnkWithdrawal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmWithdrawal frmWithdrawal = new FrmWithdrawal();
            this.Hide();
            frmWithdrawal.ShowDialog();
            this.Visible = true;
        }

        private void lnkMortgagePmnt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmMortgagePmnt frmMortgagePmnt = new FrmMortgagePmnt();
            this.Hide();
            frmMortgagePmnt.ShowDialog();
            this.Visible = true;
        }

        private void lnkLoanPmnt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmLoanPmnt frmLoanPmnt = new FrmLoanPmnt();
            this.Hide();
            frmLoanPmnt.ShowDialog();
            this.Visible = true;
        }

        private void lnkLookUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAccountsList frmAccountsList = new FrmAccountsList();
            this.Hide();
            frmAccountsList.ShowDialog();
            this.Visible = true;
        }

        private void lnkOpenAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmCreateAccount frmCreateAccount = new FrmCreateAccount();
            this.Hide();
            frmCreateAccount.ShowDialog();
            this.Visible = true;
        }

        private void lnkCloseAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmCloseAccount frmCloseAccount = new FrmCloseAccount();
            this.Hide();
            frmCloseAccount.ShowDialog();
            this.Visible = true;
        }

        private void lnkBuyIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBuyCash frmBuyCash = new FrmBuyCash();
            this.Hide();
            frmBuyCash.ShowDialog();
            this.Visible = true;
        }
    }
}

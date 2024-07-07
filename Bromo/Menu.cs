using System.Windows.Forms;
using System;

namespace Bromo
{
    public partial class Menu : Form
    {
        MasterBandara MBs;
        MasterKodePromo MKPs;
        MasterMaskapai MMs;
        MasterJadwalPenerbangan MJPs;
        UbahStatusPenerbangan USPs;
        private const int BukaMenuWidth = 209;
        private const int TutupMenuWidth = 1;
        public Menu()
        {
            InitializeComponent();

        }

        bool DashExpand = true;
        private void Dashboard_Tick(object sender, EventArgs e)
        {
            const int animationStep = 20;

            if (DashExpand)
            {
                if (MasterMenu.Width > TutupMenuWidth)
                {
                    MasterMenu.Width -= animationStep;
                }
                else
                {
                    DashExpand = false;
                    Dashboard.Stop();
                }
            }
            else
            {
                if (MasterMenu.Width < BukaMenuWidth)
                {
                    MasterMenu.Width += animationStep;
                }
                else
                {
                    DashExpand = true;
                    Dashboard.Stop();
                }
            }
        }

        private void Master_Click(object sender, EventArgs e)
        {
            if (MBs == null)
            {
                MBs = new MasterBandara();
                MBs.MdiParent = this;
                MBs.Dock = DockStyle.Fill;
                MBs.Show();
            }
            else
            {
                MBs.Activate();
            }
        }
        private void MKP_Click(object sender, EventArgs e)
        {
            if (MKPs == null)
            {
                MKPs = new MasterKodePromo();
                MKPs.MdiParent = this;
                MKPs.Dock = DockStyle.Fill;
                MKPs.Show();
            }
            else
            {
                MKPs.Activate();
            }
        }

        private void MK_Click(object sender, EventArgs e)
        {
            if (MJPs == null)
            {
                MJPs = new MasterJadwalPenerbangan();
                MJPs.MdiParent = this;
                MJPs.Dock = DockStyle.Fill;
                MJPs.Show();
            }
            else
            {
                MJPs.Activate();
            }
        }
        private void MM_Click(object sender, EventArgs e)
        {
            if (MMs == null)
            {
                MMs = new MasterMaskapai();
                MMs.MdiParent = this;
                MMs.Dock = DockStyle.Fill;
                MMs.Show();
            }
            else
            {
                MMs.Activate();
            }
        }
        private void MJD_Click(object sender, EventArgs e)
        {
            if (MJPs == null)
            {
                MJPs = new MasterJadwalPenerbangan();
                MJPs.MdiParent = this;
                MJPs.Dock = DockStyle.Fill;
                MJPs.Show();
            }
            else
            {
                MJPs.Activate();
            }
        }
        private void USP_Click(object sender, EventArgs e)
        {
            if (USPs == null)
            {
                USPs = new UbahStatusPenerbangan();
                USPs.MdiParent = this;
                USPs.Dock = DockStyle.Fill;
                USPs.Show();
            }
            else
            {
                USPs.Activate();
            }
        }

        private void BtnDash_Click(object sender, EventArgs e)
        {
            Dashboard.Start();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Login ln = new Login();
            ln.Show();
            this.Hide();
        }
    }
}

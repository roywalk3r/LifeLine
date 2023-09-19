using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeLine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ---------------- Form Responsiveness Control ----------------------- //

            int WindowHeight = Screen.PrimaryScreen.WorkingArea.Height;
            int WindowWidth = Screen.PrimaryScreen.WorkingArea.Width;
            //Setting Full And Responsive
            this.ClientSize = new Size(WindowWidth, WindowHeight);


            //Changing Active Control
            this.ActiveControl = lblLogin;


            //----------- Hiding The Show And Hide Buttons
            btnShow.Visible = false;
            btnHide.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close Function : Message Box
            //Variable Declaration & Initialization
            string message = "Are you sure you want to close window";
            string title = "Close Form";

            //Object ANd Class Declaration
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon  icon = MessageBoxIcon.Information;

            //Creating MessageBox
            DialogResult result = MessageBox.Show(message, title, buttons, icon);

            //Close Windows : If Statement Execution
            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }


        }

        private void btnMinize_Click(object sender, EventArgs e)
        {
            //Minimize  Function
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            //-------------- Username PlaceHoldler Enter ---------------------//
            if (txtUsername.Text == "User Name")
                txtUsername.Text = string.Empty;

           
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            //-------------- Username PlaceHoldler ---------------------//
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "User Name";

                //--Changing TextColor
                //txtUsername.ForeColor = Color.Beige;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                
                txtPassword.Text = "";

            //Adding Password Property
            txtPassword.isPassword = true;
        }
           
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";

                //--------------- Removing Password Property
                txtPassword.isPassword = false;

                //------ Hiding Eye Image
                btnShow.Visible = false;
                btnHide.Visible = false;

            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            // ---- Show Password ------//
            txtPassword.isPassword = false;
            // ---- Hiding & Showing Buttons
            btnShow.Visible = false;
            btnHide.Visible = true;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            //Hiding Password 
            txtPassword.isPassword = true;

            // ---- Hiding & Showing Buttons
            btnShow.Visible = true;
            btnHide.Visible = false;
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            btnShow.Visible = true;

        }

       
    }
}

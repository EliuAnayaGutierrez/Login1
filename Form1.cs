using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Login
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,          //x-coordinate of upper-left corner
            int nTopRect,           //y-coordinate of upper-left corner
            int nRightRect,         //x-coordinate of lower-right corner
            int nBottomRect,        //y-coordinate of lower-right corner
            int nWidhtEllipse,      //heigth of ellipse
            int nHeightEllipse      //widht of ellipse
            );
        
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }
        private void tbUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            Clases.Conexion objConex = new Clases.Conexion();
            objConex.establecerConexion();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EcomGr3
{
    public partial class frmML : Form
    {

        public frmML()
        {
            InitializeComponent();
        }
       
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDiscover discover = new frmDiscover();
            discover.Show();
        }

        private void frmML_Load(object sender, EventArgs e)
        {
            LoadItems();
        }

        private void LoadItems()
        {
            string connectionString = "Data Source=LAPTOP-JP2C8Q4H\\SQLEXPRESS;Initial Catalog=PixelPlay;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT ID, ItemMLimage, ItemMLname, ItemMLprice FROM tblML", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = (int)reader["ID"];
                    byte[] imageData = (byte[])reader["ItemMLimage"];
                    string itemName = reader["ItemMLname"].ToString();
                    string itemPrice = reader["ItemMLprice"].ToString();

                    MemoryStream ms = new MemoryStream(imageData);
                    PictureBox pb = new PictureBox();
                    pb.Image = Image.FromStream(ms);
                    pb.SizeMode = PictureBoxSizeMode.Zoom;
                    pb.Width = 130;
                    pb.Height = 130;
                    pb.Margin = new Padding(5);
                    pb.Padding = new Padding(50);
                    pb.BorderStyle = BorderStyle.FixedSingle;

                    PictureBox selectedPictureBox = null;

                    pb.Click += (sender, e) =>
                    {
                        PictureBox clickedPictureBox = (PictureBox)sender;
                        if (clickedPictureBox == selectedPictureBox)
                        {
                            clickedPictureBox.BorderStyle = BorderStyle.FixedSingle;
                            selectedPictureBox = null;
                        }
                        else
                        {
                            if (selectedPictureBox != null)
                            {
                                selectedPictureBox.BorderStyle = BorderStyle.FixedSingle;
                            }
                            clickedPictureBox.BorderStyle = BorderStyle.Fixed3D;
                            selectedPictureBox = clickedPictureBox;
                        }
                    };


                    Label lbl = new Label();
                    lbl.Text = itemName;
                    lbl.BackColor = Color.FromArgb(255, 185, 50);
                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                    lbl.Font = new Font("Open Sans", 8, FontStyle.Regular);
                    lbl.Height = 30;
                    lbl.Dock = DockStyle.Bottom;


                    Label lbl1 = new Label();
                    lbl1.Text = "₱ " + itemPrice;
                    lbl1.BackColor = Color.FromArgb(226, 226, 226);
                    lbl1.TextAlign = ContentAlignment.MiddleCenter;
                    //lbl1.Width = 45;
                    lbl1.Font = new Font("Open Sans", 8, FontStyle.Regular);


                    flowLayoutPanel1.Controls.Add(pb);
                    pb.Controls.Add(lbl);
                    pb.Controls.Add(lbl1);
                }

                reader.Close();
            }
        }


        // Click event handler for the PictureBox
        private void PictureBox_Click(object sender, EventArgs e)
        {
            int imageId = (int)((PictureBox)sender).Tag; // Retrieve the image ID from the Tag property of the PictureBox
                                                         // Do something with the image ID, such as displaying the full-size image or opening a new window with additional information about the image
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDiscover discover = new frmDiscover();
            discover.Show();
        }
    }
}

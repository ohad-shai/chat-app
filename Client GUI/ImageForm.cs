using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Communicator;

namespace Client_GUI
{
    public partial class ImageForm : Form
    {

        /// <summary>
        /// C'tor
        /// </summary>
        /// <param name="image">The image to display</param>
        /// <param name="sender">The user who sent the image</param>
        public ImageForm(Image image, User sender)
        {
            InitializeComponent();

            this.Text = String.Format("Image from: {0}", sender.UserName);
            saveFileDialog.DefaultExt = "jpg";
            picBoxImage.Image = image; // Assigns the image to the pictureBox
        }

        /// <summary>
        /// Button: Save Image
        /// </summary>
        private void btnSavePicture_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }

        /// <summary>
        /// Occures when the user selected the path to save the image!
        /// </summary>
        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            picBoxImage.Image.Save(saveFileDialog.FileName);
        }

        /// <summary>
        /// Button: Cancel
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client_Logic;
using System.Net;

namespace Client_GUI
{
    public partial class ConnectDialog : Form
    {

        #region Fields

        Client client;

        #endregion

        #region Properties

        /// <summary>
        /// Holds the client logic!
        /// </summary>
        public Client Client { get; set; }

        #endregion

        /// <summary>
        /// C'tor
        /// </summary>
        public ConnectDialog()
        {
            InitializeComponent();
        }

        #region Events

        /// <summary>
        /// Registers all the events raised by the client
        /// </summary>
        private void ClientEventsRegistration()
        {
            client.ServerNotFound += new Action(form_ServerNotFound);
            client.UserApproved += new Action(form_OnUserApproved);
            client.UserRejected += new Action(form_OnUserRejected);
        }

        #region Implementations of Events!

        /// <summary>
        /// Occurs when the event 'ServerNotFound' raised!
        /// Event does: Displays a message that no server is found!
        /// </summary>
        private void form_ServerNotFound()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(form_ServerNotFound));
                return;
            }

            // Update the GUI
            MessageBox.Show(
                "The server you're trying to connect was not found.",
                "Server not found",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
        }

        /// <summary>
        /// Occurs when the event 'UserApproved' raised!
        /// Event does: Displays connected mode!
        /// </summary>
        private void form_OnUserApproved()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(form_OnUserApproved));
                return;
            }

            // Update the GUI
            Client = client; // Assigns the client to the property

            // Removes registered events
            client.ServerNotFound -= form_ServerNotFound;
            client.UserApproved -= form_OnUserApproved;
            client.UserRejected -= form_OnUserRejected;

            this.DialogResult = DialogResult.OK;
            this.Close(); // Close dialog...
        }

        /// <summary>
        /// Occurs when the event 'UserRejected' raised!
        /// Event does: Displays the rejected reason from the server!
        /// </summary>
        private void form_OnUserRejected()
        {
            if (client.IsClientOK[0] == false && client.IsClientOK[1] == false && client.Stream != null) // If both the 'Name' and 'Color' are taken, needs to inform the user he's not connected!
            {
                MessageBox.Show(
                    string.Format("User Name: \"{0}\", and Color: [{1}],\nalready taken by someone else.", txtUserName.Text, btnFontColor.BackColor.Name),
                    "Failed to connect the server",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
            else if (client.IsClientOK[0] == false && client.Stream != null) // If only the 'Name' is taken, needs to inform the user he's not connected!
            {
                MessageBox.Show(
                    string.Format("User Name: \"{0}\", is already taken by someone else.", txtUserName.Text),
                    "Failed to connect the server",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
            else if (client.IsClientOK[1] == false && client.Stream != null) // If only the 'Color' is taken, needs to inform the user he's not connected!
            {
                MessageBox.Show(
                    string.Format("Color: [{0}], is already taken by someone else.", btnFontColor.BackColor.Name),
                    "Failed to connect the server",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
        }

        #endregion

        #endregion

        /// <summary>
        /// When dialog shows, setting some default values!
        /// </summary>
        private void ConnectDialog_Load(object sender, EventArgs e)
        {
            txtIP.Text = "127.0.0.1"; // Default IP
            numericPort.Value = 13000; // Default Port
            txtUserName.Text = Environment.UserName; // Default UserName
        }

        /// <summary>
        /// Button: Cancel
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Button: OK
        /// </summary>
        private void btnOK_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor; // Displays 'wait' cursor when loading!

            IPAddress checkIP;
            if (!IPAddress.TryParse(txtIP.Text, out checkIP)) // IP field check
            {
                MessageBox.Show("IP Address is not valid.");
            }
            else if ((int)numericPort.Value <= 0 || (int)numericPort.Value > 65535) // Port field check
            {
                MessageBox.Show("Port is not valid.");
            }
            else if (txtUserName.Text == string.Empty) // Server name field check
            {
                MessageBox.Show("Must enter a user name.");
            }
            else // If all fields are OK
            {
                // Sending: IP, Port, Name, and Color to start a client!
                client = new Client(txtIP.Text, (int)numericPort.Value, txtUserName.Text, btnFontColor.BackColor);
                ClientEventsRegistration();
                client.Connect();
            }

            // Now, this dialog waits for 'ServerNotFound', or 'UserApproved', 'UserRejected' events
            // Then, it acts according to the raised event!
        }

        /// <summary>
        /// Text input: User Name
        /// </summary>
        private void txtUserName_MouseDown(object sender, MouseEventArgs e)
        {
            this.txtUserName.ForeColor = Color.Black; // Makes the text color in black on focus!
        }
        
        /// <summary>
        /// Button: Font Color
        /// </summary>
        private void btnFontColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = false; // Prevents the user from selecting a custom color

            if (colorDialog.ShowDialog() == DialogResult.OK) // If picked a color in the color dialog
            {
                if (colorDialog.Color == Color.White) // If picked White color, it's not OK
                {
                    MessageBox.Show("You can't pick White color.");
                }
                else // Updates the button color if color is OK
                {
                    this.btnFontColor.BackColor = colorDialog.Color;
                }
            }
        }

        /// <summary>
        /// TextBox: IP | This won't allow to enter anything other than digits and punctuation marks in the IP text box!
        /// </summary>
        private void txtIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}

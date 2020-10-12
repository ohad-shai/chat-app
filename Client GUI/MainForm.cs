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
using Communicator;

namespace Client_GUI
{
    public partial class MainForm : Form
    {

        #region Fields

        private Client client; // Holds the client logic

        #endregion

        /// <summary>
        /// C'tor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        #region Events

        /// <summary>
        /// Registers all the events raised by the client
        /// </summary>
        private void ClientEventsRegistration()
        {
            client.ServerConnectionLost += new Action(form_ServerConnectionLost);
            client.PublicMessageReceived += new Action<ChatMessage>(form_OnPublicMessageReceived);
            client.PrivateMessageReceived += new Action<ChatMessage>(form_OnPrivateMessageReceived);
            client.UserConnected += new Action<User>(form_OnUserConnected);
            client.UserDisconnected += new Action<User>(form_OnUserDisconnected);
            client.BlockReceived += new Action<ChatMessage>(form_OnBlockReceived);
            client.ErrorOccurred += new Action<string, bool>(form_OnErrorOccurred);
        }

        #region Implementations of Events!

        /// <summary>
        /// Occurs when the event 'ServerConnectionLost' raised!
        /// Event does: Displays a message the connection has been lost, and then selecting the (virtual window) disconnected to the GUI!
        /// </summary>
        private void form_ServerConnectionLost()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(form_ServerConnectionLost));
                return;
            }

            // Update the GUI
            MessageBox.Show(
                "Connection to the server has been lost...",
                "Connection lost",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );

            virtualForms.SelectTab(0); // Select: (Virtual Form) --> Disconnected
        }

        /// <summary>
        /// Occurs each time the event 'PublicMessageReceived' raised!
        /// Event does: Displays the message!
        /// </summary>
        /// <param name="message">The message information</param>
        private void form_OnPublicMessageReceived(ChatMessage message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<ChatMessage>(form_OnPublicMessageReceived), message);
                return;
            }

            // Update the GUI
            if (message.Sender.UserName == client.User.UserName) // If the message sent from this client
            {
                rtbMessagesDisplayer.SelectionBackColor = Color.Honeydew; // Displays he's message with BackColor
            }
            else // If the message sent from other client
            {
                if (message.Image != null) // If there's an image attached
                {
                    ImageForm imageForm = new ImageForm(message.Image, message.Sender);
                    imageForm.Show();
                }
            }

            // Message Line:
            if (message.Text != string.Empty && message.Image == null) // If there's only text in the message
            {
                #region If only text

                rtbMessagesDisplayer.SelectionColor = message.Sender.FontColor; // (Color) Part 1 of Message line - (UserName)
                rtbMessagesDisplayer.SelectedText += message.Sender.UserName; // (Text) Part 1 of Message line - (UserName)
                rtbMessagesDisplayer.SelectionColor = Color.DimGray; // (Color) Part 2 of Message line - (said:)
                rtbMessagesDisplayer.SelectedText += " said: "; // (Text) Part 2 of Message line - (said:)
                rtbMessagesDisplayer.SelectionColor = Color.Black; // (Color) Part 3 of Message line - (Message Text)
                rtbMessagesDisplayer.SelectedText += message.Text + Environment.NewLine; // (Text) Part 3 of Message line - (Message Text)

                #endregion
            }
            else if (message.Text != string.Empty && message.Image != null) // If there's text and image in the message
            {
                #region If text and image

                rtbMessagesDisplayer.SelectionColor = message.Sender.FontColor; // (Color) Part 1 of Message line - (UserName)
                rtbMessagesDisplayer.SelectedText += message.Sender.UserName; // (Text) Part 1 of Message line - (UserName)
                rtbMessagesDisplayer.SelectionColor = Color.DimGray; // (Color) Part 2 of Message line - (said:)
                rtbMessagesDisplayer.SelectedText += " sent an image and said: "; // (Text) Part 2 of Message line - (said:)
                rtbMessagesDisplayer.SelectionColor = Color.Black; // (Color) Part 3 of Message line - (Message Text)
                rtbMessagesDisplayer.SelectedText += message.Text + Environment.NewLine; // (Text) Part 3 of Message line - (Message Text)

                #endregion
            }
            else if (message.Text == string.Empty && message.Image != null) // If there's only image in the message
            {
                #region If only image

                rtbMessagesDisplayer.SelectionColor = message.Sender.FontColor; // (Color) Part 1 of Message line - (UserName)
                rtbMessagesDisplayer.SelectedText += message.Sender.UserName; // (Text) Part 1 of Message line - (UserName)
                rtbMessagesDisplayer.SelectionColor = Color.DimGray; // (Color) Part 2 of Message line - (said:)
                rtbMessagesDisplayer.SelectedText += " sent an image." + Environment.NewLine; // (Text) Part 2 of Message line - (said:)

                #endregion
            }

            // "Sent at:" Line:
            rtbMessagesDisplayer.SelectionColor = Color.DarkGray; // Makes the date in gray color
            rtbMessagesDisplayer.SelectionFont = new Font("Arial", 8F, FontStyle.Bold); // Makes the date in special font
            rtbMessagesDisplayer.SelectedText += "Sent: " + message.SentAt.ToLongTimeString() + Environment.NewLine; // Message time line

            rtbMessagesDisplayer.ScrollToCaret(); // Scrolls to the current position
        }

        /// <summary>
        /// Occurs each time the event 'PrivateMessageReceived' raised!
        /// Event does: Displays the message if he's the user to receive the message!
        /// </summary>
        /// <param name="message">The message information</param>
        private void form_OnPrivateMessageReceived(ChatMessage message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<ChatMessage>(form_OnPrivateMessageReceived), message);
                return;
            }

            // Update the GUI
            if (message.Image != null) // If there's an image attached
            {
                ImageForm imageForm = new ImageForm(message.Image, message.Sender);
                imageForm.Show();
            }

            // Message Line:
            if (message.Text != string.Empty && message.Image == null) // If there's only text in the message
            {
                #region If only text

                rtbMessagesDisplayer.SelectionColor = Color.DimGray; // (Color) Part 1 of Message line (Intro)
                rtbMessagesDisplayer.SelectionFont = new Font("Arial", 11F, FontStyle.Bold); // (Font) Part 1 of Message line (Intro)
                rtbMessagesDisplayer.SelectedText += "Private message "; // (Text) Part 1 of Message line (Intro)

                rtbMessagesDisplayer.SelectionColor = Color.Black; // (Color) Part 2 of Message line (Intro)
                rtbMessagesDisplayer.SelectionFont = new Font("Arial", 11F, FontStyle.Regular); // (Font) Part 2 of Message line (Intro)
                rtbMessagesDisplayer.SelectedText += "from "; // (Text) Part 2 of Message line (Intro)

                rtbMessagesDisplayer.SelectionColor = message.Sender.FontColor; // (Color) Part 3 of Message line - (UserName)
                rtbMessagesDisplayer.SelectedText += message.Sender.UserName; // (Text) Part 3 of Message line - (UserName)

                rtbMessagesDisplayer.SelectionColor = Color.Black; // (Color) Part 4 of Message line - (content)
                rtbMessagesDisplayer.SelectedText += ": " + message.Text + Environment.NewLine; // (Text) Part 4 of Message line - (content)

                #endregion
            }
            else if (message.Text != string.Empty && message.Image != null) // If there's text and image in the message
            {
                #region If text and image

                rtbMessagesDisplayer.SelectionColor = Color.DimGray; // (Color) Part 1 of Message line (Intro)
                rtbMessagesDisplayer.SelectionFont = new Font("Arial", 11F, FontStyle.Bold); // (Font) Part 1 of Message line (Intro)
                rtbMessagesDisplayer.SelectedText += "Private message with image "; // (Text) Part 1 of Message line (Intro)

                rtbMessagesDisplayer.SelectionColor = Color.Black; // (Color) Part 2 of Message line (Intro)
                rtbMessagesDisplayer.SelectionFont = new Font("Arial", 11F, FontStyle.Regular); // (Font) Part 2 of Message line (Intro)
                rtbMessagesDisplayer.SelectedText += "from "; // (Text) Part 2 of Message line (Intro)

                rtbMessagesDisplayer.SelectionColor = message.Sender.FontColor; // (Color) Part 3 of Message line - (UserName)
                rtbMessagesDisplayer.SelectedText += message.Sender.UserName; // (Text) Part 3 of Message line - (UserName)

                rtbMessagesDisplayer.SelectionColor = Color.Black; // (Color) Part 4 of Message line - (content)
                rtbMessagesDisplayer.SelectedText += ": " + message.Text + Environment.NewLine; // (Text) Part 4 of Message line - (content)

                #endregion
            }
            else if (message.Text == string.Empty && message.Image != null) // If there's only image in the message
            {
                #region If only image

                rtbMessagesDisplayer.SelectionColor = Color.DimGray; // (Color) Part 1 of Message line (Intro)
                rtbMessagesDisplayer.SelectionFont = new Font("Arial", 11F, FontStyle.Bold); // (Font) Part 1 of Message line (Intro)
                rtbMessagesDisplayer.SelectedText += "Private image "; // (Text) Part 1 of Message line (Intro)

                rtbMessagesDisplayer.SelectionColor = Color.Black; // (Color) Part 2 of Message line (Intro)
                rtbMessagesDisplayer.SelectionFont = new Font("Arial", 11F, FontStyle.Regular); // (Font) Part 2 of Message line (Intro)
                rtbMessagesDisplayer.SelectedText += "from "; // (Text) Part 2 of Message line (Intro)

                rtbMessagesDisplayer.SelectionColor = message.Sender.FontColor; // (Color) Part 3 of Message line - (UserName)
                rtbMessagesDisplayer.SelectedText += message.Sender.UserName; // (Text) Part 3 of Message line - (UserName)

                rtbMessagesDisplayer.SelectedText += Environment.NewLine; // (Text) Part 4 of Message line - (content)

                #endregion
            }

            // "Sent at:" Line:
            rtbMessagesDisplayer.SelectionColor = Color.DarkGray; // Makes the date in gray color
            rtbMessagesDisplayer.SelectionFont = new Font("Arial", 8F, FontStyle.Bold); // Makes the date in special font
            rtbMessagesDisplayer.SelectedText += "Sent: " + message.SentAt.ToLongTimeString() + Environment.NewLine; // Message time line

            rtbMessagesDisplayer.ScrollToCaret(); // Scrolls to the current position
        }

        /// <summary>
        /// Occurs each time the event 'UserConnected' raised!
        /// Event does: Displays the user connected to the chat!
        /// </summary>
        /// <param name="user">The user connected</param>
        private void form_OnUserConnected(User user)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<User>(form_OnUserConnected), user);
                return;
            }

            // Update the GUI
            UpdateConnectedUsers(); // Updates list of connected users

            // Updates in the rich textbox messages container
            rtbMessagesDisplayer.SelectionFont = new Font("Arial", 11F, FontStyle.Bold); // The font of connected
            rtbMessagesDisplayer.SelectionColor = user.FontColor; // Makes the user name with he's color
            rtbMessagesDisplayer.SelectedText += user.UserName; // Writes the user name in the line
            rtbMessagesDisplayer.SelectionColor = Color.Green; // Makes the color of the text
            rtbMessagesDisplayer.SelectedText += " joined the chat!" + Environment.NewLine; // Writes the joined line

            rtbMessagesDisplayer.SelectionColor = Color.DarkGray; // Makes the date in gray color
            rtbMessagesDisplayer.SelectionFont = new Font("Arial", 8F, FontStyle.Bold); // Makes the date in special font
            rtbMessagesDisplayer.SelectedText += "At: " + DateTime.Now.ToLongTimeString() + Environment.NewLine; // Joined time line

            rtbMessagesDisplayer.ScrollToCaret(); // Scrolls to the current position
        }

        /// <summary>
        /// Occurs each time the event 'UserDisconnected' raised!
        /// Event does: Displays the user disconnected from the chat! 
        /// </summary>
        /// <param name="user">The user disconnected</param>
        private void form_OnUserDisconnected(User user)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<User>(form_OnUserDisconnected), user);
                return;
            }

            // Update the GUI
            UpdateConnectedUsers(); // Updates list of connected users

            // Updates in the rich textbox messages container
            rtbMessagesDisplayer.SelectionFont = new Font("Arial", 11F, FontStyle.Bold); // The font of discconected message
            rtbMessagesDisplayer.SelectionColor = user.FontColor; // Makes the user name with he's color
            rtbMessagesDisplayer.SelectedText += user.UserName; // Writes the user name in the line
            rtbMessagesDisplayer.SelectionColor = Color.Firebrick; // Makes the color of the text
            rtbMessagesDisplayer.SelectedText += " left the chat!" + Environment.NewLine; // Writes the left line

            rtbMessagesDisplayer.SelectionColor = Color.DarkGray; // Makes the date in gray color
            rtbMessagesDisplayer.SelectionFont = new Font("Arial", 8F, FontStyle.Bold); // Makes the date in special font
            rtbMessagesDisplayer.SelectedText += "At: " + DateTime.Now.ToLongTimeString() + Environment.NewLine; // Joined time line

            rtbMessagesDisplayer.ScrollToCaret(); // Scrolls to the current position
        }

        /// <summary>
        /// Occurs each time the event 'BlockReceived' raised!
        /// Event does: Blocking the user, or displayes the user that has blocked from the server!
        /// </summary>
        /// <param name="message">The message information</param>
        private void form_OnBlockReceived(ChatMessage message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<ChatMessage>(form_OnBlockReceived), message);
                return;
            }

            // Update the GUI

            if (message.SendTo == client.User.UserName) // If this user is the blocked user --> Blocks the user!
            {
                MessageBox.Show("You have been blocked from the server by the admin.",
                                "You have been blocked",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Stop
                                );

                if (client != null) // If client is not null, needs to clear resources!
                {
                    // Removes registered events in the GUI
                    client.ServerConnectionLost -= form_ServerConnectionLost;
                    client.PublicMessageReceived -= form_OnPublicMessageReceived;
                    client.PrivateMessageReceived -= form_OnPrivateMessageReceived;
                    client.UserConnected -= form_OnUserConnected;
                    client.UserDisconnected -= form_OnUserDisconnected;
                    client.BlockReceived -= form_OnBlockReceived;
                    client.ErrorOccurred -= form_OnErrorOccurred;

                    client.Close(); // Closes the client                        
                    client = null;
                }

                virtualForms.SelectTab(0); // Select: (Virtual Form) --> Disconnected
            }
            else // If this user is not the blocked user --> Displays a message about the blocked user!
            {
                UpdateConnectedUsers(); // Updates list of connected users

                // Updates in the rich textbox messages container
                rtbMessagesDisplayer.SelectionFont = new Font("Arial", 11F, FontStyle.Bold); // The font of blocked message
                rtbMessagesDisplayer.SelectionColor = message.Sender.FontColor; // Makes the blocked user with he's color
                rtbMessagesDisplayer.SelectedText += message.SendTo; // Writes the user name in the line
                rtbMessagesDisplayer.SelectionColor = Color.Red; // Makes the color of the text
                rtbMessagesDisplayer.SelectedText += " has been blocked from the server by the admin!" + Environment.NewLine; // Writes the left line

                rtbMessagesDisplayer.SelectionColor = Color.DarkGray; // Makes the date in gray color
                rtbMessagesDisplayer.SelectionFont = new Font("Arial", 8F, FontStyle.Bold); // Makes the date in special font
                rtbMessagesDisplayer.SelectedText += "At: " + DateTime.Now.ToLongTimeString() + Environment.NewLine; // Joined time line

                rtbMessagesDisplayer.ScrollToCaret(); // Scrolls to the current position
            }
        }

        /// <summary>
        /// Occurs each time the event 'ErrorOccurred' raised!
        /// Event does: Displays the error message, and closes the application if needed!
        /// </summary>
        /// <param name="text">The error message to display</param>
        /// <param name="close">Indicator if to close the application</param>
        private void form_OnErrorOccurred(string text, bool close)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string, bool>(form_OnErrorOccurred), text, close);
                return;
            }

            // Update the GUI
            // Displays the error message:
            MessageBox.Show(
                text,
                "Error occurred",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );

            // If the error must close the application:
            if (close)
                this.Close();
        }

        #endregion

        #endregion

        #region Application Window

        /// <summary>
        /// When closing the form
        /// </summary>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (virtualForms.SelectedIndex == 1) // Asks the user to validate closing, only if he's connected!
            {
                DialogResult exit = MessageBox.Show(
                    "Are you sure to exit?",
                    "Are you sure?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                if (exit == DialogResult.No) // Client stays connected!
                {
                    e.Cancel = true;
                }
                else if (exit == DialogResult.Yes) // Client close --> Clear all resources!
                {
                    if (client != null) // If client is not null, needs to clear resources!
                    {
                        // Removes registered events in the GUI
                        client.ServerConnectionLost -= form_ServerConnectionLost;
                        client.PublicMessageReceived -= form_OnPublicMessageReceived;
                        client.PrivateMessageReceived -= form_OnPrivateMessageReceived;
                        client.UserConnected -= form_OnUserConnected;
                        client.UserDisconnected -= form_OnUserDisconnected;
                        client.BlockReceived -= form_OnBlockReceived;
                        client.ErrorOccurred -= form_OnErrorOccurred;

                        client.Close(); // Closes the client                        
                        client = null;
                    }
                }
            }
        }

        /// <summary>
        /// Menu strip: (Exit)
        /// </summary>
        private void menuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Menu strip: (About)
        /// </summary>
        private void menuItemAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        /// <summary>
        /// Menu strip: (How To Use)
        /// </summary>
        private void menuItemHowToUse_Click(object sender, EventArgs e)
        {
            HowToUse howToUse = new HowToUse();
            howToUse.Show();
        }

        /// <summary>
        /// Menu strip: (Full Window)
        /// </summary>
        private void menuFullWindow_Click(object sender, EventArgs e)
        {
            if (this.FormBorderStyle == FormBorderStyle.Sizable) // Means we are not in full screen
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            }
            else if (this.FormBorderStyle == FormBorderStyle.None) // Means we are in full screen
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
                this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            }
        }

        /// <summary>
        /// Menu strip: (Log in/out)
        /// </summary>
        private void menuLogInOut_Click(object sender, EventArgs e)
        {
            if (virtualForms.SelectedIndex == 0) // If client is disconnected
            {
                btnStart_Click(sender, e); // Sends to (Button: Start to Chat) event to handle it
            }
            else if (virtualForms.SelectedIndex == 1) // If client is connected
            {
                if (client != null) // If client is not null, needs to clear resources!
                {
                    // Removes registered events in the GUI
                    client.ServerConnectionLost -= form_ServerConnectionLost;
                    client.PublicMessageReceived -= form_OnPublicMessageReceived;
                    client.PrivateMessageReceived -= form_OnPrivateMessageReceived;
                    client.UserConnected -= form_OnUserConnected;
                    client.UserDisconnected -= form_OnUserDisconnected;
                    client.BlockReceived -= form_OnBlockReceived;
                    client.ErrorOccurred -= form_OnErrorOccurred;

                    client.Close(); // Closes the client
                    client = null;
                }

                virtualForms.SelectTab(0); // Select: (Virtual Form) --> Disconnected
            }
        }

        #endregion

        #region (Virtual Form) ---> Disconnected

        /// <summary>
        /// On Load event for (virtual form) Disconnected, setting things for disconnected mode!
        /// </summary>
        private void virtualDisconnected_Enter(object sender, EventArgs e)
        {
            menuLogInOut.Text = "Log in..."; // Change text from "Log out" to "Log in"
            menuChatDetails.Enabled = false; // Disable menu item "Chat Details" when there's no connection!
        }

        /// <summary>
        /// Button: Start to Chat
        /// </summary>
        private void btnStart_Click(object sender, EventArgs e)
        {
            ConnectDialog clientConnect = new ConnectDialog();
            clientConnect.ShowDialog();

            // If succeeded in connecting! select (virtual form) connected!
            if (clientConnect.DialogResult == DialogResult.OK && clientConnect.Client != null)
            {
                client = clientConnect.Client; // Assigning of the client logic from the dialog, to this MainForm client object!
                ClientEventsRegistration();

                virtualForms.SelectTab(1); // Select: (Virtual Form) --> Connected

                UpdateConnectedUsers();
            }
        }

        #endregion

        #region (Virtual Form) ---> Connected

        /// <summary>
        /// On Load event for (virtual form) Connected, setting things for connected mode!
        /// </summary>
        private void virtualConnected_Enter(object sender, EventArgs e)
        {
            menuLogInOut.Text = "Log out..."; // Change text from "Log in" to "Log out"
            menuChatDetails.Enabled = true; // Enable menu item "Chat Details" after connection!
            btnLoggedAs.Text = " Logged as: " + client.User.UserName; // Displays the name of the logged user
            radioBtnPublic.Checked = true; // Default send message
            rtbMessagesDisplayer.Clear(); // Clears messages displayed in the last session
        }

        /// <summary>
        /// Radio Button: Private
        /// </summary>
        private void radioBtnPrivate_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnPrivate.Checked)
            {
                lblPrivateTo.ForeColor = Color.Black;
                comboBoxPrivateTo.Enabled = true;
            }
            else
            {
                lblPrivateTo.ForeColor = Color.DarkGray;
                comboBoxPrivateTo.Enabled = false;
            }
        }

        /// <summary>
        /// Button: Send (message)
        /// </summary>
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtMessageContent.Text != string.Empty && picBoxPictureAdded.Image == null) // Sends the message, if there's only text
            {
                #region Sends for only text

                if (radioBtnPublic.Checked) // If (Public) message
                {
                    client.SendMessage(txtMessageContent.Text); // Sends the public message
                    txtMessageContent.Text = string.Empty; // Clears the field after message is sent
                }
                else if (radioBtnPrivate.Checked && comboBoxPrivateTo.Text != string.Empty) // If (Private) message, and selected a user to send the private message
                {
                    client.SendMessage(txtMessageContent.Text, MessageType.Private, comboBoxPrivateTo.Text); // Sends the private message

                    // Displays message line for the client who sent the private message:
                    foreach (User user in client.ConnectedUsers)
                    {
                        // Finds the information of the user that will receive the message, to display that the private message sent to him!
                        if (user.UserName == comboBoxPrivateTo.Text)
                        {
                            rtbMessagesDisplayer.SelectionBackColor = Color.Honeydew; // Displays the message with a BackColor in the messages window in the user who sent the private message!

                            rtbMessagesDisplayer.SelectionColor = Color.DimGray; // (Color) Part 1 of Message line (Intro)
                            rtbMessagesDisplayer.SelectionFont = new Font("Arial", 11F, FontStyle.Bold); // (Font) Part 1 of Message line (Intro)
                            rtbMessagesDisplayer.SelectedText += "Private message "; // (Text) Part 1 of Message line (Intro)

                            rtbMessagesDisplayer.SelectionColor = Color.Black; // (Color) Part 2 of Message line (Intro)
                            rtbMessagesDisplayer.SelectionFont = new Font("Arial", 11F, FontStyle.Regular); // (Font) Part 2 of Message line (Intro)
                            rtbMessagesDisplayer.SelectedText += "to "; // (Text) Part 2 of Message line (Intro)

                            rtbMessagesDisplayer.SelectionColor = user.FontColor; // (Color) Part 3 of Message line - (UserName)
                            rtbMessagesDisplayer.SelectedText += user.UserName; // (Text) Part 3 of Message line - (UserName)

                            rtbMessagesDisplayer.SelectionColor = Color.Black; // (Color) Part 4 of Message line - (content)
                            rtbMessagesDisplayer.SelectedText += ": " + txtMessageContent.Text + Environment.NewLine; // (Text) Part 4 of Message line - (content)

                            rtbMessagesDisplayer.SelectionColor = Color.DarkGray; // Makes the date in gray color
                            rtbMessagesDisplayer.SelectionFont = new Font("Arial", 8F, FontStyle.Bold); // Makes the date in special font
                            rtbMessagesDisplayer.SelectedText += "Sent: " + DateTime.Now.ToLongTimeString() + Environment.NewLine; // Message time line

                            rtbMessagesDisplayer.ScrollToCaret(); // Scrolls to the current position
                        }
                    }

                    txtMessageContent.Text = string.Empty; // Clears the field after message is sent
                }

                #endregion
            }
            else if (txtMessageContent.Text != string.Empty && picBoxPictureAdded.Image != null) // Sends the message, if there's text and image!
            {
                #region Sends for text and image

                if (radioBtnPublic.Checked) // If (Public) message
                {
                    client.SendMessage(txtMessageContent.Text, picBoxPictureAdded.Image); // Sends the public message with image
                    txtMessageContent.Text = string.Empty; // Clears the field after message is sent
                    btnRemoveImage.PerformClick(); // Clears the picture box image
                }
                else if (radioBtnPrivate.Checked && comboBoxPrivateTo.Text != string.Empty) // If (Private) message, and selected a user to send the private message
                {
                    client.SendMessageAsync(txtMessageContent.Text, MessageType.Private, comboBoxPrivateTo.Text, picBoxPictureAdded.Image); // Sends the private message

                    // Displays message line for the client who sent the private message:
                    foreach (User user in client.ConnectedUsers)
                    {
                        // Finds the information of the user that will receive the message, to display that the private message sent to him!
                        if (user.UserName == comboBoxPrivateTo.Text)
                        {
                            rtbMessagesDisplayer.SelectionBackColor = Color.Honeydew; // Displays the message with a BackColor in the messages window in the user who sent the private message!

                            rtbMessagesDisplayer.SelectionColor = Color.DimGray; // (Color) Part 1 of Message line (Intro)
                            rtbMessagesDisplayer.SelectionFont = new Font("Arial", 11F, FontStyle.Bold); // (Font) Part 1 of Message line (Intro)
                            rtbMessagesDisplayer.SelectedText += "Private message with image "; // (Text) Part 1 of Message line (Intro)

                            rtbMessagesDisplayer.SelectionColor = Color.Black; // (Color) Part 2 of Message line (Intro)
                            rtbMessagesDisplayer.SelectionFont = new Font("Arial", 11F, FontStyle.Regular); // (Font) Part 2 of Message line (Intro)
                            rtbMessagesDisplayer.SelectedText += "to "; // (Text) Part 2 of Message line (Intro)

                            rtbMessagesDisplayer.SelectionColor = user.FontColor; // (Color) Part 3 of Message line - (UserName)
                            rtbMessagesDisplayer.SelectedText += user.UserName; // (Text) Part 3 of Message line - (UserName)

                            rtbMessagesDisplayer.SelectionColor = Color.Black; // (Color) Part 4 of Message line - (content)
                            rtbMessagesDisplayer.SelectedText += ": " + txtMessageContent.Text + Environment.NewLine; // (Text) Part 4 of Message line - (content)

                            rtbMessagesDisplayer.SelectionColor = Color.DarkGray; // Makes the date in gray color
                            rtbMessagesDisplayer.SelectionFont = new Font("Arial", 8F, FontStyle.Bold); // Makes the date in special font
                            rtbMessagesDisplayer.SelectedText += "Sent: " + DateTime.Now.ToLongTimeString() + Environment.NewLine; // Message time line

                            rtbMessagesDisplayer.ScrollToCaret(); // Scrolls to the current position
                        }
                    }

                    txtMessageContent.Text = string.Empty; // Clears the field after message is sent
                    btnRemoveImage.PerformClick(); // Clears the picture box image
                }

                #endregion
            }
            else if (txtMessageContent.Text == string.Empty && picBoxPictureAdded.Image != null) // Sends the message, if there's only image
            {
                #region Sends for only image

                if (radioBtnPublic.Checked) // If (Public) message
                {
                    client.SendMessage(picBoxPictureAdded.Image); // Sends the public image
                    btnRemoveImage.PerformClick(); // Clears the picture box image
                }
                else if (radioBtnPrivate.Checked && comboBoxPrivateTo.Text != string.Empty) // If (Private) message, and selected a user to send the private message
                {
                    client.SendMessageAsync("", MessageType.Private, comboBoxPrivateTo.Text, picBoxPictureAdded.Image); // Sends the private image

                    // Displays message line for the client who sent the private message:
                    foreach (User user in client.ConnectedUsers)
                    {
                        // Finds the information of the user that will receive the message, to display that the private message sent to him!
                        if (user.UserName == comboBoxPrivateTo.Text)
                        {
                            rtbMessagesDisplayer.SelectionBackColor = Color.Honeydew; // Displays the message with a BackColor in the messages window in the user who sent the private message!

                            rtbMessagesDisplayer.SelectionColor = Color.DimGray; // (Color) Part 1 of Message line (Intro)
                            rtbMessagesDisplayer.SelectionFont = new Font("Arial", 11F, FontStyle.Bold); // (Font) Part 1 of Message line (Intro)
                            rtbMessagesDisplayer.SelectedText += "Private image "; // (Text) Part 1 of Message line (Intro)

                            rtbMessagesDisplayer.SelectionColor = Color.Black; // (Color) Part 2 of Message line (Intro)
                            rtbMessagesDisplayer.SelectionFont = new Font("Arial", 11F, FontStyle.Regular); // (Font) Part 2 of Message line (Intro)
                            rtbMessagesDisplayer.SelectedText += "to "; // (Text) Part 2 of Message line (Intro)

                            rtbMessagesDisplayer.SelectionColor = user.FontColor; // (Color) Part 3 of Message line - (UserName)
                            rtbMessagesDisplayer.SelectedText += user.UserName + Environment.NewLine; // (Text) Part 3 of Message line - (UserName)

                            rtbMessagesDisplayer.SelectionColor = Color.DarkGray; // Makes the date in gray color
                            rtbMessagesDisplayer.SelectionFont = new Font("Arial", 8F, FontStyle.Bold); // Makes the date in special font
                            rtbMessagesDisplayer.SelectedText += "Sent: " + DateTime.Now.ToLongTimeString() + Environment.NewLine; // Message time line

                            rtbMessagesDisplayer.ScrollToCaret(); // Scrolls to the current position
                        }
                    }

                    btnRemoveImage.PerformClick(); // Clears the picture box image
                }

                #endregion
            }
        }

        /// <summary>
        /// Key (Enter): Send (message)
        /// </summary>
        private void txtMessageContent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnSend.PerformClick();
                e.Handled = true;
            }
        }

        /// <summary>
        /// Displays all the connected users in the server to the ListView!
        /// </summary>
        private void UpdateConnectedUsers()
        {
            listViewConnectedUsers.Clear(); // Clears the connect users
            comboBoxPrivateTo.Items.Clear(); // Clears the private send list

            if (client.ConnectedUsers != null)
            {
                foreach (User user in client.ConnectedUsers)
                {
                    ListViewItem item = new ListViewItem(user.UserName);
                    item.ForeColor = user.FontColor; // Makes the user looks with he's font color

                    listViewConnectedUsers.Items.Add(item);

                    // Now, updates the private message send list!
                    if (client.User.UserName != user.UserName) // Excludes this client, from private send list
                        comboBoxPrivateTo.Items.Add(user.UserName); // Adds a user to the private message list
                }
            }
        }

        /// <summary>
        /// Button: Exit Chat
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show(
                "Are you sure to exit?",
                "Are you sure?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (exit == DialogResult.Yes)
            {
                if (client != null) // If client is not null, needs to clear resources!
                {
                    // Removes registered events in the GUI
                    client.ServerConnectionLost -= form_ServerConnectionLost;
                    client.PublicMessageReceived -= form_OnPublicMessageReceived;
                    client.PrivateMessageReceived -= form_OnPrivateMessageReceived;
                    client.UserConnected -= form_OnUserConnected;
                    client.UserDisconnected -= form_OnUserDisconnected;
                    client.BlockReceived -= form_OnBlockReceived;
                    client.ErrorOccurred -= form_OnErrorOccurred;

                    client.Close(); // Closes the client                        
                    client = null;
                }

                virtualForms.SelectTab(0); // Select: (Virtual Form) --> Disconnected
            }
        }

        /// <summary>
        /// Button: Add Image...
        /// </summary>
        private void btnAddImage_Click(object sender, EventArgs e)
        {
            fileDialog.ShowDialog(); // Opens file dialog
        }

        /// <summary>
        /// Occures when the image file accepted!
        /// </summary>
        private void fileDialog_FileOk(object sender, CancelEventArgs e)
        {
            // After the user added an image, shows it in the picture box!
            picBoxPictureAdded.Image = Image.FromFile(fileDialog.FileName); // Assigns the image
            btnRemoveImage.Visible = true; // Button appears that can remove the image
            lblPictureAdded.Visible = true; // Label indicates that image attached to message
            splitContainer2.Panel1.BackColor = Color.SpringGreen; // Panel background color
        }

        /// <summary>
        /// Button: Remove Image
        /// </summary>
        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            picBoxPictureAdded.Image = null; // Removes the image
            btnRemoveImage.Visible = false; // Button appears that can remove the image
            lblPictureAdded.Visible = false; // Label indicates that image attached to message
            splitContainer2.Panel1.BackColor = Color.Gainsboro; // Panel background color
        }

        #endregion

    }
}

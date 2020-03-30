using System;
//  Added for Sound Player
using System.Media;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic8Ball
{
    public partial class FormMagic8Ball : Form
    {
        public FormMagic8Ball()
        {
            InitializeComponent();
        }

        //*************************************************
        //
        //  This method is called when the user
        //  clicks the Submit Question button to
        //  submit the question to the Magic 8 Ball.
        //
        //*************************************************
        private void buttonSubmitQuestion_Click(object sender, EventArgs e)
        {
            SubmitQuestion();
        }

        //*************************************************
        //
        //  This method will submit the question to
        //  the Magic 8 Ball, but it first checks to
        //  see whether or not there was a question
        //  actually inputted.
        //
        //  If no question is inputted, a Message is
        //  given to the user and the method returns
        //  with no further action required.
        //
        //  If anything was entere into the associated
        //  textbox, we generate the answer, after
        //  first, resetting the associated textbox
        //  and button attributes.
        //
        //  This method is called by either the
        //  Submit Question menu item or the Submit 
        //  Question button.
        //
        //*************************************************
        private void SubmitQuestion()
        {
            //  Flag for no input
            bool noInput = false;   //  Assume there is input

            //  Call routine to actually verify
            //  that the user inputted something
            //  into the textbox.
            noInput = CheckForNoInput();

            //  If textbox was empty, no further
            //  action required.  Just return
            //  from the method.
            if (noInput)
            {
                return;
            }

            //  There was something inputted into
            //  the textbox.  So, make the textbox
            //  invisible, disable the Submit Question
            //  button, and enable the Reset Form
            //  button.

            //  Make textbox invisible
            textBoxAskQusestion.Visible = false;

            //  Disable submit question button
            buttonSubmitQuestion.Enabled = false;

            //  Enable reset question button
            buttonResetForm.Enabled = true;

            //  Generate the associated answer
            GenerateAnswer();
        }

        //*************************************************
        //
        //  This method will make the actual check
        //  to verify that something was inputted
        //  in the associated textbox.
        //
        //*************************************************
        private bool CheckForNoInput()
        {
            //  Check for empty textbox input.
            //
            //  If no input, provide a message
            //  for the user and return true
            //  for the noInput flag.
            //
            //  If there was input, just
            //  return true for the noInput
            //  flag.
            if (textBoxAskQusestion.Text == "")
            {
                MessageBox.Show("You Must Enter A Question!",
                                "NO QUESTION ENTERED!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                textBoxAskQusestion.Focus();
                return true;
            }

            return false;
        }

        //*************************************************
        //
        //  This method will generate the answer
        //  for the Magic 8 Ball.  It will also
        //  change the associated 8 Ball image
        //  and provide the "ta da" sound when
        //  the image is changed.
        //
        //*************************************************
        private void GenerateAnswer()
        {
            //  String which holds image # plus .png
            string imageFileName = "";

            //  Seed the rand
            Random rand = new Random();

            //  Generate random number between 1 and 15
            int num = rand.Next(1, 16);

            //  Set imageFileName to num + .png
            imageFileName = num.ToString() + ".png";

            //  Change the image on the screen
            pictureBoxMagic8Ball.Image = System.Drawing.Image.FromFile(
                @"C:\Users\Ranken\Desktop\Magic8Ball\Images\" + imageFileName);

            //  Set the sizing of the image accordingly
            pictureBoxMagic8Ball.SizeMode = PictureBoxSizeMode.AutoSize;

            //  Play the "ta da" sound along with this
            var soundPlayer = new SoundPlayer(@"C:\Users\Ranken\Desktop\Magic8Ball\Sounds\tada.wav");
            soundPlayer.Play();
        }

        //*************************************************
        //
        //  This method is called when the user
        //  clicks the Reset Form button to
        //  Reset the form.
        //
        //*************************************************
        private void buttonResetForm_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        //*************************************************
        //
        //  This method will reset the form to its
        //  original values.  It is called by either
        //  the Reset Form menu item or the Reset 
        //  Form button.
        //
        //*************************************************
        private void ResetForm()
        { 
            //  Make textbox visible
            textBoxAskQusestion.Visible = true;

            //  Enable submit question button
            buttonSubmitQuestion.Enabled = true;

            //  Disable reset question button
            buttonResetForm.Enabled = false;

            //  Blank out textbox
            textBoxAskQusestion.Text = "";

            //  Reset image back to original Magic 8 Ball image
            pictureBoxMagic8Ball.Image = System.Drawing.Image.FromFile(
                @"C:\Users\Ranken\Desktop\Magic8Ball\Images\0.png");

            //  Set the focus to the textbox
            textBoxAskQusestion.Focus();
        }

        //*************************************************
        //
        //  This method is called when the user
        //  clicks the Exit Application button to
        //  possibly end the program run.
        //
        //*************************************************
        private void buttonExitApplication_Click(object sender, EventArgs e)
        {
            ExitApplication();
        }

        //*************************************************
        //
        //  This method will allow the person running
        //  the program to end the program run if s/he
        //  so desires.  It is called by either the
        //  Exit Application menu item or the Exit
        //  Application button.
        //
        //*************************************************
        private void ExitApplication()
        {
            //  Prompt user to see if s/he wants to end program now
            if (MessageBox.Show("Do You Really Want To Exit The Program?",
                            "EXIT PROGRAM NOW?!?!",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //  Normal program termination
                Application.Exit();
            }
        }

        //*************************************************
        //
        //  This method is called when the user
        //  clicks the Submit Question menu item to
        //  submit the question to the Magic 8 Ball.
        //
        //*************************************************
        private void submitQuestionMenuItem_Click(object sender, EventArgs e)
        {
            SubmitQuestion();
        }

        //*************************************************
        //
        //  This method is called when the user
        //  clicks the Reset Form menu item to
        //  Reset the form.
        //
        //*************************************************
        private void resetFormMenuItem_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        //*************************************************
        //
        //  This method is called when the user
        //  clicks the Exit Application menu item
        //  to possibly end the program run.
        //
        //*************************************************
        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            ExitApplication();
        }

        private void helpMenuItem_Click(object sender, EventArgs e)
        {
            ShowHelpMessage();
        }

        private void ShowHelpMessage()
        {
            string message  = "This is a Magic 8 Ball application.\n\n";
                   message += "Key in a question in the purple textbox below.\n";
                   message += "Then click the Submit Question button or Menu Option.\n";
                   message += "Your answer will appear in the Magic 8 Ball.\n\n";
                   message += "Click the Reset Form button or Menu Option to reset.\n\n";
                   message += "Click the Exit button or Menu Option to quit.\n\n";
                   message += "Like the 'real' Magic 8 Ball, this is for fun only!";

            MessageBox.Show(message,
                            "MAGIC 8 BALL INSTRUCTIONS",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
    }
}

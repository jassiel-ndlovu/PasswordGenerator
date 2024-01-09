using System.Security.Authentication.ExtendedProtection;

namespace PasswordGenerator
{
    public partial class frmPasswordGenerator : Form
    {
        //Declare the string that will keep all the chars we want to
        // deselect from the password
        private string unwantedChars = string.Empty;

        public frmPasswordGenerator()
        {
            InitializeComponent();
        }

        // When this button is clicked the character in the combobox must appear in the
        // list view and also be added into the string unwantedChars if it is not already
        // there
        private void btnDeselectChars_Click(object sender, EventArgs e)
        {
            if (cmbDeselectChars.SelectedIndex != -1)
            {
                // Checks if the selected character is already in string
                if (unwantedChars.IndexOf(cmbDeselectChars.Text) == -1)
                {
                    lstDeselected.Items.Add(cmbDeselectChars.Text);
                    unwantedChars += cmbDeselectChars.Text;
                }
                else
                    MessageBox.Show("Character already deselected", "Deselect Character", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Select a character", "Unselected Character", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // This function allows the user to reselect deselected characters
        // in the list view.
        private void btnReselect_Click(object sender, EventArgs e)
        {
            if (lstDeselected.SelectedItems.Count == 0)
                MessageBox.Show("Select a character to deselect in the list", "Deselect Character", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                foreach (ListViewItem item in lstDeselected.SelectedItems)
                {
                    unwantedChars = substr(unwantedChars, item.Text);
                    lstDeselected.Items.Remove(item);
                }
            }
        }

        // Another replace function for strings
        private string substr(string word, string let)
        {
            for (int i = 0; i < word.Length; i++)
                if (word[i] == let[0])
                {
                    if (i == word.Length - 1)
                        return word.Substring(0, i);
                    else
                        return word.Substring(0, i) + word.Substring(i + 1);
                }
            return word;
        }

        //Password generator
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int passwordLength = (int)nudLength.Value;

            int deselectedLength = lstDeselected.Items.Count;

            char[] deselectedChars = new char[deselectedLength];

            //Populate the deselectedChars array with the items in listView
            for (int i = 0; i < deselectedLength; i++)
                deselectedChars[i] = lstDeselected.Items[i].Text[0];

            if (chkRandom.Checked)
            {
                if (chkNumerics.Checked)
                    lblOutput.Text = (new RandomPassword(passwordLength, false, false, true, false, deselectedChars)).getPassword();
                else
                    lblOutput.Text = (new RandomPassword(passwordLength, deselectedChars)).getPassword();
            }
            else
            {

            }

            //Update the progress bar
            int charSet = cmbDeselectChars.Items.Count;
            int nudMax = (int)nudLength.Maximum;

            pgbStrength.Refresh();
            pgbStrength.Minimum = 0;

            if (!chkNumerics.Checked)
            {
                pgbStrength.Maximum = (int)(nudMax * (Math.Log2(charSet - deselectedLength)));
                pgbStrength.Value = (int)(passwordLength * (Math.Log2(charSet - deselectedLength)));
            }
            else
            {
                const int numericsLength = 10;
                pgbStrength.Maximum = (int)(nudMax * (Math.Log2(numericsLength - deselectedLength)));
                pgbStrength.Value = (int)(passwordLength * (Math.Log2(numericsLength - deselectedLength)));
            }
        }

        private void btnReselectAll_Click(object sender, EventArgs e)
        {
            unwantedChars = "";

            foreach (ListViewItem item in lstDeselected.Items)
                lstDeselected.Items.Remove(item);
        }

        private void chkNumerics_CheckStateChanged(object sender, EventArgs e)
        {
            if (!chkNumerics.Checked)
                return;

            foreach (ListViewItem item in lstDeselected.Items)
                if ((int)item.Text[0] < 48 || (int)item.Text[0] > 57)
                    lstDeselected.Items.Remove(item);
        }
    }
}

namespace session07_Winform.DAL
{
    internal class RegisterDAO
    {
        public bool checkInput(TextBox txtName, TextBox txtMail, MaskedTextBox txtDate)
        {
            try
            {
                if (string.IsNullOrEmpty(txtName.Text))
                {
                    MessageBox.Show("Full Name is required!", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtName.Focus();
                    return false;
                }
                else if (string.IsNullOrEmpty(txtMail.Text))
                {
                    MessageBox.Show("Email is required!", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMail.Focus();
                    return false;
                }
                else if (!txtDate.MaskFull)
                {
                    MessageBox.Show("Date is required!", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDate.Focus();
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return true;
        }
    }
}
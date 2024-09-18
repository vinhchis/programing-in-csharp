/*
 * Data Access Layer (DAL)
 * Data Access Object (DAO)
 */

using session07_Winform;

namespace session07_Winform.DAL
{
    internal class LoginDAO
    {
        public bool checkLogin(TextBox txtUser, TextBox txtPass)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUser.Text))
                {
                    MessageBox.Show("Login name is required!", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUser.Focus();
                    return false;
                }
                else if (string.IsNullOrEmpty(txtPass.Text))
                {
                    MessageBox.Show("Password is required!", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPass.Focus();
                    return false;
                }
                else if (txtUser.Text.Equals("aptech") && txtPass.Text.Equals("123"))
                {
                    new Register().Show();
                    return true;
                }
                else
                {
                    MessageBox.Show("Username and Password is incorrect!", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return false;
        }
    }
}
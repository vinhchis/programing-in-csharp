using System.Text;

namespace session07_Winform
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pbPicture.Image = Image.FromFile(dialog.FileName);
            }

            dialog.Dispose();
        }

        /// <summary>
        /// Tự động gen ra khi ấn vào form, chạy mang hàng với constructor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Register_Load(object sender, EventArgs e)
        {
            AcceptButton = btnRegister;
            txtName.Select();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            GetInfo();
        }

        private void GetInfo()
        {
            // 1. Đọc Data
            var sName = txtName.Text;
            var sMail = txtName.Text;
            var sDate = mtbDate.Text;
            var sGender = (rdMale.Checked) ? "Male" : "Female";


            // 2. Build thông báo
            var sb = new StringBuilder();
            sb.Append("Personal Information:\n");
            sb.Append("-----------------------\n");
            sb.Append($"Full Name: {sName}\n");
            sb.Append($"Mail: {sMail}\n");
            sb.Append($"Date of Birth: {sDate}\n");
            sb.Append($"Gender: {sGender}\n");
            sb.Append("Language: ");
            foreach (var item in clbxLanguage.CheckedItems)
            {
                sb.Append($"{item} ");
            }
            sb.Append("\n-----------------------\n");


            // 3. Bật thông báo
            DAL.RegisterDAO register = new DAL.RegisterDAO();
            if(register.checkInput(txtName, txtMail, mtbDate))
            {
                if (rdPublic.Checked)
                {
                    MessageBox.Show(sb.ToString());
                }
                else
                {
                    MessageBox.Show("Hidden sensitive Information");
                }
            }

           

            

        }

       
    }
}

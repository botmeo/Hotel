using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BUS
{
    public class CheckInput_BUS
    {
        public void CheckNumber(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Không được nhập các chữ cái và ký tự. Chỉ được nhập chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void CheckLetter(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Không được nhập các chữ số. Chỉ được nhập chữ cái.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void CheckSearchInput(KeyPressEventArgs e)
        {
            string pattern = @"[\|!#$%&/()=?»«@£§€{}.;'*~<>_,]";
            var regex = new Regex(pattern);
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        public void UsernameValidating(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void VietnameseValidating(KeyPressEventArgs e)
        {
            string pattern = @"[àáãạảăắằẳẵặâấầẩẫậèéẹẻẽêềếểễệđìíĩỉịòóõọỏôốồổỗộơớờởỡợùúũụủưứừửữựỳỵỷỹýÀÁÃẠẢĂẮẰẲẴẶÂẤẦẨẪẬÈÉẸẺẼÊỀẾỂỄỆĐÌÍĨỈỊÒÓÕỌỎÔỐỒỔỖỘƠỚỜỞỠỢÙÚŨỤỦƯỨỪỬỮỰỲỴỶỸÝ]";
            var regex = new Regex(pattern);
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }
    }
}

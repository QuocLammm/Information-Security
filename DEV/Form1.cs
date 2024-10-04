using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace DEV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public SymmetricAlgorithm GetAlgorithm(string algorithmName)
        {
            switch (algorithmName.ToUpper())
            {
                case "DES":
                    return new DESCryptoServiceProvider();
                case "TRIPLEDES":
                    return new TripleDESCryptoServiceProvider();
                case "AES":
                    return new AesCryptoServiceProvider();
                case "RIJNDAEL":
                    return new RijndaelManaged();
                default:
                    return new DESCryptoServiceProvider();
            }
        }

        private string BytestoHexaString(byte[] byteArray)
        {
            StringBuilder hex = new StringBuilder(byteArray.Length * 2);
            foreach (byte b in byteArray)
            {
                hex.AppendFormat("{0:X2}", b);
            }
            return hex.ToString();
        }

        private void txtkey_TextChanged(object sender, EventArgs e)
        {
            string input = txtkey.Text;
            if (!IsHex(input))
            {
                MessageBox.Show("Please enter a valid hexadecimal value (0-9, A-F).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtkey.Text = input.Remove(input.Length - 1);
                txtkey.SelectionStart = txtkey.Text.Length;
            }
        }

        private bool IsHex(string input)
        {
            foreach (char c in input)
            {
                if (!((c >= '0' && c <= '9') || (c >= 'A' && c <= 'F') || (c >= 'a' && c <= 'f')))
                    return false;
            }
            return true;
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string hexKey = reader.ReadLine();
                        if (!string.IsNullOrEmpty(hexKey) && IsHex(hexKey))
                        {
                            txtkey.Text = hexKey;
                            txtIV.Text = hexKey; // Cần điều chỉnh nếu IV khác nhau
                            MessageBox.Show("Key loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Invalid key format in the file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while loading the key: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Lấy tên thuật toán được chọn từ ComboBox
            string selectedAlgorithm = comboBox1.SelectedItem?.ToString(); // Lấy thuật toán đã chọn

            if (string.IsNullOrEmpty(selectedAlgorithm))
            {
                MessageBox.Show("Hãy chọn thuật toán!.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Nếu không có thuật toán nào được chọn, dừng lại
            }

            // Tạo cipher cho thuật toán đã chọn
            var cipher = GetAlgorithm(selectedAlgorithm);

            // Sinh khóa và IV cho cipher
            cipher.GenerateKey();
            cipher.GenerateIV();

            // Cập nhật TextBox với khóa và IV dưới dạng hex
            txtkey.Text = BytestoHexaString(cipher.Key);
            txtIV.Text = BytestoHexaString(cipher.IV);

            MessageBox.Show("Key and IV generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy tên thuật toán được chọn từ ComboBox
            string selectedAlgorithm = comboBox1.SelectedItem.ToString();
            btnMaHoa.Enabled = !string.IsNullOrEmpty(selectedAlgorithm); // Kích hoạt nút mã hóa
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Tạo một instance của OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Cấu hình các thuộc tính của OpenFileDialog
            openFileDialog.InitialDirectory = "C:\\";
            openFileDialog.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt|Word documents (*.docx)|*.docx"; // Bộ lọc định dạng file
            openFileDialog.FilterIndex = 1;             
            openFileDialog.RestoreDirectory = true;     

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                txtFilestart.Text = filePath;
            }
        }

        private void btnFileend_Click(object sender, EventArgs e)
        {
          
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Cấu hình các thuộc tính của OpenFileDialog
            openFileDialog.InitialDirectory = "C:\\"; 
            openFileDialog.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt|Word documents (*.docx)|*.docx"; // Bộ lọc định dạng file
            openFileDialog.FilterIndex = 1;             
            openFileDialog.RestoreDirectory = true;

            // Hiển thị hộp thoại File Explorer và kiểm tra xem người dùng có chọn file hay không
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                txtFileend.Text = filePath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Tạo SaveFileDialog để chọn nơi lưu file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.DefaultExt = "txt";  
            saveFileDialog.AddExtension = true;

            
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName; // Lấy đường dẫn file mà người dùng đã chọn

                // Lấy khóa từ TextBox hoặc bất kỳ nơi nào bạn lưu khóa
                string hexKey = txtkey.Text;
                string hexIV = txtIV.Text;

                try
                {
                    // Ghi khóa dưới dạng chuỗi hex vào file text
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.WriteLine(hexKey);
                        writer.WriteLine(hexIV);
                    }

                    // Thông báo cho người dùng rằng việc lưu file thành công
                    MessageBox.Show("Key has been saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ nếu xảy ra lỗi khi lưu file
                    MessageBox.Show($"An error occurred while saving the key: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // Phương thức chuyển đổi chuỗi hex thành byte array
        private byte[] HexStringToBytes(string hex)
        {
            int numberChars = hex.Length;
            byte[] bytes = new byte[numberChars / 2];
            for (int i = 0; i < numberChars; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            }
            return bytes;
        }
        // Phương thức xử lý button Mã Hóa
        private void btnMaHoa_Click(object sender, EventArgs e)
        {
            string selectedAlgorithm = comboBox1.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedAlgorithm))
            {
                MessageBox.Show("Please select an algorithm first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var cipher = GetAlgorithm(selectedAlgorithm);
            byte[] key = HexStringToBytes(txtkey.Text);
            byte[] iv = HexStringToBytes(txtIV.Text);

            if (key.Length != cipher.KeySize / 8)
            {
                MessageBox.Show($"Invalid key size. Expected {cipher.KeySize / 8 * 2} hex characters for {selectedAlgorithm}.", "Invalid Key", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cipher.Key = key;
            cipher.IV = iv;

            // Lấy đường dẫn file từ txtFilestart
            string inputFilePath = txtFilestart.Text;
            if (string.IsNullOrEmpty(inputFilePath) || !File.Exists(inputFilePath))
            {
                MessageBox.Show("Please select a valid input file.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo đường dẫn file đầu ra với đuôi mở rộng theo thuật toán
            string outputFilePath = Path.Combine(
                Path.GetDirectoryName(inputFilePath),
                Path.GetFileNameWithoutExtension(inputFilePath) + "." + selectedAlgorithm.ToLower() + Path.GetExtension(inputFilePath)
            );

            try
            {
                using (FileStream fsInput = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read))
                using (FileStream fsOutput = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write))
                using (CryptoStream cryptoStream = new CryptoStream(fsOutput, cipher.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    fsInput.CopyTo(cryptoStream);
                }

                MessageBox.Show($"File encrypted successfully! Saved as: {outputFilePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during encryption: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Phương thức sử lý button Giả Mã
        private void btnGiaMa_Click(object sender, EventArgs e)
        {
            String SelectedAlgorithm = comboBox1.SelectedItem?.ToString();
            if(string.IsNullOrEmpty(SelectedAlgorithm))
            {
                MessageBox.Show("Vui lòng chọn thuật toán", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            byte[] key = HexStringToBytes(txtkey.Text);
            byte[] iv = HexStringToBytes(txtIV.Text);
            var cipher = GetAlgorithm(SelectedAlgorithm);
            cipher.Key = key;
            cipher.IV = iv;

            // Lấy đường dẫn thư mục
            String inputFilePath = txtFileend.Text;
            if(string.IsNullOrEmpty (inputFilePath) || !File.Exists(inputFilePath))
            {
                MessageBox.Show("Please select a valid input file.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string outputFilePath = Path.Combine(Path.GetDirectoryName(inputFilePath),"GiaiMa_" + Path.GetFileName(inputFilePath));
            try
            {
                using (var inputFileStream = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read))
                using (var outputFileStream = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write))
                using (var decryptor = cipher.CreateDecryptor())
                using (var cryptoStream = new CryptoStream(inputFileStream, decryptor, CryptoStreamMode.Read))
                {
                    cryptoStream.CopyTo(outputFileStream); // Copy dữ liệu đã giải mã vào tệp đầu ra
                }

                MessageBox.Show($"Decryption successful! Output File created: {outputFilePath}", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during decryption: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFilestart_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFileend_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

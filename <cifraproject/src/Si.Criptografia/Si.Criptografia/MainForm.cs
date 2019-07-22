using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Si.Criptografia
{
    public partial class MainForm : Form
    {
        private EncryptionInfo info;

        public MainForm()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            info = new EncryptionInfo();
            encryptionInfoBindingSource.DataSource = info;
            keySizeComboBox.DataSource = Enum.GetValues(typeof(KeySize));
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            info.File = openFileDialog.FileName;
        }

        private void keySizeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (IsHandleCreated)
            {
                BeginInvoke(new Action(() => keyTextBox.MaxLength = info.KeySize == KeySize.Bits64 ? 8 : 16));
            }
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {            
            Scope(() => SaveTextAndInitialize(EncryptionHelper.Encrypt(info), "encrypted.txt"));
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            Scope(() => SaveTextAndInitialize(EncryptionHelper.Decrypt(info), "decrypted.txt"));
        }

        private void SaveTextAndInitialize(string contents, string name)
        {
            saveFileDialog.FileName = name;

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            { 
                return;
            }

            File.WriteAllText(saveFileDialog.FileName, contents, Encoding.ASCII);

            Initialize();
        }

        private void Scope(Action action)
        {
            try
            {
                action();
            }
            catch (EncryptionException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(string.Format("Ocorreu um erro inesperado. O arquivo pode não ser válido para criptografia. Detalhes: {0}", e.Message));
            }
        }
    }
}

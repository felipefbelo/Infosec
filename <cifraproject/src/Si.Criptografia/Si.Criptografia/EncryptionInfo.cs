
namespace Si.Criptografia
{
    public class EncryptionInfo : BindableBase<EncryptionInfo>
    {
        private string chave;
        private string file;
        private KeySize keySize;

        public string Key
        {
            get { return chave; }
            set { SetField(ref chave, value, c => c.Key); }
        }

        public KeySize KeySize
        {
            get { return keySize; }
            set { SetField(ref keySize, value, c => c.KeySize); }
        }

        public string File
        {
            get { return file; }
            set { SetField(ref file, value, c => c.file); }
        }

        public int GetRequiredKeyLenght()
        {
            return KeySize == KeySize.Bits64 ? 8 : 16;
        }

        public bool IsValidKeyLenght()
        {
            return !string.IsNullOrEmpty(Key) && GetRequiredKeyLenght() == Key.Length;
        }
    }
}

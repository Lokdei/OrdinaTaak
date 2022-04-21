using OrdinaTaak;
using OrdinaTaak.Decrypt;
using OrdinaTaak.Readers;

namespace GUI
{
    public partial class Form1 : Form
    {
        User user = new User();
        bool useEncryption = false;
        IOFileDecryptionStrategy decryptionStrategy = new ReverseTextStrategy();
        OFileType readType;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                var text = user.ReadFile(txtFileLocation.Text, readType, useEncryption, decryptionStrategy);
                lblOperationResult.Text = "Operation Result: Success!";
                txtResultText.Text = text;
            }
            catch (Exception ex)
            {
                lblOperationResult.Text = "Operation Result: " + Environment.NewLine + ex.Message;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Add Possible File Types

            var values = Enum.GetValues(typeof(OFileType));
            foreach (var value in values)
            {
                lsbFileTypes.Items.Add(value.ToString());
            }

            lsbEncryption.SetSelected(0, true);

            lsbFileTypes.SetSelected(0, true);

            // Default Select an item in downloads
            var downloadsPath = "" + Convert.ToString(
                Microsoft.Win32.Registry.GetValue(
                    @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders",
                    "{374DE290-123F-4565-9164-39C4925E467B}",
                    string.Empty
                )
            );
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string[] searchDir = { downloadsPath, documentsPath };

            for (int i = 0; i < searchDir.Length; i++)
            {
                DirectoryInfo di = new DirectoryInfo(searchDir[i]);
                var files = di.GetFiles("*.txt");
                if (files.Length > 0)
                {
                    var lookupPath = files[0].FullName;
                    txtFileLocation.Text = lookupPath;
                    break;
                }
            }
        }

        private void lsbFileTypes_SelectedValueChanged(object sender, EventArgs e)
        {
            string fileType = lsbFileTypes.GetItemText(lsbFileTypes.SelectedItem);
            var read = Enum.Parse(typeof(OFileType), fileType);

            switch (read)
            {
                case OFileType.Text:
                    readType = OFileType.Text;
                    break;

                case OFileType.XML:
                    readType = OFileType.XML;
                    break;

                case OFileType.JSON:
                    readType = OFileType.JSON;
                    break;

                default:
                    readType = OFileType.Text;
                    break;
            }
        }

        private void lsbEncryption_SelectedValueChanged(object sender, EventArgs e)
        {
            string text = lsbEncryption.GetItemText(lsbEncryption.SelectedItem);
            if (string.Equals(text, "None"))
            {
                useEncryption = false;
            }
            else if (string.Equals(text, "Reverse"))
            {
                useEncryption = true;
                decryptionStrategy = new ReverseTextStrategy();
            }
        }

        private void cbReadText_CheckedChanged(object sender, EventArgs e)
        {
            if (cbReadText.Checked)
            {
                user.AddRole(new ReadTextRole());
            }
            else
            {
                user.RevokeRole(new ReadTextRole());
            }
        }

        private void cbReadXml_CheckedChanged(object sender, EventArgs e)
        {
            if (cbReadXml.Checked)
            {
                user.AddRole(new ReadXMLRole());
            }
            else
            {
                user.RevokeRole(new ReadXMLRole());
            }
        }

        private void cbReadJson_CheckedChanged(object sender, EventArgs e)
        {
            if (cbReadJson.Checked)
            {
                user.AddRole(new ReadJSONRole());
            }
            else
            {
                user.RevokeRole(new ReadJSONRole());
            }
        }
    }
}
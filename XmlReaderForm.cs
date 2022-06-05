using System.Xml;

namespace QueryCS
{
    public partial class XmlReaderForm : Form
    {
        protected string _fileName;

        public XmlReaderForm()
        {
            InitializeComponent();
        }

        private void Btn_OpenXml_Click(object sender, EventArgs e)
        {
            try
            {
                Ofd_OpenXml.Filter = "XML Files|*.xml|All Files|*.*";
                Ofd_OpenXml.FilterIndex = 0;
                Ofd_OpenXml.RestoreDirectory = true;

                if (Ofd_OpenXml.ShowDialog() == DialogResult.OK)
                {
                    _fileName = Ofd_OpenXml.FileName;
                    Tbx_Content.Multiline = true;
                    Tbx_Content.Text = ReadXmlFile(_fileName);
                    Lbl_SelectedFile.Text = _fileName;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "XML File opening issue");
            }
        }

        private string ReadXmlFile(string fileName)
        {
            int indentDepth = 0;
            using (XmlReader xmlReader = XmlReader.Create(fileName))
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                while (xmlReader.Read())
                {
                    var nodeType = xmlReader.NodeType;

                    if (nodeType == XmlNodeType.Element) indentDepth++;
                    if (nodeType == XmlNodeType.EndElement && indentDepth > 0)
                        indentDepth--;

                    if (nodeType != XmlNodeType.Whitespace && nodeType != XmlNodeType.EndElement)
                    {
                        var line = $"{Indent(indentDepth)}" +
                            //$"{xmlReader.NodeType.ToString()} " +
                            $"{xmlReader.Name} " + $"{xmlReader.Value} " +
                            ReadAttributes(xmlReader);

                        _ = (nodeType == XmlNodeType.Element)
                            ? sb.Append(Environment.NewLine + line)
                            : sb.Append(line);
                    }
                }

                return sb.ToString();
            }
        }

        private string ReadAttributes(XmlReader xmlReader)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            if (xmlReader.HasAttributes)
                for (int i = 0; i < xmlReader.AttributeCount; i++)
                {
                    sb.Append($"{xmlReader.GetAttribute(i)} ");
                }

            return sb.ToString();
        }

        private string Indent(int depth, int tabSize = 3)
        {
            return new string(Enumerable.Repeat(' ', depth * tabSize)
                //.Select(s => s[0])
                .ToArray());
        }
    }
}

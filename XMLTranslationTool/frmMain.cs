using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CT_Additions;
using System.Xml;
using SimpleXMLTranslation;

namespace XMLTranslationTool
{
    public partial class frmMain : Form
    {
        private List<String> languages = new List<string>();

        private List<String> keyWords = new List<string>();

        private Dictionary<String, String> choosenTranslation1 = new Dictionary<string, string>();
        private Dictionary<String, String> choosenTranslation2 = new Dictionary<string, string>();

        private Dictionary<String, Dictionary<String, String>> translations = new Dictionary<string, Dictionary<string, string>>();

        private String fileName = "";
        private String filePath = "";


        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            fileName = "Translation.xml";
            filePath = Application.StartupPath;

            Update();
        }

        private void NewLanguage(ComboBox cbLanguage)
        {
            String newLanguage = frmInputBox.NewInput("New Language", "Please enter the new language").ToLower();

            if (newLanguage != "" && !languages.Contains(newLanguage))
            {
                languages.Add(newLanguage);

                cbChoosenLanguage1.Items.Add(newLanguage);
                cbChoosenLanguage2.Items.Add(newLanguage);

                Dictionary<String, String> newTranslation = new Dictionary<string, string>();
                translations.Add(newLanguage, newTranslation);

                cbLanguage.SelectedIndex = cbLanguage.Items.IndexOf(newLanguage);
            }
        }

        private void Update()
        {
            String tmpLang1 = cbChoosenLanguage1.Text;
            String tmpLang2 = cbChoosenLanguage2.Text;

            cbChoosenLanguage1.Items.Clear();
            cbChoosenLanguage2.Items.Clear();

            foreach (String language in languages)
            {
                cbChoosenLanguage1.Items.Add(language);
                cbChoosenLanguage2.Items.Add(language);
            }

            cbChoosenLanguage1.SelectedIndex = cbChoosenLanguage1.Items.IndexOf(tmpLang1);
            cbChoosenLanguage2.SelectedIndex = cbChoosenLanguage2.Items.IndexOf(tmpLang2);

            String tmpKeyWord = cbKeyWords.Text;
            cbKeyWords.Items.Clear();
            foreach (String keyWord in keyWords)
            {
                cbKeyWords.Items.Add(keyWord);
            }
            cbKeyWords.SelectedIndex = cbKeyWords.Items.IndexOf(tmpKeyWord);

            this.Text = "XML Translation Tool - " + filePath + fileName;

            if (cbChoosenLanguage1.Text != "") choosenTranslation1 = new Dictionary<string, string>(translations[cbChoosenLanguage1.Text]);
            if (cbChoosenLanguage2.Text != "") choosenTranslation2 = new Dictionary<string, string>(translations[cbChoosenLanguage2.Text]);
            ShowTranslation(1);
            ShowTranslation(2);
        }

        private void btnKeyWordsNew_Click(object sender, EventArgs e)
        {
            String newKeyword = frmInputBox.NewInput("New Language", "Please enter the new language").ToLower();


            if (newKeyword != "" && !keyWords.Contains(newKeyword) && isValidXMLName(newKeyword))
            {
                keyWords.Add(newKeyword);
                cbKeyWords.SelectedIndex = cbKeyWords.Items.Add(newKeyword);
            }
        }

        private void cbKeyWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowTranslation(1);
            ShowTranslation(2);
        }

        private void ShowTranslation(int area)
        {

            switch (area)
            {
                case 1:
                    lblTranslation1.Text = ">-----<";
                    if (cbKeyWords.Text != "" && cbChoosenLanguage1.Text != "")
                    {
                        if (!choosenTranslation1.ContainsKey(cbKeyWords.Text)) { choosenTranslation1.Add(cbKeyWords.Text, ""); }
                        tbTranslatedText1.Text = choosenTranslation1[cbKeyWords.Text];
                        lblTranslation1.Text = cbChoosenLanguage1.Text + " - " + cbKeyWords.Text;
                    }
                    break;
                case 2:
                    lblTranslation2.Text = ">-----<";
                    if (cbKeyWords.Text != "" && cbChoosenLanguage2.Text != "")
                    {
                        if (!choosenTranslation2.ContainsKey(cbKeyWords.Text)) { choosenTranslation2.Add(cbKeyWords.Text, ""); }
                        tbTranslatedText2.Text = choosenTranslation2[cbKeyWords.Text];
                        lblTranslation2.Text = cbChoosenLanguage2.Text + " - " + cbKeyWords.Text;
                    }
                    break;
            }
        }

        private void btnLanguagesNew1_Click(object sender, EventArgs e) { NewLanguage(cbChoosenLanguage1); ShowTranslation(1); }
        private void btnLanguagesNew2_Click(object sender, EventArgs e) { NewLanguage(cbChoosenLanguage2); ShowTranslation(2); }

        private void cbChoosenLanguage1_SelectedIndexChanged(object sender, EventArgs e)
        {
            choosenTranslation1 = translations[cbChoosenLanguage1.Text];
            ShowTranslation(1);

        }

        private void cbChoosenLanguage2_SelectedIndexChanged(object sender, EventArgs e)
        {
            choosenTranslation2 = translations[cbChoosenLanguage2.Text];
            ShowTranslation(2);
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            if (cbKeyWords.Text != "" && cbChoosenLanguage1.Text != "")
            {
                choosenTranslation1[cbKeyWords.Text] = tbTranslatedText1.Text;
                btnSave1.Text = "Save";
            }
        }

        private void tbTranslatedText1_TextChanged(object sender, EventArgs e)
        {
            if (cbKeyWords.Text != "" && cbChoosenLanguage1.Text != "")
            {
                if (choosenTranslation1[cbKeyWords.Text] == tbTranslatedText1.Text)
                { btnSave1.Text = "Save"; }
                else
                { btnSave1.Text = "Save *"; }
            }
        }

        private void tbTranslatedText2_TextChanged(object sender, EventArgs e)
        {
            if (cbKeyWords.Text != "" && cbChoosenLanguage2.Text != "")
            {
                if (choosenTranslation2[cbKeyWords.Text] == tbTranslatedText2.Text)
                { btnSave2.Text = "Save"; }
                else
                { btnSave2.Text = "Save *"; }
            }
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            if (cbKeyWords.Text != "" && cbChoosenLanguage2.Text != "")
            {
                choosenTranslation2[cbKeyWords.Text] = tbTranslatedText2.Text;
                btnSave2.Text = "Save";
            }
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void miNew_Click(object sender, EventArgs e)
        {
            languages = new List<string>();

            keyWords = new List<string>();

            choosenTranslation1 = new Dictionary<string, string>();
            choosenTranslation2 = new Dictionary<string, string>();

            translations = new Dictionary<string, Dictionary<string, string>>();

            cbKeyWords.Items.Clear();
            cbKeyWords.Text = "";

            cbChoosenLanguage1.Items.Clear();
            cbChoosenLanguage1.Text = "";

            cbChoosenLanguage2.Items.Clear();
            cbChoosenLanguage2.Text = "";



        }

        private void miSaveAs_Click(object sender, EventArgs e)
        {
            saveFileDialog.InitialDirectory = filePath;
            saveFileDialog.FileName = fileName;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                String tmpString = saveFileDialog.FileName;
                fileName = tmpString.Right(tmpString.Length - tmpString.LastIndexOf("\\") - 1);
                filePath = tmpString.Left(tmpString.LastIndexOf("\\") + 1); ;
                SaveXML();
            }
        }

        private void SaveXML()
        {
            XmlDocument xmlDoc = new XmlDocument();

            XmlNode xmlRoot = xmlDoc.CreateElement("XMLTranslation");
            XmlNode xmlLanguage;
            XmlNode xmlTranslation;

            foreach (String language in languages)
            {
                xmlLanguage = xmlDoc.CreateElement(language);

                Dictionary<String, String> translation = new Dictionary<string, string>(translations[language]);
                foreach (string key in translation.Keys)
                {
                    
                    xmlTranslation = xmlDoc.CreateElement(key);
                    xmlTranslation.InnerText = translation[key];
                    xmlLanguage.AppendChild(xmlTranslation);
                }
                xmlRoot.AppendChild(xmlLanguage);
            }
            xmlDoc.AppendChild(xmlRoot);

            xmlDoc.Save(filePath + fileName);

            Update();
        }

        private void OpenXML()
        {
            miNew_Click(null, null);

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath + fileName);

            XmlNode xmlRoot = xmlDoc.ChildNodes[0];


            foreach (XmlNode xmlLanguage in xmlRoot.ChildNodes)
            {
                languages.Add(xmlLanguage.Name);
                Dictionary<String, String> translation = new Dictionary<string, string>();

                foreach (XmlNode xmlTranslation in xmlLanguage.ChildNodes)
                {
                    if (!keyWords.Contains(xmlTranslation.Name)) keyWords.Add(xmlTranslation.Name);
                    translation.Add(xmlTranslation.Name, xmlTranslation.InnerText);
                }
                translations.Add(xmlLanguage.Name, translation);
            }

            Update();
        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = filePath;
            openFileDialog.FileName = fileName;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                String tmpString = openFileDialog.FileName;
                fileName = tmpString.Right(tmpString.Length - tmpString.LastIndexOf("\\") - 1);
                filePath = tmpString.Left(tmpString.LastIndexOf("\\") + 1);
                OpenXML();
            }
        }

        private void miSave_Click(object sender, EventArgs e)
        {
            SaveXML();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            String newKeyword = frmInputBox.NewInput("New Keyword", "Please enter the new Keyword", cbKeyWords.Text);
            if (newKeyword != "" && newKeyword != cbKeyWords.Text && isValidXMLName(newKeyword))
            {
                foreach (Dictionary<String, String> translation in translations.Values)
                {
                    if (translation.ContainsKey(cbKeyWords.Text))
                    {

                        translation.Add(newKeyword, translation[cbKeyWords.Text]);
                        translation.Remove(cbKeyWords.Text);
                    }

                }




                keyWords.Insert(keyWords.IndexOf(cbKeyWords.Text), newKeyword);
                keyWords.RemoveAt(keyWords.IndexOf(cbKeyWords.Text));

                Update();

                cbKeyWords.SelectedIndex = cbKeyWords.Items.IndexOf(newKeyword);
            }
        }

        private bool isValidXMLName(String text)
        {
            if (text.Contains(" ") || text.Left(3).ToLower() == "xml") return false;
            
            switch (text.Left(1).ToLower())
            {
                case "a":
                case "b":
                case "c":
                case "d":
                case "e":
                case "f":
                case "g":
                case "h":
                case "i":
                case "j":
                case "k":
                case "l":
                case "m":
                case "n":
                case "o":
                case "p":
                case "q":
                case "r":
                case "s":
                case "t":
                case "u":
                case "v":
                case "w":
                case "x":
                case "y":
                case "z": return true;
                default: return false;
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            SimpleTranslation trans = new SimpleTranslation(filePath, fileName);
            
            trans.SetLanguage(tbTestLanguage.Text);

            //SimpleTranslation trans = new SimpleTranslation(filePath, fileName,tbTestLanguage.Text);

            tbTestResult.Text = trans.GetText(tbTestKeyWord.Text);
        }
    }
}

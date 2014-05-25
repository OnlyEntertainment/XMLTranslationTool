using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace SimpleXMLTranslation
{
    public class SimpleTranslation
    {
        private Dictionary<String, Dictionary<String, String>> translations;
        private Dictionary<String, String> currentTranslation;

        private List<String> languages;
        private List<String> keyWords;

        private String currentLanguage;

        public SimpleTranslation(String filePath, String fileName) : this(filePath,fileName,"English") {}
        
        public SimpleTranslation(String filePath, String fileName, String language)
        {
            translations = new Dictionary<string, Dictionary<string, string>>();
            currentTranslation = new Dictionary<string, string>();

            languages = new List<string>();
            keyWords = new List<string>();

            currentLanguage = "";

            LoadXML(filePath, fileName);

            SetLanguage(language);
        }

        private void LoadXML(String filePath, String fileName)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath + fileName);

            XmlNode xmlRoot = xmlDoc.ChildNodes[0];

            foreach (XmlNode xmlLanguage in xmlRoot.ChildNodes)
            {
                languages.Add(xmlLanguage.Name.ToLower());
                Dictionary<String, String> translation = new Dictionary<string, string>();
                foreach (XmlNode xmlTranslation in xmlLanguage.ChildNodes)
                {
                    if (!keyWords.Contains(xmlTranslation.Name.ToLower())) keyWords.Add(xmlTranslation.Name.ToLower());
                    translation.Add(xmlTranslation.Name.ToLower(), xmlTranslation.InnerText);
                }
                translations.Add(xmlLanguage.Name.ToLower(), translation);
            }
        }

        public bool SetLanguage(String language)
        {
            if (languages.Contains(language.ToLower()))
            {
                currentLanguage = language.ToLower();
                currentTranslation = translations[language.ToLower()];
                return true;
            }
            else
            { return false; }
        }
        
        public Dictionary<String, Dictionary<String, String>> GetTranslations() {return translations;}

        public Dictionary<String, String> GetTranslation() { return currentTranslation; }

        public List<String> GetLanguages() { return languages; }

        public String GetLanguage() { return currentLanguage; }

        public List<String> GetKeyWords() { return keyWords; }

        public String GetText(String keyWord)
        {
            if (currentLanguage != "" && currentTranslation.ContainsKey(keyWord.ToLower()))
            {
                return currentTranslation[keyWord.ToLower()];
            }
            else
            {
                return "[" + keyWord.ToLower() + "]";
            }
        }

    }
}

using character;
using System.Xml;

namespace xmlSave
{

    public class SaveXml
    {
        private CharacterCreation character;
        private string name;
        private int age;
        private int level;
        private int strenght;
        private int agility;
        private int health;

        private string characterClass;
        private string characterOrigin;
        private string randomEventString;

        public  SaveXml(CharacterCreation _character)
        {
            this.character = _character;
        }

        public void XmlWriter()
        {

            XmlTextReader textReader = new XmlTextReader("C:");
        }
    }
}

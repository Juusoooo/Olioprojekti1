using character;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
namespace actions
{


    public class ActionsCreation : CharacterCreation
    {
        CharacterCreation randomAttributes = new CharacterCreation();
        List<string> characterAtributes = new List<string>();
        private string class1, origin, rndEvent;

        public ActionsCreation()
        {
            class1 = "0";
            origin = "0";
            rndEvent = "0";
        }

        public ActionsCreation(string _name, int _age, int _level, int _strenght, int _agility, int _healt, string _class, string _origin, string _rndEvent) : base(_name, _age, _level, _strenght, _agility, _healt)
        {

            this.class1 = _class;
            this.origin = _origin;
            this.rndEvent = _rndEvent;
            
        }

        public void AddAtributes()
        {
            characterAtributes = randomAttributes.CharacterRandom();
            class1 = characterAtributes[0];
            origin = characterAtributes[1];
            rndEvent = characterAtributes[2];
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"class: {class1} origin: {origin} event: {rndEvent} ");
        }


    }
}

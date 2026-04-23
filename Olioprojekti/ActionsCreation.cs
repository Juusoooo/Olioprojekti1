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

        public ActionsCreation( ) : base() 
        {
        
        }
        



        public override void ShowInfo()
        {
            base.ShowInfo();
        }
    }
}

using character;
using System;
using System.Collections.Generic;
using System.Text;

namespace randomEvent
{
    public class RandomEvent
    {
        private CharacterCreation events;

        private string rndEvent;
        private string origin;
        private string charClass;

        public RandomEvent(CharacterCreation _character)
        {
            this.events = _character;
        }

        public void EventMaker()
        {
            rndEvent = events.ReturnEvent();
            origin = events.ReturnOrigin();
            charClass = events.ReturnClass();
        }





    }
}

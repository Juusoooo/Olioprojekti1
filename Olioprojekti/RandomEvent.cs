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

        public RandomEvent(CharacterCreation _character)
        {
            this.events = _character;
        }

        public void EventMaker()
        {
            rndEvent = events.ReturnEvent();

            Console.WriteLine($"Here is event in randomevent: {rndEvent}");
        }





    }
}

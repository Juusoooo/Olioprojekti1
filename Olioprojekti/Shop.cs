using character;
using System;
using System.Collections.Generic;
using System.Text;

namespace shopNamespace
{
    public class Shop
    {
        CharacterCreation character;
        private string eventType;

        public Shop(CharacterCreation _character) 
        { 
            this.character = _character;
        }

        public void ShoppingMerchant()
        {
            eventType = character.ReturnEvent();
            if(eventType == "Merchant")
            {

            }
            
        }

    }
}

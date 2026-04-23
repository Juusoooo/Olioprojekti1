using character;
using actions;
namespace MainFile
{
    class MainRun
    {
        static void Main (string[] args)
        {
            ActionsCreation actions = new ActionsCreation();
            
            actions.CharacterAtribute();
            actions.AddAtributes();
            actions.ShowInfo();

        }
    }
}
using System.Windows.Forms;

namespace SwappingElephants
{
    class Elephant
    {
        public string Name { get; set; }

        public int EarSize { get; set; }

        public void WhoAmI()
        {
            MessageBox.Show("My ears are " + EarSize + "inches tall",
                Name + "says...");
        }

        public void TellMe(string message, Elephant whoSaidIt)
        {
            MessageBox.Show(whoSaidIt.Name + " says: " + message);
        }

        public void Speakto(Elephant whoToTalkTo, string message)
        {
            whoToTalkTo.TellMe(message, this);
        }

    }
}

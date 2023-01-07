namespace Project1
{
    class ZZ : Humanoid, ISpeakFrench,ICanDance
    {
        public string Mediaplay;

        public ZZ(string myName, string myAncestorName) : base(myName, myAncestorName)
        {
        }

        public void Speak()
        {
            Mediaplay = "Assets/Zspeak.mp4";
        }
        public void Sing()
        {
            Mediaplay = "Assets/Zsong.mp4";
        }
        public void Dance()
        {
            Mediaplay = "Assets/RickRoll.mp4";
        }
        public override void Socialize()
        {
            Sing();
            Dance();
        }
        
    }
}

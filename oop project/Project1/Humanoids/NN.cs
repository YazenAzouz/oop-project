namespace Project1
{
    class NN : ZZ, ICodeCSharp
    {
        public string playMedia;
        public NN(string myName, string myAncestorName) : base(myName, myAncestorName)
        {
        }

        public void WriteCode()
        {
            playMedia = "Assets/Coding.mp4";
        }
        public override void Socialize()
        {
            
        }
    }
}

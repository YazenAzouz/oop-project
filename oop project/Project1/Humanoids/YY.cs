namespace Project1
{
    class YY : Humanoid,ISpeakFrench,ICanEat
    {
        public string Media;

        public YY(string myName,string myAncestorName):base(myName,myAncestorName)
        {
        }
        public void Speak()
        {
            Media = "Assets/Speak.mp4";
        }
        public void Sing()
        {
           Media = "Assets/Song.mp4";
            
        }
        public void Eat() 
        {
            Media = "Assets/Mouse.mp4";
        }
        public override void Socialize()
        {
            Speak();
            Eat();
        }
        
    }
}

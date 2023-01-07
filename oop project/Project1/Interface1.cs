﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public interface ISpeakFrench
    {
        void Speak();
        void Sing();
    }
    public interface ICanEat
    {
        void Eat();
    }
    public interface ICanDance
    {
        void Dance();
    }
    interface ISnore
    {
        void Snore();
    }
    interface ICodeCSharp
    {
        void WriteCode();
    }
    abstract class Humanoid
    {
        public string Name;
        public string Ancestor;
        public Humanoid(string myName, string myAncestorName)
        {
            this.Name = myName;
            this.Ancestor = myAncestorName;
        }
        public abstract void Socialize();
    }

}



using System.Collections.Generic;

namespace Lab3App
{
        public abstract class Tool : Collectable
    {
        protected Tool(string description) : base(description) { }

        public override void AddMe(List<Collectable> newlist)
        {
            DoAction(); 
            base.AddMe(newlist);
        }
        public abstract void DoAction();
    }

}
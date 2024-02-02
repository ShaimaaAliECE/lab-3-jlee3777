using System.Collections.Generic;

namespace Lab3App
{
    
    public abstract class Tool : Collectable
    {
        protected Tool(string description) : base(description) { }

        public override void AddMe(List<Collectable> list)
        {
            DoAction(); // Perform the tool's action when it's added to the collection.
            base.AddMe(list);
        }
        public abstract void DoAction();
    }


}
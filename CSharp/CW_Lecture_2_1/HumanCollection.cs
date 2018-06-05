using System;
using System.Collections.ObjectModel;

namespace CW_Lecture_2_1
{
    public class HumanCollection :Collection<Human>
    {
        protected override void InsertItem(int index, Human item)
        {
            if(item == null || DateTime.Now.Year - item.DoB.Year <18) return; 
            base.InsertItem(index, item);
        }
    }
}
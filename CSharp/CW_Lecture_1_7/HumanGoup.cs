using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_Lecture_1_7
{
    public class HumanGoup
    {
        private readonly List<Human> _humans = new List<Human>();
        public string GroupName = "Unnamed Group";

        public void Add(Human human)
        {
            if (!IsHumanValid(human)) return;
            //if (string.IsNullOrEmpty(human?.FullName)) return;

            _humans.Add(human);
        }

        public bool TryAddHuman(Human human)
        {
            if (!IsHumanValid(human)) return false;

            _humans.Add(human);
            return true;
        }

        public ActionResult TryAddHumanV2(Human human)
        {
            if(human == null) return new ActionResult()
            {
                Message = "Humman cannot be NULL", Sucsess =  false
            };
            if (string.IsNullOrWhiteSpace(human.FullName)) return new ActionResult()
            {
                Message = "Humman name is null or isn't valid",
                Sucsess = false
            };

            _humans.Add(human);

             return new ActionResult()
             { Message = $"Humman {human.FullName} was addede",
                 Sucsess = true
             };
        }


        private bool IsHumanValid(Human human)
        {
            return human != null && !string.IsNullOrWhiteSpace(human.FullName);
        }
    }
}

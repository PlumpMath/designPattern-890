using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverTest
{
    class Boss : Subject
    {
        private IList<Observer> observers = new List<Observer>();
        private string action;
        public string SubjectState
        {
            get
            {
                return action;
            }

            set
            {
                action = value;
            }
        }

        public void Attach(Observer observer)
        {
            observers.Add(observer);
            //throw new NotImplementedException();
        }

        public void Detach(Observer observer)
        {
            observers.Remove(observer);
            //throw new NotImplementedException();
        }

        public void Notify()
        {
            foreach (Observer o in observers)
                o.Update();
            
        }
    }
}

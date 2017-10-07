using System.Collections.Generic;

namespace Assessment2.Solution.MVCO.Observer {

    public abstract class Observable {

        private readonly List<IObserver> _observers = new List<IObserver>();

        protected void AddObserver(IObserver observer) {
            _observers.Add(observer);
        }

        protected void RemoveObserver(IObserver observer) {
            if (_observers.Contains(observer))
                _observers.Remove(observer);
        }

        protected void Update() {
            foreach (var observer in _observers)
                observer.Update();
        }

    }

}
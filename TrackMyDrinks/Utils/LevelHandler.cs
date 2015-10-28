using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackMyDrinks.Interfaces;

namespace TrackMyDrinks.Utils
{
    public delegate void LevelChangedDelegate();

    class LevelHandler
    {
        private List<IVisibleElement> history;

        public static LevelHandler Instance = new LevelHandler();

        private LevelHandler()
        {
            history = new List<IVisibleElement>();
        }

        public int CurrentLevel
        {
            get
            {
                return history.Count;
            }

            private set
            {
            }
        }

        public void Push(IVisibleElement element)
        {
            if (history.Count > 0)
            {
                history.Last().IsVisible = false;
            }

            history.Add(element);
            history.Last().IsVisible = true;

            LevelChanged.Invoke();
        }

        public IVisibleElement Top
        {
            get
            {
                return history.Last();
            }
        }

        public bool Pop(int count)
        {
            if ((history.Count <= count) || (count <= 0))
            {
                return false;
            }

            history.Last().IsVisible = false;
            history.RemoveRange(history.Count - count, count);
            history.Last().IsVisible = true;

            LevelChanged.Invoke();

            return true;
        }

        public void Replace(IVisibleElement element)
        {
            if (history.Count > 0)
            {
                history.Last().IsVisible = false;
                history.RemoveAt(history.Count - 1);
            }

            history.Add(element);
            history.Last().IsVisible = true;

            LevelChanged.Invoke();
        }

        public event LevelChangedDelegate LevelChanged = delegate { };
    }
}

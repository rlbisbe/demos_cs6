using System;

namespace CSharpSixReview
{
    class EventHandling
    {
        event EventHandler MyCustomEvent;

        void HandlingEvent5()
        {
            if (MyCustomEvent != null)
            {
                MyCustomEvent(this, EventArgs.Empty);
            }
        }

        void HandlingEvents6()
        {
            MyCustomEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}

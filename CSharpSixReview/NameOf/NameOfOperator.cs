using System;
using System.ComponentModel;

namespace CSharpSixReview
{
    public class NameOfOperator
    {
        private readonly int upperLength = 100;

        public void ValidateName5(string name)
        {
            Console.WriteLine("Executing method ValidateName5, if we rename the method we will never know!");

            if (name?.Length > upperLength)
            {
                throw new ArgumentException("Upper length > " + upperLength, "name");
            }
        }

        public void ValidateName6(string name)
        {
            Console.WriteLine("Executing method" + nameof(ValidateName6) + ", if we rename the method, it will crash at compile time");

            if (name?.Length > upperLength)
            {
                throw new ArgumentException("Upper length > " + upperLength, nameof(name));
            }
        }
    }


    public class AnotherViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int _foo;
        public int Foo
        {
            get { return _foo; }
            set
            {
                _foo = value;
                OnPropertyChanged(nameof(Foo));
            }
        }

        protected virtual void OnPropertyChanged(string prop)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(prop));
            }
        }

    }

}

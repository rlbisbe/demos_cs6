using System.Collections.Generic;

namespace CSharpSixReview
{
    class AutoInitializers
    {
        public int MyProperty { get; set; } = 12;
        public List<string> MyArray { get; set; } = new List<string>();
        public int MyReadOnlyProperty { get; } = 42;
    }
}

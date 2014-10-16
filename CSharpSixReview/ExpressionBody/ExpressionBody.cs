namespace CSharpSixReview.ExpressionBody
{
    class ExpressionBody
    {
        public int X { get; set; }
        public int Y { get; set; }

        //Properties
        public string Description5
        {
            get
            {
                return string.Format("Base:{0}, Height:{1}", X, Y);
            }
        }

        public string Description6 => string.Format("Base:{0}, Height:{1}", X, Y);

        //Methods
        public int Area5 => X * Y;

        public int Area6()
        {
            return X * Y;
        }
    }
}

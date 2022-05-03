namespace Admitere
{
    internal class Answer
    {
        private int id;
        private CellObject cell;
        private bool correct;

        public int Id { get => id; set => id = value; }
        public bool Correct { get => correct; set => correct = value; }
        public CellObject Cell { get => cell; set => cell = value; }
    }
}
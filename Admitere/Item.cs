using System.Collections.Generic;

namespace Admitere
{
    internal class Item
    {
        private int itemNo;
        private CellObject question;
        private List<Answer> answers = new List<Answer>();

        public int ItemNo { get => itemNo; set => itemNo = value; }
        public CellObject Question { get => question; set => question = value; }
        public List<Answer> Answers { get => answers; set => answers = value; }
    }
}
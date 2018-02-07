namespace NETCommunity.FsCheck.Tests.Samples
{
    // F#: 
    //type Tree = Leaf of int | Branch of Tree * Tree
    public abstract class Tree
    {
        public static Tree NewLeaf(int item)
        {
            return new Leaf(item);
        }
        public bool IsLeaf => this is Leaf;
        public static Tree NewBranch(Tree item1, Tree item2)
        {
            return new Branch(item1, item2);
        }
        public bool IsBranch => this is Branch;
        public int Tag => this is Branch ? 1 : 0;
        public class Leaf : Tree
        {
            public Leaf(int item)
            {
                Item = item;
            }
            public int Item
            {
                get;
            }
        }
        public class Branch : Tree
        {
            public Branch(Tree item1, Tree item2)
            {
                Item1 = item1;
                Item2 = item2;
            }
            public Tree Item1 { get; }
            public Tree Item2 { get; }
        }
    }
}
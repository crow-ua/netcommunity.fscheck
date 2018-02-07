using FsCheck;

namespace NETCommunity.FsCheck.Tests.Samples
{
    public class TreeTests
    {
        public static Gen<Tree> SafeTreeHelper(int size)
        {
            if (size == 0)
            {
                return Arb.Generate<int>().Select(i => (Tree)new Tree.Leaf(i));
            }

            var subtree = SafeTreeHelper(size / 2);
            return Gen.OneOf(Arb.Generate<int>().Select(i => (Tree)new Tree.Leaf(i)),
                Gen.Two(subtree).Select(t => (Tree)new Tree.Branch(t.Item1, t.Item2)));
        }

        public static Gen<Tree> SafeTree()
        {
            return Gen.Sized(SafeTreeHelper);
        }
    }
}
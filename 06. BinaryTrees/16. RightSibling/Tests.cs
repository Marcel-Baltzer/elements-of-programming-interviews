using Elements_of_Programming_Interviews.Types;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._06._BinaryTrees._16._RightSibling
{
    public class Tests
    {
        [Fact]
        public void ConstructRightSibling()
        {
            var A = new BinaryTreeNodeWithNext<int> { Data = 1 };
            var B = new BinaryTreeNodeWithNext<int> { Data = 2 };
            var C = new BinaryTreeNodeWithNext<int> { Data = 3 };
            var D = new BinaryTreeNodeWithNext<int> { Data = 4 };
            var E = new BinaryTreeNodeWithNext<int> { Data = 5 };
            var F = new BinaryTreeNodeWithNext<int> { Data = 6 };
            var G = new BinaryTreeNodeWithNext<int> { Data = 7 };
            var H = new BinaryTreeNodeWithNext<int> { Data = 8 };
            var I = new BinaryTreeNodeWithNext<int> { Data = 9 };
            var J = new BinaryTreeNodeWithNext<int> { Data = 10 };
            var K = new BinaryTreeNodeWithNext<int> { Data = 11 };
            var L = new BinaryTreeNodeWithNext<int> { Data = 12 };
            var M = new BinaryTreeNodeWithNext<int> { Data = 13 };
            var N = new BinaryTreeNodeWithNext<int> { Data = 14 };
            var O = new BinaryTreeNodeWithNext<int> { Data = 15 };

            A.Left = B;
            B.Left = C;
            C.Left = D;
            C.Right = E;
            B.Right = F;
            F.Left = G;
            F.Right = H;

            A.Right = I;
            I.Left = J;
            J.Left = K;
            J.Right = L;
            I.Right = M;
            M.Left = N;
            M.Right = O;

            Solution.ConstructRightSibling(A);

            A.Next.Should().BeNull();
            B.Next.Should().BeEquivalentTo(I);
            C.Next.Should().BeEquivalentTo(F);
            D.Next.Should().BeEquivalentTo(E);
            E.Next.Should().BeEquivalentTo(G);
            F.Next.Should().BeEquivalentTo(J);
            G.Next.Should().BeEquivalentTo(H);
            H.Next.Should().BeEquivalentTo(K);
            I.Next.Should().BeNull();
            J.Next.Should().BeEquivalentTo(M);
            K.Next.Should().BeEquivalentTo(L);
            L.Next.Should().BeEquivalentTo(N);
            M.Next.Should().BeNull();
            N.Next.Should().BeEquivalentTo(O);
            O.Next.Should().BeNull();
        }
    }
}
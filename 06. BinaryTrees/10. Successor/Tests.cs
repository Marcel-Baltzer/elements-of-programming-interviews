using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._06._BinaryTrees._10._Successor
{
    public class Tests
    {
        [Fact]
        public void FindSuccessor()
        {
            var A = new BinaryTreeNodeWithParent<int>() { Data = 314 };
            var B = new BinaryTreeNodeWithParent<int>() { Data = 6 };
            var C = new BinaryTreeNodeWithParent<int>() { Data = 271 };
            var D = new BinaryTreeNodeWithParent<int>() { Data = 28 };
            var E = new BinaryTreeNodeWithParent<int>() { Data = 0 };
            var F = new BinaryTreeNodeWithParent<int>() { Data = 561 };
            var G = new BinaryTreeNodeWithParent<int>() { Data = 3 };
            var H = new BinaryTreeNodeWithParent<int>() { Data = 17 };
            var I = new BinaryTreeNodeWithParent<int>() { Data = 6 };
            var J = new BinaryTreeNodeWithParent<int>() { Data = 2 };
            var K = new BinaryTreeNodeWithParent<int>() { Data = 1 };
            var L = new BinaryTreeNodeWithParent<int>() { Data = 401 };
            var M = new BinaryTreeNodeWithParent<int>() { Data = 641 };
            var N = new BinaryTreeNodeWithParent<int>() { Data = 257 };
            var O = new BinaryTreeNodeWithParent<int>() { Data = 271 };
            var P = new BinaryTreeNodeWithParent<int>() { Data = 28 };

            A.Left = B;
            B.Parent = A;
            A.Right = I;
            I.Parent = A;
            B.Left = C;
            C.Parent = B;
            B.Right = F;
            F.Parent = B;
            C.Left = D;
            D.Parent = C;
            C.Right = E;
            E.Parent = C;
            F.Right = G;
            G.Parent = F;
            G.Left = H;
            H.Parent = G;
            I.Left = J;
            J.Parent = I;
            I.Right = O;
            O.Parent = I;
            J.Right = K;
            K.Parent = J;
            K.Left = L;
            L.Parent = K;
            K.Right = N;
            N.Parent = K;
            L.Right = M;
            M.Parent = L;
            O.Right = P;
            P.Parent = O;

            var result = Solution.FindSuccessor(H);

            result.Should().BeEquivalentTo(G);

            result = Solution.FindSuccessor(G);

            result.Should().BeEquivalentTo(A);

            result = Solution.FindSuccessor(P);

            result.Should().BeNull();
        }
    }
}
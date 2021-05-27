using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._09._HashTables._04._ComputeLCA
{
    public class Tests
    {
        [Fact]
        public void LCA()
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

            B.Parent = A;
            I.Parent = A;
            C.Parent = B;
            F.Parent = B;
            D.Parent = C;
            E.Parent = C;
            G.Parent = F;
            H.Parent = G;
            J.Parent = I;
            O.Parent = I;
            K.Parent = J;
            L.Parent = K;
            N.Parent = K;
            M.Parent = L;
            P.Parent = O;

            var result = Solution.LCA(M, N);

            result.Data.Should().Be(K.Data);
        }
    }
}
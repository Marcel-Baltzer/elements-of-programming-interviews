using System;
using System.Collections.Generic;
using System.Linq;

namespace Elements_of_Programming_Interviews._12._Recursion._11._DiameterOfATree
{
    public static class Solution
    {
        public class TreeNode
        {
            public List<Edge> Edges = new();

            public TreeNode()
            {
            }

            public TreeNode(List<Edge> edges)
            {
                Edges = edges;
            }
        }

        public class Edge
        {
            public readonly TreeNode Root = new();
            public readonly double Length;

            public Edge(double length)
            {
                Length = length;
            }
        }

        private class HeightAndDiameter
        {
            public readonly double Height;
            public readonly double Diameter;

            public HeightAndDiameter(double height, double diameter)
            {
                Height = height;
                Diameter = diameter;
            }
        }

        public static double ComputeDiameter(TreeNode treeNode)
        {
            return treeNode != null ? ComputeHeightAndDiameter(treeNode).Diameter : 0.0;
        }

        private static HeightAndDiameter ComputeHeightAndDiameter(TreeNode treeNode)
        {
            var diameter = double.MinValue;

            var heights = new[] {0.0, 0.0}; // Stores the max two heights.

            foreach (var edge in treeNode.Edges)
            {
                var heightDiameter = ComputeHeightAndDiameter(edge.Root);
                if (heightDiameter.Height + edge.Length > heights[0])
                {
                    heights[1] = heights[0];
                    heights[0] = heightDiameter.Height + edge.Length;
                }
                else if (heightDiameter.Height + edge.Length > heights[1])
                {
                    heights[1] = heightDiameter.Height + edge.Length;
                }

                diameter = Math.Max(diameter, heightDiameter.Diameter);
            }

            return new HeightAndDiameter(heights[0], Math.Max(diameter, heights.Sum()));
        }
    }
}
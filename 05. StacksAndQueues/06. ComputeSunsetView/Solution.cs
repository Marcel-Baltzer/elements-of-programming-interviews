using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._05._StacksAndQueues._06._ComputeSunsetView
{
    public class Solution
    {
        public class BuildingWithHeight
        {
            public BuildingWithHeight(int id, int height)
            {
                Id = id;
                Height = height;
            }

            public int Id { get; }
            public int Height { get; }
        }

        public static Stack<BuildingWithHeight> ExamineBuildingsWithSunset(IEnumerator<int> sequence)
        {
            var buildingIdx = 0;
            var buildingsWithSunset = new Stack<BuildingWithHeight>();

            while (sequence.MoveNext())
            {
                var buildingHeight = sequence.Current;

                while (buildingsWithSunset.Count > 0 && (buildingHeight.CompareTo(buildingsWithSunset.Peek().Height) >= 0))
                {
                    buildingsWithSunset.Pop();
                }

                buildingsWithSunset.Push(new BuildingWithHeight(buildingIdx++, buildingHeight));
            }

            return buildingsWithSunset;
        }
    }
}
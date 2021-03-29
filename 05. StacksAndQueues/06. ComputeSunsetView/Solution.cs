using System.Collections.Generic;

namespace Elements_of_Programming_Interviews.StacksAndQueues.ComputeSunsetView
{
    public class Solution
    {
        public class BuildingWithHeight
        {
            public BuildingWithHeight(int id, int height)
            {
                this.Id = id;
                this.Height = height;
            }

            public int Id { get; set; }
            public int Height { get; set; }
        }

        public static Stack<BuildingWithHeight> ExamineBuildingsWithSunset(IEnumerator<int> sequence)
        {
            int buildingldx = 0;
            var buildingsWithSunset = new Stack<BuildingWithHeight>();

            while (sequence.MoveNext())
            {
                int buildingHeight = sequence.Current;

                while (buildingsWithSunset.Count > 0 && (buildingHeight.CompareTo(buildingsWithSunset.Peek().Height) >= 0))
                {
                    buildingsWithSunset.Pop();
                }

                buildingsWithSunset.Push(new BuildingWithHeight(buildingldx++, buildingHeight));
            }

            return buildingsWithSunset;
        }
    }
}
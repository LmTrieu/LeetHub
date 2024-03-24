public class Solution {
        public int[][] Merge(int[][] intervals) {
        return [.. intervals.OrderBy(interval => interval[0]) 
                .Aggregate(new List<int[]>(), (acc, current) =>
                {
                    if (acc.Count == 0 || acc.Last()[1] < current[0])
                    {
                        acc.Add(current);
                    }
                    else
                    {
                        acc.Last()[1] = Math.Max(acc.Last()[1], current[1]);
                    }
                    return acc;
                })];
        }
    }
public class Solution {
    public int[][] AllCellsDistOrder(int Y, int X, int YY, int XX) {
        return Enumerable.Range(0, X*Y).
                    Select(x => (x / X, x % X, Math.Abs(YY - x / X) + Math.Abs(XX - x % X))).
                    OrderBy(x=>x.Item3).Select(x=> new int[] {x.Item1, x.Item2}).ToArray();
    }
}
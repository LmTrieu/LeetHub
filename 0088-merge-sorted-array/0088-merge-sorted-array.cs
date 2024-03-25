public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        var merged = nums1[..m].Concat(nums2).ToList();
        merged.Sort();
        Array.Copy(merged.ToArray(), nums1, merged.Count());
    }
}
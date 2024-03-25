public class Solution {
    public int RemoveDuplicates(int[] nums) {
        HashSet<int> result = new HashSet<int>(nums);

        result.CopyTo(nums);
        
        return result.Count;
    }
}
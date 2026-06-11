public class Solution {
    public bool hasDuplicate(int[] nums) {
        var dict = new HashSet<int>();
        var result = false;
        for (var i = 0; i<nums.Length; i++){
            if(!dict.Contains(nums[i]) && !result){
                dict.Add(nums[i]);
            }
            else {
                result= true;
            }
        }

        return result;
    }
}
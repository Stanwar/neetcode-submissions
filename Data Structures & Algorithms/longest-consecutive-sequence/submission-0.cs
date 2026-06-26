public class Solution {
    public int LongestConsecutive(int[] nums) {
        var result = 0;

        var lookupSet = new HashSet<int>();
        for (var i =0; i < nums.Length; i++){
            lookupSet.Add(nums[i]);
        }

        for (var i=0; i< nums.Length; i++){
            var current = nums[i];
            var total = 1;
            while(lookupSet.Contains(current + 1)){
                total = total + 1;
                current = current + 1;
            }

            if (total > result){
                result= total;
            }
        }

        return result;
    }
}

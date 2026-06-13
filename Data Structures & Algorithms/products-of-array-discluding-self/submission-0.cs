public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var result= new int[nums.Length];
        // Brute force
        for (var i =0; i< nums.Length; i++){
            var product = 1;
            for(var j=0; j< nums.Length; j++){
                if (i == j){
                    continue;
                }

                product = product * nums[j];
            }
            result[i] = product;
        }

        return result;
    }
}

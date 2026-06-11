public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dictionary = new Dictionary<int, int>();
        var result = new int[2];
        // Assume the array is not sorted
        for (var i=0; i<nums.Length; i++){
            var difference = target - nums[i];

            if (dictionary.ContainsKey(difference) && dictionary[difference] != i){

                if (dictionary[difference] < i) {
                    result[0] = dictionary[difference];
                    result[1] = i;
                }
                else {
                    result[0] = i;
                    result[1] = dictionary[difference];
                }

                return result;
            }
            dictionary.Add(nums[i], i);
        }

        return result;
    }
}

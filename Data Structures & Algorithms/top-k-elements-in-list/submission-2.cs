public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var countDictionary = new Dictionary<int, int>();

        // Count frequencies
        foreach (var n in nums) {
            if (!countDictionary.ContainsKey(n))
                countDictionary[n] = 0;
            countDictionary[n]++;
        }

        // Convert dictionary to list of (frequency, number)
        var pairs = new List<(int freq, int num)>();
        foreach (var entry in countDictionary) {
            pairs.Add((entry.Value, entry.Key));
        }

        // Sort by frequency descending
        pairs.Sort((a, b) => b.freq.CompareTo(a.freq));

        // Extract top k numbers
        var result = new int[k];
        for (int i = 0; i < k; i++) {
            result[i] = pairs[i].num;
        }

        return result;
    }
}
public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        if (strs.Length == 0 ){
            return [[]];
        }

        if (strs.Length ==1 && strs[0] == ""){
            return [[""]];
        }

        var dictionary = new Dictionary<string, List<string>>(); 
        for (var i = 0 ; i < strs.Length; i++){
            var chars = strs[i].ToCharArray();
            Array.Sort(chars);
            var word = new string(chars);
            if (!dictionary.ContainsKey(word)){
                var stringList = new List<string>();
                stringList.Add(strs[i]);
                dictionary.Add(word, stringList);
            }
            else {
                dictionary[word].Add(strs[i]);
            }
        }

        var results = new List<List<string>>();

        foreach (KeyValuePair<string, List<string>> entry in dictionary){
            results.Add(entry.Value);
        }
        return results;
    }
}

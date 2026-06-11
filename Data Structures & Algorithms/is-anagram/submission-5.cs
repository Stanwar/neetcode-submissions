public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length){
            return false;
        }

        var dict1 = new Dictionary<char, int>();
        var dict2 = new Dictionary<char, int>();

        for (var i = 0; i< s.Length; i ++ ){
            if(dict1.ContainsKey(s[i])){
                dict1[s[i]]++;
            }
            else {
                dict1.Add(s[i], 1);
            }
        }
        for (var i = 0; i< t.Length; i ++ ){

            if (!dict1.ContainsKey(t[i])){
                return false;
            }
            if(dict2.ContainsKey(t[i])){
                dict2[t[i]]++;
            }
            else {
                dict2.Add(t[i], 1);
            }
        }
        
        var result = true;
        for (var i=0; i< t.Length; i++){
            if (dict1[t[i]] != dict2[t[i]]){
                result = false;
            }
        }
        return result;
    }
}

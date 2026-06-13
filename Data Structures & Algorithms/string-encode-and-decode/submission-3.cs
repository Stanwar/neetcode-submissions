public class Solution {
    string delimiter = "~*~";
    public string Encode(IList<string> strs) {
        var result = "";
        if (!strs.Any()){
            return null;
        }
        if (strs.Count == 1){
            result = strs[0];
            return result;
        }
        for(var i=0; i< strs.Count; i++){
            if (i==0){
                result= strs[i];
            }
            else {
                result= result + strs[i];
            }
            if (i == strs.Count - 1){
                return result;
            }

            result= result + delimiter;
        }

        return result;
    }

    public List<string> Decode(string s) {
        if (s == null){
            return [];
        }
        var result = s.Split(delimiter).ToList();
        return result.ToList();
   }
}

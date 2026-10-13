public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var groups = new Dictionary<string, List<string>>();

        foreach (string s in strs) {
            int[] count = new int[26];
            foreach (char c in s) {
                count[c - 'a']++;              // 'a' → index 0, 'b' → 1, ...
            }
            string key = string.Join(",", count);

            if (!groups.ContainsKey(key)) {
                groups[key] = new List<string>();
            }
            groups[key].Add(s);
        }

        return new List<List<string>>(groups.Values);
    }
}
public class Solution {
    public int LengthOfLongestSubstring(string s) {
		Dictionary<char, int> currSubstring = new Dictionary<char, int>();
		int maxLen = 0;
		int start = 0;
		for(int end = 0; end < s.Length; end++) {
			if (currSubstring.ContainsKey(s[end])) {
				start = Math.Max(start, currSubstring[s[end]] + 1);
			}
			currSubstring[s[end]] = end;
			maxLen = Math.Max(maxLen, end - start + 1);
		}
		return maxLen;
    }
}

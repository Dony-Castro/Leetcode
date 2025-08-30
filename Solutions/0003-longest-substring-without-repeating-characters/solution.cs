public class Solution {
    public int LengthOfLongestSubstring(string s) {
		string subStringFound = "";
		int maxLen = 0;
		for(int i = 0; i < s.Length; i++) {
			if (subStringFound.Contains(s[i])) {
				if(subStringFound != null) {
					subStringFound = "";
				}
				s = s.Substring(1);
				i = -1;
			} else {
				subStringFound += s[i];
			}

			if (subStringFound.Length > maxLen) {
				maxLen = subStringFound.Length;
			}

		}
		return maxLen;
    }
}

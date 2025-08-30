public class Solution {
    public int LengthOfLongestSubstring(string s) {
		string[] validSubstrings = {""};
		int subStringIndex = 0;
		int maxLen = 0;
		int prevLen = 0;
		for(int i = 0; i < s.Length; i++) {
			if (validSubstrings[subStringIndex].Contains(s[i])) {
				if(validSubstrings[subStringIndex] != null) {
					Array.Resize(ref validSubstrings, validSubstrings.Length + 1);
					validSubstrings[validSubstrings.Length - 1] = "";
					subStringIndex++;
				}
				s = s.Substring(1);
				i = -1;
			} else {
				validSubstrings[subStringIndex] += s[i];
			}

			if (validSubstrings[subStringIndex].Length > prevLen) {
				prevLen = validSubstrings[subStringIndex].Length;
				maxLen = validSubstrings[subStringIndex].Length;
			}
		}
		return maxLen;
    }
}

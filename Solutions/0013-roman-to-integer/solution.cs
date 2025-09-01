public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char, int> romanMap = new Dictionary<char, int> {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000},
        };
        int total = 0;

        for(int i = 0; i < s.Length; i++) {
            total += romanMap[s[i]];
            if(i > 0) {
                if(s[i-1] == 'I' && (s[i] == 'V' || s[i] == 'X')) total -= 2;
                if(s[i-1] == 'X' && (s[i] == 'L' || s[i] == 'C')) total -= 20;
                if(s[i-1] == 'C' && (s[i] == 'D' || s[i] == 'M')) total -= 200;
            }
        }

        return total;
    }
}

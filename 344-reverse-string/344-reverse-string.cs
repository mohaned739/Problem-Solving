public class Solution {
    public void ReverseString(char[] s) {
    int i = 0;
    int back=s.Length-1;
    while( i<back)
    {
        char temp = s[i];
        s[i]=s[back];
        s[back]=temp;
        back--;
        i++;
    }
    }
}
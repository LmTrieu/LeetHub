public class Solution {
    public bool IsValid(string s) {
        Stack<int> stack = new Stack<int>();

        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == '(' || s[i] == '{' || s[i] == '[')
            {
                stack.Push(s[i]);
            }
            else if( stack.Count() == 0 || int.Abs(s[i] - stack.Peek()) > 2)
            {
                return false;
            }
            else
            {
                stack.Pop();
            }
        }
        return stack.Count() == 0;
    }
}
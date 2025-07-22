using System;
using System.Collections.Generic;

public class Program{
    public static void Main(string[] args){
        string str = "abcbcacab";
        HashSet<char> st = new HashSet<char>();

        int maxLength = 0;
        int left = 0;
        for(int right = 0; right < str.Length; right++){
            while(st.Contains(str[right])){
                st.Remove(str[left]);
                left++;
            }

            st.Add(str[right]);
            maxLength = Math.Max(maxLength, right -left +1);
        }
    Console.WriteLine(maxLength);
    }
}

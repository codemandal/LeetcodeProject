using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject
{
    public static class Atoi
    {
        public static int myAtoi(string s)
        {
           long ans = 0;
            List<char> charStack = new List<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ' && charStack.Count == 0)
                { }
                else
                {
                    if (GetValue(s[i]) >= 0)
                    {
                        charStack.Add(s[i]);
                    }
                    else
                    {
                        if (s[i] == '-' && !(charStack.Contains('-') || charStack.Contains('+')) && charStack.Count == 0)
                            charStack.Add(s[i]);
                        else if (s[i] == '+' && !(charStack.Contains('-') || charStack.Contains('+')) && charStack.Count == 0)
                            charStack.Add(s[i]);
                        else if (charStack.Count == 0)
                            return (int)ans;
                        else
                            break;

                    }                
                }
             }

            if (charStack.Count > 0)
            {
                foreach (char c in charStack)
                {
                    if (c != '-' && c != '+')
                    {
                       
                        ans = ans * 10 + GetValue(c);

                        if (  ans * -1 < int.MinValue && charStack[0] == '-' )
                        {
                            return int.MinValue;
                        }
                        else if (ans > int.MaxValue - 1 && charStack[0] != '-')
                        {
                            return int.MaxValue;
                        }
                    }
                }
                return (charStack[0] == '-') ? (int)ans * -1 : (int)ans;
            }
            else
                return (int)ans;
           

        }
        public static int myAtoiq(string s)
        {
            long ans = 0;
            bool isnegative = false;
            bool ispositive = false;
            int i = 0;
            int j = 0;
            while(i < s.Length)
            {

                if (s[0] == ' ')
                { }
                else if (s[0] == '-' && !isnegative && j == 0)
                {
                    isnegative = true;
                    j++;
                }
                else if (s[0] == '+' && !ispositive && j == 0)
                {
                    ispositive = true;
                    j++;
                }
                else
                {
                    j++;
                    if (ispositive && (s[0] == '-' || s[0] == '+'))
                        return (int)ans;
                    else if (isnegative && (s[0] == '-' || s[0] == '+'))
                        return (int)ans;
                    else if (ispositive && isnegative)
                        return (int)ans;
                    else
                    {

                        if (GetValue(s[i]) >= 0)
                        {
                            ans = ans * 10 + GetValue(s[0]);
                            if (ans * -1 < int.MinValue && isnegative)
                            {
                                return int.MinValue;
                            }
                            else if (ans > int.MaxValue - 1)
                            {
                                return int.MaxValue;
                            }
                            

                        }
                        else
                        {
                            return (int)ans;
                        }
                    }
                }

                s = s.Substring(1, s.Length-1);

            }

          

            return (isnegative) ? (int)ans * -1 : (int)ans;

        }
        public static int myAtoip(string s)
        {
            //int i = 0;
            long ans = 0;
            bool isnegative = false;
            bool ispositive = false;
            List<char> charStack = new List<char>();
            for (int i = 0; i < s.Length; i++) 
            {
                                
                if (charStack.Count == 0)
                {
                    if (s[i] == ' ')
                    { }
                    else if (s[i] == '-')
                    {
                        charStack.Add(s[i]);
                        isnegative = true;
                    }
                    else if (s[i] == '+')
                    {
                        ispositive = true;
                        charStack.Add(s[i]);
                    }
                    else
                    {
                        if (GetValue(s[i]) > 0)
                        {
                            ans = GetValue(s[i]);
                            charStack.Add(s[i]);
                        }
                        else
                            return (int)ans;
                    }

                }
                else
                {
                    if (ispositive && (s[i] == '-' || s[i] == '+'))
                        return (int)ans;
                    else if (isnegative && (s[i] == '-' || s[i] == '+'))
                        return (int)ans;
                    else {
                        if (GetValue(s[i]) >= 0)
                        {
                            if (ans * -1 < int.MinValue && isnegative)
                            {
                                return int.MinValue;
                            }
                            else if (ans > int.MaxValue - 1)
                            {
                                return int.MaxValue;
                            }
                            else
                            {
                                ans = ans * 10 + GetValue(s[i]);
                            }
                        }
                        else {
                            return (int)ans;
                        }
                                      
                    }


                }

                    
               
            }
           
            return (isnegative) ? (int)ans * -1 : (int)ans;

        }

        public static int GetValue(char c)
        {
            switch (c)
            {
                case '0':
                    return 0;
                case '1':
                    return 1;
                case '2':
                    return 2;
                case '3':
                    return 3;
                case '4':
                    return 4;
                case '5':
                    return 5;
                case '6':
                    return 6;
                case '7':
                    return 7;
                case '8':
                    return 8;
                case '9':
                    return 9;
                default:
                    return -1;

            }
        }

        public static int myAtoix(string s)
        {
            int i = 0;
            long ans = 0;
            bool isnegative = false;

            while (i < s.Length)
            {
                if (s[i] == ' ' || s[i] == '+')
                { }
                else
                {
                    if (s[i] == '-')
                    {
                        isnegative = true;
                    }
                    else
                    {

                        if (GetValue(s[i]) > 0)
                        {

                            if (ans * -1 < int.MinValue && isnegative)
                            {
                                return int.MinValue;
                            }
                            else if (ans > int.MaxValue - 1)
                                return int.MaxValue;
                            else
                            {
                                ans = ans * 10 + GetValue(s[i]);
                            }

                        }
                        else
                        {
                            //if (ans != 0)
                            return (int)ans;
                        }




                    }

                }
                i++;
            }

            return (isnegative) ? (int)ans * -1 : (int)ans;
        }


        public static int MyAtoiBest(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return 0;
            }
            var value = s.Trim();
            int sign = 1;
            if (value[0] == '-' || value[0] == '+')
            {
                sign = value[0] == '-' ? -1 : 1;
                value = value.Substring(1);
            }

            var valid = new List<string>() { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            var numberString = "";
            var startedNumber = false;
            foreach (var c in value)
            {
                if (valid.Contains(c.ToString()))
                {
                    if (c == '0' && !startedNumber)
                        continue;
                    startedNumber = true;
                    numberString += c;
                }
                else
                {
                    break;
                }
            }
            if (numberString.Length == 0)
            {
                return 0;
            }
            if (numberString.Length > 10)
            {
                if (sign > 0)
                    return int.MaxValue;
                else
                    return int.MinValue;
            }
            if (numberString.Length == 10)
            {
                if (compareToMaxInt(numberString))
                {
                    if (sign > 0)
                        return int.MaxValue;
                    else
                        return int.MinValue;
                }
            }

            return sign * int.Parse(numberString);

        }

        private static bool compareToMaxInt(string numberString)
        {
            var maxInt = int.MaxValue.ToString();
            var diff = 0;
            for (int i = 0; i < 10; i++)
            {
                diff = maxInt[i] - numberString[i];
                if (diff < 0)
                    return true;
                else if (diff >= 1)
                    return false;
            }
            return false;
        }
    }



}

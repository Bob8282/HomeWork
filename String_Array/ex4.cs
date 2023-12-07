namespace TryTo_00
{
    public class TryTo
    {
        public static string[] Str(string stringSource)
        {
            int count = 1;
            for (int i = 0; i < stringSource.Length; i++)
            {
                if (stringSource[i] == ' ')
                {
                    count += 1;
                }
            }
            string[] strArr = new string[count];

            string sign = string.Empty;
            int j = 0;
            for (int i = 0; i < count; i++)
            {
                for (j = 0; j < stringSource.Length; j++)
                {
                    // while (stringSource[j] != stringSource[stringSource.Length - 1])
                    
                    if (stringSource[j] != ' ')
                        {
                            sign = sign + stringSource[j];
                        }
                    else
                    {
                        strArr[i] = sign;
                        

                        if (sign != string.Empty)
                        {
                            sign = string.Empty;
                            continue;
                        }
                    }
                    if (j == stringSource.Length-1)
                        strArr[i] = sign;
                    
                }
                
            }
            return strArr;        
        }
    }
}
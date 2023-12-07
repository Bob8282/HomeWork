namespace TryTo_00
{
    public class TryTo
    {

        // с использованием Split 
        public static string StringReverse(string stringSource)
        {
            string[] array = stringSource.Split(" ");
            string revStr = string.Empty;
            string sign = string.Empty;
            for (int i = 0, j = array.Length-1; i < array.Length/2; i++, j--)
            {
                    sign = array[i];
                    array[i] = array[j];
                    array[j] = sign;
            }
            revStr = String.Join(" ", array); 
            return revStr;
        }      



        // попытка без Splita
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
            // for (int i = 0; i < count; i++)
            // {
                for (int j = 0; j < stringSource.Length; j++)
                {
                    //while (stringSource[j] != ' ')
                    
                    if (stringSource[j] != ' ')
                    {
                        strArr[i] += stringSource[j];                   
                    }
                    else continue;  
                
                    
                }
                return strArr;
        }
                    
        }
    }
}
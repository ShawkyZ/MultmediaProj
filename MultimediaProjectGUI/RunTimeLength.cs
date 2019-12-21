namespace MultimediaProjectGUI
{
    public static class RunTimeLength
    {
        public static string Encode(string raw)
        {
            var encodedString = string.Empty;
            var count = 1;
            for (int i = 0; i < raw.Length; i++)
            {
                if (i < raw.Length - 1 && raw[i] != raw[i + 1])
                {
                    encodedString += raw[i].ToString() + count;
                    count = 1;
                    continue;
                }

                count++;
            }

            encodedString += raw[raw.Length - 1].ToString() + (count - 1);
            return encodedString;
        }

        public static string Decode(string encodedString)
        {
            var currentChar = ' ';
            var decodedString = string.Empty;
            for (var i = 0; i < encodedString.Length; i++)
            {
                if (int.TryParse(encodedString[i].ToString(), out var num))
                {
                    for (var j = 0; j < num; j++)
                    {
                        decodedString += currentChar.ToString();
                    }
                }
                else
                {
                    currentChar = encodedString[i];
                }
            }

            return decodedString;
        }
    }
}
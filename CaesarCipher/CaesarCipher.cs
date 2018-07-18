using System;
using System.Linq;

namespace CaesarCipher
{
    public static class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
        {
            char[] textArray = text.ToCharArray();
            for(int i=0;i<textArray.Length;i++)
            {
                if (Convert.ToInt32(textArray[i]) >= 65 && Convert.ToInt32(textArray[i]) <= 90)
                {
                    CaesarCipherRotate(shiftKey, textArray, i, 90);
                }
                else if(Convert.ToInt32(textArray[i]) >= 97 && Convert.ToInt32(textArray[i]) <= 122)
                {
                    CaesarCipherRotate(shiftKey, textArray, i,122);
                }
            }
            String cipherText = new String(textArray);
            return cipherText;
        }

        private static void CaesarCipherRotate(int shiftKey, char[] textArray, int i,int upperLimit)
        {
            if (Convert.ToInt32(textArray[i]) + shiftKey > upperLimit)
                textArray[i] = (char)(Convert.ToInt32(textArray[i]) + shiftKey - 26);
            else
                textArray[i] = (char)(Convert.ToInt32(textArray[i]) + shiftKey);
        }
    }
}

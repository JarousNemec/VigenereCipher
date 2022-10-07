using System;
using System.ComponentModel;
using System.Text;

namespace VigenerCipher
{
    public class VigenereCipherProcessor
    {
        public char[,] GenerateVigenerSquare(int startChar, int endChar)
        {
            var size = endChar - startChar;
            var square = new char[size, size];
            for (var i = 0; i < size; i++)
            {
                for (var j = 0; j < size; j++)
                {
                    square[i, j] = (char)((j + i) % size + startChar);
                }
            }

            return square;
        }

        public string EncodeFromSquare(char[,] square, string text, string key)
        {
            StringBuilder sb = new StringBuilder();
            if (!CheckIfCharCanBeEncoded(square, text))
                return null;
            for (var i = 0; i < text.Length; i++)
            {
                var row = 0;
                for (int j = square[0, 0]; j <= key[i % key.Length]; j++)
                {
                    row = j;
                }

                var column = 0;
                for (int j = square[0, 0]; j <= text[i]; j++)
                {
                    column = j;
                }

                row -= square[0, 0];
                column -= square[0, 0];

                sb.Append(square[row, column]);
            }

            return sb.ToString();
        }

        public string DecodeFromSquare(char[,] square, string cipher, string key)
        {
            StringBuilder sb = new StringBuilder();
            for (var i = 0; i < cipher.Length; i++)
            {
                var row = 0;
                for (int j = square[0, 0]; j <= key[i % key.Length]; j++)
                {
                    row = j;
                }

                row -= square[0, 0];
                var column = 0;
                for (var j = 0; j < square.GetLength(1); j++)
                {
                    if (square[row, j] == cipher[i])
                    {
                        column = j;
                        break;
                    }
                }

                sb.Append(square[0, column]);
            }

            return sb.ToString();
        }

        public string EncodeByMath(string text, string key, char startChar)
        {
            StringBuilder sb = new StringBuilder();
            for (var i = 0; i < text.Length; i++)
            {
                sb.Append((char)(text[i] + (key[i % key.Length] - startChar)));
            }

            return sb.ToString();
        }

        public string DecodeByMath(string cipher, string key, char startChar)
        {
            StringBuilder sb = new StringBuilder();
            for (var i = 0; i < cipher.Length; i++)
            {
                sb.Append((char)(cipher[i] - (key[i % key.Length] - startChar)));
            }

            return sb.ToString();
        }

        private bool CheckIfCharCanBeEncoded(char[,] square, string text)
        {
            foreach (var t in text)
            {
                if (t < square[0, 0] || t > square[0, square.GetLength(1) - 1])
                    return false;
            }
            return true;
        }
    }
}
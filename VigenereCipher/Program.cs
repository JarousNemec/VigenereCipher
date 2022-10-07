﻿using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace VigenerCipher
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            VigenereCipherProcessor processor = new VigenereCipherProcessor();
            var square = processor.GenerateVigenerSquare(65, 91);
            var encoded = processor.EncodeFromSquare(square,
                "ADJVCOAJVOJJJKJKDDDDDADJVCOAJVOJJJKJKDDDDDADJVCOAJVOJJJKJKDDDDDADJVCOAJVOJJJKJKDDDDDADJVCOAJVOJJJKJKDDDDDADJVCOAJVOJJJKJKDDDDDADJVCOAJVOJJJKJKDDDDDADJVCOAJVOJJJKJKDDDDDADJVCOAJVOJJJKJKDDDDDADJVCOAJVOJJJKJKDDDDDADJVCOAJVOJJJKJKDDDDDADJVCOAJVOJJJKJKDDDDDADJVCOAJVOJJJKJKDDDDDADJVCOAJVOJJJKJKDDDDDADJVCOAJVOJJJKJKDDDDDADJVCOAJVOJJJKJKDDDDDADJVCOAJVOJJJKJKDDDDDADJVCOAJVOJJJKJKDDDDDADJVCOAJVOJJJKJKDDDDDADJVCOAJVOJJJKJKDDDDDADJVCOAJVOJJJKJKDDDDDADJVCOAJVOJJJKJKDDDDDADJVCOAJVOJJJKJKDDDDDADJVCOAJVOJJJKJKDDDDDADJVCOAJVOJJJKJKDDDDDADJVCOAJVOJJJKJKDDDDD",
                "ABC");
            var encoded2 = processor.EncodeByMath(
                "ADJVCOAJVOJJJKJKDDDDDADJVCOAJVOJJJKJKDDDDDADJVCOAJVOJJJKJKDDDDDADJVCOAJVOJJJKJKDDDDDADJVCOAJVOJJJKJKDDDDDADJVCOAJVOJJJKJKDDDDDADJVCOAJVOJJJKJKDDDDDADJVCOAJVOJJJKJKDDDDDADJVCOAJVOJJJKJKDDDDDADJVCOAJVOJJJKJKDDDDDADJVCOAJVOJJJKJKDDDDDADJVCOAJVOJJJKJKDDDDDADJVCOAJVOJJJKJKDDDDDADJVCOAJVOJJJKJKDDDDDADJVCOAJVOJJJKJKDDDDDADJVCOAJVOJJJKJKDDDDDADJVCOAJVOJJJKJKDDDDDADJVCOAJVOJJJKJKDDDDDADJVCOAJVOJJJKJKDDDDDADJVCOAJVOJJJKJKDDDDDADJVCOAJVOJJJKJKDDDDDADJVCOAJVOJJJKJKDDDDDADJVCOAJVOJJJKJKDDDDDADJVCOAJVOJJJKJKDDDDDADJVCOAJVOJJJKJKDDDDDADJVCOAJVOJJJKJKDDDDD",
                "ABC", 'A');
            var decode = processor.DecodeFromSquare(square,
                "AELVDQAKXOKLJLLKEFDEFAELVDQAKXOKLJLLKEFDEFAELVDQAKXOKLJLLKEFDEFAELVDQAKXOKLJLLKEFDEFAELVDQAKXOKLJLLKEFDEFAELVDQAKXOKLJLLKEFDEFAELVDQAKXOKLJLLKEFDEFAELVDQAKXOKLJLLKEFDEFAELVDQAKXOKLJLLKEFDEFAELVDQAKXOKLJLLKEFDEFAELVDQAKXOKLJLLKEFDEFAELVDQAKXOKLJLLKEFDEFAELVDQAKXOKLJLLKEFDEFAELVDQAKXOKLJLLKEFDEFAELVDQAKXOKLJLLKEFDEFAELVDQAKXOKLJLLKEFDEFAELVDQAKXOKLJLLKEFDEFAELVDQAKXOKLJLLKEFDEFAELVDQAKXOKLJLLKEFDEFAELVDQAKXOKLJLLKEFDEFAELVDQAKXOKLJLLKEFDEFAELVDQAKXOKLJLLKEFDEFAELVDQAKXOKLJLLKEFDEFAELVDQAKXOKLJLLKEFDEFAELVDQAKXOKLJLLKEFDEFAELVDQAKXOKLJLLKEFDEF",
                "ABC");
            var decode2 = processor.DecodeByMath(
                "AELVDQAKXOKLJLLKEFDEFAELVDQAKXOKLJLLKEFDEFAELVDQAKXOKLJLLKEFDEFAELVDQAKXOKLJLLKEFDEFAELVDQAKXOKLJLLKEFDEFAELVDQAKXOKLJLLKEFDEFAELVDQAKXOKLJLLKEFDEFAELVDQAKXOKLJLLKEFDEFAELVDQAKXOKLJLLKEFDEFAELVDQAKXOKLJLLKEFDEFAELVDQAKXOKLJLLKEFDEFAELVDQAKXOKLJLLKEFDEFAELVDQAKXOKLJLLKEFDEFAELVDQAKXOKLJLLKEFDEFAELVDQAKXOKLJLLKEFDEFAELVDQAKXOKLJLLKEFDEFAELVDQAKXOKLJLLKEFDEFAELVDQAKXOKLJLLKEFDEFAELVDQAKXOKLJLLKEFDEFAELVDQAKXOKLJLLKEFDEFAELVDQAKXOKLJLLKEFDEFAELVDQAKXOKLJLLKEFDEFAELVDQAKXOKLJLLKEFDEFAELVDQAKXOKLJLLKEFDEFAELVDQAKXOKLJLLKEFDEFAELVDQAKXOKLJLLKEFDEF",
                "ABC", 'A');
        }
    }
}
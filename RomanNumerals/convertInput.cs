﻿using System;using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;using RomanNumerals.Conversions;namespace RomanNumerals{    public class ConvertInput    {        public string ConvertNumberToRomanNumeral(int number)         {            //Dictionary<int, string> NumToRoman = new Dictionary<int, string>()            //{            //    { 1, "I" },            //    { 5, "V" },            //    { 10, "X" },            //    { 50, "L" },            //    { 100, "C" }            //    //{ 1, "I" },            //    //{ 1, "I" },            //};            string result1 = "";            string result2 = "";            string result3 = "";            string result4 = "";            string numberToCompare = number.ToString();            for (int i = 1; i <= numberToCompare.Length; i++)            {                if (i == 1) // 1 digit, 0-9                {                    var Convert_1_to_9 = new Convert_1_to_9();                    string toBeConverted = "";                    toBeConverted = numberToCompare[numberToCompare.Length-1].ToString();                    result1 = Convert_1_to_9.ConvertIt(toBeConverted);                }                else if (i == 2) // 2 digits, 10-99                {                    var Convert_10_to_99 = new Convert_10_to_99();                    string toBeConverted = "";                    toBeConverted = numberToCompare[numberToCompare.Length - 2].ToString();                    result2 = Convert_10_to_99.ConvertIt(toBeConverted);                }                else if (i == 3) // 3 digits, 100-999                {                    var Convert_100_to_999 = new Convert_100_to_999();                    string toBeConverted = "";                    toBeConverted = numberToCompare[numberToCompare.Length - 3].ToString();                    result3 = Convert_100_to_999.ConvertIt(toBeConverted);                }                else if (i == 4) // 4 digits, 1000-3999 (4000+ is subject to different rules)
                {                    var Convert_1000_to_3999 = new Convert_1000_to_3999();                    string toBeConverted = "";                    toBeConverted = numberToCompare[numberToCompare.Length - 4].ToString();                    result4 = Convert_1000_to_3999.ConvertIt(toBeConverted);                }            }            return (result4 + result3 + result2 + result1);        }    }}
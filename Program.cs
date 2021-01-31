using System;
using System.Collections.Generic;
using System.IO;

namespace CSV_Convertor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<SomeObject> listOne = new List<SomeObject>();
            List<SomeOtherObject> listTwo = new List<SomeOtherObject>();

            listOne.Add(new SomeObject{ IntPropOne = 5, IntPropTwo = 167, FloatPropOne = 23.6f, FloatPropTwo = 136.1f, StringPropOne = "dgsdgt", StringPropTwo = "dhsdsh" });
            listOne.Add(new SomeObject { IntPropOne = 563, IntPropTwo = 7537, FloatPropOne = 472.1f, FloatPropTwo = 15.15f, StringPropOne = "fsda", StringPropTwo = "fsa" });
            listOne.Add(new SomeObject { IntPropOne = 1, IntPropTwo = 7, FloatPropOne = 34.77f, FloatPropTwo = 5633.1f, StringPropOne = "dgsdghadft", StringPropTwo = "v" });
            listOne.Add(new SomeObject { IntPropOne = 75, IntPropTwo = 768, FloatPropOne = 435.98f, FloatPropTwo = 136.144f, StringPropOne = "ss", StringPropTwo = "dhscsacdsh" });
            listOne.Add(new SomeObject { IntPropOne = 6554, IntPropTwo = 11, FloatPropOne = 99.6f, FloatPropTwo = 5776.2f, StringPropOne = "gdsg", StringPropTwo = "aacf" });

            listTwo.Add(new SomeOtherObject { OtherIntPropOne = 73, OtherIntPropTwo = 43, OtherFloatPropOne = 773.98f, OtherFloatPropTwo = 114.535f, OtherStringPropOne = "shsds", OtherStringPropTwo = "gdhsdsh" });
            listTwo.Add(new SomeOtherObject { OtherIntPropOne = 5734, OtherIntPropTwo = 7, OtherFloatPropOne = 3753.75f, OtherFloatPropTwo = 15.5243f, OtherStringPropOne = "jnmh", OtherStringPropTwo = "fsdasa" });
            listTwo.Add(new SomeOtherObject { OtherIntPropOne = 4, OtherIntPropTwo = 863, OtherFloatPropOne = 787.77f, OtherFloatPropTwo = 53.144f, OtherStringPropOne = "ahadft", OtherStringPropTwo = "asgfvsd" });
            listTwo.Add(new SomeOtherObject { OtherIntPropOne = 44, OtherIntPropTwo = 174, OtherFloatPropOne = 11.3f, OtherFloatPropTwo = 783.74f, OtherStringPropOne = "sgdg", OtherStringPropTwo = "dhbndccdsh" });
            listTwo.Add(new SomeOtherObject { OtherIntPropOne = 135, OtherIntPropTwo = 366, OtherFloatPropOne = 869.13f, OtherFloatPropTwo = 1276.27f, OtherStringPropOne = "gdsgdgsg", OtherStringPropTwo = "dsgdf" });

            string path = Directory.GetCurrentDirectory();

            string CSV1 = CSVConvertor<SomeObject>.ConvertAndWriteToFile(listOne, string.Format(@"{0}\csv_result1.csv", path));
            Console.Write(CSV1);
            Console.WriteLine();

            string CSV2 = CSVConvertor<SomeOtherObject>.ConvertAndWriteToFile(listTwo, string.Format(@"{0}\csv_result2.csv", path));
            Console.Write(CSV2);

            Console.ReadLine();
        }
    }
}

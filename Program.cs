using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {

            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            string str3 = Console.ReadLine();
            string[] str1detail = str1.Split(' ');
            string[] str2detail = str2.Split(' ');
            string[] str3detail = str3.Split(' ');
            int[] line1 = chooseMethod(str1detail[1], int.Parse(str1detail[0]));
            Console.WriteLine(str1 + " $" + (line1[0]*2.99+line1[1]*4.49));
            int[] ham = { 3, 5 };
            double[] hamprice = { 2.99, 4.49 };
            for(int i = 0; i < line1.Length; i++)
            {
                if(line1[i] != 0)
                {
                    Console.WriteLine("  "+ line1[i] +" * " + ham[i] + " $"+ hamprice[i]);
                }
            }
            int[] line2 = chooseMethod(str2detail[1], int.Parse(str2detail[0]));
            Console.WriteLine(str2 + " $ " + (line2[0] * 4.95 + line2[1] * 9.95 + line2[2] * 13.95));
            int[] yoghurt = {4, 10, 15};
            double[] yoghurtprice = {4.95, 9.95, 13.95};
            for (int i = 0; i < line2.Length; i++)
            {
                if (line2[i] != 0)
                {
                    Console.WriteLine("  " + line2[i] + " * " + yoghurt[i] + " $" + yoghurtprice[i]);
                }
            }
            int[] toiletrolls = {3, 5, 9};
            double[] toiletrollsPrice = { 2.95, 4.45, 7.99 };
            int[] line3 = chooseMethod(str3detail[1], int.Parse(str3detail[0]));
            Console.WriteLine(str3 + " $" + (line3[0] * 2.95 + line3[1] * 4.45 + line3[2] * 7.99));
            for (int i = 0; i < line2.Length; i++)
            {
                if (line3[i] != 0)
                {
                    Console.WriteLine("  " + line3[i] + " * " + toiletrolls[i] + " $" + toiletrollsPrice[i]);
                }
            }
        }

        static int[] chooseMethod(string name, int total)
        {
            if (name.Equals("SH3")){
                return slicedHam(total);
            }else if (name.Equals("YT2"))
            {
                return yoghurt(total);
            }
            else{
                return toiletRolls(total);
            }
        }

        static int[] slicedHam(int total)
        {
            int[] result = new int[2];
            result[1] = total / 5;
            int rest = total % 5;
            if (rest == 1){
                result[0] = 2;
                result[1]--;
            }else if (rest == 2){
                result[0] = 4;
                result[1] -= 2;
            }else if (rest == 3){
                result[0] = 1;
            }else if (rest == 4){
                result[0] = 3;
                result[1]--;
            }else{
                result[0] = 0;
            }

            return result;
        }

        static int[] yoghurt(int total)
        {
            int[] result = new int[3];
            int temp5 = total / 5;
            int rest = total % 5;
            if (rest == 1){
                result[0] = 4;
                temp5 -= 3;
            }else if (rest == 2){
                result[0] = 3;
                temp5 -= 2;
            }else if (rest == 3){
                result[0] = 2;
                temp5--;
            }else if (rest == 4){
                result[0] = 1;
            }else{
                result[0] = 0;
            }
            result[2] = temp5 / 3;
            if(temp5%3 == 1){
                result[1] = 2;
                result[2]--;
            }else if(temp5%3 == 2){
                result[1] = 1;
            }
            return result;
        }

        static int[] toiletRolls(int total)
        {
            int[] result = new int[3];
            int temp3 = total / 3;
            int rest = total % 3;
            if (rest == 1){
                result[1] = 2;
                temp3 -= 3;
            }else if (rest == 2){
                result[0] = 1;
                temp3 -= 1;
            }else{
                result[1] = 0;
            }
            result[2] = temp3 / 3;
            if (temp3 % 3 == 1){
                result[0] = 1;
            }else if (temp3 % 3 == 2)
            {
                result[2] -= 1;
                result[1] += 3;
                result[0] = 0;
            }
            return result;
        }
    }
}

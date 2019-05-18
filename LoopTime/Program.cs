using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Testing Loop Speed";

            MyStopwatch sw = new MyStopwatch();
            sw.Start();
            for (int i = 0; i < 5000; i++) Console.WriteLine(i);
            sw.Stop();

            MyStopwatch sw1 = new MyStopwatch();
            int[] array = Enumerable.Range(0, 5000).ToArray();
            sw1.Start();
            for (int i = 0; i < array.Length; i++) Console.WriteLine(array[i]);
            sw1.Stop();

            MyStopwatch sw2 = new MyStopwatch();
            var arrList = array.ToList();
            sw2.Start();
            for (int i = 0; i < arrList.Count; i++) Console.WriteLine(arrList[i]);
            sw2.Stop();

            //Now foreach loop

            MyStopwatch sw3 = new MyStopwatch();
            sw3.Start();
            foreach (var arr in array) Console.WriteLine(arr);
            sw3.Stop();

            MyStopwatch sw4 = new MyStopwatch();
            sw4.Start();
            foreach (var arr in arrList) Console.WriteLine(arr);
            sw4.Stop();

            MyStopwatch sw5 = new MyStopwatch();
            sw5.Start();
            int j = 0;
            while (j != array.Length) Console.WriteLine(array[j++]);
            sw5.Stop();

            MyStopwatch sw6 = new MyStopwatch();
            sw6.Start();
            j = 0;
            while (j != arrList.Count) Console.WriteLine(arrList[j++]);
            sw6.Stop();

            Console.WriteLine($"for loop- time elapsed: {sw.ElapsedMilliseconds} Milliseconds, StartAt: {sw.StartAt.Value}, EndAt: {sw.EndAt.Value}");
            Console.WriteLine($"for loop on array- time elapsed: {sw1.ElapsedMilliseconds} Milliseconds, StartAt: {sw1.StartAt.Value}, EndAt: {sw1.EndAt.Value}");
            Console.WriteLine($"for loop on list- time elapsed: {sw2.ElapsedMilliseconds} Milliseconds, StartAt: {sw2.StartAt.Value}, EndAt: {sw2.EndAt.Value}");
            Console.WriteLine($"foreach on array- time elapsed: {sw3.ElapsedMilliseconds} Milliseconds, StartAt: {sw3.StartAt.Value}, EndAt: {sw3.EndAt.Value}");
            Console.WriteLine($"foreach on list- time elapsed: {sw4.ElapsedMilliseconds} Milliseconds, StartAt: {sw4.StartAt.Value}, EndAt: {sw4.EndAt.Value}");
            Console.WriteLine($"while loop on array- time elapsed: {sw5.ElapsedMilliseconds} Milliseconds, StartAt: {sw5.StartAt.Value}, EndAt: {sw5.EndAt.Value}");
            Console.WriteLine($"while loop on list- time elapsed: {sw6.ElapsedMilliseconds} Milliseconds, StartAt: {sw6.StartAt.Value}, EndAt: {sw6.EndAt.Value}");

            Console.ReadKey();


        }
    }
}

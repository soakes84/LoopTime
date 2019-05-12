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

            //Now for each loop

            MyStopwatch sw3 = new MyStopwatch();
            sw3.Start();
            foreach (var arr in array) Console.WriteLine(arr);
            sw3.Stop();

            MyStopwatch sw4 = new MyStopwatch();
            sw4.Start();
            foreach (var arr in arrList) Console.WriteLine(arr);
            sw4.Stop();

            Console.WriteLine($"for loop- time elapsed: {sw.ElapsedMilliseconds} Milliseconds, StartAt: {sw.StartAt.Value}, EndAt: {sw.EndAt.Value}");
            Console.WriteLine($"for loop on array- time elapsed: {sw1.ElapsedMilliseconds} Milliseconds, StartAt: {sw1.StartAt.Value}, EndAt: {sw1.EndAt.Value}");
            Console.WriteLine($"for loop on list- time elapsed: {sw2.ElapsedMilliseconds} Milliseconds, StartAt: {sw2.StartAt.Value}, EndAt: {sw2.EndAt.Value}");
            Console.WriteLine($"for each on array- time elapsed: {sw3.ElapsedMilliseconds} Milliseconds, StartAt: {sw3.StartAt.Value}, EndAt: {sw3.EndAt.Value}");
            Console.WriteLine($"for each on list- time elapsed: {sw4.ElapsedMilliseconds} Milliseconds, StartAt: {sw4.StartAt.Value}, EndAt: {sw4.EndAt.Value}");
            Console.ReadKey();


        }
    }
}

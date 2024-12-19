using System;

namespace practice.DataTypes
{
    public class dataTypes
    {
        public int a;
        public double b;
        public sbyte c;
        public byte d;
        public short e;
        public ushort f;
        public uint g;
        public long h;
        public ulong i;
        public float j;
        public decimal k;
        public bool l;
        public char m;
        public DateTime n;
        public string s;
        //public var o;
        public dataTypes()
        {
            a = 10;
            b = 3.14;
            c = 5;
            d = 10;
            e = 1000;
            f = 2000;
            g = 4000;
            h = 50000;
            i = 60000;
            j = 1.23f;
            k = 123.45m;
            l = true;
            m = 'A';
            n = DateTime.Now;
        }
        public void checkdatatypes()
        {

            s = "test";
            object[] variables = { a, b, c, d, e, f, g, h, i, j, k, l, m ,n ,s};
            foreach (var variable in variables)
            {
                try
                {
                    Console.WriteLine($"Variable type: {variable.GetType()}, Value: {variable}");
                }catch (Exception ex) 
                { 
                    Console.WriteLine(ex.ToString()); 
                }
            }
            var v = true;
            var w = 20;
            var x = "bceuwf"; 
            var y = 'a';
            var z = 10.110;
            Console.WriteLine($"\n\n Variable type: {v.GetType()}, Value: {v}");
            Console.WriteLine($"Variable type: {w.GetType()}, Value: {w}");
            Console.WriteLine($"Variable type: {x.GetType()}, Value: {x}");
            Console.WriteLine($"Variable type: {y.GetType()}, Value: {y}");
            Console.WriteLine($"Variable type: {z.GetType()}, Value: {z}");
        }

    }
}

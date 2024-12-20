using System;

//namespace practice.dataTypes
//{
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

        public dataTypes()
        {
            s = "test";
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
        public dataTypes(int sample)
        {
            a = new int();        // Default value is 0
            b = new double();     // Default value is 0.0
            c = new sbyte();      // Default value is 0
            d = new byte();       // Default value is 0
            e = new short();      // Default value is 0
            f = new ushort();     // Default value is 0
            g = new uint();       // Default value is 0
            h = new long();       // Default value is 0
            i = new ulong();      // Default value is 0
            j = new float();      // Default value is 0.0f
            k = new decimal();    // Default value is 0.0
            l = new bool();       // Default value is false
            m = new char();       // Default value is '\0' (null character)
            n = new DateTime();   // Default value is DateTime.MinValue (January 1, 0001 at 00:00:00.000)
            s = new string(' ');  // Default value is empty string (new string for initialization)
        }
        public void checkdatatypes()
        {

            
            object[] variables = { a, b, c, d, e, f, g, h, i, j, k, l, m ,n };
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
        public static void strBehaviour()
        {
            string str = "sample";
            var varr = new[] { 'a', 'b', 'c' };
            var strarr = new[] { "str1", "str2" };
            // data type [] (Array)
            Console.WriteLine($"Variable type: {str.GetType()} , Value: {str}");
            Console.WriteLine($"Variable type: {varr.GetType()}, Value: {varr}");
            Console.WriteLine($"Variable type: {strarr.GetType()}, Value: {strarr}");
            var vstr = "var string ";
            Console.WriteLine($"Variable type: {vstr.GetType()}, Value: {vstr}");

            // use of @ in string to escape charecters in string 
            string str1 = "a\\a\\";
            string str2 = @"a\a\";
            if (str1 == str2)
            {
                Console.WriteLine($"str1 : {str1}   str2: {str2}");
            }
            else
            {
                Console.WriteLine("String are not equal !");
            }
            // use of @ in multipline string " escape "" 
            string str3 = @"Here's something 
                on a new line! ""Wow!"" done ";
            Console.WriteLine(str3 );

        }
        public static void parseVsTryParse()
        {
            string str1 = "1234";
            string invalide = "hello";
            string fnum = "123.564";
            string b = "true";
            string test = "0.6438";
            int num = 0;
            Console.WriteLine($" str1 : {str1} after parse to int : {int.Parse(str1)}");
            Console.WriteLine($" invalide string  : {invalide} after TryParse to int status : {int.TryParse(invalide,out num)}  parse valuse : {num}");
            //Console.WriteLine($" float number  : {fnum} after parse to int : {int.Parse(invalide)}");
            //Console.WriteLine($" bool  : {b} after parse to int : {int.Parse(invalide)}");
            //Console.WriteLine($" test : {test} after parse to int : {int.Parse(invalide)}");

            Console.WriteLine($" float number  : {fnum} after TryParse to int status : {int.TryParse(fnum, out num)}  parse valuse : {num}");
            Console.WriteLine($" bool  : {b} after TryParse to int status : {int.TryParse(b, out num)}  parse valuse : {num}");
            Console.WriteLine($" test : {test} after TryParse to int status : {int.TryParse(test, out num)}  parse valuse : {num}");
        }

    }
//}

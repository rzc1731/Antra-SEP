// See https://aka.ms/new-console-template for more information

string[] names = { "sbyte", "byte", "short", "ushort", "int", "uint", "long", "ulong","float", 
    "double", "decimal" };
byte[] bytes = { 1,1,2,2,4,4,8,8,8,16,32 };
string[] minimums = {"0", "-128", "-32768", "0", "-2147483648", "0", "-9223372036854775808", 
    "0", "-3.40282347E+38", "-1.7976931348623157E+308", "-7.9228E+28" };
string[] maximums = { "255", "127", "32767", "65535", "2147483647", "4294967295", "9223372036854775807", 
    "18446744073709551615", "3.40282347E+38", "1.7976931348623157E+308", "7.9228e28" };

Console.WriteLine("{0,-20} {1,-20} {2,-30} {3,-30}\n", "Name", "Bytes", "Minimums", "Maximums");
for (int ctr = 0; ctr < names.Length; ctr++)
    Console.WriteLine("{0,-20} {1,-20} {2,-30} {3,-30}", names[ctr], bytes[ctr], minimums[ctr], maximums[ctr]);

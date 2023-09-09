internal class Program
{
    public static void Main(string[] args)
    {
        string degisken="C-sharp dersimize hosgeldiniz!";
        string degisken2="C-sharp";

        //Length
        Console.WriteLine(degisken.Length);
        Console.WriteLine(degisken2.Length);

        //ToUpper, ToLower
        Console.WriteLine(degisken.ToUpper());
        Console.WriteLine(degisken.ToLower());

        //Concat
        Console.WriteLine(string.Concat(degisken,"c-sharp kodlari:"));

        //Compare, CompareTo
        Console.WriteLine(degisken.CompareTo(degisken2));//0,1,-1
        Console.WriteLine(string.Compare(degisken,degisken2,true));
        Console.WriteLine(string.Compare(degisken,degisken2,false));

        //Contains
        Console.WriteLine(degisken.Contains(degisken2));
        Console.WriteLine(degisken.EndsWith("hosgeldiniz!"));
        Console.WriteLine(degisken2.StartsWith("merhaba"));

        //IndexOf
        Console.WriteLine(degisken.IndexOf("C-sharp"));
        Console.WriteLine(degisken.IndexOf("aysegul"));
        Console.WriteLine(degisken.LastIndexOf("i"));

        //Insert
        Console.WriteLine(degisken.Insert(0,"Merhaba!"));

        //PadLeft, PadRight
        Console.WriteLine(degisken+degisken2.PadLeft(40));
        Console.WriteLine(degisken+degisken2.PadLeft(40,'#'));
        Console.WriteLine(degisken.PadRight(50)+degisken2);
        Console.WriteLine(degisken.PadRight(50,'*')+degisken2);

        //Remove
        Console.WriteLine(degisken.Remove(10));
        Console.WriteLine(degisken.Remove(5,3));
        Console.WriteLine(degisken.Remove(0,1));

        //Replace
        Console.WriteLine(degisken.Replace("C-sharp","C#"));
        Console.WriteLine(degisken.Replace(" ","-"));

        //Split
        Console.WriteLine(degisken.Split(' ')[1]);

        //Substring
        Console.WriteLine(degisken.Substring(4));
        Console.WriteLine(degisken.Substring(4,6));
    }
}
class Program
{
    static void Main()
    {
        double angleRad;
        double func;

        // for (double angleDeg = 0; angleDeg <= 180; angleDeg += 10)
        // {
        //     angleRad = angleDeg * Math.PI / 180.0;
        //     func = Math.Cos(angleRad);

        //     Console.WriteLine($"{angleDeg,4} {angleRad,5:F2} {func,12:F4}");
        // }

        // double angleDeg = 0;
        // while (angleDeg <= 180)
        // {
        //     angleRad = angleDeg * Math.PI / 180.0;
        //     func = Math.Cos(angleRad);
        //     angleDeg += 10;

        //     Console.WriteLine($"{angleDeg,4} {angleRad,5:F2} {func,12:F4}");
        // }

        double angleDeg = 0;
        do
        {
            angleRad = angleDeg * Math.PI / 180.0;
            func = Math.Cos(angleRad);
            angleDeg += 10;

            Console.WriteLine($"{angleDeg,4} {angleRad,5:F2} {func,12:F4}");
        } while (angleDeg <= 180);
    }
}
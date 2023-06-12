// See https://aka.ms/new-console-template for more information
using uniffi.rust_lib;

Console.WriteLine("Example 1:");
Console.WriteLine("");

var svgCode = RustLibMethods.GenerateQrCodeSvg("https://strathweb.com");
Console.WriteLine(svgCode);
Console.WriteLine("");
Console.WriteLine("");

Console.WriteLine("Example 2:");
Console.WriteLine("");

var qrCode = RustLibMethods.EncodeText("https://strathweb.com", QrCodeEcc.MEDIUM);
PrintQr(qrCode);

static void PrintQr(QrCode qr)
{
    int border = 4;
    for (int y = -border; y < qr.Size() + border; y++)
    {
        for (int x = -border; x < qr.Size() + border; x++)
        {
            char c = qr.GetModule(x, y) ? '█' : ' ';
            Console.Write($"{c}{c}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
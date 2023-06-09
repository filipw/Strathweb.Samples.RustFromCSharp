// See https://aka.ms/new-console-template for more information
using uniffi.rust_lib;

var code = RustLibMethods.GenerateQrCode("https://strathweb.com");
Console.WriteLine(code);
using System.Reflection;
var asm = Assembly.LoadFrom(@"C:\Users\marco\.nuget\packages\openmeteo.dotnet.client.sdk\5.8.2\lib\net8.0\OpenMeteo.dll");
foreach (var t in asm.GetExportedTypes().OrderBy(t => t.FullName)) Console.WriteLine(t.FullName);

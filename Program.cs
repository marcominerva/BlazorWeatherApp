using System.Reflection;
var t = typeof(OpenMeteo.Weather.Forecast.Options.CurrentOptions);
foreach (var c in t.GetConstructors())
{
    var ps = c.GetParameters();
    Console.WriteLine($"Ctor({ps.Length}):");
    foreach (var p in ps) Console.WriteLine($"  {p.ParameterType} {p.Name} isParams={p.IsDefined(typeof(ParamArrayAttribute))}");
}

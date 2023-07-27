Mapperly is a .NET source generator for generating object mappings

Because Mapperly creates the mapping code at build time, there is minimal overhead at runtime.
Even better, the generated code is perfectly readable, allowing you to verify the generated mapping code easily.

Mapperly works by using .NET Source Generators.
Since no reflection is used at runtime, the generated code is completely trimming save and AOT friendly.

| Method        |       Mean |   Error |  StdDev |  Gen 0 | Allocated |
| ------------- | ---------: | ------: | ------: | -----: | --------: |
| AutoMapper    | 1,203.9 ns | 2.30 ns | 2.15 ns | 0.9098 |   1,904 B |
a| ManualMapping |   529.6 ns | 0.52 ns | 0.44 ns | 0.5541 |   1,160 B |
| Mapperly      |   338.5 ns | 0.95 ns | 0.84 ns | 0.4396 |     920 B |

## Requirements

Mapperly supports .NET 5+ and .NET Framework 4.x.
Mapperly requires at least C# language version 9 and Roslyn 4.0 or later.

**Documentation**: https://mapperly.riok.app/docs/intro

**Repository**: https://github.com/riok/mapperly
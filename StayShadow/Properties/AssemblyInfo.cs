using MelonLoader;
using System.Reflection;

[assembly: AssemblyTitle(StayShadow.BuildInfo.Description)]
[assembly: AssemblyDescription(StayShadow.BuildInfo.Description)]
[assembly: AssemblyCompany(StayShadow.BuildInfo.Company)]
[assembly: AssemblyProduct(StayShadow.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + StayShadow.BuildInfo.Author)]
[assembly: AssemblyTrademark(StayShadow.BuildInfo.Company)]
[assembly: AssemblyVersion(StayShadow.BuildInfo.Version)]
[assembly: AssemblyFileVersion(StayShadow.BuildInfo.Version)]
[assembly: MelonInfo(typeof(StayShadow.StayShadow), StayShadow.BuildInfo.Name, StayShadow.BuildInfo.Version, StayShadow.BuildInfo.Author, StayShadow.BuildInfo.DownloadLink)]
[assembly: MelonColor()]

// Create and Setup a MelonGame Attribute to mark a Melon as Universal or Compatible with specific Games.
// If no MelonGame Attribute is found or any of the Values for any MelonGame Attribute on the Melon is null or empty it will be assumed the Melon is Universal.
// Values for MelonGame Attribute can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame(null, null)]
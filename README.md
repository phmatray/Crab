![Crab banner](.github/banner.png)

# Crab — Belgian CRAB address API client for .NET

<!-- portfolio-badges:start -->
<!-- Identity -->
[![phmatray - Crab](https://img.shields.io/static/v1?label=phmatray&message=Crab&color=blue&logo=github)](https://github.com/phmatray/Crab)
![Top language](https://img.shields.io/github/languages/top/phmatray/Crab)
[![Stars](https://img.shields.io/github/stars/phmatray/Crab?style=social)](https://github.com/phmatray/Crab/stargazers)
[![Forks](https://img.shields.io/github/forks/phmatray/Crab?style=social)](https://github.com/phmatray/Crab/network/members)

<!-- Activity -->
[![Issues](https://img.shields.io/github/issues/phmatray/Crab)](https://github.com/phmatray/Crab/issues)
[![Pull requests](https://img.shields.io/github/issues-pr/phmatray/Crab)](https://github.com/phmatray/Crab/pulls)
[![Last commit](https://img.shields.io/github/last-commit/phmatray/Crab)](https://github.com/phmatray/Crab/commits)
<!-- portfolio-badges:end -->


A .NET client library for the Belgian CRAB (Centraal Referentieadressenbestand / Fichier Central d'Adresses de Référence) web service, providing access to the official Belgian address database with street names, building numbers, and geographical coordinates.

## ✨ Features
- Access to Belgian official address reference data
- Street name and house number lookups
- Geographical coordinate retrieval for addresses
- Municipality and postal code queries
- SOAP/REST API client abstractions

## 📦 Installation
```bash
dotnet add package Crab
# or
git clone https://github.com/phmatray/Crab
```

## 🚀 Quick Start
```csharp
var client = new CrabClient();
var addresses = await client.GetAddressesByStreetAsync("Rue de la Loi", "Bruxelles");
foreach (var address in addresses)
    Console.WriteLine($"{address.StreetName} {address.HouseNumber}, {address.Municipality}");
```

## 📄 License
MIT — see LICENSE

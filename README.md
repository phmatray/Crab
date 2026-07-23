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

<!-- portfolio-toc:start -->

## Table of Contents

- [✨ Features](#-features)
- [📦 Installation](#-installation)
- [🚀 Quick Start](#-quick-start)
- [Usage](#usage)
- [📄 License](#-license)
- [Roadmap](#roadmap)
- [Contributing](#contributing)

<!-- portfolio-toc:end -->



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

## Usage

Crab.NetCoreApi wraps the Belgian CRAB SOAP web service behind a plain ASP.NET Core REST API. Run it locally, then call it like any HTTP API:

```bash
cd Crab.NetCoreApi/src/Crab.NetCoreApi
dotnet run
```

```bash
curl http://localhost:5000/api/streetnames/1
```

```json
{
  "id": 1,
  "name": "Rue de la Loi",
  "status": "InGebruik"
}
```

Related resources are reachable from the same controller, e.g. `GET /api/streetnames/1/housenumbers` or `GET /api/streetnames/1/postaladdresses`, each proxying and mapping the underlying `WsCrabClient` SOAP calls to plain JSON DTOs.

<!-- portfolio-techstack:start -->

## Tech Stack

- **C#**

<!-- portfolio-techstack:end -->

## 📄 License
MIT — see LICENSE

---

## Roadmap

- [ ] Replace the legacy SOAP `Service Reference` client with a modern, generated client (WCF Core / CoreWCF or a hand-rolled SOAP envelope client)
- [ ] Publish an official `Crab` NuGet package matching the install instructions above
- [ ] Add automated tests around the controller-to-SOAP mapping layer
- [ ] Add caching for frequently requested reference data (municipalities, postal codes)
- [ ] Containerize the API with a ready-to-use Dockerfile

See the [open issues](https://github.com/phmatray/Crab/issues) for the full list of proposed features and known issues.

<!-- portfolio-sections:start -->

## Contributing

Contributions are welcome. Open an issue first to discuss any significant change.

1. Fork the repository and create your branch (`git checkout -b feat/my-feature`)
2. Commit your changes (`git commit -m 'feat: ...'`)
3. Push the branch and open a Pull Request

<!-- portfolio-sections:end -->

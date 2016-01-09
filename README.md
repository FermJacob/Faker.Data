# Faker
Faker is a C# library used to easily generate fake data for: names, address, and many more!

It is available via [NuGet Package](https://www.nuget.org/packages/Faker.Data/)


|CI Build | NuGet Package Deployment| NuGet |
| :------: | :----: | :---: | :----: | :-----: |
| ![CI Build Status](https://ferm.visualstudio.com/DefaultCollection/_apis/public/build/definitions/c55f9b7a-25b6-4f2e-8b7e-b1c8345d9344/10/badge) | ![Package Build Status](https://ferm.visualstudio.com/DefaultCollection/_apis/public/build/definitions/c55f9b7a-25b6-4f2e-8b7e-b1c8345d9344/11/badge) | ![NuGet Status](https://img.shields.io/nuget/v/Faker.Data.svg)

Install the NuGet package via the Package Manager or
```
PM> Install-Package Faker.Data
```
## Usage
```
var state = Faker.Address.State();
var usZip = Faker.Address.USZip();
```




# Faker
Faker is a C# library used to easily generate fake data for: names, address, and many more!

It is available via [NuGet Package](https://www.nuget.org/packages/Faker.Data/)


|CI Build | NuGet Package Deployment| NuGet |
| :------: | :----: | :---: | :----: | :-----: |
| ![CI Build Status](https://ferm.visualstudio.com/DefaultCollection/_apis/public/build/definitions/c55f9b7a-25b6-4f2e-8b7e-b1c8345d9344/10/badge) | ![Package Build Status](https://ferm.visualstudio.com/DefaultCollection/_apis/public/build/definitions/c55f9b7a-25b6-4f2e-8b7e-b1c8345d9344/11/badge) | [![NuGet Status](https://buildstats.info/nuget/faker.data/)](https://www.nuget.org/packages/Faker.Data/)

Install the NuGet package via the Package Manager or
```
PM> Install-Package Faker.Data
```
## Usage

#### Addresses
```
var state = Faker.Address.State();
var stateAbbr = Faker.Address.StateAbbreviation();
var provinceAbbr = Faker.Address.ProvinceAbbreviation();
var province = Faker.Address.Province();
var streetName = Faker.Address.StreetName();
var country = Faker.Address.Country();
var cityPrefix = Faker.Address.CityPrefix();
var citySuffix = Faker.Address.CitySuffix();
var secondaryAddress = Faker.Address.SecondaryAddress();
var usCity = Faker.Address.USCity();
var usCounty = Faker.Address.USCounty();
var canadianZip = Faker.Address.CanadianZip();
var usZip = Faker.Address.USZip();
```
#### Geo Location
```
var lat = Faker.GeoLocation.Latitude();
var lon = Faker.GeoLocation.Longitude();
```
#### Colors
```
var rgb = Faker.Color.RGB();
var hex = Faker.Color.Hex();
```
#### Numbers
```
var randomNumber = Faker.Number.RandomNumber();
var randomNumber1 = Faker.Number.RandomNumber(10);
var randomNumber2 = Faker.Number.RandomNumber(10,20);
var negativeNumber = Faker.Number.NegativeNumber(10);
var evenNumber = Faker.Number.Even(0,50);
var oddNumber = Faker.Number.Odd(0,50);
var doubleNumber = Faker.Number.Double();
var boolResult = Faker.Number.Bool();
```
#### Image
```
var jpeg = Faker.Images.JPEG();
var bmp = Faker.Images.BMP();
var png = Faker.Images.PNG();
```
#### Internet
```
var host = Faker.Internet.Hosts();
var ipv4 = Faker.Internet.IPv4();
var ipv6 = Faker.Internet.IPv6();
var macAddress = Faker.Internet.Mac();
var localhost = Faker.Internet.LocalHost();
var protocol = Faker.Internet.Protocol();
var topDomainSuffix = Faker.Internet.TopDomainSuffix();
var topCountrySuffix = Faker.Internet.TopCountryDomainSuffix();
var domainSuffix = Faker.Interent.DomainSuffix();
```


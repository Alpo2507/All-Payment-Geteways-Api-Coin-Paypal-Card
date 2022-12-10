 # All gateways payments & SMS
 <p align="center">

 

<a href="https://github.com/arabnewscms/gateways">
    <img src="https://img.shields.io/github/forks/arabnewscms/gateways" alt="GitHub forks">
</a>

<a href="https://github.com/arabnewscms/gateways">
    <img src="https://img.shields.io/github/issues/arabnewscms/gateways" alt="GitHub issues">
</a>

<a href="https://github.com/arabnewscms/gateways">
    <img src="https://img.shields.io/github/stars/arabnewscms/gateways" alt="GitHub stars">
</a>

<a href="https://packagist.org/packages/phpanonymous/gateways">
    <img src="https://img.shields.io/packagist/v/phpanonymous/gateways" alt="Latest Stable Version" style="max-width:100%;">
</a>

<a href="https://github.com/arabnewscms/gateways">
    <img src="https://img.shields.io/github/license/arabnewscms/gateways" alt="GitHub license">
</a>

</p>
 package name: `gateways`
 
 package version: `v1.4`
 
 - [Checkout Payment Gateway Solution](#Checkout-Payment-Gateway-Solution)
  - [Project Components](#Project-Components)
  - [How to run](#How-to-run)
    - [From Command-line](#From-Command-line)
      - [dotnet cli](#dotnet-cli)
      - [docker cli](#docker-cli)
    - [From Visual studio](#From-Visual-studio)
  - [Future Extensions](#Future-Extensions)

The solution provide implementation for the simple payment gateway. It provides the following scenarios:

- Ability to make a payment using a fake bank API
- Ability to retrieve a payment detail using payment identifier

## Project Components

To fulfill these scenarios, the solution consists of the following projects which serve specific purpose (Projects are all prefixed with **Checkout.PaymentGateway** name):

- Common: Contains all Dto objects.
- Data: Contains store and store related operation. *The current store has been implemented using MemoryCache but in more realistic case it should be using SQL/NoSQL or Column Based implementations.*
- Service: This project contains all the core operations for the payment which is implemented in PaymentService.
- API: This project is surfacing the API to outside consumer. It also contains initialization for API documentation (swagger), docker configuration and logging (by Serilog)
- Client: This project uses refit to provide light and typed version of the client to the consumer of API.

## How to run

The solution has been developed in .Net Core 2.2 so to be able to run the solution the relevant SDK need to be available on the machine.
Also because the solution is docker enabled, The Docker CE desktop should be available on the machine.

Here is the links to the relevant downloads:

- .Net Core 2.2 SDK: <https://dotnet.microsoft.com/download/dotnet-core/2.2>

- Docker CE Desktop: <https://hub.docker.com/editions/community/docker-ce-desktop-windows>

There are different ways to run the solution:

### From Command-line

From command line you can run the project in the following ways:

#### dotnet cli

To run the project through command line, run the following command in CMD (in the root of the repository):

```cmd
dotnet restore .\Checkout.PaymentGateway.sln

dotnet run --project .\Checkout.PaymentGateway.Api\Checkout.PaymentGateway.Api.csproj
```

Then the API will be accessible from the following urls:

- <http://localhost:5000>

- <https://localhost:5001>

#### docker cli

To run the api using docker cli, use the following commands in the root of repository:

```cmd
docker-compose up -d
```

### From Visual studio

By opening the solution in visual studio, It can be running as normal web api by running api project or can be run as docker using docker-compose.yml.

## Future Extensions

- The Store can be implemented using a proper database (SQl/NoSQL) with proper event sourcing technique.

- The monitoring can be done using ApplicationInsights or similar techniques which add visibility to the running API.

- Security can be implemented using OAuth 2.0 and passing Authorization Header

- Payment Status can be implemented in more comprehensive and distinguishable way to cover more states in processing the payments.
  
 
 
 
 description :`provide gateways payments and SMS`
 
 
 
to install this pacakge 

```
composer require phpanonymous/gateways
```

then publish config/gateways.php file 

```
php artisan vendor:publish --provider="Phpanonymous\Gateways\GatewayProvider"

# Dojo.Net.Plus
Unofficial client library for the Dojo API.

The official Dojo C# SDK is feature incomplete and has poor documentation. This package attempts to simplify the process 
of interacting with the Dojo API.

## Dependencies

This library uses Refit for HTTP requests, and Polly for retry policies.

## Installation

You can install the Dojo.Net.Plus library via NuGet Package Manager Console:

```bash 
Install-Package Dojo.Net.Plus
```

Add the following code to your `Program.cs` to configure the service:

```csharp
builder.Services.AddDojoNetPlus("api_key");
```

You can also configure additional options, or override the defaults.

```csharp
builder.Services.AddDojoNetPlus(
        "api_key", options =>
        {
            options.SoftwareHouseId = "your_software_house_id";
            options.ApiVersion = "2024-02-05";
            options.BaseUrl = "https://api.dojo.tech";
            options.OutputResponseBodyToConsole = true;
        });
```

## Usage

Inject the required service(s) into your class constructor

```csharp
public class MyService
{
    private readonly IDojoPaymentIntentService _paymentIntentService;
    private readonly IDojoTerminalService _terminalService;
    private readonly IDojoRefundService _refundService;

    public MyService(IDojoPaymentIntentService paymentIntentService, 
                     IDojoTerminalService terminalService,
                     IDojoRefundService refundService)
    {
        _paymentIntentService = paymentIntentService;
        _terminalService = terminalService;
        _refundService = refundService;
    }

    public async Task DoSomethingAsync()
    {
        var intent = new CreatePaymentIntentRequest(1000, "my-reference");
        var response = await _paymentIntentService.CreatePaymentIntentAsync(intent);
        ...
    }
}
```

All responses are wrapper in a `DojoResponse<T>` object, which contains the status, the response object if successful 
and error details message if the request failed.


## Missing Features

The features below are not yet impleted but will be added in future releases, likely in this order:

- Fetching multiple payment intents
- Setup Intents
- Webhooks
- Customers

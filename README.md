[![Build Status](https://dev.azure.com/LINEDeveloperCommunity/line-pay-csharp/_apis/build/status/line-pay-csharp-CI?branchName=master)](https://dev.azure.com/LINEDeveloperCommunity/line-pay-csharp/_build/latest?definitionId=2&branchName=master)

# LINE Login SDK for C#

This repository contains LINE Login SDK for C# 

See [Integrating LINE Login with your web app](https://developers.line.me/en/docs/line-login/web/integrate-line-login/) for LINE Login detail.

## Usage

Instantiate LINE Login Client

```csharp
var client = new LineLoginClient(channelId, channelSecret, redirectUri, "State", Scope.Profile | Scope.OpenId);
```

Get Authorization URL

```csharp
var authUri = client.GetAuthUri();
```

Get Token (AccessToken and JWT)

```csharp
var code = Request.QueryString["code"];
var token = await client.GetToken(code);
```
# LICENSE
[MIT](/LICENSE)

# Reference
I refer to following references to get basic coding idea.

[Integrating LINE Login with your web app](https://developers.line.me/en/docs/line-login/web/integrate-line-login/) 

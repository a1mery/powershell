---
applicable: SharePoint Online
external help file: PnP.PowerShell.dll-Help.xml
Module Name: PnP.PowerShell
online version: https://docs.microsoft.com/powershell/module/sharepoint-pnp/get-pnpstructuralnavigationcachewebstate
schema: 2.0.0
title: Get-PnPStructuralNavigationCacheWebState
---

# Get-PnPStructuralNavigationCacheWebState

## SYNOPSIS
Get the structural navigation caching state for a web.

## SYNTAX

```
Get-PnPStructuralNavigationCacheWebState [-WebUrl <String>]
```

## DESCRIPTION
The Get-PnPStructuralNavigationCacheWebState cmdlet can be used to determine if structural navigation caching is enabled or disabled for a web in a site collection. If the WebUrl parameter has not been specified the currently connected to web will be used. [Learn more](https://support.office.com/article/structural-navigation-and-performance-f163053f-8eca-4b9c-b973-36b395093b43). 

## EXAMPLES

### Example 1
```powershell
Get-PnPStructuralNavigationCacheWebState -WebUrl "https://contoso.sharepoint.com/sites/product/electronics" 
```

This example checks if structural navigation caching is enabled for the web https://contoso.sharepoint.com/sites/product/electronics. If caching is enabled, then it will return True. If caching is disabled, then it will return False. 

## PARAMETERS

### -WebUrl
Specifies the absolute URL for the web being checked for its caching state. 

```yaml
Type: String
Parameter Sets: (All)
Aliases:
Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

## RELATED LINKS

[Microsoft 365 Patterns and Practices](https://aka.ms/m365pnp)
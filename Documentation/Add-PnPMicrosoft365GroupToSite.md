---
applicable: SharePoint Online
external help file: PnP.PowerShell.dll-Help.xml
Module Name: PnP.PowerShell
online version: https://docs.microsoft.com/powershell/module/sharepoint-pnp/add-pnpmicrosoft365grouptosite
schema: 2.0.0
title: Add-PnPMicrosoft365GroupToSite
---

# Add-PnPMicrosoft365GroupToSite

## SYNOPSIS

**Required Permissions**

* SharePoint: Access to the SharePoint Tenant Administration site

Groupifies a classic team site by creating a Microsoft 365 group for it and connecting the site with the newly created group

## SYNTAX

```
Add-PnPMicrosoft365GroupToSite -Url <String> -Alias <String> [-Description <String>] -DisplayName <String>
 [-Classification <String>] [-IsPublic] [-KeepOldHomePage] [-HubSiteId <GuidPipeBind>] [-Owners <String[]>]
 [-Connection <PnPConnection>] [<CommonParameters>]
```

## DESCRIPTION
This command allows you to add a Microsoft 365 Unified group to an existing classic site collection, also known as groupifying.

## EXAMPLES

### EXAMPLE 1
```powershell
Add-PnPOffice365GroupToSite -Url "https://contoso.sharepoint.com/sites/FinanceTeamsite" -Alias "FinanceTeamsite" -DisplayName = "My finance team site group"
```

This will groupify the FinanceTeamsite

## PARAMETERS

### -Alias
Specifies the alias of the group. Cannot contain spaces.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Classification
Specifies the classification of the group

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

### -Connection
Optional connection to be used by the cmdlet. Retrieve the value for this parameter by either specifying -ReturnConnection on Connect-PnPOnline or by executing Get-PnPConnection.

```yaml
Type: PnPConnection
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
The optional description of the group

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

### -DisplayName
The display name of the group

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HubSiteId
If specified the site will be associated to the hubsite as identified by this id

```yaml
Type: GuidPipeBind
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsPublic
Specifies if the group is public. Defaults to false.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -KeepOldHomePage
Specifies if the current site home page is kept. Defaults to false.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Owners
The array UPN values of the group's owners

```yaml
Type: String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Url
Url of the site to be connected to an Microsoft 365 Group

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

## NOTES

## RELATED LINKS

[SharePoint Developer Patterns and Practices](https://aka.ms/sppnp)
﻿using Microsoft.Online.SharePoint.TenantAdministration;
using Microsoft.SharePoint.Client;
using PnP.PowerShell.Commands.Base;
using PnP.PowerShell.Commands.Base.PipeBinds;
using System.IO;
using System.Management.Automation;

[Cmdlet(VerbsCommon.Set, "SiteScriptPackage")]
public class SetSiteScriptPackage : PnPAdminCmdlet
{
    [Parameter(Mandatory = true)]
    public TenantSiteScriptPipeBind Identity;

    [Parameter(Mandatory = false)]
    public string Title;

    [Parameter(Mandatory = false)]
    public string Description;

    [Parameter(Mandatory = false)]
    public string ContentPath;

    [Parameter(Mandatory = false)]
    public int Version;

    protected override void ExecuteCmdlet()
    {
        var siteScript = Tenant.GetSiteScript(ClientContext, Identity.Id);
        ClientContext.Load(siteScript);
        ClientContext.ExecuteQueryRetry();

        if (!Path.IsPathRooted(ContentPath))
        {
            ContentPath = Path.Combine(SessionState.Path.CurrentFileSystemLocation.Path, ContentPath);
        }

        using (var contentStream = (ContentPath == null) ? null : System.IO.File.OpenRead(ContentPath))
        {
            if(ParameterSpecified(nameof(Title)))
            {
                siteScript.Title = Title;
            }
            if(ParameterSpecified(nameof(Description)))
            {
                siteScript.Description = Description;
            }
            if(ParameterSpecified(nameof(Version)))
            {
                siteScript.Version = Version;
            }
            var tenantSiteScript = this.Tenant.UpdateSiteScriptPackage(siteScript);
            ClientContext.Load(tenantSiteScript);
            ClientContext.ExecuteQueryRetry();
            WriteObject(tenantSiteScript);
        }
    }
}




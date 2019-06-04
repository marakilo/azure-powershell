---
external help file:
Module Name: Az.Resources
online version: https://docs.microsoft.com/en-us/powershell/module/az.resources/set-azmanagementlock
schema: 2.0.0
---

# Set-AzManagementLock

## SYNOPSIS
When you apply a lock at a parent scope, all child resources inherit the same lock.
To create management locks, you must have access to Microsoft.Authorization/* or Microsoft.Authorization/locks/* actions.
Of the built-in roles, only Owner and User Access Administrator are granted those actions.

## SYNTAX

### Update1 (Default)
```
Set-AzManagementLock -LockName <String> -SubscriptionId <String> [-Parameter <IManagementLockObject>]
 [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateExpanded3
```
Set-AzManagementLock -LockName <String> -Scope <String> -Level <LockLevel> [-Note <String>]
 [-Owner <IManagementLockOwner[]>] [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateExpanded2
```
Set-AzManagementLock -LockName <String> -ResourceGroupName <String> -SubscriptionId <String>
 -Level <LockLevel> [-Note <String>] [-Owner <IManagementLockOwner[]>] [-DefaultProfile <PSObject>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### UpdateExpanded1
```
Set-AzManagementLock -LockName <String> -SubscriptionId <String> -Level <LockLevel> [-Note <String>]
 [-Owner <IManagementLockOwner[]>] [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateExpanded
```
Set-AzManagementLock -LockName <String> -ParentResourcePath <String> -ResourceGroupName <String>
 -ResourceName <String> -ResourceProviderNamespace <String> -ResourceType <String> -SubscriptionId <String>
 -Level <LockLevel> [-Note <String>] [-Owner <IManagementLockOwner[]>] [-DefaultProfile <PSObject>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Update3
```
Set-AzManagementLock -LockName <String> -Scope <String> [-Parameter <IManagementLockObject>]
 [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update2
```
Set-AzManagementLock -LockName <String> -ResourceGroupName <String> -SubscriptionId <String>
 [-Parameter <IManagementLockObject>] [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Set-AzManagementLock -LockName <String> -ParentResourcePath <String> -ResourceGroupName <String>
 -ResourceName <String> -ResourceProviderNamespace <String> -ResourceType <String> -SubscriptionId <String>
 [-Parameter <IManagementLockObject>] [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded3
```
Set-AzManagementLock -InputObject <IResourcesIdentity> -Level <LockLevel> [-Note <String>]
 [-Owner <IManagementLockOwner[]>] [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded2
```
Set-AzManagementLock -InputObject <IResourcesIdentity> -Level <LockLevel> [-Note <String>]
 [-Owner <IManagementLockOwner[]>] [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded1
```
Set-AzManagementLock -InputObject <IResourcesIdentity> -Level <LockLevel> [-Note <String>]
 [-Owner <IManagementLockOwner[]>] [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Set-AzManagementLock -InputObject <IResourcesIdentity> -Level <LockLevel> [-Note <String>]
 [-Owner <IManagementLockOwner[]>] [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity3
```
Set-AzManagementLock -InputObject <IResourcesIdentity> [-Parameter <IManagementLockObject>]
 [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity2
```
Set-AzManagementLock -InputObject <IResourcesIdentity> [-Parameter <IManagementLockObject>]
 [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity1
```
Set-AzManagementLock -InputObject <IResourcesIdentity> [-Parameter <IManagementLockObject>]
 [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Set-AzManagementLock -InputObject <IResourcesIdentity> [-Parameter <IManagementLockObject>]
 [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
When you apply a lock at a parent scope, all child resources inherit the same lock.
To create management locks, you must have access to Microsoft.Authorization/* or Microsoft.Authorization/locks/* actions.
Of the built-in roles, only Owner and User Access Administrator are granted those actions.

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -InputObject
Identity Parameter

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Resources.Models.IResourcesIdentity
Parameter Sets: UpdateViaIdentityExpanded3, UpdateViaIdentityExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentity3, UpdateViaIdentity2, UpdateViaIdentity1, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Level
The level of the lock.
Possible values are: NotSpecified, CanNotDelete, ReadOnly.
CanNotDelete means authorized users are able to read and modify the resources, but not delete.
ReadOnly means authorized users can only read from a resource, but they can't modify or delete it.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Resources.Support.LockLevel
Parameter Sets: UpdateExpanded3, UpdateExpanded2, UpdateExpanded1, UpdateExpanded, UpdateViaIdentityExpanded3, UpdateViaIdentityExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -LockName
The name of lock.

```yaml
Type: System.String
Parameter Sets: Update1, UpdateExpanded3, UpdateExpanded2, UpdateExpanded1, UpdateExpanded, Update3, Update2, Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Note
Notes about the lock.
Maximum of 512 characters.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded3, UpdateExpanded2, UpdateExpanded1, UpdateExpanded, UpdateViaIdentityExpanded3, UpdateViaIdentityExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Owner
The owners of the lock.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Resources.Models.Api20160901.IManagementLockOwner[]
Parameter Sets: UpdateExpanded3, UpdateExpanded2, UpdateExpanded1, UpdateExpanded, UpdateViaIdentityExpanded3, UpdateViaIdentityExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Parameter
The lock information.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Resources.Models.Api20160901.IManagementLockObject
Parameter Sets: Update1, Update3, Update2, Update, UpdateViaIdentity3, UpdateViaIdentity2, UpdateViaIdentity1, UpdateViaIdentity
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -ParentResourcePath
The parent resource identity.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ResourceGroupName
The name of the resource group to lock.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded2, UpdateExpanded, Update2, Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ResourceName
The name of the resource to lock.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ResourceProviderNamespace
The resource provider namespace of the resource to lock.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ResourceType
The resource type of the resource to lock.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Scope
The scope for the lock.
When providing a scope for the assignment, use '/subscriptions/{subscriptionId}' for subscriptions, '/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}' for resource groups, and '/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{parentResourcePathIfPresent}/{resourceType}/{resourceName}' for resources.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded3, Update3
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SubscriptionId
The ID of the target subscription.

```yaml
Type: System.String
Parameter Sets: Update1, UpdateExpanded2, UpdateExpanded1, UpdateExpanded, Update2, Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Resources.Models.Api20160901.IManagementLockObject

### Microsoft.Azure.PowerShell.Cmdlets.Resources.Models.IResourcesIdentity

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Resources.Models.Api20160901.IManagementLockObject

## ALIASES

## RELATED LINKS

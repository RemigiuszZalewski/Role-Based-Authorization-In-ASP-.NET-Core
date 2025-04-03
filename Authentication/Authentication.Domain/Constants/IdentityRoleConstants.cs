namespace Authentication.Domain.Constants;

public static class IdentityRoleConstants
{
    public static readonly Guid AdminRoleGuid = new("5d8d3cc8-4fde-4c21-a70b-deaf8ebe51a2");
    public static readonly Guid RegularEmployeeRoleGuid = new("66dddd1c-bf05-4032-b8a5-6adbf73dc09e");
    public static readonly Guid HrManagerRoleGuid = new("c1e9279e-e9fd-472e-8d8f-b723fdcdc919");
    
    public const string Admin = "Admin";
    public const string RegularEmployee = "RegularEmployee";
    public const string HrManager = "HrManager";
}
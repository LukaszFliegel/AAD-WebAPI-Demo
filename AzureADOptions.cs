namespace AAD_WebAPI_Demo
{
    public class AzureAdOptions
    {
        public string Instance { get; set; }
        public string ClientId { get; set; }
        public string TenantId { get; set; }
        public string Authority => Instance + TenantId;
    }
}
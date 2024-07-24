namespace FrontStore.Domain.Settings;

public class StripeSettings
{
    public string SecretKey { get; set; }
    public string WebhookSecret { get; set; }
    public string SuccessUrl { get; set; }
    public string CancelUrl { get; set; }
}
namespace Going.Plaid.Entity;

/// <summary>
/// <para>The details for the newly created end customer, including secrets for all environments.</para>
/// </summary>
public record PartnerEndCustomerWithSecrets
{
	/// <summary>
	/// <para>Your Plaid API <c>client_id</c>. The <c>client_id</c> is required and may be provided either in the <c>PLAID-CLIENT-ID</c> header or as part of a request body.</para>
	/// </summary>
	[JsonPropertyName("client_id")]
	public string ClientId { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("company_name")]
	public string CompanyName { get; init; } = default!;

	/// <summary>
	/// <para>The status of the given end customer.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.PartnerEndCustomerStatus Status { get; init; } = default!;

	/// <summary>
	/// <para>The secrets for the newly created end customer.</para>
	/// </summary>
	[JsonPropertyName("secrets")]
	public Entity.PartnerEndCustomerSecrets Secrets { get; init; } = default!;
}
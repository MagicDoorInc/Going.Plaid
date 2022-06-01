namespace Going.Plaid.Entity;

/// <summary>
/// <para>The transaction details</para>
/// </summary>
public record WalletTransaction
{
	/// <summary>
	/// <para>A unique ID identifying the transaction</para>
	/// </summary>
	[JsonPropertyName("transaction_id")]
	public string TransactionId { get; init; } = default!;

	/// <summary>
	/// <para>A reference for the transaction</para>
	/// </summary>
	[JsonPropertyName("reference")]
	public string Reference { get; init; } = default!;

	/// <summary>
	/// <para>The type of the transaction. The supported transaction types that are returned are:</para>
	/// </summary>
	[JsonPropertyName("type")]
	public Entity.WalletTransactionTypeEnum Type { get; init; } = default!;

	/// <summary>
	/// <para>The amount and currency of a transaction</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public Entity.WalletTransactionAmount Amount { get; init; } = default!;

	/// <summary>
	/// <para>An object representing the e-wallet transaction's counterparty</para>
	/// </summary>
	[JsonPropertyName("counterparty")]
	public Entity.WalletTransactionCounterparty Counterparty { get; init; } = default!;

	/// <summary>
	/// <para>The status of the transaction.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.WalletTransactionStatus Status { get; init; } = default!;

	/// <summary>
	/// <para>Timestamp when the transaction was created, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format.</para>
	/// </summary>
	[JsonPropertyName("created_at")]
	public DateTimeOffset CreatedAt { get; init; } = default!;
}
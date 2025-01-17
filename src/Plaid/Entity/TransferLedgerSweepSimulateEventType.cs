namespace Going.Plaid.Entity;

/// <summary>
/// <para>The asynchronous event to be simulated. May be: <c>posted</c>, <c>settled</c>, <c>failed</c>, or <c>returned</c>.</para>
/// <para>An error will be returned if the event type is incompatible with the current ledger sweep status. Compatible status --> event type transitions include:</para>
/// <para><c>pending</c> --> <c>posted</c></para>
/// <para><c>pending</c> --> <c>failed</c></para>
/// <para><c>posted</c> --> <c>settled</c></para>
/// <para><c>posted</c> --> <c>returned</c></para>
/// <para><c>settled</c> --> <c>returned</c></para>
/// </summary>
public enum TransferLedgerSweepSimulateEventType
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "sweep.posted")]
	SweepPosted,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "sweep.settled")]
	SweepSettled,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "sweep.returned")]
	SweepReturned,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "sweep.failed")]
	SweepFailed,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}
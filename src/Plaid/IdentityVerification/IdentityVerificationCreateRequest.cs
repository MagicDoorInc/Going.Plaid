namespace Going.Plaid.IdentityVerification;

/// <summary>
/// <para>Request schema for '/identity_verification/create'</para>
/// </summary>
public partial class IdentityVerificationCreateRequest : RequestBase
{
	/// <summary>
	/// <para>A flag specifying whether you would like Plaid to expose a shareable URL for the verification being created.</para>
	/// </summary>
	[JsonPropertyName("is_shareable")]
	public bool IsShareable { get; set; } = default!;

	/// <summary>
	/// <para>ID of the associated Identity Verification template.</para>
	/// </summary>
	[JsonPropertyName("template_id")]
	public string TemplateId { get; set; } = default!;

	/// <summary>
	/// <para>A flag specifying whether the end user has already agreed to a privacy policy specifying that their data will be shared with Plaid for verification purposes.</para>
	/// <para>If <c>gave_consent</c> is set to <c>true</c>, the <c>accept_tos</c> step will be marked as <c>skipped</c> and the end user's session will start at the next step requirement.</para>
	/// </summary>
	[JsonPropertyName("gave_consent")]
	public bool GaveConsent { get; set; } = default!;

	/// <summary>
	/// <para>User information collected outside of Link, most likely via your own onboarding process.</para>
	/// <para>Each of the following identity fields are optional:</para>
	/// <para><c>email_address</c></para>
	/// <para><c>phone_number</c></para>
	/// <para><c>date_of_birth</c></para>
	/// <para><c>name</c></para>
	/// <para><c>address</c></para>
	/// <para><c>id_number</c></para>
	/// <para>Specifically, these fields are optional in that they can either be fully provided (satisfying every required field in their subschema) or omitted from the request entirely by not providing the key or value.</para>
	/// <para>Providing these fields via the API will result in Link skipping the data collection process for the associated user. All verification steps enabled in the associated Identity Verification Template will still be run. Verification steps will either be run immediately, or once the user completes the <c>accept_tos</c> step, depending on the value provided to the <c>gave_consent</c> field.</para>
	/// <para>If you are not using the shareable URL feature, you can optionally provide these fields via <c>/link/token/create</c> instead; both <c>/identity_verification/create</c> and <c>/link/token/create</c> are valid ways to provide this information. Note that if you provide a non-<c>null</c> user data object via <c>/identity_verification/create</c>, any user data fields entered via <c>/link/token/create</c> for the same <c>client_user_id</c> will be ignored when prefilling Link.</para>
	/// </summary>
	[JsonPropertyName("user")]
	public Entity.IdentityVerificationRequestUser User { get; set; } = default!;

	/// <summary>
	/// <para>An optional flag specifying how you would like Plaid to handle attempts to create an Identity Verification when an Identity Verification already exists for the provided <c>client_user_id</c> and <c>template_id</c>.</para>
	/// <para>If idempotency is enabled, Plaid will return the existing Identity Verification. If idempotency is disabled, Plaid will reject the request with a <c>400 Bad Request</c> status code if an Identity Verification already exists for the supplied <c>client_user_id</c> and <c>template_id</c>.</para>
	/// </summary>
	[JsonPropertyName("is_idempotent")]
	public bool? IsIdempotent { get; set; } = default!;
}
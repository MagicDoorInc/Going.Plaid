namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>The <c>/identity/get</c> endpoint allows you to retrieve various account holder information on file with the financial institution, including names, emails, phone numbers, and addresses. Only name data is guaranteed to be returned; other fields will be empty arrays if not provided by the institution.</para>
	/// <para>This request may take some time to complete if identity was not specified as an initial product when creating the Item. This is because Plaid must communicate directly with the institution to retrieve the data.</para>
	/// <para>Note: In API versions 2018-05-22 and earlier, the <c>owners</c> object is not returned, and instead identity information is returned in the top level <c>identity</c> object. For more details, see <a href="https://plaid.com/docs/api/versioning/#version-2019-05-29">Plaid API versioning</a>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/identity/#identityget" /></remarks>
	public Task<Identity.IdentityGetResponse> IdentityGetAsync(Identity.IdentityGetRequest request) =>
		PostAsync("/identity/get", request)
			.ParseResponseAsync<Identity.IdentityGetResponse>();

	/// <summary>
	/// <para>The <c>/identity/match</c> endpoint generates a match score, which indicates how well the provided identity data matches the identity information on file with the account holder's financial institution.</para>
	/// <para>This request may take some time to complete if Identity was not specified as an initial product when creating the Item. This is because Plaid must communicate directly with the institution to retrieve the data.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/identity/#identitymatch" /></remarks>
	public Task<Identity.IdentityMatchResponse> IdentityMatchAsync(Identity.IdentityMatchRequest request) =>
		PostAsync("/identity/match", request)
			.ParseResponseAsync<Identity.IdentityMatchResponse>();

	/// <summary>
	/// <para><c>/identity/refresh</c> is an optional endpoint for users of the Identity product. It initiates an on-demand extraction to fetch the most up to date Identity information from the Financial Institution. This on-demand extraction takes place in addition to the periodic extractions that automatically occur any Identity-enabled Item. If changes to Identity are discovered after calling <c>/identity/refresh</c>, Plaid will fire a webhook <a href="https://plaid.com/docs/api/products/identity/#default_update"><c>DEFAULT_UPDATE</c></a>.</para>
	/// <para><c>/identity/refresh</c> is offered as an add-on to Identity and has a separate <a href="https://plaid.com/docs/account/billing/#per-request-flat-fee">fee model</a>. To request access to this endpoint, submit a <a href="https://dashboard.plaid.com/team/products">product access request</a> or contact your Plaid account manager.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/identity/#identityrefresh" /></remarks>
	public Task<Identity.IdentityRefreshResponse> IdentityRefreshAsync(Identity.IdentityRefreshRequest request) =>
		PostAsync("/identity/refresh", request)
			.ParseResponseAsync<Identity.IdentityRefreshResponse>();
}
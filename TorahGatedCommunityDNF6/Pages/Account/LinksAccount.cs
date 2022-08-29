namespace TorahGatedCommunityDNF6.Links;

public static partial class Account
{
	public static class Login
	{
		public const string Index = "/login-provider";
		public const string Title = "Log in";
		public const string PageTitle = "Login";
		public const string Icon = "fas fa-sign-in-alt";
	}
	public static class Logout
	{
		public const string Index = "/Logout";
		public const string Title = "Log out";
		public const string PageTitle = "Logout";
		public const string Icon = "fas fa-sign-out-alt";
	}
}

/*

public static class Account
{
	public const string Login = "/Account/Login";
	public const string Logout = "/Account/Logout";
	public const string LogoutAction = "Account/LogOut";
	public const string Profile = "/Account/Profile";

	public const string TitleAccessDenied = "Access Denied.";
	public const string TitleLogin = "Login";
	public const string TitleLogout = "Logout";
	public const string TitleProfile = "Profile";

	public const string IconClaims = "fab fa-superpowers";
	public const string IconProfileVerified = "fas fa-check";
	public const string IconProfileNotVerified = "fas fa-question";
	public const string IconLogout = "fas fa-sign-out-alt";
	public const string IconLogin = "fas fa-sign-in-alt";
	public const string IconProfile = "fas fa-user";

	public static class PasswordChanged
	{
		public const string Index = "/account/PasswordChanged";
		public const string Title = " Password Changed Successfully";
		public const string PageTitle = " Password Changed";
		public const string Icon = "fas fa-key";
	}
}
*/
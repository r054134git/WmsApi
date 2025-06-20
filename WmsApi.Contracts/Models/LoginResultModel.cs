namespace WmsApi.Contracts.Models
{
	public class LoginResultModel
	{
		public string userId { get; set; }
		public bool IsSucceed { get; set; }

		public string Message { get; set; }

		public string Name { get; set; }
		public string Account { get; set; }

		public string DefaultHouseId { get; set; }

		public string DefaultBayId { get; set; }

		public string DefaultBayName { get; set; }
		public string Department { get; set; }

		public bool IsAdmin { get; set; }

		public string Role { get; set; }

		public string Token { get; set; }

		public string[] CurrentAuthority { get; set; }
	}
}

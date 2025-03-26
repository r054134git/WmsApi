namespace WmsApi.Contracts
{
    public class TokenData
    {
        public string AccessToken { get; set; }

		public TokenData()
		{
		}
	}
    public class GateTokenResult
    {
        public TokenData Data { get; set; } = new TokenData();
        public string ErrMsg { get; set; }
        public bool Success { get; set; }

		public GateTokenResult()
		{
		}
	}
}

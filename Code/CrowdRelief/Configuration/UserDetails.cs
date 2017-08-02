namespace CrowdRelief.Pages
{
    public class UserDetails
    {
        public string TwitterId { get; set; }
		public string FacebookAccessToken { get; set; }
		public string Firstname { get; set; }
		public string Lastname { get; set; }
		public string Email { get; set; }
		public string ScreenName { get; set; }
        public string Token { get; set; }
        public string TokenSecret { get; set; }
        public bool IsAuthenticated
        {
            get
            {
                return !string.IsNullOrWhiteSpace(Token);
            }
        }
    }
}

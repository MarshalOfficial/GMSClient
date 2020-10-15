using GMSClient.Data;
using System;

namespace GMSClient
{
    public class StateContainer
    {
        public TokenEntity User { get; set; }
        public string Token { get; set; }

        public event Action OnChange;

        public void SetUser(TokenEntity value)
        {
            User = value;
            NotifyStateChanged();
        }

        public void SetToken(string value)
        {
            Token = value;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}

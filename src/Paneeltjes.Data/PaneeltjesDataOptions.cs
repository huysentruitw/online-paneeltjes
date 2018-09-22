using System;

namespace Paneeltjes.Data
{
    public class PaneeltjesDataOptions
    {
        public string ConnectionString { get; set; }

        public void Validate()
        {
            if (string.IsNullOrEmpty(ConnectionString))
            {
                throw new ArgumentException("String can't be null or empty", nameof(ConnectionString));
            }
        }
    }
}
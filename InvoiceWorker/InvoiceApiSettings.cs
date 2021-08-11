﻿using System.IO;
using System.Threading.Tasks;

namespace InvoiceWorker
{
    public class InvoiceApiSettings
    {
        private const string InvoiceApiUri = "https://invoice-worker-api-mock.netlify.app/api/invoices/events";
        private static readonly string HighwatermarkFilePath = Path.Combine(Directory.GetCurrentDirectory(), "InvoiceWorkerHighwatermark.txt");

        public static async Task<string> GenerateUriAsync()
        {
            if (File.Exists(HighwatermarkFilePath) && long.TryParse(await File.ReadAllTextAsync(HighwatermarkFilePath), out var highwatermark))
            {
                return $"{InvoiceApiUri}?afterEventId={highwatermark}";
            }

            return InvoiceApiUri;
        }

        public static async Task SaveHighwatermarkAsync(long highwatermark)
        {
            await File.WriteAllTextAsync(HighwatermarkFilePath, highwatermark.ToString());
        }
    }
}
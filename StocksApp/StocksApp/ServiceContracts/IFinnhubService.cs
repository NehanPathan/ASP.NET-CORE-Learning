namespace StocksApp.ServiceContracts
{
    public interface IFinnhubService
    {
        Task<Dictionary<string, Object>?> GetStockPriceQuote(string stockSymbol);
    }
}

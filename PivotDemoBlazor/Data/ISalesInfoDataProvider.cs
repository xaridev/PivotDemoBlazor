namespace PivotDemoBlazor.Data
{
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    using System.Threading;
    using System.Threading.Tasks;

    public interface ISalesInfoDataProvider
    {
        Task<IEnumerable<SaleInfo>> GetSalesAsync(CancellationToken ct = default);
        Task<IEnumerable<SaleInfo>> GetReducedSalesAsync(CancellationToken ct = default);
    }
}

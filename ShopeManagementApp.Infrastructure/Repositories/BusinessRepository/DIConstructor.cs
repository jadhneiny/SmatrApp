using Microsoft.Extensions.Logging;
using ShopeManagementApp.Infrastructure.Contracts;

namespace ShopeManagementApp.Infrastructure.Repositories;

public partial class BusinessRepository : IBusinessRepository
{
    private readonly IDatabaseContext _databaseContext;
    private readonly ILogger<BusinessRepository> _logger;

    public BusinessRepository(
        ILogger<BusinessRepository> i_Logger,
        IDatabaseContext i_DatabaseContext
    )
    {
        _databaseContext = i_DatabaseContext ?? throw new ArgumentNullException(nameof(i_DatabaseContext));
        _logger = i_Logger ?? throw new ArgumentNullException(nameof(i_Logger));
    }
}

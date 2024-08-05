using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ShopeManagementApp.Application.Contracts;
using ShopeManagementApp.Common.Contracts;
using ShopeManagementApp.Domain.Entities;
using ShopeManagementApp.Infrastructure.Contracts;

namespace ShopeManagementApp.Application.Services;

public partial class BusinessService : IBusinessService
{
    private readonly ApplicationSettings _applicationSettings;
    private readonly ILogger<BusinessService> _logger;
    private readonly IDatabaseContext _databaseContext;
    private readonly IUserSessionContext _userSessionContext;
    private readonly IBusinessRepository _businessRepository;

    public BusinessService(
        IOptions<ApplicationSettings> i_ApplicationSettings,
        ILogger<BusinessService> i_Logger,
        IDatabaseContext i_DatabaseContext,
        IUserSessionContext i_UserSessionContext,
        IBusinessRepository i_BusinessRepository
    )
    {
        _applicationSettings = i_ApplicationSettings?.Value ?? throw new ArgumentNullException(nameof(i_ApplicationSettings));
        _logger = i_Logger ?? throw new ArgumentNullException(nameof(i_Logger));
        _databaseContext = i_DatabaseContext ?? throw new ArgumentNullException(nameof(i_DatabaseContext));
        _userSessionContext = i_UserSessionContext ?? throw new ArgumentNullException(nameof(i_UserSessionContext));
        _businessRepository = i_BusinessRepository ?? throw new ArgumentNullException(nameof(i_BusinessRepository));

        PostConstruct();
    }
}

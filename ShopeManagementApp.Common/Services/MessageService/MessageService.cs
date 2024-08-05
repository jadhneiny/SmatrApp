using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using ShopeManagementApp.Domain.Entities;
using ShopeManagementApp.Common.Contracts;

namespace ShopeManagementApp.Common.Services;

public partial class MessageService : IMessageService
{
    private readonly IConfiguration _configuration;
    private readonly ILogger<MessageService> _logger;
    private readonly IUserSessionContext _userSessionContext;

    private readonly string _defaultMessage = "Message not found";
    private Dictionary<Enum_Language, Dictionary<Enum_Message_Code, string>> _messagesByLanguage = [];

    public MessageService(
        ILogger<MessageService> i_Logger,
        IConfiguration i_Configuration,
        IUserSessionContext i_UserSessionContext
    )
    {
        _logger = i_Logger ?? throw new ArgumentNullException(nameof(i_Logger));
        _configuration = i_Configuration ?? throw new ArgumentNullException(nameof(i_Configuration));
        _userSessionContext = i_UserSessionContext ?? throw new ArgumentNullException(nameof(i_UserSessionContext));
    }

    public string GetMessageContent(Enum_Message_Code i_Message_Code, Enum_Language? i_Language = null)
    {
        try
        {
            if (_messagesByLanguage.Count == 0)
            {
                Load_Messages();
            }

            _logger.LogInformation("Retrieving message content for code: {Message_Code}, language: {Language}", i_Message_Code, i_Language);

            if (_messagesByLanguage.TryGetValue(i_Language ?? _userSessionContext.Language, out var oList_Message) && oList_Message.TryGetValue(i_Message_Code, out var oMessage))
            {
                return oMessage;
            }

            _logger.LogWarning("Message for code {Message_Code} not found. Returning default message.", i_Message_Code);
            return _defaultMessage;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error occurred while retrieving message content.");
            return _defaultMessage;
        }
    }
    #region Utilities
    private void Load_Messages()
    {
        try
        {
            _messagesByLanguage = [];

            var oMessagesSection = _configuration.GetSection("Messages");
            foreach (var oLanguageSection in oMessagesSection.GetChildren())
            {
                Enum_Language oLanguage = Enum.Parse<Enum_Language>(oLanguageSection.Key, true);
                var oMessages = new Dictionary<Enum_Message_Code, string>();
                foreach (var oMessage in oLanguageSection.GetChildren())
                {
                    Enum_Message_Code oMessageCode = Enum.Parse<Enum_Message_Code>(oMessage.Key, true);
                    oMessages[oMessageCode] = oMessage.Value;
                }
                _messagesByLanguage[oLanguage] = oMessages;
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error occurred while loading messages.");
            throw;
        }
    }
    #endregion
}

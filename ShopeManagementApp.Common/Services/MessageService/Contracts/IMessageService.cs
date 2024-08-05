using ShopeManagementApp.Domain.Entities;

namespace ShopeManagementApp.Common.Contracts;

public partial interface IMessageService
{
    /// <summary>
    /// Retrieves the message content for a given message code and language.
    /// If the language is not provided, the service will use the default application language.
    /// </summary>
    /// <param name="i_Message_Code">The message code for which content is required.</param>
    /// <param name="i_Language">Optional. The language for which the message content is requested.</param>
    /// <returns>The localized message content if found, otherwise a default message.</returns>
    string GetMessageContent(Enum_Message_Code i_Message_Code, Enum_Language? i_Language = null);
}

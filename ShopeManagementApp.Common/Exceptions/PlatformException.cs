using ShopeManagementApp.Domain.Entities;
using ShopeManagementApp.Common.Services;
using ShopeManagementApp.Common.Contracts;

namespace ShopeManagementApp.Common.Exceptions;

public partial class PlatformException : Exception
{
    public PlatformException(string i_Message_Content) : base(i_Message_Content) { }
    public PlatformException(string i_Message_Content, Dictionary<string, string> i_Map_Substitution) : base(ConstructMessage(i_Message_Content, i_Map_Substitution)) { }

    public PlatformException(Enum_Message_Code i_Message_Code) : base(GetMessageContent(i_Message_Code)) { }
    public PlatformException(Enum_Message_Code i_Message_Code, Dictionary<string, string> i_Map_Substitution) : base(ConstructMessage(i_Message_Code, i_Map_Substitution)) { }

    private static string GetMessageContent(Enum_Message_Code i_Message_Code)
    {
        var MessageService = ServiceLocator.GetService<IMessageService>();
        return MessageService.GetMessageContent(i_Message_Code);
    }
    private static string ConstructMessage(string i_Message_Content, Dictionary<string, string> i_Map_Substitution)
    {
        return i_Map_Substitution.Aggregate(i_Message_Content, (oCurrent_Message, oSubstitution) => oCurrent_Message.Replace(oSubstitution.Key, oSubstitution.Value));
    }
    private static string ConstructMessage(Enum_Message_Code i_Message_Code, Dictionary<string, string> i_Map_Substitution)
    {
        return i_Map_Substitution.Aggregate(GetMessageContent(i_Message_Code), (oCurrent_Message, oSubstitution) => oCurrent_Message.Replace(oSubstitution.Key, oSubstitution.Value));
    }
}

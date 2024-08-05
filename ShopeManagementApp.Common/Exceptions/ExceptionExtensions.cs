using ShopeManagementApp.Domain.Entities;

namespace ShopeManagementApp.Common.Exceptions;

public static class ExceptionExtensions
{
    public static void HandleEditException(this Exception i_Exception)
    {
        if (i_Exception.Message.Contains("Violation of UNIQUE KEY constraint"))
        {
            throw new PlatformException(Enum_Message_Code.UniqueKeyViolation);
        }
        else if (i_Exception.Message.Contains("Cannot insert the value NULL into column"))
        {
            throw new PlatformException(Enum_Message_Code.NullValueInsertionError);
        }
        else if (i_Exception.Message.Contains("Cannot update because the record does not exist"))
        {
            throw new PlatformException(Enum_Message_Code.RecordToUpdateNotFoundError);
        }
        else
        {
            throw new PlatformException(i_Exception.Message);
        }
    }
    public static void HandleDeleteException(this Exception i_Exception)
    {
        if (i_Exception.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
        {
            throw new PlatformException(Enum_Message_Code.DeletionBlockedByRelatedRecords);
        }
        else
        {
            throw new PlatformException(i_Exception.Message);
        }
    }
}

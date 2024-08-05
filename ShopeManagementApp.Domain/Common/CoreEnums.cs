namespace ShopeManagementApp.Domain.Entities;

public enum Enum_Edit_Mode
{
    Add,
    Update
}
public enum Enum_Language
{
    English,
    French,
    Arabic
}
public enum Enum_Message_Code
{
    None, // Empty
    UserIdParseError, // Couldn't parse User ID!
    NullValueInsertionError, // A required field was left blank.
    UniqueKeyViolation, // An item with the same key already exists.
    RecordToUpdateNotFoundError, // The item you are trying to edit does not exist.
    InvalidPrimaryKey, // The Specified Primary Key (%1) is Invalid While Calling %2!
    DeletionBlockedByRelatedRecords, // Cannot be Deleted Because of Related Records in Other Tables!
}

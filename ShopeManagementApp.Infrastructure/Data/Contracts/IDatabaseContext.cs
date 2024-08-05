using Dapper;
using System.Data;
using ShopeManagementApp.Infrastructure.Entities;

namespace ShopeManagementApp.Infrastructure.Contracts;

public partial interface IDatabaseContext
{
    Task SetContext();
    Task CommitAsync();
    Task RollbackAsync();
    Task BeginTransactionAsync();
    Task<dynamic> Execute<TReturn>(
        Enum_Operation_Type i_Operation_Type,
        string i_Stored_Procedure,
        DynamicParameters i_DynamicParameters,
        string i_Split_On = "",
        Type[] i_List_Type = null,
        Func<object[], TReturn> i_Map = null,
        CommandType i_CommandType = CommandType.StoredProcedure
    );
}

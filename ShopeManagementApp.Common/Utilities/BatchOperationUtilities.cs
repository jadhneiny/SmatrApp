namespace ShopeManagementApp.Common.Utilities;

public static partial class BatchOperationUtilities
{
    public static async Task<(
        IEnumerable<TSuccess> Success,
        IEnumerable<TFailed> Failed
    )> ProcessBatchOperations<TSuccess, TFailed>(
        this IEnumerable<TSuccess> i_List_Item_to_Process,
        Func<TSuccess, Task> i_Process_Action,
        Func<TSuccess, TFailed> i_Failure_Mapping
    )
    {
        List<TFailed> oList_Failed_Item = [];
        List<TSuccess> oList_Successful_Item = [];

        foreach (var oItem_to_Process in i_List_Item_to_Process)
        {
            try
            {
                await i_Process_Action(oItem_to_Process);
                oList_Successful_Item.Add(oItem_to_Process);
            }
            catch
            {
                oList_Failed_Item.Add(i_Failure_Mapping(oItem_to_Process));
            }
        }

        return (oList_Successful_Item, oList_Failed_Item);
    }
}

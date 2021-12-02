using Microsoft.AspNetCore.Datasync.EFCore;

namespace AzureToDoAppApi.Models
{
    // The ITableData (which is implemented by EntityTableData) provides the ID of the record.
    public class TodoItem : EntityTableData
	{
        /// <summary>
        /// Text of the Todo Item
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Is the item complete?
        /// </summary>
        public bool Complete { get; set; }

        // ITableData implements other properties for handling data sync services:
        // - UpdatedAt (DateTimeOffset?) provides the date that the record was last updated.
        // - Version (byte[]) provides an opaque value that changes on every write.
        // - Deleted (bool) is true if the record has been deleted but not yet purged.
    }
}

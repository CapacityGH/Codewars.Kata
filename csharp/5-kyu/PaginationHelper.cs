using System;
using System.Collections.Generic;

public class PaginationHelper<T>
{
    public IList<T> Collection { get; }
    public int ItemsPerPage { get; }
    public int ItemCount { get => Collection.Count; }
    public int PageCount { get => (int)Math.Ceiling((double)Collection.Count / ItemsPerPage); }

    public PaginationHelper(IList<T> collection, int itemsPerPage)
    {
        Collection = collection;
        ItemsPerPage = itemsPerPage;
    }

    public int PageItemCount(int pageIndex)
    {
        if (pageIndex < 0 || pageIndex > PageCount - 1)
            return -1;
        else if (pageIndex == PageCount - 1)
            return ItemCount % ItemsPerPage == 0 ? ItemsPerPage : ItemCount % ItemsPerPage;
        else
            return ItemsPerPage;
    }

    public int PageIndex(int itemIndex)
    {
        if (itemIndex < 0 || itemIndex >= ItemCount)
            return -1;
        return itemIndex / ItemsPerPage;
    }
}
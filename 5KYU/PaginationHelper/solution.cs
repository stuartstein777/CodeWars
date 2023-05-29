using System;
using System.Collections.Generic;

public class PaginationHelper<T>
{
    private readonly IList<T> _collection;
    private readonly int _itemCount;
    private readonly int _itemsPerPage;
  
    /// <summary>
    /// Constructor, takes in a list of items and the number of items that fit within a single page
    /// </summary>
    /// <param name="collection">A list of items</param>
    /// <param name="itemsPerPage">The number of items that fit within a single page</param>
    public PaginationHelper(IList<T> collection, int itemsPerPage)
    {
        _collection = collection;
        _itemsPerPage = itemsPerPage;
        _itemCount = _collection.Count;
    }

    /// <summary>
    /// The number of items within the collection
    /// </summary>
    public int ItemCount => _itemCount;

    /// <summary>
    /// The number of pages
    /// </summary>
    public int PageCount => (int)Math.Ceiling(ItemCount / (double)_itemsPerPage);

    /// <summary>
    /// Returns the number of items in the page at the given page index 
    /// </summary>
    /// <param name="pageIndex">The zero-based page index to get the number of items for</param>
    /// <returns>The number of items on the specified page or -1 for pageIndex values that are out of range</returns>
    public int PageItemCount(int pageIndex)
    {
        System.Console.WriteLine($"pageIndex: {pageIndex}");
        System.Console.WriteLine($"pageCount: {PageCount}");
        System.Console.WriteLine($"_itemCount: {_itemCount}");
        System.Console.WriteLine($"_itemsPerPage: {_itemsPerPage}");        
        
        if (pageIndex >= PageCount || pageIndex < 0) return -1;
        if(_itemsPerPage > _itemCount) return _itemCount;
        if(_itemsPerPage == 1) return 1;
        if(_itemCount % _itemsPerPage == 0) return _itemsPerPage; 
        if(pageIndex == PageCount-1 && PageCount !=1)
          return _itemCount % _itemsPerPage;
        return _itemsPerPage;
    }

    /// <summary>
    /// Returns the page index of the page containing the item at the given item index.
    /// </summary>
    /// <param name="itemIndex">The zero-based index of the item to get the pageIndex for</param>
    /// <returns>The zero-based page index of the page containing the item at the given item index or -1 if the item index is out of range</returns>
    public int PageIndex(int itemIndex)
    {
        System.Console.WriteLine($"itemIndex: {itemIndex}");
        System.Console.WriteLine($"pageCount: {PageCount}");
        System.Console.WriteLine($"_itemCount: {_itemCount}");
        System.Console.WriteLine($"_itemsPerPage: {_itemsPerPage}");        
        
        if (itemIndex >= _itemCount || itemIndex < 0) return -1;
        return (int)Math.Floor(itemIndex / (double)_itemsPerPage);
    }
}
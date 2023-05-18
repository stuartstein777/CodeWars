using System;

public class Kata
{
  public static string PaginationText(int pageNumber, int pageSize, int totalProducts)
     => $"Showing {(pageNumber-1) * pageSize + 1} to {Math.Min(totalProducts, pageSize * pageNumber)} of {totalProducts} Products.";
}
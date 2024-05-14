using Packt.Shared;

//QueryingCategories();

// FilteredIncludes();

// QueryingProducts();

//QueryingWithLike();

//GetRandomProduct();


WriteLine("About to delete all products whose name starts with Bob.");
Write("Press Enter to continue or any other key to exit: ");
if (ReadKey(intercept: true).Key == ConsoleKey.Enter)
{
  int deleted = DeleteProducts(productNameStartsWith: "Bob");
  WriteLine($"{deleted} product(s) were deleted.");
}
else
{
  WriteLine("Delete was canceled.");
}
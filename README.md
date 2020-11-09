# dotnet-core-practice---inventory-system-day-1

**Purpose:** 
This practice is meant to challenge your mastery of ASP.NET and how well you are able to use ASP.NET Web API to create a CRUD application. Your goal in this practice is to create an inventory management system which helps a company keep track of goods and supplies. As goods and supplies are restocked, sold, or used, your application should update the data appropriately to reflect the changes. This is a cumulative activity. You will build on this practice for your next assignment.

**Author:** Atinder Pal

**Requirements:**
* Create “Product” (Model).
    * Properties are to be decided by you based on the rest of the requirements.
* Create “InventoryContext” (Context):
  * Seed data of 10 sample products, at least one of which is discontinued.
  * Migrate to a database called “mvc_inventory”.
* Create “ProductController” (Controller):
  * Ensure that appropriate validation is present on all methods (see “General Validation” on ASP.NET Core Assignment - Library Due Date Tracker Day 3).
  * The product being operated on must exist for all ‘ProductByID’ methods.
  *  Add a “CreateProduct()” method that will accept strings for each property of “Product”.
    * The product should default to not discontinued if that property is not provided.
    * The quantity on hand should default to zero if it is not provided.
  * Add a “DiscontinueProductByID()” method that will discontinue a product.
    * The product must not already be discontinued.
  * Add a “ReceiveProductByID()” method that will add a quantity to a product.
  * Add a “SendProductByID()” method that will subtract a quantity from a product.
    * The product must have the necessary quantity to subtract.
  * Add a “GetInventory()” method that will get the entire inventory.
    * Include a boolean parameter that will either show, or not show, the discontinued items as part of the list.
      * Default the boolean to true if it is not provided.
    * If there are no products, return null, not an empty list.
  * Add a “GetProductByID()” method that will get a product.
    * If the product does not exist, return null.

* Create “InventoryController” (API Controller):
  * All requests should have a proper response code that represents the state of the request.
  * Create an HttpPost endpoint that will create a product.
  * Create an HttpPatch endpoint that will discontinue, send, or receive a product.
  * Create an HttpGet endpoint that displays the full active inventory.
    * Order by “Quantity” from lowest to highest so that the user will know what needs to be restocked.
* Create an HttpGet endpoint that displays the full inventory.
  * Order by “Name” alphabetically.
* Create an HttpGet endpoint that responds to a primary key in the query string with the associated product.
* Use Postman to test each endpoint
  * Take Postman screenshots of:
    * Creating a product (success).
    * Creating a product (error).
    * Patching a product (discontinue, success).
    * Patching a product (discontinue, not found).
    * Patching a product (discontinue, already discontinued).
    * Patching a product (receive, success).
    * Patching a product (send, success).
    * Patching a product (send, not enough inventory).
    * Getting products (get full active inventory).
    * Getting products (get full inventory).
    * Getting a product (one product, success).
    * Getting a product (one product, not found).
* Include a “Screenshots” folder in the root of your repository with these screenshots.

**Link to Trello Board:** https://trello.com/b/Wo4EaJkm/inventory-system-day-1

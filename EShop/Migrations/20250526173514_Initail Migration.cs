using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EShop.Migrations
{
    /// <inheritdoc />
    public partial class InitailMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category_tb",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category_tb", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Customer_tb",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactInfo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer_tb", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Product_tb",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product_tb", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Product_tb_Category_tb_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Category_tb",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order_tb",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order_tb", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Order_tb_Customer_tb_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer_tb",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payment_tb",
                columns: table => new
                {
                    PaymentInformationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CVV = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment_tb", x => x.PaymentInformationID);
                    table.ForeignKey(
                        name: "FK_Payment_tb_Customer_tb_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer_tb",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Shipping_tb",
                columns: table => new
                {
                    ShippingAddressID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipping_tb", x => x.ShippingAddressID);
                    table.ForeignKey(
                        name: "FK_Shipping_tb_Customer_tb_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer_tb",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Review_tb",
                columns: table => new
                {
                    ReviewID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review_tb", x => x.ReviewID);
                    table.ForeignKey(
                        name: "FK_Review_tb_Customer_tb_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer_tb",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Review_tb_Product_tb_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product_tb",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem_tb",
                columns: table => new
                {
                    OrderItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ItemPrice = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem_tb", x => x.OrderItemID);
                    table.ForeignKey(
                        name: "FK_OrderItem_tb_Order_tb_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Order_tb",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItem_tb_Product_tb_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product_tb",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_tb_CustomerID",
                table: "Order_tb",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_tb_OrderID",
                table: "OrderItem_tb",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_tb_ProductID",
                table: "OrderItem_tb",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_tb_CustomerID",
                table: "Payment_tb",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_tb_CategoryID",
                table: "Product_tb",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Review_tb_CustomerID",
                table: "Review_tb",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Review_tb_ProductID",
                table: "Review_tb",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Shipping_tb_CustomerID",
                table: "Shipping_tb",
                column: "CustomerID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItem_tb");

            migrationBuilder.DropTable(
                name: "Payment_tb");

            migrationBuilder.DropTable(
                name: "Review_tb");

            migrationBuilder.DropTable(
                name: "Shipping_tb");

            migrationBuilder.DropTable(
                name: "Order_tb");

            migrationBuilder.DropTable(
                name: "Product_tb");

            migrationBuilder.DropTable(
                name: "Customer_tb");

            migrationBuilder.DropTable(
                name: "Category_tb");
        }
    }
}

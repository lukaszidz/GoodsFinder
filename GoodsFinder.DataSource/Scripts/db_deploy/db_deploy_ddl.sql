BEGIN TRAN

CREATE TABLE Product.Product (
	Id bigint NOT NULL,
	[Name] varchar(127) NOT NULL,

	CONSTRAINT PK_ProductProduct PRIMARY KEY (Id)
)

CREATE TABLE Product.Category (
	Id bigint NOT NULL,
	[Name] varchar(127) NOT NULL,
	ParentCategoryId bigint NULL,
    
    CONSTRAINT PK_ProductCategory PRIMARY KEY (Id),
    CONSTRAINT FK_ProductCategory_Product FOREIGN KEY (ParentCategoryId) REFERENCES Product.Category(Id)
)

CREATE TABLE Product.ProductCategory (
	ProductId bigint NOT NULL,
	CategoryId bigint NOT NULL,

    CONSTRAINT PK_ProductProductCategory PRIMARY KEY (ProductId, CategoryId),
    CONSTRAINT FK_ProductProductCategory_Product FOREIGN KEY (ProductId) REFERENCES Product.Product(Id),
    CONSTRAINT FK_ProductProductCategory_Category FOREIGN KEY (CategoryId) REFERENCES Product.Category(Id)
)

CREATE TABLE Product.ProductReview (
    Id bigint NOT NULL,
	ProductId bigint NOT NULL,
	Title varchar(127) NULL,
	Manufacturer varchar(127) NULL,
	Rate float NULL,
	[Text] varchar (5000) NULL,

    CONSTRAINT FK_ProductReview_Product FOREIGN KEY (ProductId) REFERENCES Product.Product(Id)
)

COMMIT TRAN
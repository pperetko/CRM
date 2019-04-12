CREATE TABLE dbo.customers (
  id_customers int IDENTITY(1, 1) NOT NULL,
  name varchar(100) COLLATE SQL_Polish_CP1250_CI_AS NOT NULL,
  prename varchar(100) COLLATE SQL_Polish_CP1250_CI_AS NOT NULL,
  nationality varchar(3) COLLATE SQL_Polish_CP1250_CI_AS NULL,
  state varchar(100) COLLATE SQL_Polish_CP1250_CI_AS NULL,
  city varchar(100) COLLATE SQL_Polish_CP1250_CI_AS NULL,
  street varchar(100) COLLATE SQL_Polish_CP1250_CI_AS NULL,
  No varchar(50) COLLATE SQL_Polish_CP1250_CI_AS NULL,
  dob date NULL,
  CONSTRAINT PK_Customers PRIMARY KEY CLUSTERED (id_customers)
    WITH (
      PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF,
      ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
ON [PRIMARY]
GO
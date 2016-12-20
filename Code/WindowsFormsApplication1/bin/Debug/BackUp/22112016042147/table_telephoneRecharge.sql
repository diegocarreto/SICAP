create table [telephoneRecharge] (
  [id] int IDENTITY(1,1) NOT NULL ,
  [phone] varchar(10)  NOT NULL ,
  [folio] varchar(10)  NOT NULL ,
  [companyName] varchar(100)  NOT NULL ,
  [plan] varchar(200)  NOT NULL ,
  [amount] money  NOT NULL ,
  [successful] bit  NOT NULL ,
  [message] varchar(500)  NOT NULL ,
  [createDate] datetime  NOT NULL DEFAULT (getdate())
)

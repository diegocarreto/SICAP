create table [purchase] (
  [id] int IDENTITY(1,1) NOT NULL ,
  [name] varchar(50)  NOT NULL ,
  [date] date  NOT NULL ,
  [total] money  NOT NULL ,
  [path] varchar(1000)  NULL ,
  [deleted] bit  NOT NULL DEFAULT ((0)),
  [createDate] datetime  NOT NULL DEFAULT (getdate()),
  [deletedDate] datetime  NULL ,
  [idSaleFather] int  NULL ,
  [idCompany] int  NOT NULL ,
  PRIMARY KEY (
   [id]
  )
)

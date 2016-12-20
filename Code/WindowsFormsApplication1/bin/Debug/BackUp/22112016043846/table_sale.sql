create table [sale] (
  [id] int IDENTITY(1,1) NOT NULL ,
  [total] money  NOT NULL ,
  [deleted] bit  NOT NULL DEFAULT ((0)),
  [createDate] datetime  NOT NULL DEFAULT (getdate()),
  [deletedDate] datetime  NULL ,
  [idClient] int  NOT NULL ,
  [freight] bit  NOT NULL DEFAULT ((0)),
  [cancel] bit  NULL DEFAULT ((0)),
  [cancelDate] datetime  NULL ,
  [idSaleFather] int  NULL ,
  [idCompany] int  NULL ,
  [reference] varchar(12)  NULL ,
  PRIMARY KEY (
   [id]
  )
)

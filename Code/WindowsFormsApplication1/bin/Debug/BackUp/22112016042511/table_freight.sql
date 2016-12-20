create table [freight] (
  [id] int IDENTITY(1,1) NOT NULL ,
  [idPM] int  NOT NULL ,
  [idDestination] int  NOT NULL ,
  [cost] money  NOT NULL ,
  [min] float  NULL ,
  [max] float  NULL ,
  [active] bit  NOT NULL DEFAULT ((1)),
  [deleted] bit  NOT NULL DEFAULT ((0)),
  [createDate] datetime  NOT NULL DEFAULT (getdate()),
  [updateDate] datetime  NULL ,
  [deletedDate] datetime  NULL ,
  [default] bit  NULL DEFAULT ((0)),
  [costUni] money  NULL ,
  PRIMARY KEY (
   [id]
  )
)

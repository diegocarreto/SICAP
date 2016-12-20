create table [box] (
  [id] int IDENTITY(1,1) NOT NULL ,
  [amount] money  NOT NULL ,
  [open] datetime  NOT NULL DEFAULT (getdate()),
  [close] datetime  NULL ,
  [cashRegister] int  NOT NULL ,
  [idUser] int  NOT NULL DEFAULT ((1)),
  [idUserOpen] int  NOT NULL DEFAULT ((1)),
  [IdUserClose] int  NOT NULL DEFAULT ((1)),
  [finalAmount] money  NOT NULL DEFAULT ((0)),
  PRIMARY KEY (
   [id]
  )
)

create table [detailSale] (
  [id] int IDENTITY(1,1) NOT NULL ,
  [idSale] int  NOT NULL ,
  [idPM] int  NOT NULL ,
  [amount] float  NOT NULL ,
  [unitary] money  NOT NULL ,
  [price] money  NOT NULL ,
  PRIMARY KEY (
   [idSale],
   [idPM]
  )
)

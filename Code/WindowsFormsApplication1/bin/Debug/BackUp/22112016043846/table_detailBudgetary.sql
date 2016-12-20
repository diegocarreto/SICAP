create table [detailBudgetary] (
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

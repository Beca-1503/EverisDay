CREATE TABLE PEDIDO(
IDPEDIDO INT IDENTITY(1,1) PRIMARY KEY  NOT NULL,
CPF VARCHAR (11)  NOT NULL, 
DATA_PEDIDO VARCHAR(50) NOT NULL ,
PRECO_TOTAL DECIMAL(18,02) NOT NULL,
FORMA_DE_PAGAMENTO VARCHAR(80) NOT NULL,
STATUS_PEDIDO VARCHAR(50) NOT NULL
);
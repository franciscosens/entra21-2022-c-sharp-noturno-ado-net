--DROP TABLE pedidos_produtos;
--DROP TABLE pedidos;
--DROP TABLE produtos;
--DROP TABLE clientes;

CREATE TABLE clientes(
	id INTEGER PRIMARY KEY IDENTITY(1,1),

	nome VARCHAR(100) NOT NULL, -- tamanho variável até 100 caracteres
	cpf CHAR(14) NOT NULL, -- tamamho fixo de 14
	renda DECIMAL(8, 2) NOT NULL,
	eh_inadimplente BIT NOT NULL, -- boolean
	data_nascimento DATETIME2 NOT NULL
);

CREATE TABLE produtos(
	id INTEGER PRIMARY KEY IDENTITY(1,1),

	nome VARCHAR(100) NOT NULL,
	valor_unitario DECIMAL(8,2) NOT NULL
);

CREATE TABLE pedidos(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	id_cliente  INTEGER NOT NULL,

	valor_total DECIMAL(10, 2) NOT NULL,
	data_compra DATETIME2 NOT NULL,

	FOREIGN KEY(id_cliente) REFERENCES clientes(id)
);

CREATE TABLE pedidos_produtos(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	id_pedido  INTEGER NOT NULL,
	id_produto INTEGER NOT NULL,

	quantidade INTEGER NOT NULL,
	
	FOREIGN KEY(id_pedido) REFERENCES pedidos(id),
	FOREIGN KEY(id_produto) REFERENCES produtos(id)
);

INSERT INTO produtos (nome, valor_unitario) VALUES
('TV 55 SAMSUNG QLED 4k', 3491.20),
('TV 65 SAMSUNG QLED 4k', 5034.05),
('TV 70 SAMSUNG QLED 4k', 6719.04),
('TV 85 SAMSUNG QLED 4k', 25999.00),
('Xbox Series X', 4521.92),
('Xbox Series S', 2049.99),
('PlayStation 5 com disco', 5299.90),
('PlayStation 5 sem disco', 4779.00),
('Nintendo Switch Lite', 1516.16),
('Nintendo Switch', 2420.00),
('Nintendo Switch OLED', 2664.21);

INSERT INTO clientes (nome, renda, data_nascimento, cpf, eh_inadimplente) VALUES
('Theo Caio da Rocha', 9850.30, '1983-03-03', '609.445.458-82', 1), -- Inadimplente
('Raquel Jaqueline Mendes', 5329.19, '1986-05-04', '369.301.807-34', 0),
('Aurora Ester Bernardes', 12392.21, '1986-03-15', '612.255.280-11', 0);

INSERT INTO pedidos (id_cliente, valor_total, data_compra) VALUES
(2, 25924.11, '2022-01-10' ), -- Raquel
(1, 5541.19, '2022-03-30'); -- Theo

INSERT INTO pedidos_produtos (id_pedido, id_produto, quantidade) VALUES
(1, 3, 2), -- Raquel, TV 70 SAMSUNG QLED 4k, qtd: 2
(1, 5, 1), -- Raquel, Xbox Series X, qtd: 1
(1, 7, 1), -- Raquel, PlayStation 5 com disco, qtd: 1
(1, 11, 1), -- Raquel, Nintendo Switch OLED, qtd: 1
(2, 1, 1), -- Theo, TV 55 SAMSUNG QLED 4k, qtd: 1
(2, 6, 1); -- Theo, Xbox Series S, qtd: 1

SELECT * FROM clientes;
SELECT * FROM produtos;
SELECT * FROM pedidos;
SELECT * FROM pedidos_produtos;

SELECT 
	cli.nome AS 'Cliente', 
	ped.id AS 'Número do pedido',
	ped.valor_total AS 'Valor total do pedido',
	pro.nome AS 'Produto',
	pp.quantidade AS  'Quantidade',
	pro.valor_unitario AS 'Valor Unitário',
	(pro.valor_unitario * pp.quantidade) AS 'Valor total'
	FROM pedidos AS ped
	INNER JOIN pedidos_produtos AS pp ON(ped.id = pp.id_pedido)
	INNER JOIN produtos AS pro ON(pp.id_produto = pro.id)
	INNER JOIN clientes AS cli ON(ped.id_cliente = cli.id);
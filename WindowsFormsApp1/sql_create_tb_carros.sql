-- Script SQL: cria a tabela tb_carros usada pelo formulário
-- Execute no MySQL/MariaDB (ajuste charset/collation se necessário)

CREATE TABLE IF NOT EXISTS tb_carros (
  id_carro INT AUTO_INCREMENT PRIMARY KEY,
  placa VARCHAR(50) NOT NULL UNIQUE,
  modelo VARCHAR(100) DEFAULT NULL,
  marca VARCHAR(100) DEFAULT NULL,
  combustivel VARCHAR(50) DEFAULT NULL,
  cor VARCHAR(50) DEFAULT NULL,
  ano INT DEFAULT NULL,
  quilometragem INT DEFAULT NULL,
  preco DECIMAL(10,2) DEFAULT 0,
  foto LONGBLOB DEFAULT NULL,
  foto_path VARCHAR(300) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Exemplo de uso:
-- INSERT INTO tb_carros (marca, modelo, placa, combustivel, quilometragem, ano, cor, preco, foto)
-- VALUES ('Fiat','Uno','ABC1234','Flex',12345.67,2015,'Prata',25000.00,'C:/imagens/uno.jpg');

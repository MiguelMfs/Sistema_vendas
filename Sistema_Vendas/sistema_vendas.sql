-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: localhost    Database: sistema_vendas
-- ------------------------------------------------------
-- Server version	8.2.0

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cliente` (
  `idcliente` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(200) NOT NULL,
  `cpf_cnpj` varchar(20) DEFAULT NULL,
  `telefone` varchar(15) DEFAULT NULL,
  `email` varchar(200) DEFAULT NULL,
  `logradouro` varchar(200) DEFAULT NULL,
  `bairro` varchar(200) DEFAULT NULL,
  `cidade` varchar(200) NOT NULL,
  `uf` varchar(2) DEFAULT NULL,
  PRIMARY KEY (`idcliente`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES (1,'Ana Silva','123.456.789-00','(11) 1234-5678','ana@email.com','Rua das Flores, 123','Centro','São Paulo','SP'),(2,'Carlos Oliveira 1212','987.654.321-00','(22) 9876--5432','carlos@email.com','Avenida Principal, 456','Centro','Rio de Janeiro','RJ'),(3,'Mariana Santos','111.222.333-00','(33) 3333-3333','mariana@email.com','Rua das Palmeiras, 789','Jardins','Belo Horizonte','MG'),(4,'Rafael Lima','555.666.777-00','(44) 4444-4444','rafael@email.com','Rua do Comércio, 321','Centro','Porto Alegre','RS'),(5,'Juliana Pereira','999.888.777-00','(55) 5555-5555','juliana@email.com','Avenida Industrial, 654','Industrial','Curitiba','PR'),(6,'Fernando Costa','444.333.222-00','(66) 6666-6666','fernando@email.com','Rua das Indústrias, 987','Industrial','Salvador','BA'),(7,'Patrícia Oliveira','777.888.999-00','(77) 7777-7777','patricia@email.com','Avenida das Árvores, 753','Jardim Botânico','Brasília','DF'),(8,'Gustavo Pereira','222.111.000-00','(88) 8888-8888','gustavo@email.com','Rua dos Pássaros, 159','Centro','Fortaleza','CE'),(9,'Bruna Santos','666.555.444-00','(99) 9999-9999','bruna@email.com','Avenida das Flores, 357','Jardins','Manaus','AM'),(10,'Thiago Oliveira','333.444.555-00','(00) 0000-0000','thiago@email.com','Rua dos Coqueiros, 753','Centro','Recife','PE'),(11,'Aline Lima','123.321.321-00','(11) 1111-1111','aline@email.com','Avenida Principal, 951','Centro','Natal','RN'),(12,'Daniel Souza','654.321.987-00','(22) 2222-2222','daniel@email.com','Rua das Oliveiras, 159','Jardim','Maceió','AL'),(13,'Luiza Martins','987.123.654-00','(33) 3333-3333','luiza@email.com','Avenida das Rosas, 753','Floricultura','Aracaju','SE'),(14,'Pedro Alves','222.666.999-00','(44) 4444-4444','pedro@email.com','Rua das Laranjeiras, 357','Centro','Campo Grande','MS'),(15,'Luciana Costa','000.111.222-00','(55) 5555-5555','luciana@email.com','Avenida dos Ipês, 951','Jardim','Teresina','PI'),(16,'Fábio Santos','666.222.888-00','(66) 6666-6666','fabio@email.com','Rua das Mangueiras, 159','Centro','Cuiabá','MT'),(17,'Paula Oliveira','555.222.555-00','(77) 7777-7777','paula@email.com','Avenida das Bromélias, 753','Jardim','João Pessoa','PB'),(18,'Roberto Lima','333.555.777-00','(88) 8888-8888','roberto@email.com','Rua das Acácias, 357','Centro','Florianópolis','SC'),(19,'Ana Carolina','999.111.999-00','(99) 9999-9999','ana.carol@email.com','Avenida das Margaridas, 951','Jardim','Vitória','ES'),(20,'Ricardo Almeida','123.321.123-00','(00) 0000-0000','ricardo@email.com','Rua das Violetas, 159','Centro','Goiânia','GO'),(21,'Eduardo Gomes','000.000.000-00','(99) 99999-9999','teste@teste.com','uuuuuuuuuuuuuuuu','uuuuuuuuuuuuuuuuu','uuuuuuu','SC'),(24,'fdfdfdfd','999.999.999-99','(44) 44444-4444','jhjkhjhjk','hjhjkhjk','hjkhjkhk','hjhkj','GO'),(25,'Gustavo Pereira','222.111.000-00','(88) 8888--8888','gustavo@email.com','Rua dos Pássaros, 159','Centro','Fortaleza','CE'),(26,'Paula Oliveira','555.222.555-00','(77) 7777--7777','paula@email.com','Avenida das Bromélias, 753','Jardim','João Pessoa','PB');
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fornecedor`
--

DROP TABLE IF EXISTS `fornecedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `fornecedor` (
  `idfornecedor` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(200) NOT NULL,
  `cpf_cnpj` varchar(20) DEFAULT NULL,
  `telefone` varchar(15) DEFAULT NULL,
  `email` varchar(200) DEFAULT NULL,
  `logradouro` varchar(200) DEFAULT NULL,
  `bairro` varchar(200) DEFAULT NULL,
  `cidade` varchar(200) NOT NULL,
  `uf` varchar(2) DEFAULT NULL,
  PRIMARY KEY (`idfornecedor`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fornecedor`
--

LOCK TABLES `fornecedor` WRITE;
/*!40000 ALTER TABLE `fornecedor` DISABLE KEYS */;
INSERT INTO `fornecedor` VALUES (1,'TechSolutions','12.345.678/0001-01','(11) 1234-5678','contato@techsolutions.com','Rua dos Tecnólogos, 123','Tecnopark','São Paulo','SP'),(2,'MobileTech','98.765.432/0001-02','(22) 9876-5432','contato@mobiletech.com','Avenida das Inovações, 456','Techcenter','Rio de Janeiro','RJ'),(3,'ByteMaster','11.22.33/0001-03','(33) 3333-3333','contato@bytemaster.com','Rua dos Programadores, 789','Codeville','Belo Horizonte','MG'),(4,'SmartGadget','55.66.77/0001-04','(44) 4444-4444','contato@smartgadget.com','Avenida dos Smartphones, 321','Techsquare','Porto Alegre','RS'),(5,'FutureTech','99.88.77/0001-05','(55) 5555-5555','contato@futuretech.com','Rua das Futurísticas, 654','Futurum','Curitiba','PR'),(6,'Digital Dynamics','44.33.22/0001-06','(66) 6666-6666','contato@digitaldynamics.com','Avenida das Tendências, 987','Techvalley','Salvador','BA'),(7,'GigaByte','77.88.99/0001-07','(77) 7777-7777','contato@gigabyte.com','Rua das Gigabytes, 753','Techville','Brasília','DF'),(8,'MicroTrends','22.11.00/0001-08','(88) 8888-8888','contato@microtrends.com','Avenida dos Micros, 159','Techcentral','Fortaleza','CE'),(9,'Computron','66.55.44/0001-09','(99) 9999-9999','contato@computron.com','Rua dos Computadores, 357','Techplaza','Manaus','AM'),(10,'NetGadget','33.44.55/0001-10','(00) 0000-0000','contato@netgadget.com','Avenida das Redes, 951','Techpark','Recife','PE'),(11,'FastTech','12.32.32/0001-11','(11) 1111-1111','contato@fasttech.com','Rua dos Velozes, 951','Techarea','Natal','RN'),(12,'DataLogic','65.43.21/0001-12','(22) 2222-2222','contato@datalogic.com','Avenida dos Dados, 159','Techland','Maceió','AL'),(13,'Infotech','98.71.65/0001-13','(33) 3333-3333','contato@infotech.com','Rua das Informações, 753','Techcenter','Aracaju','SE'),(14,'Cybertron','22.66.99/0001-14','(44) 4444-4444','contato@cybertron.com','Avenida dos Cibernéticos, 357','Techplaza','Campo Grande','MS'),(15,'MegaByte','00.11.22/0001-15','(55) 5555-5555','contato@megabyte.com','Rua dos Megas, 951','Techpark','Teresina','PI'),(16,'MicroWorld','66.22.88/0001-16','(66) 6666-6666','contato@microworld.com','Avenida dos Micromundos, 159','Techland','Cuiabá','MT'),(17,'TechWare','55.22.55/0001-17','(77) 7777-7777','contato@techware.com','Rua dos Techs, 753','Techville','João Pessoa','PB'),(18,'GadgetZone','33.55.77/0001-18','(88) 8888-8888','contato@gadgetzone.com','Avenida dos Gadgets, 357','Techplaza','Florianópolis','SC'),(19,'NanoTech','99.11.99/0001-19','(99) 9999-9999','contato@nanotech.com','Rua dos Nanos, 951','Techpark','Vitória','ES'),(20,'Computech','12.33.12/0001-20','(00) 0000-0000','contato@computech.com','Avenida dos Computadores, 159','Techcenter','Goiânia','GO');
/*!40000 ALTER TABLE `fornecedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `produto`
--

DROP TABLE IF EXISTS `produto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `produto` (
  `idproduto` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(200) DEFAULT NULL,
  `unidade_medida` varchar(3) DEFAULT NULL,
  `marca` varchar(60) DEFAULT NULL,
  `cor` varchar(45) DEFAULT NULL,
  `quantidade` decimal(10,2) DEFAULT NULL,
  `valor_unitario` decimal(10,2) DEFAULT NULL,
  `idfornecedor` int NOT NULL,
  PRIMARY KEY (`idproduto`),
  KEY `fk_produto_fornecedor1_idx` (`idfornecedor`),
  CONSTRAINT `fk_produto_fornecedor1` FOREIGN KEY (`idfornecedor`) REFERENCES `fornecedor` (`idfornecedor`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `produto`
--

LOCK TABLES `produto` WRITE;
/*!40000 ALTER TABLE `produto` DISABLE KEYS */;
INSERT INTO `produto` VALUES (1,'Smartphone X','UN','MarcaX','Preto',100.00,1500.00,1),(2,'Notebook Y','UN','MarcaY','Prata',50.00,3000.00,2),(3,'Tablet Z','UN','MarcaZ','Branco',80.00,2000.00,3),(4,'Desktop A','UN','MarcaA','Preto',30.00,2500.00,4),(5,'Router B','UN','MarcaB','Branco',120.00,200.00,5),(6,'Monitor C','UN','MarcaC','Cinza',70.00,800.00,6),(7,'SSD D','UN','MarcaD','Prata',200.00,400.00,7),(8,'Mouse E','UN','MarcaE','Preto',300.00,50.00,8),(9,'Keyboard F','UN','MarcaF','Preto',200.00,80.00,9),(10,'Printer G','UN','MarcaG','Branco',100.00,300.00,10),(11,'Scanner H','UN','MarcaH','Preto',50.00,150.00,11),(12,'VR Headset I','UN','MarcaI','Preto',80.00,700.00,12),(13,'Smartwatch J','UN','MarcaJ','Preto',150.00,400.00,13),(14,'Gaming Console K','UN','MarcaK','Preto',100.00,600.00,14),(15,'Smart Speaker L','UN','MarcaL','Branco',120.00,200.00,15),(16,'Data Storage M','UN','MarcaM','Preto',300.00,100.00,16),(17,'Printer N','UN','MarcaN','Preto',80.00,250.00,17),(18,'Scanner O','UN','MarcaO','Preto',50.00,200.00,18),(19,'Projector P','UN','MarcaP','Preto',30.00,1000.00,19),(20,'Earbuds Q','UN','MarcaQ','Preto',200.00,150.00,20);
/*!40000 ALTER TABLE `produto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuario` (
  `idusuario` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(200) NOT NULL,
  `login` varchar(40) NOT NULL,
  `senha` varchar(64) DEFAULT NULL,
  `telefone` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`idusuario`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (1,'João Silva','joaosilva','joaosilvasenha','(11) 1234-5678'),(2,'Maria Oliveira','mariaoliveira','mariaoliveirasenha','(22) 9876-5432'),(3,'Pedro Santos','pedrosantos','pedrosantossenha','(33) 3333-3333'),(4,'Juliana Lima','julianalima','julianalimasenha','(44) 4444-4444'),(5,'Lucas Costa','lucascosta','lucascostasenha','(55) 5555-5555'),(6,'Fernanda Souza','fernandasouza','fernandasouzasenha','(66) 6666-6666'),(7,'Matheus Alves','matheusalves','matheusalvessenha','(77) 7777-7777'),(8,'Mariana Silva','marianasilva','marianasilvasenha','(88) 8888-8888'),(9,'Rodrigo Oliveira','rodrigooliveira','rodrigooliveirasenha','(99) 9999-9999'),(10,'Camila Santos','camilasantos','camilasantossenha','(00) 0000-0000'),(11,'Anderson Lima','andersonlima','andersonlimasenha','(11) 1111-1111'),(12,'Amanda Costa','amandacosta','amandacostasenha','(22) 2222-2222'),(13,'Gustavo Pereira','gustavopereira','gustavopereirasenha','(33) 3333-3333'),(14,'Patricia Oliveira','patriciaoliveira','patriciaoliveirasenha','(44) 4444-4444'),(15,'Marcos Silva','marcossilva','marcossilvasenha','(55) 5555-5555'),(16,'Laura Santos','laurasantos','laurasantossenha','(66) 6666-6666'),(17,'Guilherme Costa','guilhermecosta','guilhermecostasenha','(77) 7777-7777'),(18,'Carolina Lima','carolinalima','carolinalimasenha','(88) 8888-8888'),(19,'Rafael Almeida','rafaelalmeida','rafaelalmeidasenha','(99) 9999-9999'),(20,'Ana Clara','anaclara','anaclarasenha','(00) 0000-0000');
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `venda`
--

DROP TABLE IF EXISTS `venda`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `venda` (
  `idvenda` int NOT NULL AUTO_INCREMENT,
  `idcliente` int NOT NULL,
  `data_venda` datetime DEFAULT NULL,
  `valor_total` decimal(10,2) DEFAULT NULL,
  `idusuario` int NOT NULL,
  PRIMARY KEY (`idvenda`),
  KEY `fk_ordem_servico_cliente1_idx` (`idcliente`),
  KEY `fk_ordem_servico_usuario1_idx` (`idusuario`),
  CONSTRAINT `fk_vendas_cliente1` FOREIGN KEY (`idcliente`) REFERENCES `cliente` (`idcliente`),
  CONSTRAINT `fk_vendas_usuario1` FOREIGN KEY (`idusuario`) REFERENCES `usuario` (`idusuario`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `venda`
--

LOCK TABLES `venda` WRITE;
/*!40000 ALTER TABLE `venda` DISABLE KEYS */;
INSERT INTO `venda` VALUES (1,1,'2024-03-15 10:00:00',5600.00,1),(2,2,'2024-03-15 11:30:00',8800.00,2),(3,3,'2024-03-15 12:45:00',1100.00,3),(4,4,'2024-03-15 14:15:00',1000.00,4),(5,5,'2024-03-15 15:30:00',2700.00,5),(6,6,'2024-03-15 16:45:00',950.00,6),(7,7,'2024-03-15 18:00:00',840.00,7),(8,8,'2024-03-15 19:15:00',3550.00,8),(9,9,'2024-03-15 20:30:00',6700.00,9),(10,10,'2024-03-15 21:45:00',2200.00,10),(11,11,'2024-03-15 10:00:00',1150.00,11),(12,12,'2024-03-15 11:30:00',1080.00,12),(13,13,'2024-03-15 12:45:00',3550.00,13),(14,14,'2024-03-15 14:15:00',6700.00,14),(15,15,'2024-03-15 15:30:00',2200.00,15),(16,16,'2024-03-15 16:45:00',1150.00,16),(17,17,'2024-03-15 18:00:00',1080.00,17),(18,18,'2024-03-15 19:15:00',3550.00,18),(19,19,'2024-03-15 20:30:00',6700.00,19),(20,20,'2024-03-15 21:45:00',2200.00,20);
/*!40000 ALTER TABLE `venda` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `venda_produto`
--

DROP TABLE IF EXISTS `venda_produto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `venda_produto` (
  `idvenda` int NOT NULL,
  `idproduto` int NOT NULL,
  `quantidade` decimal(10,2) DEFAULT NULL,
  `valor_unitario` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`idvenda`,`idproduto`),
  KEY `fk_ordem_servico_has_produto_produto1_idx` (`idproduto`),
  KEY `fk_ordem_servico_has_produto_ordem_servico1_idx` (`idvenda`),
  CONSTRAINT `fk_vendas_has_produto1` FOREIGN KEY (`idvenda`) REFERENCES `venda` (`idvenda`),
  CONSTRAINT `fk_vendas_has_produto_produto1` FOREIGN KEY (`idproduto`) REFERENCES `produto` (`idproduto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `venda_produto`
--

LOCK TABLES `venda_produto` WRITE;
/*!40000 ALTER TABLE `venda_produto` DISABLE KEYS */;
INSERT INTO `venda_produto` VALUES (1,1,2.00,1500.00),(1,3,1.00,2000.00),(1,5,3.00,200.00),(2,2,1.00,3000.00),(2,4,2.00,2500.00),(2,6,1.00,800.00),(3,8,2.00,80.00),(3,10,1.00,300.00),(3,12,1.00,700.00),(4,14,1.00,600.00),(4,16,2.00,100.00),(4,18,1.00,200.00),(5,17,1.00,250.00),(5,19,2.00,1000.00),(5,20,3.00,150.00),(6,11,1.00,150.00),(6,13,1.00,400.00),(6,15,2.00,200.00),(7,5,1.00,200.00),(7,7,1.00,400.00),(7,9,3.00,400.00),(8,1,1.00,1500.00),(8,3,1.00,2000.00),(8,8,1.00,80.00),(9,2,2.00,3000.00),(9,7,1.00,800.00),(9,10,1.00,300.00),(10,12,1.00,700.00),(10,17,2.00,250.00),(10,19,1.00,1000.00),(11,11,1.00,150.00),(11,13,2.00,400.00),(11,15,1.00,200.00),(12,5,1.00,200.00),(12,7,2.00,400.00),(12,9,1.00,400.00),(13,1,1.00,1500.00),(13,3,1.00,2000.00),(13,8,1.00,80.00),(14,2,2.00,3000.00),(14,7,1.00,800.00),(14,10,1.00,300.00),(15,12,1.00,700.00),(15,17,2.00,250.00),(15,19,1.00,1000.00),(16,11,1.00,150.00),(16,13,2.00,400.00),(16,15,1.00,200.00),(17,5,1.00,200.00),(17,7,2.00,400.00),(17,9,1.00,400.00),(18,1,1.00,1500.00),(18,3,1.00,2000.00),(18,8,1.00,80.00),(19,2,2.00,3000.00),(19,7,1.00,800.00),(19,10,1.00,300.00),(20,12,1.00,700.00),(20,17,2.00,250.00),(20,19,1.00,1000.00);
/*!40000 ALTER TABLE `venda_produto` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;



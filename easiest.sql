-- phpMyAdmin SQL Dump
-- version 3.5.1
-- http://www.phpmyadmin.net
--
-- Servidor: localhost
-- Tiempo de generación: 21-06-2017 a las 19:26:50
-- Versión del servidor: 5.5.24-log
-- Versión de PHP: 5.4.3

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de datos: `easiest`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `descpermisos`
--

CREATE TABLE IF NOT EXISTS `descpermisos` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `tipo` int(11) NOT NULL,
  `descripcion` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=7 ;

--
-- Volcado de datos para la tabla `descpermisos`
--

INSERT INTO `descpermisos` (`id`, `tipo`, `descripcion`) VALUES
(1, 1, 'Alta de Usuarios'),
(2, 2, 'Modificación de Usuarios'),
(3, 3, 'Bajas de Usuarios'),
(4, 4, 'Consultas Básicas'),
(5, 5, 'Consultas Avanzadas'),
(6, 6, 'Exportación de Logs');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empleados`
--

CREATE TABLE IF NOT EXISTS `empleados` (
  `id` int(11) NOT NULL,
  `dni` varchar(9) COLLATE utf8_spanish2_ci NOT NULL,
  `nombre` text COLLATE utf8_spanish2_ci NOT NULL,
  `apellido` text COLLATE utf8_spanish2_ci NOT NULL,
  `fechnac` date NOT NULL,
  `email` text COLLATE utf8_spanish2_ci NOT NULL,
  `direccion` text COLLATE utf8_spanish2_ci NOT NULL,
  `ciudad` text COLLATE utf8_spanish2_ci NOT NULL,
  `pais` text COLLATE utf8_spanish2_ci NOT NULL,
  `telefono` int(9) NOT NULL,
  `trabajo` text COLLATE utf8_spanish2_ci NOT NULL,
  `salario` double NOT NULL,
  `restaurante` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci;

--
-- Volcado de datos para la tabla `empleados`
--

INSERT INTO `empleados` (`id`, `dni`, `nombre`, `apellido`, `fechnac`, `email`, `direccion`, `ciudad`, `pais`, `telefono`, `trabajo`, `salario`, `restaurante`) VALUES
(0, '02717657t', 'Pablo', 'de Luis Duarte', '2017-02-03', 'deluisp@gmail.com', 'Avda.Bruselas 41', 'Madrid', 'España', 626842423, 'Camarero', 20000, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ingredientes`
--

CREATE TABLE IF NOT EXISTS `ingredientes` (
  `id` int(11) NOT NULL,
  `nombre` varchar(30) NOT NULL,
  `tipo` int(11) NOT NULL,
  `descripcion` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `ingredientes`
--

INSERT INTO `ingredientes` (`id`, `nombre`, `tipo`, `descripcion`) VALUES
(1, 'Vaca', 1, 'Calorias 143 \nGrasas totales 3.5 g	\nAcidos grasos saturados 1.2 g	\nAcidos grasos poliinsaturados 0.5 g	\nAcidos grasos monoinsaturados 1.3 g	\nAcidos grasos trans 0 g	\nColesterol 73 mg	\nSodio 57 mg	\nPotasio 421 mg \nHidratos de carbono 0 g	\nFibra alimentaria 0 g	\nAzucares 0 g	\nProteinas 26 g	\nVitamina A	0 IU	\nVitamina C	0 mg \nCalcio	6 mg	\nHierro 	1.2 mg \nVitamina D 	10 IU	\nVitamina B 6	0.7 mg \nVitamina B 12	0.6 mg	\nMagnesio 	29 mg'),
(2, 'Pollo', 2, 'Calorias 239'),
(3, 'Ternera', 2, 'Calorias 250\nGrasas totales 15 g	\nAcidos grasos saturados 6 g	\nAcidos grasos poliinsaturados 0.5 g	\nAcidos grasos monoinsaturados 7 g	\nAcidos grasos trans 1.1 g	\nColesterol 90 mg	\nSodio 72 mg	\nPotasio 318 mg	\nHidratos de carbono 0 g	\nFibra alimentaria 0 g	\nAzucares 0 g	\nProteinas 26 g	\nVitamina A	0 IU	\nVitamina C	0 mg\nCalcio	18 mg	\nHierro	2.6 mg\nVitamina D	7 IU	\nVitamina B6	0.4 mg\nVitamina B12	2.6 mg	\nMagnesio	21 mg'),
(4, 'Cordero', 1, 'Calorias 294\nGrasas totales 21 g	\nAcidos grasos saturados 9 g	\nAcidos grasos poliinsaturados 1.5 g	\nAcidos grasos monoinsaturados 9 g	\nColesterol 97 mg	\nSodio 72 mg	\nPotasio 310 mg	\nHidratos de carbono 0 g	\nFibra alimentaria 0 g	\nAzucares 0 g	\nProteinas 25 g	\nVitamina A	0 IU	\nVitamina C	0 mg\nCalcio	17 mg	\nHierro	1.9 mg\nVitamina D	2 IU	\nVitamina B6	0.1 mg\nVitamina B12	2.6 mg	\nMagnesio	23 mg'),
(5, 'Caballo', 1, 'Calorias: 107 kcal\nProteinas: 20.5 g\nHidratos de carbono: Trazas\nGrasas: 2.7 g\nFibra: 0 g\nColesterol: 60 mg\nVitaminas:\n   Vitamina A: 21 mg\n   Vitamina B1: 0.04 mg\n   Vitamina B2: 0.27 mg\n   Vitamina B3: 0.1 mg\n   Vitamina B6: 0.27 mg\n   Vitamina E: 0.1 mg\nMinerales:\n   Potasio: 335 mg\n   Calcio: 13 mg\n   Fosforo: 185 mg\n   Magnesio: 23 mg\n   Hierro: 4.5 mg\n   Sodio: 44 mg'),
(6, 'Conejo', 2, 'Calorias: 140 Calorias\nProteinas: 10.35 gramos.\nGrasa: 5.30 g.\nPurinas: 132 mg.\nColesterol: 71.95 mg.\nVitaminas: \n     vitamina A (0.35 ug.)\n     vitamina B1 (0.10 mg.)\n     vitamina B2 (0.12 mg.)\n     vitamina B3 (10.99 mg.)\n     vitamina B5 (0.80 ug.)\n     vitamina B6 (0.40 mg.)\n     vitamina B7 (1 ug.)\n     vitamina B9 (4.85 ug.)\n     vitamina E (0.28 mg.)\n     vitamina K (4 ug.).\nMinerales: \n     calcio (22.80 mg.)\n     potasio (350 mg.)\n     sodio (45 mg.)\n     Fosforo (215 mg.).'),
(7, 'Cerdo', 2, 'Grasas totales 14 g	\nAcidos grasos saturados 5 g	\nAcidos grasos poliinsaturados 1.2 g	\nAcidos grasos monoinsaturados 6 g	\nColesterol 80 mg	\nSodio 62 mg	\nPotasio 423 mg	\nHidratos de carbono 0 g	\nFibra alimentaria 0 g	\nAzucares 0 g	\nProteinas 27 g	\nVitamina A	7 IU	\nVitamina C	0.6 mg\nCalcio	19 mg	\nHierro	0.9 mg\nVitamina D	53 IU	\nVitamina B6	0.5 mg\nVitamina B12	0.7 mg	\nMagnesio	28 mg'),
(8, 'Pato', 1, 'Valor calorico 	\n5.123 kcal 21.448 kJ\nGrasas 498.8 g\n  Grasas saturadas 167.6 g\n  Grasas monoinsaturadas 237.0 g\n  Grasas poliinsaturadas 64.4 g\nCarbohidratos 0.0 g\n  Azucares 0.0 g\nProteinas 145.7 g\nFibra alimentaria 0.0 g\nColesterol 963.7 mg\nSodio 0.8 g\nAgua 615.0 g'),
(9, 'Melon', 3, 'Azucares 	7.86 g\nFibra alimentaria 	0.90 g\nGrasas 	0.19 g\nProteinas 	0.84 g\nTiamina (vit. B1) 	0.041 mg (3%)\nRiboflavina (vit. B2) 	0.019 mg (1%)\nNiacina (vit. B3) 	0.734 mg (5%)\nAcido pantotenico (vit. B5) 	0.105 mg (2%)\nVitamina B6 	0.072 mg (6%)\nVitamina C 	36.7 mg (61%)\nVitamina E 	0.05 mg (0%)\nVitamina K 	0.002 ?g (0%)\nCalcio 	9 mg (1%)\nHierro 	0.21 mg (2%)\nFosforo 	15 mg (2%)\nPotasio 	267 mg (6%)\nSodio 	16 mg (1%)'),
(10, 'Zarzamora', 4, 'Agua 	                88.15g\nProteinas 	        1.39g\nLipidos 	        0.49g\nCeniza 	                0.37g\nHidratos de Carbono 	9.61g'),
(11, 'Grosella Roja', 4, 'Calorias             35 kcal.\nProteinas            0.90 g\nHidratos de carbono  4.4 g\nGrasas totales       2.1 g\nFibra                4.4 g\nIndice glucimico     50		\nVitaminas		\nMinerales\nVitamina A            270 IU.\nPotasio               198 mg.\nVitamina B1           0.04 mg.\nCalcio                25 mg.\nVitamina B2           0.03 mg.	\nMagnesio              10 mg.\nVitamina B3           0.3 mg.\nManganeso             0.14 mg.\nVitamina B5           0.28 mg.\nHierro                0.32 mg.\nVitamina B6           0.08 mg.\nSodio                 1 mg.\nVitamina C            27 mg.\nZinc                  0.12 mg.\nVitamina E	      0.37 mg.\nCobre                 0.07 mg.\nFosforo               27 mg.'),
(12, 'Pomelo', 5, 'Calorias 42\nGrasas totales 0.1 g	\nAcidos grasos saturados 0 g	\nAcidos grasos poliinsaturados 0 g	\nAcidos grasos monoinsaturados 0 g	\nColesterol 0 mg	\nSodio 0 mg	\nPotasio 135 mg	\nHidratos de carbono 11 g	\nFibra alimentaria 1.6 g	\nAzucares 7 g	\nProteinas 0.8 g	\nVitamina A	1.150 IU	\nVitamina C	31.2 mg\nCalcio	22 mg	\nHierro	0.1 mg\nVitamina D	0 IU	\nVitamina B6	0.1 mg\nVitamina B12	0 mg	\nMagnesio	9 mg'),
(13, 'Nectarina', 6, 'Calorias 44\nGrasas totales 0.3 g	\nAcidos grasos saturados 0 g	\nAcidos grasos poliinsaturados 0.1 g	\nAcidos grasos monoinsaturados 0.1 g	\nColesterol 0 mg	\nSodio 0 mg	\nPotasio 201 mg	\nHidratos de carbono 11 g	\nFibra alimentaria 1.7 g	\nAzucares 8 g	\nProteinas 1.1 g	\nVitamina A	332 IU	\nVitamina C	5.4 mg\nCalcio	6 mg	\nHierro	0.3 mg\nVitamina D	0 IU	\nVitamina B6	0 mg\nVitamina B12	0 mg	\nMagnesio	9 mg'),
(14, 'Pera', 6, 'Calorias 57\nGrasas totales 0.1 g	\nAcidos grasos saturados 0 g	\nAcidos grasos poliinsaturados 0.1 g	\nAcidos grasos monoinsaturados 0.1 g	\nColesterol 0 mg	\nSodio 1 mg	\nPotasio 116 mg	\nHidratos de carbono 15 g	\nFibra alimentaria 3.1 g	\nAzucares 10 g	\nProteinas 0.4 g	\nVitamina A	25 IU	\nVitamina C	4.3 mg\nCalcio	9 mg	\nHierro	0.2 mg\nVitamina D	0 IU	\nVitamina B6	0 mg\nVitamina B12	0 mg	\nMagnesio	7 mg'),
(15, 'Litchi', 7, 'Calorias 66\nGrasas totales 0.4 g	\nAcidos grasos saturados 0.1 g	\nAcidos grasos poliinsaturados 0.1 g	\nAcidos grasos monoinsaturados 0.1 g	\nColesterol 0 mg	\nSodio 1 mg	\nPotasio 171 mg	\nHidratos de carbono 17 g	\nFibra alimentaria 1.3 g	\nAzucares 15 g	\nProteinas 0.8 g	\nVitamina A	0 IU	\nVitamina C	71.5 mg\nCalcio	5 mg	\nHierro	0.3 mg\nVitamina D	0 IU	\nVitamina B6	0.1 mg\nVitamina B12	0 mg	\nMagnesio	10 mg'),
(16, 'Pistacho', 8, 'Calorias 562\nGrasas totales 45 g	\nAcidos grasos saturados 6 g	\nAcidos grasos poliinsaturados 14 g	\nAcidos grasos monoinsaturados 24 g	\nAcidos grasos trans 0 g	\nColesterol 0 mg	\nSodio 1 mg	\nPotasio 1.025 mg	\nHidratos de carbono 28 g	\nFibra alimentaria 10 g	\nAzucares 8 g	\nProteinas 20 g	\nVitamina A	415 IU	\nVitamina C	5.6 mg\nCalcio	105 mg	\nHierro	3.9 mg\nVitamina D	0 IU	\nVitamina B6	1.7 mg\nVitamina B12	0 mg	\nMagnesio	121 mg'),
(17, 'Nuez', 8, 'Calorias 607\nGrasas totales 54 g	\nAcidos grasos saturados 9 g	\nAcidos grasos poliinsaturados 15 g	\nAcidos grasos monoinsaturados 28 g	\nAcidos grasos trans 0.1 g	\nColesterol 0 mg	\nSodio 273 mg	\nPotasio 632 mg	\nHidratos de carbono 21 g	\nFibra alimentaria 7 g	\nAzucares 4.2 g	\nProteinas 20 g	\nVitamina A	3 IU	\nVitamina C	0.5 mg\nCalcio	117 mg	\nHierro	2.6 mg\nVitamina D	0 IU	\nVitamina B6	0.4 mg\nVitamina B12	0 mg	\nMagnesio	229 mg'),
(18, 'Grosella Espinosa', 4, 'Calorias		44 kcal\nGrasas	                0.58 g\nGrasas saturadas	0.038 g\nGrasas poliinsaturadas	0.317 g\nGrasas monoinsaturadas	0.051 g\nProteinas		0.88 g\nCarbohidratos	        10.18 g\nAzucar	                -- g\nFibra	                4.3 g\nColesterol	        -- mg\nMinerales		\nCalcio	                25 mg\nHierro	                0.31 mg\nSodio	                1 mg\nPotasio	                198 mg\nMagnesio	        10 mg\nFosforo		\nZinc		\nVitaminas		\nVitamina A	        290 IU\nVitamina C	        27.7 mg\nVitamina D	        -- mg\nVitamina B1 (Tiamina)		\nVitamina B6             0.08 mg\nVitamina B sub 12	0 mg\nVitamina E		\nVitamina K		\nFolato (Acido folico)	6 mg'),
(19, 'Calabaza', 4, 'Calorias	28.37 kcal.\nGrasa	0.13 g.\nColesterol	0 mg.\nSodio	3.10 mg.\nCarbohidratos	4.59 g.\nFibra	2.16 g.\nAzucares	3.89 g.\nProteinas	1.13 g.\nVitamina A	127.58 ug.	\nVitamina C	12 mg.\nVitamina B12	0 ug.	\nCalcio	22 mg.\nHierro	0.80 mg.	\nVitamina B3	0.35 mg.'),
(20, 'Grosella Negra', 4, 'Calorias	67.10 kcal.\nGrasa	        0.16 g.\nColesterol	0 mg.\nSodio	        2 mg.\nCarbohidratos	15.50 g.\nFibra	        0.40 g.\nAzucares	15.50 g.\nProteinas	0.72 g.\nVitamina A	10 ug.	\nVitamina C	4 mg.\nVitamina B12	0 ug.	\nCalcio	        4 mg.\nHierro	        0.30 mg.	\nVitamina B3	0.37 mg.'),
(21, 'Fresa', 4, 'Carbohidratos 	                7.68 g\n Azucares 	                4.89 g\n Fibra alimentaria 	        2 g\nGrasas 	                        0.3 g\nProteinas 	                0.67 g\nTiamina (vit. B1) 	        0.024 mg (2%)\nRiboflavina (vit. B2) 	        0.022 mg (1%)\nNiacina (vit. B3) 	        0.386 mg (3%)\nAcido pantotenico (vit. B5) 	0.125 mg (3%)\nVitamina B6 	                0.047 mg (4%)\nAcido folico (vit. B9) 	        24 ?g (6%)\nVitamina C 	                58.8 mg (98%)\nVitamina E 	                0.29 mg (2%)\nVitamina K 	                2.2 ?g (2%)\nCalcio 	                        16 mg (2%)\nHierro 	                        0.41 mg (3%)\nMagnesio 	                13 mg (4%)\nManganeso 	                0.386 mg (19%)\nFosforo 	                24 mg (3%)\nPotasio 	                153 mg (3%)\nSodio 	                        1 mg (0%)\nZinc 	                        0.14 mg (1%)'),
(22, 'Acerola', 5, 'Carbohidratos 	                7.69 g\nFibra alimentaria 	        1.1 g\nGrasas 	                        0.3 g\nProteinas 	                0.4 g\nRetinol (vit. A) 	        38 ?g (4%)\nTiamina (vit. B1) 	        0.02 mg (2%)\nRiboflavina (vit. B2) 	        0.06 mg (4%)\nNiacina (vit. B3) 	        0.04 mg (0%)\nAcido pantotenico (vit. B5) 	0.309 mg (6%)\nVitamina B6 	                0.009 mg (1%)\nVitamina C 	                1677.6 mg (2796%)\nCalcio 	                        12 mg (1%)\nHierro 	                        0.2 mg (2%)\nMagnesio 	                18 mg (5%)\nManganeso 	                0.6 mg (30%)\nFosforo 	                11 mg (2%)\nPotasio 	                146 mg (3%)\nSodio 	                        7 mg (0%)\nZinc 	                        0.1 mg (1%)'),
(23, 'Limon', 5, 'Carbohidratos 	                9.32 g\nAzucares 	                2.5 g\nFibra alimentaria 	        2.8 g\nGrasas 	                        0.3 g\nProteinas 	                1.1 g\nTiamina (vit. B1) 	        0.04 mg (3%)\nRiboflavina (vit. B2) 	        0.02 mg (1%)\nNiacina (vit. B3) 	        0.1 mg (1%)\nAcido pantotenico (vit. B5) 	0.19 mg (4%)\nVitamina B6 	                0.08 mg (6%)\nVitamina C 	                53 mg (88%)\nCalcio 	                        26 mg (3%)\nHierro 	                        0.6 mg (5%)\nMagnesio 	                8 mg (2%)\nManganeso 	                0.03 mg (2%)\nFosforo 	                16 mg (2%)\nPotasio 	                138 mg (3%)\nZinc 	                        0.06 mg (1%)'),
(24, 'Arandano', 4, 'Carbohidratos 	        6.05 g\n  Fibra alimentaria 	4.9 g\nGrasas 	                0.6 g\n  saturadas 	        -\n  monoinsaturadas 	-\n  poliinsaturadas 	-\nProteinas 	        0.625 g\nAgua 	                87.8 g\nRetinol (vit. A) 	5.7 ?g (1%)\n ?-caroteno 	        34.2 ?g (0%)\nTiamina (vit. B1) 	0.02 mg (2%)\nRiboflavina (vit. B2) 	0.02 mg (1%)\nNiacina (vit. B3) 	0.09 mg (1%)\nVitamina B6 	        0.06 mg (5%)\nVitamina B12 	        0 ?g (0%)\nVitamina C 	        22 mg (37%)\nVitamina E 	        1.921 mg (13%)\nCalcio 	                10 mg (1%)\nHierro 	                0.74 mg (6%)\nMagnesio 	        2.4 mg (1%)\nFosforo 	        13 mg (2%)\nPotasio 	        78 mg (2%)\nSelenio 	        0.1 ?g (0%)\nSodio 	                1 mg (0%)\nZinc 	                0.131 mg (1%)'),
(25, 'Frambuesa', 4, 'Carbohidratos 	        11.94 g\nAzucares 	        4.42 g\nFibra alimentaria 	6.5 g\nGrasas 	                0.65 g\nProteinas 	        1.20 g\nAgua 	                85.75 g\nRetinol (vit. A) 	2 ?g (0%)\nTiamina (vit. B1) 	0.032 mg (2%)\nRiboflavina (vit. B2) 	0.038 mg (3%)\nNiacina (vit. B3) 	0.598 mg (4%)\nVitamina B6 	        0.055 mg (4%)\nVitamina C 	        26.2 mg (44%)\nVitamina E 	        0.87 mg (6%)\nVitamina K 	        7.8 ?g (7%)\nCalcio 	                25 mg (3%)\nHierro 	                0.69 mg (6%)\nMagnesio 	        22 mg (6%)\nFosforo 	        29 mg (4%)\nPotasio 	        151 mg (3%)\nSodio 	                1 mg (0%)\nZinc 	                0.4 mg (4%)'),
(26, 'Mandarina', 5, 'Carbohidratos 	        13.34 g\nAzucares 	        10.58 g\nFibra alimentaria 	1.18 g\nGrasas 	                0.31 g\n  saturadas 	        0.039 g\n  trans 	        0.00 g\n  monoinsaturadas 	0.06 g\n  poliinsaturadas 	0.065 g\nProteinas 	        0.81 g\nAgua 	                85.17 g\nRetinol (vit. A) 	34 ?g (4%)\nTiamina (vit. B1) 	0.058 mg (4%)\nRiboflavina (vit. B2) 	0.036 mg (2%)\nNiacina (vit. B3) 	0.376 mg (3%)\nVitamina B6 	        0.078 mg (6%)\nAcido folico (vit. B9) 	16 ?g (4%)\nVitamina B12 	        0 ?g (0%)\nVitamina C 	        26.7 mg (45%)\nVitamina D 	        0 ?g (0%)\nVitamina E 	        0.2 mg (1%)\nVitamina K 	        0 ?g (0%)\nCalcio 	                37 mg (4%)\nHierro 	                0.15 mg (1%)\nMagnesio 	        12 mg (3%)\nFosforo 	        20 mg (3%)\nPotasio 	        166 mg (4%)\nSodio 	                2 mg (0%)\nZinc 	                0.07 mg (1%)'),
(27, 'Aceituna', 9, 'Carbohidratos 	3.84 g\n Azucares 	0.54 g\n Fibra alimentaria 	3.3 g\nGrasas 	15.32 g\n saturadas 	2.029 g\n monoinsaturadas 	11.314 g\n poliinsaturadas 	1.307 g\nProteinas 	1.03 g\nRetinol (vit. A) 	20 ?g (2%)\n  ?-caroteno 	231 ?g (2%)\nTiamina (vit. B1) 	0.021 mg (2%)\nRiboflavina (vit. B2) 	0.007 mg (0%)\nNiacina (vit. B3) 	0.237 mg (2%)\nVitamina B6 	0.031 mg (2%)\nAcido folico (vit. B9) 	3 ?g (1%)\nVitamina E 	3.81 mg (25%)\nVitamina K 	1.4 ?g (1%)\nCalcio 	52 mg (5%)\nHierro 	0.49 mg (4%)\nMagnesio 	11 mg (3%)\nFosforo 	4 mg (1%)\nPotasio 	42 mg (1%)\nSodio 	1556 mg (104%)'),
(28, 'Sandia', 3, 'Carbohidratos 	7.55 g\n  Azucares 	6.2 g\n  Fibra alimentaria 	0.4 g\nGrasas 	0.15 g\nProteinas 	0.61 g\nAgua 	91.45 g\nRetinol (vit. A) 	28 ?g (3%)\n  ?-caroteno 	303 ?g (3%)\nTiamina (vit. B1) 	0.033 mg (3%)\nRiboflavina (vit. B2) 	0.021 mg (1%)\nNiacina (vit. B3) 	0.178 mg (1%)\nAcido pantotenico (vit. B5) 	0.221 mg (4%)\nVitamina B6 	0.045 mg (3%)\nVitamina C 	8.1 mg (14%)\nCalcio 	7 mg (1%)\nHierro 	0.24 mg (2%)\nMagnesio 	10 mg (3%)\nManganeso 	0.038 mg (2%)\nFosforo 	11 mg (2%)\nPotasio 	112 mg (2%)\nSodio 	1 mg (0%)\nZinc 	0.1 mg (1%)'),
(29, 'Aguacate', 4, 'Carbohidratos 	8.53 g\n  Azucares 	0.66 g\n  Fibra alimentaria 	6.7 g\nGrasas 	14.66 g\nProteinas 	2 g\nAgua 	73.23 g\nRetinol (vit. A) 	7 ?g (1%)\n  ?-caroteno 	62 ?g (1%)\nTiamina (vit. B1) 	0.067 mg (5%)\nRiboflavina (vit. B2) 	0.13 mg (9%)\nNiacina (vit. B3) 	1.738 mg (12%)\nAcido pantotenico (vit. B5) 	1.389 mg (28%)\nVitamina B6 	0.257 mg (20%)\nVitamina C 	10 mg (17%)\nVitamina E 	2.07 mg (14%)\nVitamina K 	21 ?g (20%)\nCalcio 	12 mg (1%)\nHierro 	0.55 mg (4%)\nMagnesio 	29 mg (8%)\nManganeso 	0.142 mg (7%)\nFosforo 	52 mg (7%)\nPotasio 	485 mg (10%)\nSodio 	7 mg (0%)\nZinc 	0.64 mg (6%)'),
(30, 'Melocoton', 6, 'Carbohidratos 	9.54 g\n  Azucares 	8.39 g\n  Fibra alimentaria 	1.5 g\nGrasas 	0.25 g\nProteinas 	0.91 g\nAgua 	88.87 g\nRetinol (vit. A) 	16 ?g (2%)\nTiamina (vit. B1) 	0.024 mg (2%)\nRiboflavina (vit. B2) 	0.031 mg (2%)\nNiacina (vit. B3) 	0.806 mg (5%)\nVitamina B6 	0.025 mg (2%)\nVitamina C 	6.6 mg (11%)\nVitamina E 	0.73 mg (5%)\nVitamina K 	2.6 ?g (2%)\nCalcio 	6 mg (1%)\nHierro 	0.25 mg (2%)\nMagnesio 	9 mg (2%)\nFosforo 	20 mg (3%)\nPotasio 	190 mg (4%)\nSodio 	0 mg (0%)\nZinc 	0.17 mg (2%)'),
(31, 'Lima', 5, 'Carbohidratos 	10.5 g\n  Azucares 	1.7 g\n  Fibra alimentaria 	2.8 g\nGrasas 	0.2 g\nProteinas 	0.7 g\nTiamina (vit. B1) 	0.03 mg (2%)\nRiboflavina (vit. B2) 	0.02 mg (1%)\nNiacina (vit. B3) 	0.2 mg (1%)\nAcido pantotenico (vit. B5) 	0.217 mg (4%)\nVitamina B6 	0.046 mg (4%)\nAcido folico (vit. B9) 	8 ?g (2%)\nVitamina C 	29.1 mg (49%)\nCalcio 	33 mg (3%)\nHierro 	0.6 mg (5%)\nMagnesio 	6 mg (2%)\nFosforo 	18 mg (3%)\nPotasio 	102 mg (2%)\nSodio 	2 mg (0%)'),
(32, 'Papaya', 7, 'Carbohidratos 	10.82 g\n  Azucares 	7.82 g\n  Fibra alimentaria 	1.5 g\nGrasas 	0.26 g\nProteinas 	0.47 g\nRetinol (vit. A) 	47 ?g (5%)\n  ?-caroteno 	274 ?g (3%)\nTiamina (vit. B1) 	0.023 mg (2%)\nRiboflavina (vit. B2) 	0.027 mg (2%)\nNiacina (vit. B3) 	0.357 mg (2%)\nAcido pantotenico (vit. B5) 	0.191 mg (4%)\nVitamina B6 	0.038 mg (3%)\nAcido folico (vit. B9) 	37 ?g (9%)\nVitamina C 	60.9 mg (102%)\nVitamina E 	0.3 mg (2%)\nVitamina K 	2.6 ?g (2%)\nCalcio 	20 mg (2%)\nHierro 	0.3 mg (2%)\nMagnesio 	41 mg (11%)\nManganeso 	0.04 mg (2%)\nFosforo 	14 mg (2%)\nPotasio 	211 mg (4%)\nSodio 	3 mg (0%)\nZinc 	0.08 mg (1%)'),
(33, 'Naranja', 5, 'Carbohidratos 	11.75 g\n  Azucares 	9.35 g\n  Fibra alimentaria 	2.4 g\nGrasas 	0.12 g\n  saturadas 	0.015 g\n  monoinsaturadas 	0.023 g\n  poliinsaturadas 	0.025 g\nProteinas 	0.94 g\nAgua 	86.75 g\nRetinol (vit. A) 	11 ?g (1%)\n  ?-caroteno 	71 ?g (1%)\nTiamina (vit. B1) 	0.087 mg (7%)\nRiboflavina (vit. B2) 	0.040 mg (3%)\nNiacina (vit. B3) 	0.282 mg (2%)\nAcido pantotenico (vit. B5) 	0.250 mg (5%)\nVitamina B6 	0.060 mg (5%)\nAcido folico (vit. B9) 	30 ?g (8%)\nVitamina B12 	0 ?g (0%)\nVitamina C 	53.2 mg (89%)\nVitamina D 	0 ?g (0%)\nVitamina E 	0.18 mg (1%)\nVitamina K 	0 ?g (0%)\nCalcio 	40 mg (4%)\nHierro 	0.10 mg (1%)\nMagnesio 	10 mg (3%)\nManganeso 	0.025 mg (1%)\nFosforo 	14 mg (2%)\nPotasio 	181 mg (4%)\nSodio 	0 mg (0%)\nZinc 	0.07 mg (1%)'),
(34, 'Albaricoque', 6, 'Carbohidratos 	11.12 g\n  Azucares 	9.24 g\n  Fibra alimentaria 	2.0 g\nGrasas 	0.39 g\nProteinas 	1.40 g\nAgua 	86.35 g\nRetinol (vit. A) 	96 ?g (11%)\nTiamina (vit. B1) 	0.030 mg (2%)\nRiboflavina (vit. B2) 	0.040 mg (3%)\nNiacina (vit. B3) 	0.600 mg (4%)\nVitamina B6 	0.054 mg (4%)\nVitamina C 	10.0 mg (17%)\nVitamina E 	0.89 mg (6%)\nVitamina K 	3.3 ?g (3%)\nCalcio 	13.0 mg (1%)\nHierro 	0.39 mg (3%)\nMagnesio 	10.0 mg (3%)\nFosforo 	23.0 mg (3%)\nPotasio 	269.0 mg (6%)\nSodio 	1.0 mg (0%)\nZinc 	0.20 mg (2%)'),
(35, 'Ciruela', 6, 'Carbohidratos 	11.42 g\n  Azucares 	9.92 g\n  Fibra alimentaria 	1.4 g\nGrasas 	0.28 g\nProteinas 	0.7 g\nRetinol (vit. A) 	17 ?g (2%)\n  ?-caroteno 	190 ?g (2%)\nTiamina (vit. B1) 	0.028 mg (2%)\nRiboflavina (vit. B2) 	0.026 mg (2%)\nNiacina (vit. B3) 	0.417 mg (3%)\nAcido pantotenico (vit. B5) 	0.135 mg (3%)\nVitamina B6 	0.029 mg (2%)\nAcido folico (vit. B9) 	5 ?g (1%)\nVitamina C 	9.5 mg (16%)\nVitamina E 	0.26 mg (2%)\nVitamina K 	6.4 ?g (6%)\nCalcio 	6 mg (1%)\nHierro 	0.17 mg (1%)\nMagnesio 	7 mg (2%)\nManganeso 	0.052 mg (3%)\nFosforo 	16 mg (2%)\nPotasio 	157 mg (3%)\nSodio 	0 mg (0%)\nZinc 	0.1 mg (1%)'),
(36, 'Mora', 4, 'Carbohidratos 	11.94 g\n  Azucares 	4.42 g\n  Fibra alimentaria 	6.5 g\nGrasas 	0.65 g\nProteinas 	1.2 g\nTiamina (vit. B1) 	0.032 mg (2%)\nRiboflavina (vit. B2) 	0.038 mg (3%)\nNiacina (vit. B3) 	0.598 mg (4%)\nAcido pantotenico (vit. B5) 	0.329 mg (7%)\nVitamina B6 	0.055 mg (4%)\nAcido folico (vit. B9) 	21 ?g (5%)\nVitamina C 	26.2 mg (44%)\nVitamina E 	0.87 mg (6%)\nVitamina K 	7.8 ?g (7%)\nCalcio 	25 mg (3%)\nHierro 	0.69 mg (6%)\nMagnesio 	22 mg (6%)\nManganeso 	0.67 mg (34%)\nFosforo 	29 mg (4%)\nPotasio 	151 mg (3%)\nSodio 	1 mg (0%)\nZinc 	0.42 mg (4%)'),
(37, 'Nispero', 6, 'Carbohidratos 	12.14 g\n  Fibra alimentaria 	1.7 g\nGrasas 	0.20 g\nProteinas 	0.43 g\nAgua 	86.73 g\nRetinol (vit. A) 	76 ?g (8%)\nTiamina (vit. B1) 	0.019 mg (1%)\nRiboflavina (vit. B2) 	0.024 mg (2%)\nNiacina (vit. B3) 	0.180 mg (1%)\nVitamina B6 	0.100 mg (8%)\nVitamina C 	1 mg (2%)\nCalcio 	16 mg (2%)\nHierro 	0.28 mg (2%)\nMagnesio 	12 mg (3%)\nFosforo 	27 mg (4%)\nPotasio 	266 mg (6%)\nSodio 	1 mg (0%)\nZinc 	0.05 mg (1%)'),
(38, 'Manzana', 6, 'Carbohidratos 	12.76 g\n  Azucares 	10.10 g\n  Fibra alimentaria 	1.3 g\nGrasas 	0.13 g\nProteinas 	0.27 g\nAgua 	86.67 g\nRetinol (vit. A) 	2 ?g (0%)\nTiamina (vit. B1) 	0.019 mg (1%)\nRiboflavina (vit. B2) 	0.028 mg (2%)\nNiacina (vit. B3) 	0.091 mg (1%)\nVitamina B6 	0.037 mg (3%)\nVitamina C 	4.0 mg (7%)\nVitamina E 	0.05 mg (0%)\nVitamina K 	0.6 ?g (1%)\nCalcio 	5 mg (1%)\nHierro 	0.07 mg (1%)\nMagnesio 	4 mg (1%)\nFosforo 	11 mg (2%)\nPotasio 	90 mg (2%)\nSodio 	0 mg (0%)\nZinc 	0.05 mg (1%)'),
(39, 'Piña', 7, 'Carbohidratos 	13.12 g\n  Azucares 	9.85 g\n  Fibra alimentaria 	1.4 g\nGrasas 	0.12 g\nProteinas 	0.54 g\nTiamina (vit. B1) 	0.079 mg (6%)\nRiboflavina (vit. B2) 	0.032 mg (2%)\nNiacina (vit. B3) 	0.5 mg (3%)\nAcido pantotenico (vit. B5) 	0.213 mg (4%)\nVitamina B6 	0.112 mg (9%)\nAcido folico (vit. B9) 	18 ?g (5%)\nVitamina C 	47.8 mg (80%)\nCalcio 	13 mg (1%)\nHierro 	0.29 mg (2%)\nMagnesio 	12 mg (3%)\nManganeso 	0.927 mg (46%)\nFosforo 	8 mg (1%)\nPotasio 	109 mg (2%)\nSodio 	1 mg (0%)\nZinc 	0.12 mg (1%)'),
(40, 'Kiwi', 7, 'Carbohidratos 	14.66 g\n  Azucares 	8.99 g\n  Fibra alimentaria 	3.0 g\nGrasas 	0.52 g\nProteinas 	1.14 g\nAgua 	83.07 g\nRetinol (vit. A) 	4 ?g (0%)\nTiamina (vit. B1) 	0.027 mg (2%)\nRiboflavina (vit. B2) 	0.025 mg (2%)\nNiacina (vit. B3) 	0.341 mg (2%)\nVitamina B6 	0.063 mg (5%)\nVitamina C 	92.7 mg (155%)\nVitamina E 	1.46 mg (10%)\nVitamina K 	40.3 ?g (38%)\nCalcio 	34 mg (3%)\nHierro 	0.31 mg (2%)\nMagnesio 	17 mg (5%)\nFosforo 	34 mg (5%)\nPotasio 	312 mg (7%)\nSodio 	3 mg (0%)\nZinc 	0.14 mg (1%)'),
(41, 'Mango', 7, 'Carbohidratos 	14.98 g\n  Azucares 	13.66 g\nGrasas 	0.38 g\nProteinas 	0.82 g\nAgua 	83.46 g\nRetinol (vit. A) 	54 ?g (6%)\n  ?-caroteno 	640 ?g (6%)\nTiamina (vit. B1) 	0.028 mg (2%)\nRiboflavina (vit. B2) 	0.038 mg (3%)\nNiacina (vit. B3) 	0.669 mg (4%)\nAcido pantotenico (vit. B5) 	0.197 mg (4%)\nVitamina B6 	0.119 mg (9%)\nAcido folico (vit. B9) 	43 ?g (11%)\nVitamina C 	36.4 mg (61%)\nVitamina E 	0.9 mg (6%)\nVitamina K 	4.2 ?g (4%)\nCalcio 	11 mg (1%)\nHierro 	0.16 mg (1%)\nMagnesio 	10 mg (3%)\nManganeso 	0.063 mg (3%)\nFosforo 	14 mg (2%)\nPotasio 	168 mg (4%)\nSodio 	1 mg (0%)\nZinc 	0.09 mg (1%)'),
(42, 'Membrillo', 7, 'Carbohidratos 	15.3 g\n  Fibra alimentaria 	1.9 g\nGrasas 	0.1 g\nProteinas 	0.4 g\nTiamina (vit. B1) 	0.02 mg (2%)\nRiboflavina (vit. B2) 	0.03 mg (2%)\nNiacina (vit. B3) 	0.2 mg (1%)\nAcido pantotenico (vit. B5) 	0.081 mg (2%)\nVitamina B6 	0.04 mg (3%)\nAcido folico (vit. B9) 	3 ?g (1%)\nVitamina C 	15 mg (25%)\nCalcio 	11 mg (1%)\nHierro 	0.7 mg (6%)\nMagnesio 	8 mg (2%)\nFosforo 	17 mg (2%)\nPotasio 	197 mg (4%)\nSodio 	4 mg (0%)\nZinc 	0.04 mg (0%)'),
(43, 'Coco', 7, 'Carbohidratos 	15.23 g\n  Azucares 	6.23 g\n  Fibra alimentaria 	9 g\nGrasas 	33.49 g\n  saturadas 	29.70 g\n  monoinsaturadas 	1.43 g\n  poliinsaturadas 	0.37 g\nProteinas 	3.3 g\nTiamina (vit. B1) 	0.066 mg (5%)\nRiboflavina (vit. B2) 	0.02 mg (1%)\nNiacina (vit. B3) 	0.54 mg (4%)\nAcido pantotenico (vit. B5) 	0.3 mg (6%)\nVitamina B6 	0.054 mg (4%)\nAcido folico (vit. B9) 	26 ?g (7%)\nVitamina C 	3.3 mg (6%)\nCalcio 	14 mg (1%)\nHierro 	2.43 mg (19%)\nMagnesio 	32 mg (9%)\nFosforo 	113 mg (16%)\nPotasio 	356 mg (8%)\nZinc 	1.1 mg (11%)'),
(44, 'Cereza', 6, 'Carbohidratos 	16.01 g\n  Azucares 	12.82 g\n  Fibra alimentaria 	2.10 g\nGrasas 	0.20 g\n  saturadas 	0.038\n  monoinsaturadas 	0.047\n  poliinsaturadas 	0.052\nProteinas 	1.06 g\nAgua 	82.25 g\nRetinol (vit. A) 	3 ?g (0%)\nTiamina (vit. B1) 	0.027 mg (2%)\nRiboflavina (vit. B2) 	0.033 mg (2%)\nNiacina (vit. B3) 	0.154 mg (1%)\nAcido pantotenico (vit. B5) 	0.199 mg (4%)\nVitamina B6 	0.049 mg (4%)\nAcido folico (vit. B9) 	4 ?g (1%)\nVitamina C 	7 mg (12%)\nVitamina E 	0.07 mg (0%)\nVitamina K 	2.10 ?g (2%)\nCalcio 	13 mg (1%)\nHierro 	0.36 mg (3%)\nMagnesio 	11 mg (3%)\nManganeso 	0.07 mg (4%)\nFosforo 	21 mg (3%)\nPotasio 	222 mg (5%)\nZinc 	0.07 mg (1%)'),
(45, 'Avellana', 8, 'Carbohidratos 	16.7\n  Azucares 	4.34\nGrasas 	60.75\nProteinas 	14.95\nAgua 	5\nRetinol (vit. A) 	1 ?g (0%)\nTiamina (vit. B1) 	0.643 mg (49%)\nRiboflavina (vit. B2) 	0.113 mg (8%)\nNiacina (vit. B3) 	1.800 mg (12%)\nVitamina B6 	0.563 mg (43%)\nVitamina C 	6.3 mg (11%)\nVitamina E 	15.03 mg (100%)\nVitamina K 	14.2 ?g (14%)\nCalcio 	114 mg (11%)\nHierro 	4.70 mg (38%)\nMagnesio 	163 mg (44%)\nFosforo 	290 mg (41%)\nPotasio 	680 mg (14%)\nSodio 	0 mg (0%)\nZinc 	2.45 mg (25%)'),
(46, 'Chirimoya', 7, 'Carbohidratos 	16.71 g\n  Azucares 	12.87\n  Fibra alimentaria 	3 g\nGrasas 	0.68 g\nProteinas 	1.57 g\nTiamina (vit. B1) 	0.101 mg (8%)\nRiboflavina (vit. B2) 	0.131 mg (9%)\nNiacina (vit. B3) 	0.644 mg (4%)\nAcido pantotenico (vit. B5) 	0.345 mg (7%)\nVitamina B6 	0.257 mg (20%)\nAcido folico (vit. B9) 	23 ?g (6%)\nVitamina C 	12.6 mg (21%)\nVitamina E 	0.27 mg (2%)\nCalcio 	10 mg (1%)\nHierro 	0.27 mg (2%)\nMagnesio 	17 mg (5%)\nManganeso 	0.093 mg (5%)\nFosforo 	26 mg (4%)\nPotasio 	287 mg (6%)\nSodio 	7 mg (0%)\nZinc 	0.16 mg (2%)'),
(47, 'Uva', 6, 'Carbohidratos 	18.1 g\n  Azucares 	15.69 g\n  Fibra alimentaria 	0.9 g\nGrasas 	0.16 g\nProteinas 	0.73 g\nTiamina (vit. B1) 	0.069 mg (5%)\nRiboflavina (vit. B2) 	0.07 mg (5%)\nNiacina (vit. B3) 	0.188 mg (1%)\nAcido pantotenico (vit. B5) 	0.05 mg (1%)\nVitamina B6 	0.086 mg (7%)\nAcido folico (vit. B9) 	2 ?g (1%)\nVitamina B12 	0 ?g (0%)\nVitamina C 	10.8 mg (18%)\nVitamina K 	22 ?g (21%)\nCalcio 	10 mg (1%)\nHierro 	0.36 mg (3%)\nMagnesio 	7 mg (2%)\nManganeso 	0.071 mg (4%)\nFosforo 	20 mg (3%)\nPotasio 	191 mg (4%)\nSodio 	3.02 mg (0%)\nZinc 	0.07 mg (1%)'),
(48, 'Granada', 6, 'Carbohidratos 	18.7 g\n  Azucares 	13.67 g\n  Fibra alimentaria 	4 g\nGrasas 	1.17 g\nProteinas 	1.67 g\nTiamina (vit. B1) 	0.067 mg (5%)\nRiboflavina (vit. B2) 	0.053 mg (4%)\nNiacina (vit. B3) 	0.293 mg (2%)\nAcido pantotenico (vit. B5) 	0.377 mg (8%)\nVitamina B6 	0.075 mg (6%)\nAcido folico (vit. B9) 	38 ?g (10%)\nVitamina C 	10.2 mg (17%)\nVitamina E 	0.6 mg (4%)\nVitamina K 	16.4 ?g (16%)\nCalcio 	10 mg (1%)\nHierro 	0.3 mg (2%)\nMagnesio 	12 mg (3%)\nManganeso 	0.119 mg (6%)\nFosforo 	36 mg (5%)\nPotasio 	236 mg (5%)\nSodio 	3 mg (0%)\nZinc 	0.35 mg (4%)'),
(49, 'Caqui', 6, 'Carbohidratos 	18.59 g\n  Azucares 	12.53 g\n  Fibra alimentaria 	3.6 g\nGrasas 	0.19 g\nProteinas 	0.58 g\nRetinol (vit. A) 	81 ?g (9%)\n  ?-caroteno 	253 ?g (2%)\nTiamina (vit. B1) 	0.03 mg (2%)\nRiboflavina (vit. B2) 	0.02 mg (1%)\nNiacina (vit. B3) 	0.1 mg (1%)\nVitamina B6 	0.1 mg (8%)\nAcido folico (vit. B9) 	8 ?g (2%)\nVitamina C 	7.5 mg (13%)\nVitamina E 	0.73 mg (5%)\nVitamina K 	2.6 ?g (2%)\nCalcio 	8 mg (1%)\nHierro 	0.15 mg (1%)\nMagnesio 	9 mg (2%)\nManganeso 	0.355 mg (18%)\nFosforo 	17 mg (2%)\nPotasio 	161 mg (3%)\nSodio 	1 mg (0%)\nZinc 	0.11 mg (1%)'),
(50, 'Higo', 6, 'Carbohidratos 	19.18 g\n  Azucares 	16.26 g\n  Fibra alimentaria 	2.9 g\nGrasas 	0.30 g\nProteinas 	0.75 g\nTiamina (vit. B1) 	0.060 mg (5%)\nRiboflavina (vit. B2) 	0.050 mg (3%)\nNiacina (vit. B3) 	0.400 mg (3%)\nAcido pantotenico (vit. B5) 	0.300 mg (6%)\nVitamina B6 	0.113 mg (9%)\nAcido folico (vit. B9) 	0 ?g (0%)\nVitamina C 	2 mg (3%)\nCalcio 	35 mg (4%)\nCobre 	0.070 mg (0%)\nHierro 	0.37 mg (3%)\nMagnesio 	17 mg (5%)\nManganeso 	0.128 mg (6%)\nFosforo 	14 mg (2%)\nPotasio 	232 mg (5%)\nSelenio 	0.2 ?g (0%)\nSodio 	1 mg (0%)\nZinc 	0.15 mg (2%)'),
(51, 'Cacahuete', 8, 'Carbohidratos 	21 g\n  Azucares 	0\n  Fibra alimentaria 	9 g\nGrasas 	48 g\nProteinas 	25 g\nAgua 	4.26 g\nTiamina (vit. B1) 	0.6 mg (46%)\nNiacina (vit. B3) 	12.9 mg (86%)\nAcido pantotenico (vit. B5) 	1.8 mg (36%)\nVitamina B6 	0.3 mg (23%)\nVitamina C 	0 mg (0%)\nCalcio 	62 mg (6%)\nHierro 	2 mg (16%)\nMagnesio 	184 mg (50%)\nFosforo 	336 mg (48%)\nPotasio 	332 mg (7%)\nZinc 	3.3 mg (33%)'),
(52, 'Almendra', 8, 'Carbohidratos 	21.55 g\n  Almidon 	0.72 g\n  Azucares 	4.35 g\n  Fibra alimentaria 	12.5 g\nGrasas 	49.93 g\n  saturadas 	3.802 g\n  trans 	0.015 g\n  monoinsaturadas 	31.551 g\n  poliinsaturadas 	12.329 g\nProteinas 	21.15 g\nAgua 	4.41 g\nRetinol (vit. A) 	2 ?g (0%)\n  ?-caroteno 	1 ?g (0%)\nTiamina (vit. B1) 	0.205 mg (16%)\nRiboflavina (vit. B2) 	1.138 mg (76%)\nNiacina (vit. B3) 	3.618 mg (24%)\nAcido pantotenico (vit. B5) 	0.471 mg (9%)\nVitamina B6 	0.137 mg (11%)\nAcido folico (vit. B9) 	44 ?g (11%)\nVitamina E 	25.63 mg (171%)\nCalcio 	269 mg (27%)\nCobre 	1.031 mg (0%)\nHierro 	3.71 mg (30%)\nMagnesio 	270 mg (73%)\nManganeso 	2.179 mg (109%)\nFosforo 	481 mg (69%)\nPotasio 	733 mg (16%)\nSelenio 	4.1 ?g (9%)\nSodio 	1 mg (0%)\nZinc 	3.12 mg (31%)'),
(53, 'Platano', 10, 'Carbohidratos 	22.84 g\n  Almidon 	5.38 g\n  Azucares 	12.23 g\n  Lactosa 	0 g\n  Fibra alimentaria 	2.6 g\nGrasas 	0.33 g\nProteinas 	1.09 g\nAgua 	74.91 g\nRetinol (vit. A) 	3 ?g (0%)\nTiamina (vit. B1) 	0.031 mg (2%)\nRiboflavina (vit. B2) 	0.073 mg (5%)\nNiacina (vit. B3) 	0.665 mg (4%)\nAcido pantotenico (vit. B5) 	0.334 mg (7%)\nVitamina B6 	0.367 mg (28%)\nAcido folico (vit. B9) 	0 ?g (0%)\nVitamina B12 	0 ?g (0%)\nVitamina C 	0 mg (0%)\nVitamina D 	0 ?g (0%)\nVitamina E 	0.1 mg (1%)\nVitamina K 	0.5 ?g (0%)\nCalcio 	0 mg (0%)\nCobre 	0.078 mg (0%)\nHierro 	0.26 mg (2%)\nMagnesio 	27 mg (7%)\nManganeso 	0.27 mg (14%)\nFosforo 	22 mg (3%)\nFluor 	2.2 ?g (0%)\nPotasio 	358 mg (8%)\nSelenio 	1 ?g (2%)\nSodio 	1 mg (0%)\nZinc 	0.15 mg (2%)'),
(54, 'Fruta de la Pasion', 4, 'Carbohidratos 	23.38 g\n  Azucares 	11.20 g\n  Fibra alimentaria 	10.4 g\nGrasas 	0.70 g\nProteinas 	2.20 g\nAgua 	72.93 g\nRetinol (vit. A) 	64 ?g (7%)\nTiamina (vit. B1) 	0 mg (0%)\nRiboflavina (vit. B2) 	0.130 mg (9%)\nNiacina (vit. B3) 	1.500 mg (10%)\nVitamina B6 	0.100 mg (8%)\nVitamina C 	30.0 mg (50%)\nVitamina E 	0.02 mg (0%)\nVitamina K 	0.7 ?g (1%)\nCalcio 	12 mg (1%)\nHierro 	1.60 mg (13%)\nMagnesio 	29 mg (8%)\nFosforo 	68 mg (10%)\nPotasio 	348 mg (7%)\nSodio 	28 mg (2%)\nZinc 	0.10 mg (1%)'),
(55, 'Castaña', 8, 'Carbohidratos 	44.17 g\nGrasas 	1.25 g\nProteinas 	1.63 g\nAgua 	52.00 g\nRetinol (vit. A) 	1 ?g (0%)\nTiamina (vit. B1) 	0.144 mg (11%)\nRiboflavina (vit. B2) 	0.016 mg (1%)\nNiacina (vit. B3) 	1.102 mg (7%)\nVitamina B6 	0.352 mg (27%)\nVitamina C 	40.2 mg (67%)\nCalcio 	19 mg (2%)\nHierro 	0.94 mg (8%)\nMagnesio 	30 mg (8%)\nFosforo 	38 mg (5%)\nPotasio 	484 mg (10%)\nSodio 	2 mg (0%)\nZinc 	0.49 mg (5%)'),
(56, 'Datil', 6, 'Carbohidratos 	75 g\n  Azucares 	63 g\n  Fibra alimentaria 	8 g\nGrasas 	0.4 g\nProteinas 	2.5 g\nAgua 	21 g\nVitamina C 	0.4 mg (1%)\nManganeso 	0.262 mg (13%)'),
(57, 'Col China', 11, 'Calorias 12\nGrasas totales 0.2 g	\nColesterol 0 mg	\nSodio 11 mg	\nPotasio 87 mg	\nHidratos de carbono 2.2 g	\nProteinas 1.1 g	\nVitamina A	263 IU	\nVitamina C	3.2 mg\nCalcio	29 mg	\nHierro	0.7 mg\nVitamina D	0 IU	\nVitamina B6	0 mg\nVitamina B12	0 mg	\nMagnesio	8 mg'),
(58, 'Escarola Lisa', 12, 'Calorias 17\nGrasas totales 0.2 g	\nAcidos grasos saturados 0 g	\nAcidos grasos poliinsaturados 0.1 g	\nAcidos grasos monoinsaturados 0 g	\nColesterol 0 mg	\nSodio 22 mg	\nPotasio 314 mg	\nHidratos de carbono 3.4 g	\nFibra alimentaria 3.1 g	\nAzucares 0.3 g	\nProteinas 1.3 g	\nVitamina A	2.167 IU	\nVitamina C	6.5 mg\nCalcio	52 mg	\nHierro	0.8 mg\nVitamina D	0 IU	\nVitamina B6	0 mg\nVitamina B12	0 mg	\nMagnesio	15 mg'),
(59, 'Pimiento', 13, 'Calorias 20\nGrasas totales 0.2 g	\nAcidos grasos saturados 0.1 g	\nAcidos grasos poliinsaturados 0.1 g	\nAcidos grasos monoinsaturados 0 g	\nColesterol 0 mg	\nSodio 3 mg	\nPotasio 175 mg	\nHidratos de carbono 4.6 g	\nFibra alimentaria 1.7 g	\nAzucares 2.4 g	\nProteinas 0.9 g	\nVitamina A	370 IU	\nVitamina C	80.4 mg\nCalcio	10 mg	\nHierro	0.3 mg\nVitamina D	0 IU	\nVitamina B6	0.2 mg\nVitamina B12	0 mg	\nMagnesio	10 mg'),
(60, 'Hierba de los Canonigos', 14, 'Calorias 21\nGrasas totales 0.4 g	\nColesterol 0 mg	\nSodio 4 mg	\nPotasio 459 mg	\nHidratos de carbono 3.6 g	\nProteinas 2 g	\nVitamina A	7.092 IU	\nVitamina C	38.2 mg\nCalcio	38 mg	\nHierro	2.2 mg\nVitamina D	0 IU	\nVitamina B6	0.3 mg\nVitamina B12	0 mg	\nMagnesio	13 mg'),
(61, 'Champiñon', 15, 'Calorias 22\nGrasas totales 0.3 g	\nAcidos grasos saturados 0.1 g	\nAcidos grasos poliinsaturados 0.2 g	\nAcidos grasos monoinsaturados 0 g	\nColesterol 0 mg	\nSodio 5 mg	\nPotasio 318 mg	\nHidratos de carbono 3.3 g	\nFibra alimentaria 1 g	\nAzucares 2 g	\nProteinas 3.1 g	\nVitamina A	0 IU	\nVitamina C	2.1 mg\nCalcio	3 mg	\nHierro	0.5 mg\nVitamina D	7 IU	\nVitamina B6	0.1 mg\nVitamina B12	0 mg	\nMagnesio	9 mg'),
(62, 'Lombarda', 11, 'Calorias 31\nGrasas totales 0.2 g	\nAcidos grasos saturados 0 g	\nAcidos grasos poliinsaturados 0.1 g	\nAcidos grasos monoinsaturados 0 g	\nColesterol 0 mg	\nSodio 27 mg	\nPotasio 243 mg	\nHidratos de carbono 7 g	\nFibra alimentaria 2.1 g	\nAzucares 3.8 g	\nProteinas 1.4 g	\nVitamina A	1.116 IU	\nVitamina C	57 mg\nCalcio	45 mg	\nHierro	0.8 mg\nVitamina D	0 IU	\nVitamina B6	0.2 mg\nVitamina B12	0 mg	\nMagnesio	16 mg'),
(63, 'Colinabo', 11, 'Calorias 38\nGrasas totales 0.2 g	\nAcidos grasos saturados 0 g	\nAcidos grasos poliinsaturados 0.1 g	\nAcidos grasos monoinsaturados 0 g	\nColesterol 0 mg	\nSodio 12 mg	\nPotasio 305 mg	\nHidratos de carbono 9 g	\nFibra alimentaria 2.3 g	\nAzucares 4.5 g	\nProteinas 1.1 g	\nVitamina A	2 IU	\nVitamina C	25 mg\nCalcio	43 mg	\nHierro	0.4 mg\nVitamina D	0 IU	\nVitamina B6	0.1 mg\nVitamina B12	0 mg	\nMagnesio	20 mg'),
(64, 'Cebolla', 16, 'Calorias 40\nGrasas totales 0.1 g	\nAcidos grasos saturados 0 g	\nAcidos grasos poliinsaturados 0 g	\nAcidos grasos monoinsaturados 0 g	\nColesterol 0 mg	\nSodio 4 mg	\nPotasio 146 mg	\nHidratos de carbono 9 g	\nFibra alimentaria 1.7 g	\nAzucares 4.2 g	\nProteinas 1.1 g	\nVitamina A	2 IU	\nVitamina C	7.4 mg\nCalcio	23 mg	\nHierro	0.2 mg\nVitamina D	0 IU	\nVitamina B6	0.1 mg\nVitamina B12	0 mg	\nMagnesio	10 mg'),
(65, 'Alcachofa', 12, 'Calorias 47\nGrasas totales 0.2 g	\nAcidos grasos saturados 0 g	\nAcidos grasos poliinsaturados 0.1 g	\nAcidos grasos monoinsaturados 0 g	\nColesterol 0 mg	\nSodio 94 mg	\nPotasio 370 mg	\nHidratos de carbono 11 g	\nFibra alimentaria 5 g	\nAzucares 1 g	\nProteinas 3.3 g	\nVitamina A	13 IU	\nVitamina C	11.7 mg\nCalcio	44 mg	\nHierro	1.3 mg\nVitamina D	0 IU	\nVitamina B6	0.1 mg\nVitamina B12	0 mg	\nMagnesio	60 mg'),
(66, 'Haba', 17, 'Calorias 88\nGrasas totales 0.7 g	\nAcidos grasos saturados 0.1 g	\nAcidos grasos poliinsaturados 0.3 g	\nAcidos grasos monoinsaturados 0.1 g	\nColesterol 0 mg	\nSodio 25 mg	\nPotasio 332 mg	\nHidratos de carbono 18 g	\nFibra alimentaria 8 g	\nAzucares 9 g	\nProteinas 8 g	\nVitamina A	333 IU	\nVitamina C	3.7 mg\nCalcio	37 mg	\nHierro	1.6 mg\nVitamina D	0 IU	\nVitamina B6	0.1 mg\nVitamina B12	0 mg	\nMagnesio	33 mg'),
(67, 'Calabazin', 3, 'Calorias	23.20 kcal.\nGrasa	0.50 g.\nColesterol	0 mg.\nSodio	1 mg.\nCarbohidratos	2 g.\nFibra	1.60 g.\nAzucares	1.91 g.\nProteinas	1.88 g.\nVitamina A	47.81 ug.	\nVitamina C	13.82 mg.\nVitamina B12	0 ug.	\nCalcio	21.51 mg.\nHierro	0.67 mg.	\nVitamina B3	0.71 mg.'),
(68, 'Borraja', 14, 'Calorias	25.70 kcal.\nGrasa	0.70 g.\nColesterol	0 mg.\nSodio	80 mg.\nCarbohidratos	3.06 g.\nFibra	0 g.\nAzucares	0 g.\nProteinas	1.80 g.\nVitamina A	210 ug.	\nVitamina C	35 mg.\nVitamina B12	0 ug.	\nCalcio	93 mg.\nHierro	3.30 mg.	\nVitamina B3	0 mg.'),
(69, 'Calabaza', 3, 'Calorias	28.37 kcal.\nGrasa	0.13 g.\nColesterol	0 mg.\nSodio	3.10 mg.\nCarbohidratos	4.59 g.\nFibra	2.16 g.\nAzucares	3.89 g.\nProteinas	1.13 g.\nVitamina A	127.58 ug.	\nVitamina C	12 mg.\nVitamina B12	0 ug.	\nCalcio	22 mg.\nHierro	0.80 mg.	\nVitamina B3	0.35 mg.'),
(70, 'Lechuga', 12, 'Carbohidratos 	2.23 g\n  Azucares 	0.94\n  Fibra alimentaria 	1.1 g\nGrasas 	0.22 g\nProteinas 	1.35 g\nAgua 	95.63 g\nRetinol (vit. A) 	166 ?g (18%)\n  ?-caroteno 	1987 ?g (18%)\nTiamina (vit. B1) 	0.057 mg (4%)\nRiboflavina (vit. B2) 	0.062 mg (4%)\nAcido pantotenico (vit. B5) 	0.15 mg (3%)\nVitamina B6 	0.082 mg (6%)\nVitamina C 	3.7 mg (6%)\nVitamina E 	0.18 mg (1%)\nVitamina K 	102.3 ?g (97%)\nCalcio 	35 mg (4%)\nHierro 	1.24 mg (10%)\nMagnesio 	13 mg (4%)\nManganeso 	0.179 mg (9%)\nFosforo 	33 mg (5%)\nPotasio 	238 mg (5%)\nSodio 	5 mg (0%)\nZinc 	0.2 mg (2%)'),
(71, 'Espinaca', 14, 'Carbohidratos 	3.6 g\n  Azucares 	0.4 g\nGrasas 	0.4 g\nProteinas 	2.9 g\nRetinol (vit. A) 	469 ?g (52%)\n  ?-caroteno 	5626 ?g (52%)\nVitamina C 	28 mg (47%)\nVitamina E 	2 mg (13%)\nVitamina K 	483 ?g (460%)\nCalcio 	99 mg (10%)\nHierro 	2.7 mg (22%)'),
(72, 'Tomate', 13, 'Carbohidratos 	3.9 g\n  Azucares 	2.6 g\n  Fibra alimentaria 	1.2 g\nGrasas 	0.2 gl\nProteinas 	0.9 g\nAgua 	94.5 g\nRetinol (vit. A) 	42 ?g (5%)\n  ?-caroteno 	449 ?g (4%)\nTiamina (vit. B1) 	0.037 mg (3%)\nNiacina (vit. B3) 	0.594 mg (4%)\nVitamina B6 	0.08 mg (6%)\nVitamina C 	14 mg (23%)\nVitamina E 	0.54 mg (4%)\nVitamina K 	7.9 ?g (8%)\nMagnesio 	11 mg (3%)\nManganeso 	0.114 mg (6%)\nFosforo 	24 mg (3%)\nPotasio 	237 mg (5%)'),
(73, 'Rabano', 11, 'Carbohidratos 	3.40 g\n  Azucares 	1.86 g\n  Fibra alimentaria 	1.6 g\nGrasas 	0.10\nProteinas 	0.68 g\nAgua 	95.27 g\nTiamina (vit. B1) 	0.012 mg (1%)\nRiboflavina (vit. B2) 	0.039 mg (3%)\nNiacina (vit. B3) 	0.254 mg (2%)\nVitamina B6 	0.071 mg (5%)\nVitamina C 	17.2 mg (29%)\nVitamina K 	1.3 ?g (1%)\nCalcio 	25 mg (3%)\nHierro 	0.34 mg (3%)\nMagnesio 	10 mg (3%)\nFosforo 	20 mg (3%)\nPotasio 	233 mg (5%)\nSodio 	39 mg (3%)\nZinc 	0.28 mg (3%)'),
(74, 'Pepino', 3, 'Carbohidratos 	3.63 g\n  Azucares 	1.67\n  Fibra alimentaria 	0.5 g\nGrasas 	0.11 g\nProteinas 	0.65 g\nAgua 	95.23\nTiamina (vit. B1) 	0.027 mg (2%)\nRiboflavina (vit. B2) 	0.033 mg (2%)\nNiacina (vit. B3) 	0.098 mg (1%)\nAcido pantotenico (vit. B5) 	0.259 mg (5%)\nVitamina B6 	0.04 mg (3%)\nVitamina C 	2.8 mg (5%)\nVitamina K 	16.4 ?g (16%)\nCalcio 	16 mg (2%)\nHierro 	0.28 mg (2%)\nMagnesio 	13 mg (4%)\nManganeso 	0.079 mg (4%)\nFosforo 	24 mg (3%)\nPotasio 	147 mg (3%)\nSodio 	2 mg (0%)\nZinc 	0.2 mg (2%)'),
(75, 'Esparrago', 16, 'Carbohidratos 	3.88 g\nGrasas 	0.12 g\nProteinas 	2.2 g\nRetinol (vit. A) 	38 ?g (4%)\nTiamina (vit. B1) 	0.143 mg (11%)\nRiboflavina (vit. B2) 	0.141 mg (9%)\nNiacina (vit. B3) 	0.978 mg (7%)\nAcido pantotenico (vit. B5) 	0.274 mg (5%)\nVitamina B6 	0.091 mg (7%)\nVitamina C 	5.6 mg (9%)\nVitamina E 	1.1 mg (7%)\nVitamina K 	41.6 ?g (40%)\nCalcio 	24 mg (2%)\nHierro 	2.14 mg (17%)\nMagnesio 	14 mg (4%)\nManganeso 	0.158 mg (8%)\nFosforo 	52 mg (7%)\nPotasio 	202 mg (4%)\nSodio 	2 mg (0%)\nZinc 	0.54 mg (5%)'),
(76, 'Acelga', 14, 'Carbohidratos 	4.13 g\n  Azucares 	1.1 g\n  Fibra alimentaria 	2.1 g\nGrasas 	0.08 g\nProteinas 	1.88 g\nAgua 	92.65 g\nRetinol (vit. A) 	306 ?g (34%)\n  ?-caroteno 	3652 ?g (34%)\nTiamina (vit. B1) 	0.034 mg (3%)\nRiboflavina (vit. B2) 	0.086 mg (6%)\nNiacina (vit. B3) 	0.36 mg (2%)\nAcido pantotenico (vit. B5) 	0.163 mg (3%)\nVitamina B6 	0.085 mg (7%)\nVitamina C 	18 mg (30%)\nVitamina E 	1.89 mg (13%)\nVitamina K 	327.3 ?g (312%)\nCalcio 	58 mg (6%)\nHierro 	2.26 mg (18%)\nMagnesio 	86 mg (23%)\nManganeso 	0.334 mg (17%)\nFosforo 	33 mg (5%)\nPotasio 	549 mg (12%)\nSodio 	179 mg (12%)\nZinc 	0.33 mg (3%)'),
(77, 'Berenjema', 13, 'Carbohidratos 	5.7 g\n  Azucares 	2.35 g\nGrasas 	0.19 g\nProteinas 	1.01 g\nAgua 	93%\nTiamina (vit. B1) 	0.039 mg (3%)\nRiboflavina (vit. B2) 	0.037 mg (2%)\nNiacina (vit. B3) 	0.649 mg (4%)\nAcido pantotenico (vit. B5) 	0.281 mg (6%)\nVitamina B6 	0.084 mg (6%)\nAcido folico (vit. B9) 	22 ?g (6%)\nVitamina C 	2.2 mg (4%)\nCalcio 	9 mg (1%)\nHierro 	0.24 mg (2%)\nMagnesio 	14 mg (4%)\nManganeso 	0.25 mg (13%)\nFosforo 	25 mg (4%)\nPotasio 	230 mg (5%)\nZinc 	0.16 mg (2%)'),
(78, 'Col Blanca', 11, 'Carbohidratos 	5.8 g\n  Azucares 	3.2 g\n  Fibra alimentaria 	2.5 g\nGrasas 	0.1 g\nProteinas 	1.28 g\nTiamina (vit. B1) 	0.061 mg (5%)\nRiboflavina (vit. B2) 	0.040 mg (3%)\nNiacina (vit. B3) 	0.234 mg (2%)\nAcido pantotenico (vit. B5) 	0.212 mg (4%)\nVitamina B6 	0.124 mg (10%)\nVitamina C 	36.6 mg (61%)\nVitamina K 	76 ?g (72%)\nCalcio 	40 mg (4%)\nHierro 	0.47 mg (4%)\nMagnesio 	12 mg (3%)\nManganeso 	0.16 mg (8%)\nFosforo 	26 mg (4%)\nPotasio 	170 mg (4%)\nSodio 	18 mg (1%)\nZinc 	0.18 mg (2%)'),
(79, 'Col de Saboya', 11, 'Carbohidratos 	6.1 g\n  Azucares 	2.27 g\n  Fibra alimentaria 	3.1 g\nGrasas 	0.1 g\nProteinas 	2 g\nAgua 	91 g\nRetinol (vit. A) 	50 ?g (6%)\n  ?-caroteno 	600 ?g (6%)\nTiamina (vit. B1) 	0.07 mg (5%)\nRiboflavina (vit. B2) 	0.03 mg (2%)\nNiacina (vit. B3) 	0.3 mg (2%)\nAcido pantotenico (vit. B5) 	0.187 mg (4%)\nVitamina B6 	0.19 mg (15%)\nVitamina C 	31 mg (52%)\nVitamina E 	0.17 mg (1%)\nVitamina K 	68.8 ?g (66%)\nCalcio 	35 mg (4%)\nHierro 	0.4 mg (3%)\nMagnesio 	28 mg (8%)\nManganeso 	0.18 mg (9%)\nFosforo 	42 mg (6%)\nPotasio 	230 mg (5%)\nZinc 	0.27 mg (3%)'),
(80, 'Coliflor', 11, 'Carbohidratos 	6.2 g\n  Azucares 	2.6 g\n  Fibra alimentaria 	3.6 g\nGrasas 	0.1 g\nProteinas 	1.7 g\nTiamina (vit. B1) 	0.05 mg (4%)\nRiboflavina (vit. B2) 	0.02 mg (1%)\nNiacina (vit. B3) 	0.4 mg (3%)\nAcido pantotenico (vit. B5) 	0.165 mg (3%)\nVitamina B6 	0.15 mg (12%)\nVitamina C 	62 mg (103%)\nVitamina E 	0.48 mg (3%)\nCalcio 	24 mg (2%)\nHierro 	0.4 mg (3%)\nMagnesio 	19 mg (5%)\nManganeso 	0.139 mg (7%)\nFosforo 	46 mg (7%)\nPotasio 	350 mg (7%)\nSodio 	20 mg (1%)'),
(81, 'Perejil', 14, 'Carbohidratos 	6.3 g\n  Azucares 	0.9 g\nGrasas 	0.8 g\nProteinas 	3.0 g\nTiamina (vit. B1) 	0.1 mg (8%)\nRiboflavina (vit. B2) 	0.2 mg (13%)\nNiacina (vit. B3) 	1.3 mg (9%)\nAcido pantotenico (vit. B5) 	0.4 mg (8%)\nVitamina B6 	0.1 mg (8%)\nAcido folico (vit. B9) 	152 ?g (38%)\nVitamina C 	133.0 mg (222%)\nVitamina K 	1640.0 ?g (1562%)\nCalcio 	138.0 mg (14%)\nHierro 	6.2 mg (50%)\nMagnesio 	50.0 mg (14%)\nFosforo 	58.0 mg (8%)\nPotasio 	554 mg (12%)\nZinc 	1.1 mg (11%)'),
(82, 'Nabo', 11, 'Carbohidratos 	6.43 g\n  Azucares 	3.80 g\n  Fibra alimentaria 	1.8 g\nGrasas 	0.10 g\n  saturadas 	0.011 g\n  monoinsaturadas 	0.006\n  poliinsaturadas 	0.053\nProteinas 	0.90 g\nAgua 	91.87 g\nTiamina (vit. B1) 	0.040 mg (3%)\nRiboflavina (vit. B2) 	0.030 mg (2%)\nNiacina (vit. B3) 	0.400 mg (3%)\nVitamina B6 	0.090 mg (7%)\nAcido folico (vit. B9) 	15 ?g (4%)\nVitamina C 	21.0 mg (35%)\nVitamina E 	0.03 mg (0%)\nVitamina K 	0.1 ?g (0%)\nCalcio 	30 mg (3%)\nHierro 	0.30 mg (2%)\nMagnesio 	11 mg (3%)\nFosforo 	27 mg (4%)\nPotasio 	191 mg (4%)\nSodio 	67 mg (4%)\nZinc 	0.27 mg (3%)'),
(83, 'Brocoli', 11, 'Carbohidratos 	6.64 g\n  Azucares 	1.7 g\n  Fibra alimentaria 	2.6 g\nGrasas 	0.37 g\nProteinas 	2.82 g\nAgua 	89.3 g\nRetinol (vit. A) 	31 ?g (3%)\n  ?-caroteno 	361 ?g (3%)\nTiamina (vit. B1) 	0.071 mg (5%)\nRiboflavina (vit. B2) 	0.117 mg (8%)\nNiacina (vit. B3) 	0.639 mg (4%)\nAcido pantotenico (vit. B5) 	0.573 mg (11%)\nVitamina B6 	0.175 mg (13%)\nAcido folico (vit. B9) 	63 ?g (16%)\nVitamina C 	89.2 mg (149%)\nVitamina E 	0.78 mg (5%)\nVitamina K 	101.6 ?g (97%)\nCalcio 	47 mg (5%)\nHierro 	0.73 mg (6%)\nMagnesio 	21 mg (6%)\nManganeso 	0.21 mg (11%)\nFosforo 	66 mg (9%)\nPotasio 	316 mg (7%)\nZinc 	0.41 mg (4%)'),
(84, 'Judias Verdes', 17, 'Carbohidratos 	6.97 g\n  Azucares 	3.26 g\n  Fibra alimentaria 	2.7 g\nGrasas 	0.22 g\nProteinas 	1.83 g\nAgua 	90.32 g\nRetinol (vit. A) 	35 ?g (4%)\nVitamina B6 	0.141 mg (11%)\nVitamina C 	12.2 mg (20%)\nVitamina K 	14.4 ?g (14%)\nCalcio 	37 mg (4%)\nHierro 	1.03 mg (8%)\nMagnesio 	25 mg (7%)\nManganeso 	0.216 mg (11%)\nFosforo 	38 mg (5%)\nPotasio 	211 mg (4%)\nZinc 	0.24 mg (2%)'),
(85, 'Col de Bruselas', 11, 'Carbohidratos 	8.95 g\n  Azucares 	2.2 g\n  Fibra alimentaria 	3.8 g\nGrasas 	0.3 g\nProteinas 	3.38 g\nAgua 	86 g\nRetinol (vit. A) 	38 ?g (4%)\n  ?-caroteno 	450 ?g (4%)\nTiamina (vit. B1) 	0.139 mg (11%)\nRiboflavina (vit. B2) 	0.09 mg (6%)\nNiacina (vit. B3) 	0.745 mg (5%)\nAcido pantotenico (vit. B5) 	0.309 mg (6%)\nVitamina B6 	0.219 mg (17%)\nVitamina C 	85 mg (142%)\nVitamina E 	0.88 mg (6%)\nVitamina K 	177 ?g (169%)\nCalcio 	42 mg (4%)\nHierro 	1.4 mg (11%)\nMagnesio 	23 mg (6%)\nManganeso 	0.337 mg (17%)\nFosforo 	1.4 mg (0%)\nPotasio 	389 mg (8%)\nSodio 	25 mg (2%)\nZinc 	0.42 mg (4%)'),
(86, 'Apio', 14, 'Carbohidratos 	9.2 g\nGrasas 	0.3 g\nProteinas 	1.5 g\nAgua 	88 g\nTiamina (vit. B1) 	0.05 mg (4%)\nRiboflavina (vit. B2) 	0.06 mg (4%)\nNiacina (vit. B3) 	0.7 mg (5%)\nAcido pantotenico (vit. B5) 	0.352 mg (7%)\nVitamina B6 	0.165 mg (13%)\nVitamina C 	8 mg (13%)\nVitamina K 	41 ?g (39%)\nCalcio 	43 mg (4%)\nHierro 	0.7 mg (6%)\nMagnesio 	20 mg (5%)\nManganeso 	0.158 mg (8%)\nFosforo 	115 mg (16%)\nPotasio 	300 mg (6%)\nSodio 	100 mg (7%)\nZinc 	0.33 mg (3%)'),
(87, 'Zanahoria', 19, 'Carbohidratos 	9.6 g\n  Azucares 	4.7 g\n  Fibra alimentaria 	2.8 g\nGrasas 	0.24 g\nProteinas 	0.93 g\nRetinol (vit. A) 	835 ?g (93%)\n  ?-caroteno 	8285 ?g (77%)\nTiamina (vit. B1) 	0.066 mg (5%)\nRiboflavina (vit. B2) 	0.058 mg (4%)\nNiacina (vit. B3) 	0.983 mg (7%)\nAcido pantotenico (vit. B5) 	0.273 mg (5%)\nVitamina B6 	0.138 mg (11%)\nVitamina C 	5.9 mg (10%)\nVitamina E 	0.66 mg (4%)\nVitamina K 	13.2 ?g (13%)\nCalcio 	33 mg (3%)\nHierro 	0.3 mg (2%)\nMagnesio 	12 mg (3%)\nManganeso 	0.143 mg (7%)\nFosforo 	35 mg (5%)\nPotasio 	320 mg (7%)\nSodio 	69 mg (5%)\nZinc 	0.24 mg (2%)'),
(88, 'Remolacha', 20, 'Carbohidratos 	9.56 g\n  Azucares 	6.76 g\n  Fibra alimentaria 	2.8 g\nGrasas 	0.17 g\nProteinas 	1.61 g\nAgua 	87.58 g\nRetinol (vit. A) 	2 ?g (0%)\nTiamina (vit. B1) 	0.031 mg (2%)\nRiboflavina (vit. B2) 	0.040 mg (3%)\nNiacina (vit. B3) 	0.334 mg (2%)\nVitamina B6 	0.067 mg (5%)\nVitamina C 	4.9 mg (8%)\nVitamina E 	0.04 mg (0%)\nVitamina K 	0.2 ?g (0%)\nCalcio 	16 mg (2%)\nHierro 	0.80 mg (6%)\nMagnesio 	23 mg (6%)\nFosforo 	40 mg (6%)\nPotasio 	325 mg (7%)\nSodio 	78 mg (5%)\nZinc 	0.35 mg (4%)'),
(89, 'Puerro', 16, 'Carbohidratos 	14.15 g\n  Fibra alimentaria 	1.8 g\nGrasas 	0.3 g\nProteinas 	1.5 g\nAgua 	83 g\nRetinol (vit. A) 	83 ?g (9%)\nTiamina (vit. B1) 	0.06 mg (5%)\nRiboflavina (vit. B2) 	0.03 mg (2%)\nNiacina (vit. B3) 	0.4 mg (3%)\nAcido pantotenico (vit. B5) 	0.233 mg (5%)\nVitamina B6 	64 mg (4923%)\nVitamina C 	12 mg (20%)\nVitamina E 	0.92 mg (6%)\nVitamina K 	47 ?g (45%)\nCalcio 	59 mg (6%)\nHierro 	2.1 mg (17%)\nMagnesio 	28 mg (8%)\nManganeso 	0.481 mg (24%)\nFosforo 	35 mg (5%)\nPotasio 	180 mg (4%)'),
(90, 'Guisante', 17, 'Carbohidratos 	14.45 g\n  Azucares 	5.67 g\n  Fibra alimentaria 	5.1 g\nGrasas 	0.4 g\nProteinas 	5.42 g\nRetinol (vit. A) 	35 ?g (4%)\n  ?-caroteno 	449 ?g (4%)\nTiamina (vit. B1) 	0.266 mg (20%)\nRiboflavina (vit. B2) 	0.132 mg (9%)\nNiacina (vit. B3) 	2.09 mg (14%)\nVitamina B6 	0.169 mg (13%)\nVitamina C 	40 mg (67%)\nVitamina E 	0.13 mg (1%)\nVitamina K 	24.8 ?g (24%)\nCalcio 	25 mg (3%)\nHierro 	1.47 mg (12%)\nMagnesio 	33 mg (9%)\nManganeso 	0.41 mg (21%)\nFosforo 	108 mg (15%)\nPotasio 	244 mg (5%)\nSodio 	5 mg (0%)\nZinc 	1.24 mg (12%)'),
(91, 'Ascalonia', 16, 'Carbohidratos 	16.8 g\nGrasas 	0.1 g\nProteinas 	2.5 g\nTiamina (vit. B1) 	0.06 mg (5%)\nRiboflavina (vit. B2) 	0.02 mg (1%)\nNiacina (vit. B3) 	0.2 mg (1%)\nAcido pantotenico (vit. B5) 	0.29 mg (6%)\nVitamina B6 	0.345 mg (27%)\nVitamina C 	8 mg (13%)\nCalcio 	37 mg (4%)\nHierro 	1.2 mg (10%)\nMagnesio 	21 mg (6%)\nManganeso 	0.292 mg (15%)\nFosforo 	60 mg (9%)\nPotasio 	334 mg (7%)\nZinc 	0.4 mg (4%)'),
(92, 'Chirivia', 19, 'Carbohidratos 	18 g\n  Azucares 	4.8\n  Fibra alimentaria 	4.9 g\nGrasas 	0.2 g\nProteinas 	1.2 g\nAgua 	79.53 g\nTiamina (vit. B1) 	0.09 mg (7%)\nRiboflavina (vit. B2) 	0.05 mg (3%)\nNiacina (vit. B3) 	0.7 mg (5%)\nAcido pantotenico (vit. B5) 	0.6 mg (12%)\nVitamina B6 	0.09 mg (7%)\nVitamina C 	17 mg (28%)\nVitamina E 	1.49 mg (10%)\nVitamina K 	22.5 ?g (21%)\nCalcio 	36 mg (4%)\nHierro 	0.59 mg (5%)\nMagnesio 	29 mg (8%)\nManganeso 	0.56 mg (28%)\nFosforo 	71 mg (10%)\nPotasio 	375 mg (8%)\nSodio 	10 mg (1%)\nZinc 	0.59 mg (6%)'),
(93, 'Patata', 13, 'Carbohidratos 	19 g\n  Almidon 	15 g\nGrasas 	0.1 g\nProteinas 	2 g\nAgua 	75 g\nTiamina (vit. B1) 	0.08 mg (6%)\nRiboflavina (vit. B2) 	0.03 mg (2%)\nNiacina (vit. B3) 	1.1 mg (7%)\nVitamina B6 	0.25 mg (19%)\nVitamina C 	20 mg (33%)\nCalcio 	12 mg (1%)\nHierro 	1.8 mg (14%)\nMagnesio 	23 mg (6%)\nFosforo 	57 mg (8%)\nPotasio 	421 mg (9%)\nSodio 	6 mg (0%)'),
(94, 'Maiz', 21, 'Carbohidratos 	19 g\n  Azucares 	3.2 g\nGrasas 	1.2 g\nProteinas 	3.2 g\nRetinol (vit. A) 	10 ?g (1%)\nTiamina (vit. B1) 	0.2 mg (15%)\nNiacina (vit. B3) 	1.7 mg (11%)\nAcido folico (vit. B9) 	46 ?g (12%)\nVitamina C 	7 mg (12%)\nHierro 	0.5 mg (4%)\nMagnesio 	37 mg (10%)\nPotasio 	270 mg (6%)'),
(95, 'Boniato', 12, 'Carbohidratos 	20.1 g\n  Almidon 	12.7 g\n  Azucares 	4.2 g\nGrasas 	0.1 g\nProteinas 	1.6 g\nRetinol (vit. A) 	709 ?g (79%)\n  ?-caroteno 	8509 ?g (79%)\nTiamina (vit. B1) 	0.1 mg (8%)\nRiboflavina (vit. B2) 	0.1 mg (7%)\nNiacina (vit. B3) 	0.61 mg (4%)\nAcido pantotenico (vit. B5) 	0.8 mg (16%)\nVitamina B6 	0.2 mg (15%)\nAcido folico (vit. B9) 	11 ?g (3%)\nVitamina C 	2.4 mg (4%)\nCalcio 	30.0 mg (3%)\nHierro 	0.6 mg (5%)\nMagnesio 	25.0 mg (7%)\nFosforo 	47.0 mg (7%)\nPotasio 	337 mg (7%)\nSodio 	55.0 mg (4%)\nZinc 	0.3 mg (3%)'),
(96, 'Ajo', 16, 'Carbohidratos 	33.06 g\n  Azucares 	1.00 g\nGrasas 	0.5 g\nProteinas 	6.36 g\nNiacina (vit. B3) 	0.7 mg (5%)\nAcido pantotenico (vit. B5) 	0.596 mg (12%)\nVitamina B6 	1.235 mg (95%)\nVitamina C 	31.2 mg (52%)\nCalcio 	181 mg (18%)\nHierro 	1.7 mg (14%)\nMagnesio 	25 mg (7%)\nFosforo 	153 mg (22%)\nSodio 	17 mg (1%)\nZinc 	1.16 mg (12%)'),
(97, 'Judia Blanca', 22, 'Calorias 67\nGrasas totales 0.7 g	\nAcidos grasos saturados 0.1 g	\nAcidos grasos poliinsaturados 0.4 g	\nAcidos grasos monoinsaturados 0.1 g	\nColesterol 0 mg	\nSodio 13 mg	\nPotasio 307 mg	\nHidratos de carbono 13 g	\nProteinas 6 g	\nVitamina A	4 IU	\nVitamina C	18.8 mg\nCalcio	15 mg	\nHierro	1.9 mg\nVitamina D	0 IU	\nVitamina B6	0.2 mg\nVitamina B12	0 mg	\nMagnesio	101 mg'),
(98, 'Frijol Negro', 22, 'Calorias 339\nGrasas totales 0.9 g	\nAcidos grasos saturados 0.2 g	\nAcidos grasos poliinsaturados 0.4 g	\nAcidos grasos monoinsaturados 0.1 g	\nColesterol 0 mg	\nSodio 9 mg	\nPotasio 1.500 mg	\nHidratos de carbono 63 g	\nFibra alimentaria 16 g	\nAzucares 2.1 g	\nProteinas 21 g	\nVitamina A	17 IU	\nVitamina C	0 mg\nCalcio	160 mg	\nHierro	8.7 mg\nVitamina D	0 IU	\nVitamina B6	0.3 mg\nVitamina B12	0 mg	\nMagnesio	160 mg');
INSERT INTO `ingredientes` (`id`, `nombre`, `tipo`, `descripcion`) VALUES
(99, 'Regaliz', 22, 'Calorias	323 kcal.\nGrasa	1.90 g.\nColesterol	0 mg.\nSodio	75 mg.\nCarbohidratos	71.50 g.\nFibra	2 g.\nAzucares	65.20 g.\nProteinas	3.90 g.\nVitamina A	0 ug.	\nVitamina C	0 mg.\nVitamina B12	0 ug.	\nCalcio	63 mg.\nHierro	8.10 mg.	\nVitamina B3	0 mg.'),
(100, 'Alfalfa', 23, 'Carbohidratos 	2.1 g\n  Fibra alimentaria 	1.9 g\nGrasas 	0.7 g\nProteinas 	4 g\nTiamina (vit. B1) 	0.076 mg (6%)\nRiboflavina (vit. B2) 	0.126 mg (8%)\nNiacina (vit. B3) 	0.481 mg (3%)\nAcido pantotenico (vit. B5) 	0.563 mg (11%)\nVitamina B6 	0.034 mg (3%)\nVitamina C 	8.2 mg (14%)\nVitamina K 	30.5 ?g (29%)\nCalcio 	32 mg (3%)\nHierro 	0.96 mg (8%)\nMagnesio 	27 mg (7%)\nManganeso 	0.188 mg (9%)\nFosforo 	70 mg (10%)\nPotasio 	79 mg (2%)\nSodio 	6 mg (0%)\nZinc 	0.92 mg (9%)'),
(101, 'Guisantes', 22, 'Carbohidratos 	14.45 g\n  Azucares 	5.67 g\n  Fibra alimentaria 	5.1 g\nGrasas 	0.4 g\nProteinas 	5.42 g\nRetinol (vit. A) 	35 ?g (4%)\n  ?-caroteno 	449 ?g (4%)\nTiamina (vit. B1) 	0.266 mg (20%)\nRiboflavina (vit. B2) 	0.132 mg (9%)\nNiacina (vit. B3) 	2.09 mg (14%)\nVitamina B6 	0.169 mg (13%)\nVitamina C 	40 mg (67%)\nVitamina E 	0.13 mg (1%)\nVitamina K 	24.8 ?g (24%)\nCalcio 	25 mg (3%)\nHierro 	1.47 mg (12%)\nMagnesio 	33 mg (9%)\nManganeso 	0.41 mg (21%)\nFosforo 	108 mg (15%)\nPotasio 	244 mg (5%)\nSodio 	5 mg (0%)\nZinc 	1.24 mg (12%)'),
(102, 'Garrofon', 22, 'Carbohidratos 	20.88 g\n  Azucares 	2.9 g\n  Fibra alimentaria 	7 g\nGrasas 	0.38 g\nProteinas 	7.8 g\nTiamina (vit. B1) 	0.161 mg (12%)\nRiboflavina (vit. B2) 	0.055 mg (4%)\nNiacina (vit. B3) 	0.421 mg (3%)\nAcido pantotenico (vit. B5) 	0.422 mg (8%)\nVitamina B6 	0.161 mg (12%)\nVitamina E 	0.18 mg (1%)\nVitamina K 	2 ?g (2%)\nCalcio 	17 mg (2%)\nHierro 	2.39 mg (19%)\nMagnesio 	43 mg (12%)\nManganeso 	0.516 mg (26%)\nFosforo 	111 mg (16%)\nPotasio 	508 mg (11%)\nSodio 	2 mg (0%)\nZinc 	0.95 mg (10%)'),
(103, 'Soja', 23, 'Carbohidratos 	30.16 g\n  Azucares 	7.33 g\n  Fibra alimentaria 	9.3 g\nGrasas 	19.94 g\nProteinas 	36.49 g\nAgua 	8.54 g\nRetinol (vit. A) 	1 ?g (0%)\nVitamina B6 	0.377 mg (29%)\nVitamina B12 	0 ?g (0%)\nVitamina C 	6 mg (10%)\nVitamina K 	47 ?g (45%)\nCalcio 	277 mg (28%)\nCobre 	1.658 mg (0%)\nHierro 	15.70 mg (126%)\nMagnesio 	280 mg (76%)\nPotasio 	1797 mg (38%)\nSodio 	2 mg (0%)\nZinc 	4.89 mg (49%)'),
(104, 'Lenteja', 22, 'Carbohidratos 	60 g\n  Azucares 	2 g\n  Fibra alimentaria 	31 g\nGrasas 	1 g\nProteinas 	26 g\nAgua 	10.4 g\nTiamina (vit. B1) 	0.87 mg (67%)\nRiboflavina (vit. B2) 	0.211 mg (14%)\nNiacina (vit. B3) 	2.605 mg (17%)\nAcido pantotenico (vit. B5) 	2.120 mg (42%)\nVitamina B6 	0.54 mg (42%)\nAcido folico (vit. B9) 	479 ?g (120%)\nVitamina C 	4.4 mg (7%)\nCalcio 	56 mg (6%)\nHierro 	7.54 mg (60%)\nMagnesio 	122 mg (33%)\nFosforo 	451 mg (64%)\nPotasio 	955 mg (20%)\nSodio 	6 mg (0%)\nZinc 	4.78 mg (48%)'),
(105, 'Frijoles', 22, 'Carbohidratos 	61.5 g\n  Fibra alimentaria 	4.3 g\nGrasas 	1.8 g\n  saturadas 	0.12 g\n  monoinsaturadas 	0.06 g\n  poliinsaturadas 	0.18 g\nProteinas 	19.2 g\nAgua 	7.9 g\nRetinol (vit. A) 	1.0 ?g (0%)\nTiamina (vit. B1) 	0.62 mg (48%)\nRiboflavina (vit. B2) 	0.14 mg (9%)\nNiacina (vit. B3) 	1.7 mg (11%)\nVitamina B6 	0.4 mg (31%)\nAcido folico (vit. B9) 	394 ?g (99%)\nCalcio 	228 mg (23%)\nMagnesio 	140 mg (38%)\nFosforo 	407 mg (58%)\nPotasio 	1406 mg (30%)\nSodio 	24 mg (2%)\nZinc 	2.79 mg (28%)'),
(106, 'Habichuela', 22, 'Carbohidratos 	61.5 g\n  Fibra alimentaria 	4.3 g\nGrasas 	1.8 g\n  saturadas 	0.12 g\n  monoinsaturadas 	0.06 g\n  poliinsaturadas 	0.18 g\nProteinas 	19.2 g\nAgua 	7.9 g\nRetinol (vit. A) 	1.0 ?g (0%)\nTiamina (vit. B1) 	0.62 mg (48%)\nRiboflavina (vit. B2) 	0.14 mg (9%)\nNiacina (vit. B3) 	1.7 mg (11%)\nVitamina B6 	0.4 mg (31%)\nAcido folico (vit. B9) 	394 ?g (99%)\nCalcio 	228 mg (23%)\nMagnesio 	140 mg (38%)\nFosforo 	407 mg (58%)\nPotasio 	1406 mg (30%)\nSodio 	24 mg (2%)\nZinc 	2.79 mg (28%)'),
(107, 'Judia Pinta', 22, 'Carbohidratos 	61.5 g\n  Fibra alimentaria 	4.3 g\nGrasas 	1.8 g\n  saturadas 	0.12 g\n  monoinsaturadas 	0.06 g\n  poliinsaturadas 	0.18 g\nProteinas 	19.2 g\nAgua 	7.9 g\nRetinol (vit. A) 	1.0 ?g (0%)\nTiamina (vit. B1) 	0.62 mg (48%)\nRiboflavina (vit. B2) 	0.14 mg (9%)\nNiacina (vit. B3) 	1.7 mg (11%)\nVitamina B6 	0.4 mg (31%)\nAcido folico (vit. B9) 	394 ?g (99%)\nCalcio 	228 mg (23%)\nMagnesio 	140 mg (38%)\nFosforo 	407 mg (58%)\nPotasio 	1406 mg (30%)\nSodio 	24 mg (2%)\nZinc 	2.79 mg (28%)'),
(108, 'Garbanzo', 22, 'Carbohidratos 	62.95 g\n  Azucares 	10.70 g\n  Fibra alimentaria 	12.2 g\nGrasas 	6.04 g\nProteinas 	20.47 g\nAgua 	7.68 g\nTiamina (vit. B1) 	0.477 mg (37%)\nRiboflavina (vit. B2) 	0.212 mg (14%)\nNiacina (vit. B3) 	1.541 mg (10%)\nVitamina B6 	0.535 mg (41%)\nVitamina C 	4.0 mg (7%)\nVitamina E 	0.82 mg (5%)\nVitamina K 	9.0 ?g (9%)\nCalcio 	57 mg (6%)\nHierro 	4.31 mg (34%)\nMagnesio 	79 mg (21%)\nFosforo 	252 mg (36%)\nPotasio 	718 mg (15%)\nSodio 	24 mg (2%)\nZinc 	2.76 mg (28%)'),
(109, 'Pulpo', 24, 'Calorias	\n57\nProteinas(g)	10.6\nGrasas	1\nG. saturadas(g)	N.d.\nG. monoinsaturadas(g)	N.d.\nG. poliinsaturadas(g)	N.d.\nHierro(mg)	1.7\nMagnesio(mg)	N.d.\nPotasio(mg)	N.d.\nFosforo(mg)	N.d.\nCinc(mg)	N.d.\nYodo(mg)	N.d.\nB1 o Tiamina(mg)	0.08\nB2 o riboflavina(mg)	0.04\nB3 o niacina(mg)	3.5\nB12 o cianocobalamina(mcg)	N.d'),
(110, 'Almeja', 24, 'Calorias	47.3\nProteinas(g)	10.7\nGrasas	0.5\nG. saturadas(g)	0.05\nG. monoinsaturadas(g)	0.03\nG. poliinsaturadas(g)	0.12\nHierro(mg)	24\nMagnesio(mg)	51\nPotasio(mg)	43\nFosforo(mg)	204\nCinc(mg)	1.3\nYodo(mg)	N.d.\nB1 o Tiamina(mg)	0.04\nB2 o riboflavina(mg)	0.14\nB3 o niacina(mg)	4.1\nB12 o cianocobalamina(mcg)	Trazas'),
(111, 'Cigala', 25, 'Calorias	66.3\nProteinas(g)	15\nGrasas	0.7\nG. saturadas(g)	0.1\nG. monoinsaturadas(g)	0.2\nG. poliinsaturadas(g)	0.2\nHierro(mg)	0.5\nMagnesio(mg)	30\nPotasio(mg)	250\nFosforo(mg)	200\nCinc(mg)	3.6\nYodo(mcg)	30\nB1 o Tiamina(mg)	N.d.\nB2 o riboflavina(mg)	N.d.\nB3 o niacina(mg)	N.d.\nB12 o cianocobalamina(mg)	1'),
(112, 'Percebe', 25, 'Calorias	66.4\nProteinas(g)	15.7\nGrasas	0.4\nG. saturadas(g)	0.01\nG. monoinsaturadas(g)	0.01\nG. poliinsaturadas(g)	0.01\nHierro(mg)	0.3\nMagnesio(mg)	21\nPotasio(mg)	330\nFosforo(mg)	N.d.\nCinc(mg)	0.5\nYodo(mcg)	N.d.\nB1 o Tiamina(mg)	0.3\nB2 o riboflavina(mg)	0.6\nB3 o niacina(mg)	N.d.\nB12 o cianocobalamina(mg)	N.d.'),
(113, 'Mejillones', 24, 'Calorias	67.4\nProteinas(g)	10.8\nGrasas	1.9\nG. saturadas(g)	0.3\nG. monoinsaturadas(g)	0.3\nG. poliinsaturadas(g)	0.5\nHierro(mg)	4.5\nMagnesio(mg)	23\nPotasio(mg)	320\nFosforo(mg)	250\nCinc(mg)	1.8\nYodo(mg)	40\nB1 o Tiamina(mg)	0.1\nB2 o riboflavina(mg)	0.14\nB3 o niacina(mg)	3.0\nB12 o cianocobalamina(mcg)	10.2'),
(114, 'Ostras', 24, 'Calorias	71\nProteinas(g)	10.2\nGrasas	1.4\nG. saturadas(g)	0.2\nG. monoinsaturadas(g)	0.1\nG. poliinsaturadas(g)	0.4\nHierro(mg)	6.5\nMagnesio(mg)	44\nPotasio(mg)	260\nFosforo(mg)	171\nCinc(mg)	52\nYodo(mg)	20\nB1 o Tiamina(mg)	0.2\nB2 o riboflavina(mg)	0.3\nB3 o niacina(mg)	3.8\nB12 o cianocobalamina(mcg)	16.5'),
(115, 'Calamar', 24, 'Calorias	81.6\nProteinas(g)	17\nGrasas	1.3\nG. saturadas(g)	0.3\nG. monoinsaturadas(g)	0.1\nG. poliinsaturadas(g)	0.4\nHierro(mg)	1.7\nMagnesio(mg)	34\nPotasio(mg)	90\nFosforo(mg)	221\nCinc(mg)	N.d.\nYodo(mg)	N.d.\nB1 o Tiamina(mg)	0.07\nB2 o riboflavina(mg)	0.14\nB3 o niacina(mg)	3.6\nB12 o cianocobalamina(mcg)	1.3'),
(116, 'Vieira', 24, 'Calorias	84.1\nProteinas(g)	19\nGrasas	0.9\nG. saturadas(g)	0.3\nG. monoinsaturadas(g)	0.1\nG. poliinsaturadas(g)	0.2\nHierro(mg)	2.4\nMagnesio(mg)	38\nPotasio(mg)	480\nFosforo(mg)	195\nCinc(mg)	1.3\nYodo(mg)	N.d.\nB1 o Tiamina(mg)	0.04\nB2 o riboflavina(mg)	0.1\nB3 o niacina(mg)	6.4\nB12 o cianocobalamina(mcg)	1.4'),
(117, 'Bogavante', 25, 'Calorias	91.2\nProteinas(g)	18.3\nGrasas	2\nG. saturadas(g)	0.2\nG. monoinsaturadas(g)	0.3\nG. poliinsaturadas(g)	0.7\nHierro(mg)	0.7\nMagnesio(mg)	34\nPotasio(mg)	220\nFosforo(mg)	200\nCinc(mg)	2.3\nYodo(mcg)	40\nB1 o Tiamina(mg)	0.1\nB2 o riboflavina(mg)	0.1\nB3 o niacina(mg)	5.3\nB12 o cianocobalamina(mg)	1'),
(118, 'Langosta', 25, 'Calorias	91.2\nProteinas(g)	18.3\nGrasas	2\nG. saturadas(g)	0.2\nG. monoinsaturadas(g)	0.3\nG. poliinsaturadas(g)	0.7\nHierro(mg)	0.7\nMagnesio(mg)	34\nPotasio(mg)	220\nFosforo(mg)	200\nCinc(mg)	2.3\nYodo(mcg)	40\nB1 o Tiamina(mg)	0.1\nB2 o riboflavina(mg)	0.1\nB3 o niacina(mg)	5.3\nB12 o cianocobalamina(mg)	1'),
(119, 'Gamba', 25, 'Calorias	95.7\nProteinas(g)	21\nGrasas	1.3\nG. saturadas(g)	0.2\nG. monoinsaturadas(g)	0.3\nG. poliinsaturadas(g)	0.5\nHierro(mg)	2\nMagnesio(mg)	42\nPotasio(mg)	260\nFosforo(mg)	300\nCinc(mg)	3.6\nYodo(mcg)	90\nB1 o Tiamina(mg)	0.01\nB2 o riboflavina(mg)	0.03\nB3 o niacina(mg)	2\nB12 o cianocobalamina(mg)	1'),
(120, 'Langostino', 25, 'Calorias	95.7\nProteinas(g)	21\nGrasas	1.3\nG. saturadas(g)	0.3\nG. monoinsaturadas(g)	0.4\nG. poliinsaturadas(g)	0.3\nHierro(mg)	2\nMagnesio(mg)	42\nPotasio(mg)	260\nFosforo(mg)	300\nCinc(mg)	3.6\nYodo(mcg)	90\nB1 o Tiamina(mg)	0.01\nB2 o riboflavina(mg)	0.03\nB3 o niacina(mg)	2\nB12 o cianocobalamina(mg)	1'),
(121, 'Cangrejo', 25, 'Calorias	124\nProteinas(g)	19.5\nGrasas	5.1\nG. saturadas(g)	0.7\nG. monoinsaturadas(g)	1.1\nG. poliinsaturadas(g)	2.2\nHierro(mg)	1.3\nMagnesio(mg)	48\nPotasio(mg)	270\nFosforo(mg)	160\nCinc(mg)	3.8\nYodo(mcg)	40\nB1 o Tiamina(mg)	0.1\nB2 o riboflavina(mg)	0.2\nB3 o niacina(mg)	6.3\nB12 o cianocobalamina(mg)	Trazas'),
(122, 'Centollo', 25, 'Calorias	127.2\nProteinas(g)	20.1\nGrasas	5.2\nG. saturadas(g)	0.7\nG. monoinsaturadas(g)	1.2\nG. poliinsaturadas(g)	2.2\nHierro(mg)	1.3\nMagnesio(mg)	48\nPotasio(mg)	270\nFosforo(mg)	N.d.\nCinc(mg)	5.5\nYodo(mcg)	40\nB1 o Tiamina(mg)	0.1\nB2 o riboflavina(mg)	0.2\nB3 o niacina(mg)	6.1\nB12 o cianocobalamina(mg)	Trazas'),
(123, 'Panzerotti', 26, 'Calorias 	1 	\nSodio 	0 mg\nGrasas totales 	0 g 	\nPotasio 	0 mg\nSaturadas 	0 g 	\nCarbohidratos totales 	0 g\nPoliinsaturados 	0 g 	\nFibra dietetica 	0 g\nMonoinsaturados 	0 g 	Azucares 	0 g\nTrans 	0 g 	\nProteinas 	0 g\nColesterol 	0 mg 	'),
(124, 'Tortelloni', 26, 'Calorias 	2.088 	\nSodio 	6.654 mg\nGrasas totales 	92 g 	\nPotasio 	2.812 mg\nSaturadas 	85 g 	\nCarbohidratos totales 	167 g\nPoliinsaturados 	12 g 	\nFibra dietetica 	0 g\nMonoinsaturados 	8 g 	Azucares 	22 g\nTrans 	24 g 	\nProteinas 	175 g\nColesterol 	428 mg 	  	 \nVitamina A 	48% 	\nCalcio 	188%\nVitamina C 	30% 	\nHierro 	37%'),
(125, 'Tortellini', 26, 'Calorias 	70 	\nSodio 	260 mg\nGrasas totales 	5 g 	\nPotasio 	0 mg\nSaturadas 	4 g 	\nCarbohidratos totales 	1 g\nPoliinsaturados 	0 g 	\nFibra dietetica 	0 g\nMonoinsaturados 	0 g 	Azucares 	0 g\nTrans 	0 g 	\nProteinas 	5 g\nColesterol 	20 mg 	  	 \nVitamina A 	4% 	\nCalcio 	10%'),
(126, 'Lengua de pajaro', 27, 'Calorias 	75 	\nSodio 	70 mg\nGrasas totales 	1 g 	\nPotasio 	315 mg\nSaturadas 	1 g 	\nCarbohidratos totales 	13 g\nPoliinsaturados 	0 g 	\nFibra dietetica 	1 g\nMonoinsaturados 	0 g 	Azucares 	11 g\nTrans 	0 g 	\nProteinas 	4 g\nColesterol 	5 mg 	  	 \nVitamina A 	5% 	\nCalcio 	17%\nVitamina C 	2% 	\nHierro 	1%'),
(127, 'Dedales', 27, 'Calorias 	160 	\nSodio 	0 mg\nGrasas totales 	0 g 	\nPotasio 	0 mg\nSaturadas 	0 g 	\nCarbohidratos totales 	0 g\nPoliinsaturados 	0 g 	\nFibra dietetica 	0 g\nMonoinsaturados 	0 g 	Azucares 	0 g\nTrans 	0 g 	\nProteinas 	0 g\nColesterol 	0 mg'),
(128, 'Agnolotti', 26, 'Calorias 	170 	\nSodio 	0 mg\nGrasas totales 	0 g 	\nPotasio 	0 mg\nSaturadas 	0 g 	\nCarbohidratos totales 	0 g\nPoliinsaturados 	0 g 	\nFibra dietetica 	0 g\nMonoinsaturados 	0 g 	Azucares 	0 g\nTrans 	0 g 	\nProteinas 	0 g\nColesterol 	0 mg 	'),
(129, 'Cappelletti', 26, 'Calorias 	173 	\nSodio 	0 mg\nGrasas totales 	11 g 	\nPotasio 	0 mg\nSaturadas 	1 g 	\nCarbohidratos totales 	17 g\nPoliinsaturados 	1 g 	\nFibra dietetica 	0 g\nMonoinsaturados 	9 g 	Azucares 	1 g\nTrans 	0 g 	\nProteinas 	2 g\nColesterol 	0 mg'),
(130, 'Gnocchi', 27, 'Calorias 	197 	\nSodio 	0 mg\nGrasas totales 	4 g 	\nPotasio 	0 mg\nSaturadas 	1 g 	\nCarbohidratos totales 	34 g\nPoliinsaturados 	0 g 	\nFibra dietetica 	0 g\nMonoinsaturados 	0 g 	Azucares 	0 g\nTrans 	0 g 	\nProteinas 	6 g\nColesterol 	0 mg 	  	 \nVitamina A 	0% 	\nCalcio 	0%\nVitamina C 	0% 	\nHierro 	0%'),
(131, 'Penne', 27, 'Calorias 	200 	\nSodio 	0 mg\nGrasas totales 	1 g 	\nPotasio 	0 mg\nSaturadas 	0 g 	\nCarbohidratos totales 	41 g\nPoliinsaturados 	0 g 	\nFibra dietetica 	2 g\nMonoinsaturados 	0 g 	Azucares 	2 g\nTrans 	0 g 	\nProteinas 	7 g\nColesterol 	0 mg 	  	 \nVitamina A 	0% 	\nCalcio 	0%\nVitamina C 	0% 	\nHierro 	10%'),
(132, 'Rigatoni', 27, 'Calorias 	200 	\nSodio 	0 mg\nGrasas totales 	1 g 	\nPotasio 	0 mg\nSaturadas 	0 g 	\nCarbohidratos totales 	42 g\nPoliinsaturados 	0 g 	\nFibra dietetica 	2 g\nMonoinsaturados 	0 g 	Azucares 	2 g\nTrans 	0 g 	\nProteinas 	7 g\nColesterol 	0 mg 	  	 \nVitamina A 	0% 	\nCalcio 	0%\nVitamina C 	0% 	\nHierro 	0%'),
(133, 'Linguine', 28, 'Calorias 	200 	\nSodio 	0 mg\nGrasas totales 	1 g 	\nPotasio 	0 mg\nSaturadas 	0 g 	\nCarbohidratos totales 	42 g\nPoliinsaturados 	0 g 	\nFibra dietetica 	2 g\nMonoinsaturados 	0 g 	Azucares 	2 g\nTrans 	0 g 	\nProteinas 	7 g\nColesterol 	0 mg 	  	 \nVitamina A 	0% 	\nCalcio 	0%\nVitamina C 	0% 	\nHierro 	10%'),
(134, 'Ziti', 28, 'Calorias 	200 	\nSodio 	0 mg\nGrasas totales 	1 g 	\nPotasio 	0 mg\nSaturadas 	0 g 	\nCarbohidratos totales 	42 g\nPoliinsaturados 	0 g 	\nFibra dietetica 	2 g\nMonoinsaturados 	0 g 	Azucares 	2 g\nTrans 	0 g 	\nProteinas 	7 g\nColesterol 	0 mg 	  	 \nVitamina A 	0% 	\nCalcio 	0%\nVitamina C 	0% 	\nHierro 	10%'),
(135, 'Cabello de Angel', 28, 'Calorias 	280 	\nSodio 	0 mg\nGrasas totales 	0 g 	\nPotasio 	0 mg\nSaturadas 	0 g 	\nCarbohidratos totales 	58 g\nPoliinsaturados 	0 g 	\nFibra dietetica 	3 g\nMonoinsaturados 	0 g 	Azucares 	0 g\nTrans 	0 g 	\nProteinas 	11 g\nColesterol 	0 mg 	  	 \nVitamina A 	0% 	\nCalcio 	0%\nVitamina C 	0% 	\nHierro 	25%'),
(136, 'Rotini', 27, 'Calorias 	325 	\nSodio 	0 mg\nGrasas totales 	0 g 	\nPotasio 	0 mg\nSaturadas 	0 g 	\nCarbohidratos totales 	0 g\nPoliinsaturados 	0 g 	\nFibra dietetica 	0 g\nMonoinsaturados 	0 g 	Azucares 	0 g\nTrans 	0 g 	\nProteinas 	0 g\nColesterol 	0 mg 	'),
(137, 'Ravioli', 26, 'Calorias 	334 	\nSodio 	699 mg\nGrasas totales 	13 g 	\nPotasio 	836 mg\nSaturadas 	18 g 	\nCarbohidratos totales 	40 g\nPoliinsaturados 	6 g 	\nFibra dietetica 	5 g\nMonoinsaturados 	8 g 	Azucares 	6 g\nTrans 	6 g 	\nProteinas 	8 g\nColesterol 	25 mg 	  	 \nVitamina A 	42% 	\nCalcio 	20%\nVitamina C 	11% 	\nHierro 	22%'),
(138, 'Tortiglioni', 27, 'Calorias 	356 	\nSodio 	3 mg\nGrasas totales 	2 g 	\nPotasio 	0 mg\nSaturadas 	1 g 	\nCarbohidratos totales 	72 g\nPoliinsaturados 	0 g 	\nFibra dietetica 	3 g\nMonoinsaturados 	0 g 	Azucares 	4 g\nTrans 	0 g 	\nProteinas 	12 g\nColesterol 	0 mg 	  	 \nVitamina A 	0% 	\nCalcio 	0%\nVitamina C 	0% 	\nHierro 	0%'),
(139, 'Pappardelle', 28, 'Calorias 	369 	\nSodio 	0 mg\nGrasas totales 	3 g 	\nPotasio 	0 mg\nSaturadas 	0 g 	\nCarbohidratos totales 	71 g\nPoliinsaturados 	0 g 	\nFibra dietetica 	0 g\nMonoinsaturados 	0 g 	Azucares 	0 g\nTrans 	0 g 	\nProteinas 	15 g\nColesterol 	0 mg'),
(140, 'Fusilli', 27, 'Calorias 	429 	\nSodio 	318 mg\nGrasas totales 	6 g 	\nPotasio 	97 mg\nSaturadas 	2 g 	\nCarbohidratos totales 	67 g\nPoliinsaturados 	0 g 	\nFibra dietetica 	4 g\nMonoinsaturados 	0 g 	Azucares 	2 g\nTrans 	0 g 	\nProteinas 	27 g\nColesterol 	0 mg 	  	 \nVitamina A 	3% 	\nCalcio 	3%\nVitamina C 	3% 	\nHierro 	129%'),
(141, 'Bucatini', 28, 'Calorias 	581 	\nSodio 	1.355 mg\nGrasas totales 	13 g 	\nPotasio 	0 mg\nSaturadas 	4 g 	\nCarbohidratos totales 	74 g\nPoliinsaturados 	0 g 	\nFibra dietetica 	6 g\nMonoinsaturados 	0 g 	Azucares 	5 g\nTrans 	0 g 	\nProteinas 	41 g\nColesterol 	98 mg 	  	 \nVitamina A 	0% 	\nCalcio 	11%\nVitamina C 	0% 	\nHierro 	5%'),
(142, 'Farfalle', 27, 'Calorias 	722 	\nSodio 	322 mg\nGrasas totales 	46 g 	\nPotasio 	157 mg\nSaturadas 	28 g 	\nCarbohidratos totales 	42 g\nPoliinsaturados 	1 g 	\nFibra dietetica 	17 g\nMonoinsaturados 	4 g 	Azucares 	13 g\nTrans 	0 g 	\nProteinas 	38 g\nColesterol 	460 mg 	  	 \nVitamina A 	343% 	\nCalcio 	73%\nVitamina C 	6% 	\nHierro 	67%'),
(143, 'Fettuccine', 28, 'Calorias 99\nGrasas totales 2.7 g	\nAcidos grasos saturados 0.9 g	\nAcidos grasos poliinsaturados 0.4 g	\nAcidos grasos monoinsaturados 0.9 g	\nAcidos grasos trans 0 g	\nColesterol 14 mg	\nSodio 166 mg	\nPotasio 168 mg	\nHidratos de carbono 14 g	\nFibra alimentaria 2 g	\nAzucares 1.3 g	\nProteinas 6 g	\nCalcio	28 mg	\nHierro	0.6 mg\nVitamina D	0 IU	\nVitamina B6	0.1 mg\nVitamina B12	0 mg	\nMagnesio	6 mg'),
(144, 'Spaghetti', 28, 'Calorias 158\nGrasas totales 0.9 g	\nAcidos grasos saturados 0.2 g	\nAcidos grasos poliinsaturados 0.3 g	\nAcidos grasos monoinsaturados 0.1 g	\nAcidos grasos trans 0 g	\nColesterol 0 mg	\nSodio 1 mg	\nPotasio 44 mg	\nHidratos de carbono 31 g	\nFibra alimentaria 1.8 g	\nAzucares 0.6 g	\nProteinas 6 g	\nVitamina A	0 IU	\nVitamina C	0 mg\nCalcio	7 mg	\nHierro	1.3 mg\nVitamina D	0 IU	\nVitamina B6	0 mg\nVitamina B12	0 mg	\nMagnesio	18 mg'),
(145, 'Tagliatelle', 28, 'Calorias 288\nGrasas totales 2.3 g	\nAcidos grasos saturados 0.3 g	\nAcidos grasos poliinsaturados 0.9 g	\nAcidos grasos monoinsaturados 0.3 g	\nColesterol 73 mg	\nSodio 26 mg	\nPotasio 179 mg	\nHidratos de carbono 55 g	\nProteinas 11 g	\nVitamina A	47 IU	\nVitamina C	0 mg\nCalcio	15 mg	\nHierro	3.4 mg\nVitamina B6	0.1 mg	\nVitamina B12	0.3 mg\nMagnesio	46 mg	'),
(146, 'Vermicelli', 28, 'Calorias 331\nGrasas totales 0.1 g	\nAcidos grasos saturados 0 g	\nAcidos grasos poliinsaturados 0 g	\nAcidos grasos monoinsaturados 0 g	\nColesterol 0 mg	\nSodio 4 mg	\nPotasio 3 mg	\nHidratos de carbono 82 g	\nFibra alimentaria 3.9 g	\nAzucares 17 g	\nProteinas 0.1 g	\nVitamina A	37 IU	\nVitamina C	0 mg\nCalcio	55 mg	\nHierro	1.8 mg\nVitamina D	0 IU	\nVitamina B6	0 mg\nVitamina B12	0 mg	\nMagnesio	2 mg'),
(147, 'Macarrones', 27, 'Calorias 371\nGrasas totales 1.5 g	\nAcidos grasos saturados 0.3 g	\nAcidos grasos poliinsaturados 0.6 g	\nAcidos grasos monoinsaturados 0.2 g	\nAcidos grasos trans 0 g	\nColesterol 0 mg	\nSodio 6 mg	\nPotasio 223 mg	\nHidratos de carbono 75 g	\nFibra alimentaria 3.2 g	\nAzucares 2.7 g	\nProteinas 13 g	\nVitamina A	0 IU	\nVitamina C	0 mg\nCalcio	21 mg	\nHierro	1.3 mg\nVitamina B6	0.1 mg	\nVitamina B12	0 mg\nMagnesio	53 mg	'),
(148, 'Liba', 29, 'Calorias 	74.4\nProteinas (g) 	17.7\nGrasas (g) 	0.4\nHierro (mg) 	0.4\nMagnesio (mg) 	20\nPotasio (mg) 	274\nFosforo (mg) 	180\nCinc (mg) 	0.4\nB9 o Acido folico (mcg) 	13\nB12 o cianocobalamina (mcg) 	0.53'),
(149, 'Gallo', 29, 'Calorias 	80.3\nProteinas (g) 	15.8\nGrasas (g) 	1.9\nHierro (mg) 	0.96\nMagnesio (mg) 	42.1\nPotasio (mg) 	250\nSodio (mg) 	150\nFosforo (mg) 	260\nYodo (mg) 	16\nB6 o Pridoxina (mg) 	0.38\nB9 o Acido folico (mcg) 	11.2'),
(150, 'Lenguado', 29, 'Calorias 	81.38\nProteinas (g) 	16.5\nGrasas (g) 	1.5\nHierro (mg) 	0.7\nMagnesio (mg) 	29\nPotasio (mg) 	230\nFosforo (mg) 	260\nYodo (mg) 	30\nB3 o niacina (mg) 	5.5\nB9 o Acido folico (mcg) 	11'),
(151, 'Lubina', 29, 'Calorias 	85.95\nProteinas (g) 	18\nGrasas (g) 	1.3\nHierro (mg) 	1.1\nMagnesio (mg) 	26\nPotasio (mg) 	255\nFosforo (mg) 	210\nCinc (mg) 	0.80\nB1 o tiamina (mg) 	0.11\nB2 o riboflavina (mg) 	0.16\nB3 o niacina (mg) 	6.7\nB12 o cianocobalamina (mcg) 	3.8'),
(152, 'Trucha', 29, 'Calorias 	89.8\nProteinas (g) 	15.7\nGrasas (g) 	3.0\nG. saturadas (g) 	0.4\nG. monoinsaturadas (g) 	0.7\nG. poliinsaturadas (g) 	1.0\nHierro (mg) 	1.0\nMagnesio (mg) 	28.0\nPotasio (mg) 	250\nFosforo (mg) 	250\nCinc (mg) 	0.8\nB1 o tiamina (mg) 	0.1\nB2 o riboflavina (mg) 	0.1\nB3 o niacina (mcg) 	5.1\nVitamina A (mcg) 	14.0'),
(153, 'Rodaballo', 29, 'Calorias 	102\nProteinas (g) 	16\nGrasas (g) 	3.6\nHierro (mg) 	1\nMagnesio (mg) 	20\nPotasio (mg) 	290\nFosforo (mg) 	164\nSodio (mg) 	110\nB2 o riboflavina (mg) 	0.14\nB3 o niacina (mg) 	5.5\nB9 o Acido folico (mcg) 	16\nB12 o cianocobalamina (mcg) 	0.8'),
(154, 'Fleton', 29, 'Calorias 	103.1\nProteinas (g) 	21.5\nGrasas (g) 	1.9\nPotasio (mg) 	410\nFosforo (mg) 	200\nB3 (mg) 	9.8\nB6 (mg) 	0.38\nB9 (mcg) 	9\nVitmamina E (mg) 	0.85'),
(155, 'Carpa', 30, 'Calorias 	118.8\nProteinas (g) 	18\nGrasas (g) 	5.2\nHierro (mg) 	1.2\nPotasio (mg) 	320\nFosforo (mg) 	315\nMagnesio (mg) 	30\nB2 o Riboflavina (mg) 	0.05\nB6 o Piridoxina (mg) 	0.17\nB12 o cianocobalama (mg) 	1.5\nVitamina A (mcg) 	44\nVitmamina E (mg) 	0.5'),
(156, 'Tiburon', 30, 'Calorias 	130\nProteinas (g) 	21\nGrasas (g) 	4.5\nG. saturadas (g) 	0.9\nG. monoinsaturadas (g) 	1.8\nG. poliinsaturadas (g) 	1.2\nHierro (mg) 	0.84\nMagnesio (mg) 	49\nPotasio (mg) 	160\nFosforo (mg) 	210\nB2 o riboflavina (mg) 	0.62\nB3 o niacina (mg) 	2.9\nB12 o cianocobalamina (mcg) 	1.5\nVitamina A o retinol (mcg) 	70'),
(157, 'Sardina', 30, 'Calorias 	153\nProteinas (g) 	17.1\nGrasas (g) 	9.4\nG. saturadas (g) 	2.6\nG. monoinsaturadas (g) 	2.8\nG. poliinsaturadas (g) 	2.9\nHierro (mg) 	2.7\nMagnesio (mg) 	25.1\nPotasio (mg) 	20\nFosforo (mg) 	258\nCinc (mg) 	0.9\nYodo (mg) 	29\nB1 o tiamina (mg) 	0.1\nB2 o riboflavina (mg)		0.3\nB3 o niacina (mg) 	6.4\nB9 o Acido folico (mcg) 	8.7\nB12 o cianocobalamina (mcg) 	28.4\nVitamina A (mcg) 	62.9\nVitmamina D (mcg) 	7.9\nVitmamina E o tocoferol (mcg) 	1.6'),
(158, 'Atun', 30, 'Calorias 	200\nProteinas (g) 	23\nGrasas (g) 	12\nG. saturadas (g) 	2.77\nG. monoinsaturadas (g) 	2.39\nG. poliinsaturadas (g) 	3.07\nHierro (mg) 	1.3\nMagnesio (mg) 	28\nPotasio (mg) 	40\nFosforo (mg) 	200\nCinc (mg) 	1.1\nYodo (mg) 	10\nB2 o riboflavina (mg) 	0.2\nB3 o niacina (mg) 	17.8\nB9 o Acido folico (mcg) 	15\nB12 o cianocobalamina (mcg) 	5\nVitamina A (mcg) 	60\nVitmamina D (mcg) 	25'),
(159, 'Lamprea', 30, 'Calorias 	218\nProteinas (g) 	14\nGrasas (g) 	18\nG. saturadas (g) 	4.6\nG. monoinsaturadas (g) 	7\nG. poliinsaturadas (g) 	4.6\nHierro (mg) 	1\nPotasio (mg) 	220\nFosforo (mg) 	170\nMagnesio (mg) 	19\nB1 (mg) 	0.15\nB2 (mg) 	0.4\nVitamina A (mcg) 	1000\nVitmamina D (mcg) 	4.9'),
(160, 'Anguila', 30, 'Calorias 	218\nProteinas (g) 	14\nGrasas (g) 	18\nG. saturadas (g) 	4.58\nG. monoinsaturadas (g) 	7.03\nG. poliinsaturadas (g) 	4.58\nHierro (mg) 	1\nPotasio (mg) 	220\nFosforo (mg) 	170\nZinc (mg) 	3\nYodo (mg) 	10\nB1 (mg) 	0.15\nB2 (mg) 	0.4\nVitamina A (mcg) 	1000\nVitmamina D (mcg) 	4.9\nVitmamina E (mg) 	5.6'),
(161, 'Besugo', 30, 'Calorias 86\nProteinas (g) 17\nGrasas (g) 2-5\nHierro (mg) 0.8\nMagnesio (mg) 25\nPotasio (mg) 310\nFosforo (mg) 210\nB3 o niacina (mg) 5\nB6 o piridoxina (mg) 0.46\nB12 o cianocobalamina (mcg) 2\nVitamina A (mcg) 9'),
(162, 'Congrio', 29, 'Calorias 106.45\nProteinas (g) 19\nGrasas (g) 2.8\nFosforo (mg) 202\nMagnesio (mg) 30\nB1 o Tiamina (mg) 0.17\nB2 o riboflavina (mg) 0.37\nB3 o niacina (mg) 5.5\nVitamina A (mcg) 500\nVitmamina D (mcg) 22'),
(163, 'Salm�n', 30, 'Calorias 179.8\nProteinas (g) 20.2\nGrasas (g) 11\nG. saturadas (g) 1.9\nG. monoinsaturadas (g) 4.4\nG. poliinsaturadas (g) 3.1\nHierro (mg) 0.4\nMagnesio (mg) 27\nPotasio (mg) 360\nFosforo (mg) 250\nSodio (mg) 45\nYodo (mcg) 37\nB1 o tiamina (mg) 0.23\nB2 o riboflavina (mg) 0.13\nB3 o niacina (mg) 7.2\nB6 o piridoxina (mg) 0.75\nB9 o Acido folico (mcg) 16\nB12 o cianocobalamina (mcg) 4\nVitamina A (mcg) 13\nVitamina D (mcg) 8\nVitmamina E (mg) 1.9'),
(164, 'Bacalao Fresco', 29, 'Calorias		74.4\nProteinas (g)		17.7\nGrasas (g)		0.4\nHierro (mg)		0.4\nMagnesio (mg)		20\nPotasio (mg)		274\nFosforo (mg)		180\nCinc (mg)		0.4\nSodio (mg)		89\nB9 o Acido folico (mcg)		13\nB12 o cianocobalamina (mcg)		0.53\nVitamina A (mcg)		10\nVitmamina D (mcg)		1.3\nVitmamina E (mg)		0.26'),
(165, 'Bacaladilla', 29, 'Calorias		75.9\nProteinas (g)		17.4\nGrasas (g)		0.7\nHierro (mg)		0.3\nMagnesio (mg)		23\nCinc (mg)		0.4\nYodo (mg)		30\nB1 o tiamina (mg)		0.08\nB2 o riboflavina (mg)		0.07\nB3 o niacina (mg)		4.9\nB9 o Acido folico (mcg)		12\nB12 o cianocobalamina (mcg)		2'),
(166, 'Raya', 29, 'Calorias		79.5\nProteinas (g)		17.1\nGrasas (g)		0.9\nHierro (mg)		1.0\nMagnesio (mg)		24\nPotasio (mg)		270\nSodio (mg)		160\nFosforo (mg)		155\nB2 o riboflavina (mg)		0.15\nB3 o niacina (mg)		5.2\nB6 o piridoxina (mg)		0.37\nB12 o cianocobalamina (mcg)		6\nVitamina A (mcg)		3'),
(167, 'Rape', 29, 'Calorias		86\nProteinas (g)		17\nGrasas (g)		2\nHierro (mg)		1\nMagnesio (mg)		20\nPotasio (mg)		274\nFosforo (mg)		180\nB1 o tiamina (mg)		0.08\nB3 o niacina (mg)		2\nB9 o Acido folico (mcg)		13'),
(168, 'Salmonete', 29, 'Calorias		89.7\nProteinas (g)		14.1\nGrasas (g)		3.7\nG. saturadas (g)		0.96\nG. monoinsaturadas (g)		0.76\nG. poliinsaturadas (g)		0.56\nHierro (mg)		0.7\nMagnesio (mg)		25\nPotasio (mg)		255\nFosforo (mg)		260\nYodo (mg)		190\nB1 (mg)		0.05\nB2 (mg)		0.07\nB3 (mg)		1.9'),
(169, 'Cabracho', 29, 'Calorias		110\nProteinas (g)		18.2\nGrasas (g)		3.6\nG. saturadas (g)		0.7\nG. monoinsaturadas (g)		1.9\nG. poliinsaturadas (g)		1.2\nHierro (mg)		0.7\nMagnesio (mg)		29\nPotasio (mg)		308\nFosforo (mg)		201\nB12 o cianocobalamina (mcg)		3.8\nVitamina A (mcg)		12\nVitmamina D (mcg)		2.3'),
(170, 'Emperador', 29, 'Calorias		110.45\nProteinas (g)		17\nGrasas (g)		4.3\nHierro (mg)		0.9\nMagnesio (mg)		57\nPotasio (mg)		342\nSodio (mg)		102\nFosforo (mg)		506\nB3 o niacina (mg)		9\nB6 o Piridoxina (mg)		0.51\nB9 o Acido folico (mcg)		15\nB12 o cianocobalamina (mcg)		5\nVitamina A (mcg)		500'),
(171, 'Palometa', 29, 'Calorias		125\nProteinas (g)		20\nGrasas (g)		5\nMagnesio (mg)		28\nPotasio (mg)		430\nFosforo (mg)		250\nB3 o niacina (mg)		9\nB12 o cianocobalamina (mcg)		10\nVitamina A (mcg)		36\nVitmamina D (mcg)		16'),
(172, 'Boqueron', 30, 'Calorias		138\nProteinas (g)		20.6\nGrasas (g)		6\nHierro (mg)		1\nMagnesio (mg)		28\nYodo (mg)		20\nB2 o riboflavina (mg)		0.27\nB3 o niacina (mg)		7.6\nB9 o Acido folico (mcg)		8.7\nB12 o cianocobalamina (mcg)		1.9\nVitamina A (mcg)		31.9\nVitmamina D (mcg)		7'),
(173, 'Bonito', 30, 'Calorias		138\nProteinas (g)		21\nGrasas (g)		6\nHierro (mg)		1\nMagnesio (mg)		28\nYodo (mg)		10\nB2 o riboflavina (mg)		0.2\nB3 o niacina (mg)		17.8\nB9 o Acido folico (mcg)		15\nB12 o cianocobalamina (mcg)		5\nVitamina A (mcg)		40\nVitmamina D (mcg)		20'),
(174, 'Caballa', 30, 'Calorias		153\nProteinas (g)		15\nGrasas (g)		10\nHierro (mg)		1\nMagnesio (mg)		31\nSodio (mg)		130\nPotasio (mg)		360\nFosforo (mg)		244\nYodo (mg)		10\nB1 o tiamina (mg)		0.09\nB2 o riboflavina (mg)		0.3\nB3 o niacina (mg)		9\nB6 o piridoxina (mcg)		0.7\nB12 o cianocobalamina (mcg)		10\nVitamina A (mcg)		36\nVitmamina D (mcg)		16\nVitmamina E (mg)		1.25'),
(175, 'Mero', 29, 'Calorias	118\nProteinas (g)	16\nGrasas (g)	6\nG. saturadas (g)	0.92\nG. monoinsaturadas (g)	1.79\nG. poliinsaturadas (g)	2.78\nMagnesio (mg)	20\nPotasio (mg)	255\nFosforo (mg)	210\nB2 o riboflavina (mg)	0.14\nB3 o niacina (mg)	2.3\nB6 o Piridoxina (mg)	0.32\nB9 o Acido folico (mcg)	11\nB12 o cianocobalamina (mcg)	2\nVitamina E (mg)	0.8'),
(176, 'Merluza', 29, 'Proteinas (g) 	11.8\nGrasas (g) 	1.8\nG. saturadas (g) 	0.35\nG. monoinsaturadas (g) 	0.43\nG. poliinsaturadas (g) 	0.46\nHierro (mg) 	1.10\nMagnesio (mg) 	25.1\nPotasio (mg) 	270\nFosforo (mg) 	190\nCinc (mg) 	0.37\nYodo (mg) 	18\nB1 o tiamina (mg) 	0.09\nB2 o riboflavina (mg) 	0.09\nB3 o niacina (mg) 	6.1\nB9 o Acido folico (mcg) 	12.3\nB12 o cianocobalamina (mcg) 	1.10'),
(177, 'Jurel', 30, 'Proteinas (g) 	15.7\nGrasas (g) 	6.8\nHierro (mg) 	1\nMagnesio (mg) 	31\nYodo (mg) 	10\nB1 o tiamina (mg) 	0.09\nB2 o riboflavina (mg) 	0.3\nB3 o niacina (mg) 	9\nB12 o cianocobalamina (mcg) 	10\nVitamina A (mcg) 	36\nVitmamina D (mcg) 	16'),
(178, 'Dorada', 30, 'Proteinas (g) 	17\nGrasas (g) 	2.7\nG. saturadas (g) 	0.5\nG. monoinsaturadas (g) 	0.8\nG. poliinsaturadas (g) 	0.5\nHierro (mg) 	0.9\nMagnesio (mg) 	25\nPotasio (mg) 	300\nFosforo (mg) 	180\nB3 o niacina (mg) 	5\nB12 o cianocobalamina (mcg) 	2\nVitamina A (mcg) 	9\nVitmamina E (mg) 	1.25'),
(179, 'Perca', 29, 'Proteinas (g) 	18.4\nGrasas (g) 	0.8\nHierro (mg) 	1\nPotasio (mg) 	330\nFosforo (mg) 	198\nMagnesio (mg) 	20\nB1 o Tiamina (mg) 	0.08\nB2 o Riboflavina (mg) 	0.12\nB3 o Niacina (mg) 	1.74\nVitamina A (mcg) 	7'),
(180, 'Bagre', 30, 'Valor calorico 	144 kcal 603 kJ\nGrasas 	7.2 g\nGrasas saturadas 	1.6 g\nGrasas monoinsaturadas 	3.1 g\nGrasas poliinsaturadas 	1.4 g\nCarbohidratos 	0.0 g\nAzucares 	0.0 g\nProteinas 	18.4 g\nFibra alimentaria 	0.0 g\nColesterol 	66.0 mg\nSodio 	0.1 g\nAgua 	74.7 g'),
(181, 'Arenques', 30, 'Valor calorico 	217 kcal 909 kJ\nGrasas 	12.4 g\nGrasas saturadas 	2.8 g\nGrasas monoinsaturadas 	5.1 g\nGrasas poliinsaturadas 	2.9 g\nCarbohidratos 	0.0 g\nAzucares 	0.0 g\nProteinas 	24.6 g\nFibra alimentaria 	0.0 g\nColesterol 	82.0 mg\nSodio 	0.9 g\nAgua 	59.7 g');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ingredientes_categorias`
--

CREATE TABLE IF NOT EXISTS `ingredientes_categorias` (
  `id` int(11) NOT NULL,
  `nombre` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `ingredientes_categorias`
--

INSERT INTO `ingredientes_categorias` (`id`, `nombre`) VALUES
(1, 'Carne'),
(2, 'Fruta'),
(3, 'Hortaliza'),
(4, 'Legumbre'),
(5, 'Marisco'),
(6, 'Pasta'),
(7, 'Pescado');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ingredientes_tipos`
--

CREATE TABLE IF NOT EXISTS `ingredientes_tipos` (
  `id` int(11) NOT NULL,
  `nombre` varchar(30) NOT NULL,
  `categoria` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `ingredientes_tipos`
--

INSERT INTO `ingredientes_tipos` (`id`, `nombre`, `categoria`) VALUES
(1, 'Carne Roja', 1),
(2, 'Carne Blanca', 1),
(3, 'Cucurbitaceas', 2),
(4, 'Bayas', 2),
(5, 'Citricos', 2),
(6, 'Frutas Dulces', 2),
(7, 'Exotica', 2),
(8, 'Frutos Secos', 2),
(9, 'Drupaceo', 2),
(10, 'Falsa Baya', 2),
(11, 'Brasicaceas', 3),
(12, 'Compuestas', 3),
(13, 'Solanaceas', 3),
(14, 'Hojas Verdes', 3),
(15, 'Hongos', 3),
(16, 'Liliaceas', 3),
(17, 'Fabaceas', 3),
(18, 'Cucurbitaceas', 3),
(19, 'Umbeliferas', 3),
(20, 'Quenopodiaceas', 3),
(21, 'Gramineas', 3),
(22, 'Grano', 4),
(23, 'Oleaginosas', 4),
(24, 'Moluscos', 5),
(25, 'Crustaceos', 5),
(26, 'Pasta rellena', 6),
(27, 'Pasta corta', 6),
(28, 'Pasta larga', 6),
(29, 'Pescado Blanco', 7),
(30, 'Pescado Azul', 7);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `lineas_pedido`
--

CREATE TABLE IF NOT EXISTS `lineas_pedido` (
  `id` int(11) NOT NULL,
  `id_pedido` int(11) NOT NULL,
  `id_plato` int(11) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `total` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `lineas_pedido`
--

INSERT INTO `lineas_pedido` (`id`, `id_pedido`, `id_plato`, `cantidad`, `total`) VALUES
(0, 0, 0, 3, 12.75),
(1, 0, 1, 1, 2.25);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `logs`
--

CREATE TABLE IF NOT EXISTS `logs` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `idUsuario` int(11) NOT NULL,
  `fechaInicio` datetime NOT NULL,
  `fechaFin` datetime NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=145 ;

--
-- Volcado de datos para la tabla `logs`
--

INSERT INTO `logs` (`id`, `idUsuario`, `fechaInicio`, `fechaFin`) VALUES
(46, 8, '2017-02-01 17:17:47', '2017-02-02 17:17:48'),
(54, 5, '2017-03-10 17:28:32', '2017-03-10 17:29:11'),
(55, 5, '2017-03-10 17:30:00', '2017-03-10 17:30:15'),
(56, 5, '2017-03-10 18:02:37', '2017-03-10 18:02:46'),
(57, 5, '2017-03-10 18:04:08', '2017-03-10 18:04:19'),
(58, 5, '2017-03-10 18:05:09', '2017-03-10 18:05:58'),
(59, 5, '2017-03-10 18:06:47', '2017-03-10 18:07:08'),
(60, 5, '2017-03-10 18:09:24', '2017-03-10 18:09:35'),
(61, 5, '2017-03-10 18:09:42', '2017-03-10 18:10:01'),
(62, 5, '2017-03-25 11:00:47', '2017-03-25 11:01:23'),
(63, 8, '2017-02-01 17:17:47', '2017-03-25 11:21:35'),
(64, 5, '2017-03-25 11:25:28', '2017-03-25 11:25:51'),
(65, 5, '2017-03-25 11:27:09', '2017-03-25 11:27:37'),
(66, 5, '2017-03-25 11:28:01', '2017-03-25 11:28:24'),
(67, 5, '2017-03-25 11:29:50', '2017-03-25 11:30:06'),
(68, 5, '2017-03-25 11:31:07', '2017-03-25 11:31:40'),
(69, 9, '2017-03-25 11:32:40', '2017-03-25 11:32:56'),
(70, 8, '2017-02-01 17:17:47', '2017-03-25 11:36:45'),
(71, 5, '2017-03-25 11:39:19', '2017-03-25 11:39:27'),
(72, 5, '2017-03-25 11:42:31', '2017-03-25 11:42:45'),
(73, 5, '2017-03-25 11:45:16', '2017-03-25 11:45:35'),
(74, 5, '2017-03-25 11:57:45', '2017-03-25 11:58:04'),
(75, 5, '2017-03-25 11:58:32', '2017-03-25 11:58:56'),
(76, 5, '2017-03-25 11:59:20', '2017-03-25 11:59:37'),
(77, 9, '2017-03-25 12:00:15', '2017-03-25 12:00:23'),
(78, 8, '2017-02-01 17:17:47', '2017-03-25 12:04:51'),
(79, 9, '2017-03-25 12:05:56', '2017-03-25 12:06:04'),
(80, 9, '2017-03-25 12:06:53', '2017-03-25 12:06:56'),
(81, 5, '2017-03-25 12:09:48', '2017-03-25 12:09:54'),
(82, 9, '2017-03-25 12:11:29', '2017-03-25 12:11:47'),
(83, 5, '2017-03-25 12:20:32', '2017-03-25 12:20:44'),
(84, 9, '2017-03-25 12:40:48', '2017-03-25 12:40:51'),
(85, 9, '2017-03-25 12:58:19', '2017-03-25 12:58:36'),
(86, 5, '2017-03-26 21:55:21', '2017-03-26 21:55:31'),
(87, 8, '2017-02-01 17:17:47', '2017-03-26 21:57:39'),
(88, 9, '2017-03-26 21:59:57', '2017-03-26 22:00:05'),
(89, 5, '2017-03-26 22:12:17', '2017-03-26 22:12:19'),
(90, 9, '2017-03-26 22:12:25', '2017-03-26 22:12:27'),
(91, 9, '2017-03-26 22:13:01', '2017-03-26 22:13:06'),
(92, 5, '2017-03-26 22:13:18', '2017-03-26 22:13:47'),
(93, 5, '2017-03-26 22:14:26', '2017-03-26 22:14:34'),
(94, 5, '2017-03-26 22:19:18', '2017-03-26 22:19:24'),
(95, 5, '2017-03-26 22:19:36', '2017-03-26 22:19:42'),
(96, 5, '2017-03-26 22:20:12', '2017-03-26 22:20:21'),
(97, 5, '2017-03-26 22:21:39', '2017-03-26 22:21:47'),
(98, 5, '2017-03-26 22:22:36', '2017-03-26 22:22:45'),
(99, 5, '2017-03-26 22:23:18', '2017-03-26 22:23:25'),
(100, 5, '2017-03-26 22:24:21', '2017-03-26 22:24:31'),
(101, 5, '2017-03-26 22:34:05', '2017-03-26 22:34:30'),
(102, 11, '2017-03-26 22:34:54', '2017-03-26 22:34:59'),
(103, 8, '2017-02-01 17:17:47', '2017-03-26 22:39:10'),
(104, 5, '2017-03-26 22:41:54', '2017-03-26 22:42:26'),
(105, 5, '2017-03-26 22:42:42', '2017-03-26 22:42:51'),
(106, 11, '2017-03-26 22:52:31', '2017-03-26 22:52:35'),
(107, 8, '2017-02-01 17:17:47', '2017-03-26 22:56:32'),
(108, 5, '2017-03-26 23:55:37', '2017-03-26 23:55:41'),
(109, 9, '2017-06-11 18:35:11', '2017-06-11 18:35:56'),
(110, 9, '2017-06-11 18:50:28', '2017-06-11 18:50:40'),
(111, 9, '2017-06-11 18:51:35', '2017-06-11 18:51:52'),
(112, 9, '2017-06-17 19:27:16', '2017-06-17 19:27:34'),
(113, 9, '2017-06-17 19:36:09', '2017-06-17 19:36:21'),
(114, 9, '2017-06-17 19:38:12', '2017-06-17 19:38:24'),
(115, 9, '2017-06-17 19:39:39', '2017-06-17 19:39:50'),
(116, 9, '2017-06-17 19:40:09', '2017-06-17 19:40:26'),
(117, 9, '2017-06-17 19:44:31', '2017-06-17 19:45:12'),
(118, 9, '2017-06-17 19:47:23', '2017-06-17 19:48:19'),
(119, 8, '2017-02-01 17:17:47', '2017-06-18 12:21:34'),
(120, 9, '2017-06-18 12:21:46', '2017-06-18 12:22:03'),
(121, 8, '2017-02-01 17:17:47', '2017-06-18 12:31:12'),
(122, 9, '2017-06-18 12:31:56', '2017-06-18 12:32:17'),
(123, 9, '2017-06-18 12:32:33', '2017-06-18 12:33:03'),
(124, 9, '2017-06-18 12:34:25', '2017-06-18 12:34:35'),
(125, 9, '2017-06-18 12:35:05', '2017-06-18 12:35:09'),
(126, 9, '2017-06-18 12:35:20', '2017-06-18 12:35:34'),
(127, 8, '2017-02-01 17:17:47', '2017-06-18 12:52:24'),
(128, 9, '2017-06-18 12:56:26', '2017-06-18 12:56:59'),
(129, 9, '2017-06-18 12:58:05', '2017-06-18 12:59:03'),
(130, 9, '2017-06-18 13:01:50', '2017-06-18 13:02:17'),
(131, 9, '2017-06-18 13:02:54', '2017-06-18 13:05:40'),
(132, 9, '2017-06-18 18:11:07', '2017-06-18 18:11:26'),
(133, 9, '2017-06-18 18:12:48', '2017-06-18 18:13:45'),
(134, 9, '2017-06-18 18:34:50', '2017-06-18 18:34:54'),
(135, 9, '2017-06-18 18:35:36', '2017-06-18 18:36:09'),
(136, 9, '2017-06-18 18:36:39', '2017-06-18 18:36:50'),
(137, 9, '2017-06-18 18:50:41', '2017-06-18 18:50:55'),
(138, 9, '2017-06-18 18:57:29', '2017-06-18 18:57:47'),
(139, 9, '2017-06-18 18:58:20', '2017-06-18 18:58:48'),
(140, 9, '2017-06-18 19:06:26', '2017-06-18 19:07:20'),
(141, 9, '2017-06-18 19:07:40', '2017-06-18 19:08:34'),
(142, 9, '2017-06-18 19:09:21', '2017-06-18 19:09:35'),
(143, 9, '2017-06-18 19:48:37', '2017-06-18 19:49:38'),
(144, 9, '2017-06-20 19:50:22', '2017-06-20 19:50:40');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pedidos`
--

CREATE TABLE IF NOT EXISTS `pedidos` (
  `id` int(11) NOT NULL,
  `fecha` date NOT NULL,
  `mesa` int(11) NOT NULL,
  `id_empleado` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `pedidos`
--

INSERT INTO `pedidos` (`id`, `fecha`, `mesa`, `id_empleado`) VALUES
(0, '2017-06-21', 1, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `permisos`
--

CREATE TABLE IF NOT EXISTS `permisos` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `idUsuario` int(11) NOT NULL,
  `tipo` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=15 ;

--
-- Volcado de datos para la tabla `permisos`
--

INSERT INTO `permisos` (`id`, `idUsuario`, `tipo`) VALUES
(1, 5, 1),
(2, 5, 2),
(3, 5, 3),
(4, 5, 4),
(5, 5, 5),
(11, 11, 1),
(12, 11, 2),
(13, 11, 3),
(14, 11, 4);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `platos`
--

CREATE TABLE IF NOT EXISTS `platos` (
  `id` int(11) NOT NULL,
  `nombre` varchar(255) NOT NULL,
  `descripcion` varchar(255) NOT NULL,
  `esbebida` int(11) NOT NULL,
  `precio` double NOT NULL,
  `tipo` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `platos`
--

INSERT INTO `platos` (`id`, `nombre`, `descripcion`, `esbebida`, `precio`, `tipo`) VALUES
(0, 'prueba3', 'assdf', 0, 4.25, 1),
(1, 'ahorasoybebida', 'cambio la descriupcion y la bebida', 1, 2.25, 5);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `platos_ingredientes`
--

CREATE TABLE IF NOT EXISTS `platos_ingredientes` (
  `id_plato` int(11) NOT NULL,
  `id_ingrediente` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `platos_ingredientes`
--

INSERT INTO `platos_ingredientes` (`id_plato`, `id_ingrediente`) VALUES
(0, 1),
(1, 1),
(1, 4),
(1, 6);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE IF NOT EXISTS `usuarios` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `usuario` varchar(255) NOT NULL,
  `clave` varchar(255) NOT NULL,
  `tipo` int(11) NOT NULL,
  `email` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=12 ;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`id`, `usuario`, `clave`, `tipo`, `email`) VALUES
(5, 'eva', 'fernandez', 2, 'eva@fernandez.com'),
(9, 'pablo', 'asdf', 1, 'deluisp@gmail.com'),
(10, 'adrian', 'lopez', 0, 'asdf@asdf.com'),
(11, 'prueba', 'pruebita', 2, 'prueba@prueba.com');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

-- phpMyAdmin SQL Dump
-- version 3.5.1
-- http://www.phpmyadmin.net
--
-- Servidor: localhost
-- Tiempo de generación: 08-05-2017 a las 17:54:26
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
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=109 ;

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
(108, 5, '2017-03-26 23:55:37', '2017-03-26 23:55:41');

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

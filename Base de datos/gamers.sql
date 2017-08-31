-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 31-08-2017 a las 05:00:43
-- Versión del servidor: 5.7.15-log
-- Versión de PHP: 7.0.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `gamers`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente`
--

CREATE TABLE `cliente` (
  `idCliente` int(11) NOT NULL,
  `cNombre` varchar(45) NOT NULL,
  `cApellido` varchar(45) NOT NULL,
  `cDireccion` varchar(45) DEFAULT NULL,
  `cFechaNac` date NOT NULL,
  `cEmail` varchar(45) DEFAULT NULL,
  `cTel` varchar(45) DEFAULT NULL,
  `cRFC` varchar(45) DEFAULT NULL,
  `cDomFiscal` varchar(45) DEFAULT NULL,
  `cRazonSocial` varchar(45) DEFAULT NULL,
  `cCP` varchar(45) DEFAULT NULL,
  `cPais` varchar(45) DEFAULT NULL,
  `cEstado` varchar(45) DEFAULT NULL,
  `cMunicipio` varchar(45) DEFAULT NULL,
  `cSaldo` float NOT NULL,
  `cDisponible` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `cliente`
--

INSERT INTO `cliente` (`idCliente`, `cNombre`, `cApellido`, `cDireccion`, `cFechaNac`, `cEmail`, `cTel`, `cRFC`, `cDomFiscal`, `cRazonSocial`, `cCP`, `cPais`, `cEstado`, `cMunicipio`, `cSaldo`, `cDisponible`) VALUES
(1, 'Dahlia', 'Hawthrone', 'Solares 120-45', '1993-12-01', 'Dahlia@gmail.com', '3350643210', 'A12D45RFW3', 'Solares 120-45', 'Dahlia Hawthrone', '45135', 'México', 'Jalisco', 'Zapopan', 1046.8, 1),
(2, 'Angel', 'Hernández', 'Santa Esther 201', '2001-03-09', 'omega05@outlook.com', '3320204312', 'AH453DFDCGDF', '', '', '45134', 'México', 'Jalisco', 'Guadalajara', 0, 1),
(3, 'Miguel', 'Estrada', 'Tabachines 1004', '1990-01-20', 'Miguel_Estrada@outlook.com', '3320104319', 'ME493DFDC9DF', 'Revolución 200', 'Miguel Estrada', '46202', 'México', 'Jalisco', 'Guadalajara', 349.3, 1),
(4, 'Monica', 'Zepeda', 'Santa Margarita 900', '1996-12-29', 'MonyZ@gmail.com', '3320201010', 'GTHFNDJAJW', 'Calle Banderas 190', 'Azura SA de CV', '45130', 'México', 'Jalisco', 'Zapopan', 0, 1),
(5, 'Pablo', 'Rodriguez', 'Ramón corona 4522', '1992-10-10', 'PR92@hotmail.com', '3311345490', '', '', '', '45135', 'México', 'Jalisco', 'Zapopan', 0, 1),
(6, 'Jaqueline', 'Pérez', 'Rio nilo 100', '1994-05-05', 'Jaque_PRTG@gmail.com', '5513905423', 'JP943DFDAFDH', 'Av. Guadalupe 2340', 'Empresa SA de CV', '45128', 'México', 'Tlaquepaque', 'Guadalajara', 0, 1),
(7, 'Irvin', 'Bravo', 'Casa 1', '1990-01-02', 'irvin@hotmail.com', '3312345678', 'AGFHTBR6059', 'Casa 2', 'Empresa SA de CV', '10345', 'México', 'Jalisco', 'Tonalá', 0, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detallefactura`
--

CREATE TABLE `detallefactura` (
  `Venta_idVenta` int(11) NOT NULL,
  `Factura_idFactura` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalleventa`
--

CREATE TABLE `detalleventa` (
  `Producto_idProducto` int(11) NOT NULL,
  `Venta_idVenta` int(11) NOT NULL,
  `Cantidad` int(11) DEFAULT NULL,
  `Precio` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `detalleventa`
--

INSERT INTO `detalleventa` (`Producto_idProducto`, `Venta_idVenta`, `Cantidad`, `Precio`) VALUES
(1, 1, 1, 1399),
(1, 3, 1, 1399),
(1, 11, 3, 1399),
(1, 12, 1, 1399),
(1, 14, 1, 1399),
(2, 2, 2, 999),
(2, 4, 3, 999),
(2, 7, 2, 999),
(2, 13, 1, 499.5),
(3, 11, 6, 999),
(3, 12, 1, 999),
(4, 8, 1, 249.5),
(4, 10, 1, 499),
(4, 13, 5, 249.5),
(5, 9, 1, 6800),
(13, 10, 4, 1199);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empleado`
--

CREATE TABLE `empleado` (
  `idEmpleado` int(11) NOT NULL,
  `eNombre` varchar(45) NOT NULL,
  `eApellido` varchar(45) NOT NULL,
  `ePuesto` varchar(45) NOT NULL,
  `eContrasena` varchar(45) NOT NULL,
  `eStatus` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `empleado`
--

INSERT INTO `empleado` (`idEmpleado`, `eNombre`, `eApellido`, `ePuesto`, `eContrasena`, `eStatus`) VALUES
(1, 'Daniel', 'Hernández', 'Gerente', 'abc', 1),
(2, 'Edgar', 'Casillas', 'Cajero', '123', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `factura`
--

CREATE TABLE `factura` (
  `idFactura` int(11) NOT NULL,
  `fFecha` datetime NOT NULL,
  `fDisponible` tinyint(1) NOT NULL,
  `venta_idVenta` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `factura`
--

INSERT INTO `factura` (`idFactura`, `fFecha`, `fDisponible`, `venta_idVenta`) VALUES
(1, '2016-11-16 22:06:54', 0, 1),
(2, '2016-11-20 03:40:35', 1, 7),
(3, '2016-11-20 03:44:40', 1, 6),
(4, '2016-11-20 03:55:29', 1, 3),
(5, '2016-11-20 03:55:36', 1, 7),
(6, '2016-11-20 03:58:55', 1, 4),
(7, '2016-11-23 07:40:36', 1, 12);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `producto`
--

CREATE TABLE `producto` (
  `idProducto` int(11) NOT NULL,
  `pNombre` varchar(80) NOT NULL,
  `pTipo` varchar(45) NOT NULL,
  `pConsola` varchar(45) NOT NULL,
  `pGenero` varchar(45) NOT NULL,
  `pStatus` varchar(45) NOT NULL,
  `pPrecio` float NOT NULL,
  `pStock` int(11) NOT NULL,
  `pFoto` varchar(255) DEFAULT 'hi',
  `pDisponible` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `producto`
--

INSERT INTO `producto` (`idProducto`, `pNombre`, `pTipo`, `pConsola`, `pGenero`, `pStatus`, `pPrecio`, `pStock`, `pFoto`, `pDisponible`) VALUES
(1, 'Watch Dogs 2', 'Videojuegos', 'Playstation', 'Accion', 'Nuevo', 1399, 2, 'C:\\Users\\kyo_9\\Documents\\GitHub\\Gamers\\Fotos Productos\\WatchDogs2.jpg', 1),
(2, 'Watch Dogs 2', 'Videojuegos', 'Playstation', 'Accion', 'Seminuevo', 999, 7, 'C:\\Users\\kyo_9\\Documents\\GitHub\\Gamers\\Fotos Productos\\WatchDogs2.jpg', 1),
(3, 'Assassins Creed Black Flag', 'Videojuegos', 'Xbox', 'Accion', 'Nuevo', 999, 9, 'C:\\Users\\kyo_9\\Documents\\GitHub\\Gamers\\Fotos Productos\\AssassinsCreedBF.jpg', 1),
(4, 'Assassins Creed Black Flag', 'Videojuegos', 'Xbox', 'Accion', 'Seminuevo', 499, 10, 'C:\\Users\\kyo_9\\Documents\\GitHub\\Gamers\\Fotos Productos\\AssassinsCreedBF.jpg', 1),
(5, 'Playstation 4 PRO', 'Consolas', 'Playstation', 'Otro', 'Nuevo', 6800, 5, 'C:\\Users\\kyo_9\\Documents\\GitHub\\Gamers\\Fotos Productos\\Ps4Pro.jpg', 1),
(6, 'Playstation 4 Controller', 'Accesorios', 'Playstation', 'Otro', 'Nuevo', 999, 10, 'C:\\Users\\kyo_9\\Documents\\GitHub\\Gamers\\Fotos Productos\\ControlPs4.jpg', 1),
(7, 'Xbox One', 'Consolas', 'Xbox', 'Otro', 'Nuevo', 5999, 5, 'C:\\Users\\kyo_9\\Documents\\GitHub\\Gamers\\Fotos Productos\\XboxSlim.jpg', 1),
(8, 'Grand Theft Auto V', 'Videojuegos', 'Playstation', 'Accion', 'Nuevo', 1399, 4, 'C:\\Users\\kyo_9\\Documents\\GitHub\\Gamers\\Fotos Productos\\GTAV.jpg', 1),
(9, 'Grand Theft Auto V', 'Videojuegos', 'Playstation', 'Accion', 'Seminuevo', 999, 10, 'C:\\Users\\kyo_9\\Documents\\GitHub\\Gamers\\Fotos Productos\\GTAV.jpg', 1),
(10, 'Mario Party 10', 'Videojuegos', 'Nintendo', 'Plataforma', 'Nuevo', 1399, 9, 'C:\\Users\\kyo_9\\Documents\\GitHub\\Gamers\\Fotos Productos\\MarioParty10.jpg', 1),
(11, 'Mario Party 10', 'Videojuegos', 'Nintendo', 'Plataforma', 'Seminuevo', 999, 0, 'C:\\Users\\kyo_9\\Documents\\GitHub\\Gamers\\Fotos Productos\\MarioParty10.jpg', 1),
(12, 'Dark Souls III', 'Videojuegos', 'Playstation', 'RPG', 'Nuevo', 1399, 0, 'C:\\Users\\kyo_9\\Documents\\GitHub\\Gamers\\Fotos Productos\\DarkSoulsIII.jpg', 1),
(13, 'Mario Kart 8', 'Videojuegos', 'Nintendo', 'Carreras', 'Nuevo', 1199, 1, 'C:\\Users\\kyo_9\\Documents\\GitHub\\Gamers\\Fotos Productos\\MarioKart8.jpg', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `venta`
--

CREATE TABLE `venta` (
  `idVenta` int(11) NOT NULL,
  `vFecha` datetime NOT NULL,
  `vTipoPago` varchar(45) NOT NULL,
  `VC` varchar(45) NOT NULL,
  `vDisponible` tinyint(1) NOT NULL,
  `vSaldo` float NOT NULL DEFAULT '0',
  `Empleado_idEmpleado` int(11) NOT NULL,
  `Cliente_idCliente` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `venta`
--

INSERT INTO `venta` (`idVenta`, `vFecha`, `vTipoPago`, `VC`, `vDisponible`, `vSaldo`, `Empleado_idEmpleado`, `Cliente_idCliente`) VALUES
(1, '2016-11-16 21:58:36', 'Efectivo', 'V', 1, 0, 1, 2),
(2, '2016-11-17 23:55:18', 'Efectivo', 'V', 0, 0, 1, 4),
(3, '2016-11-18 00:32:55', 'Tarjeta', 'V', 1, 0, 1, 2),
(4, '2016-11-20 02:38:55', 'Efectivo', 'V', 1, 0, 1, 4),
(6, '2016-11-20 02:48:48', 'Efectivo', 'V', 1, 0, 1, 3),
(7, '2016-11-20 02:56:23', 'Efectivo', 'V', 1, 699.3, 1, 2),
(8, '2016-11-20 03:31:15', 'Electrónico', 'C', 1, 0, 1, 3),
(9, '2016-11-22 18:10:51', 'Electrónico', 'V', 0, 699.3, 1, 2),
(10, '2016-11-23 07:28:21', 'Efectivo', 'V', 1, 0, 1, 5),
(11, '2016-11-23 07:36:29', 'Efectivo', 'V', 0, 0, 1, 1),
(12, '2016-11-23 07:39:44', 'Tarjeta', 'V', 1, 0, 1, 1),
(13, '2016-11-23 07:41:59', 'Electrónico', 'C', 1, 0, 1, 1),
(14, '2016-11-23 07:43:15', 'Electrónico', 'V', 1, 2445.8, 1, 1);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`idCliente`);

--
-- Indices de la tabla `detallefactura`
--
ALTER TABLE `detallefactura`
  ADD PRIMARY KEY (`Venta_idVenta`,`Factura_idFactura`),
  ADD KEY `fk_Venta_has_Factura_Factura1_idx` (`Factura_idFactura`),
  ADD KEY `fk_Venta_has_Factura_Venta1_idx` (`Venta_idVenta`);

--
-- Indices de la tabla `detalleventa`
--
ALTER TABLE `detalleventa`
  ADD PRIMARY KEY (`Producto_idProducto`,`Venta_idVenta`),
  ADD KEY `fk_Producto_has_Venta_Venta1_idx` (`Venta_idVenta`),
  ADD KEY `fk_Producto_has_Venta_Producto1_idx` (`Producto_idProducto`);

--
-- Indices de la tabla `empleado`
--
ALTER TABLE `empleado`
  ADD PRIMARY KEY (`idEmpleado`);

--
-- Indices de la tabla `factura`
--
ALTER TABLE `factura`
  ADD PRIMARY KEY (`idFactura`,`venta_idVenta`),
  ADD KEY `fk_factura_venta1_idx` (`venta_idVenta`);

--
-- Indices de la tabla `producto`
--
ALTER TABLE `producto`
  ADD PRIMARY KEY (`idProducto`);

--
-- Indices de la tabla `venta`
--
ALTER TABLE `venta`
  ADD PRIMARY KEY (`idVenta`),
  ADD KEY `fk_Venta_Empleado_idx` (`Empleado_idEmpleado`),
  ADD KEY `fk_Venta_Cliente1_idx` (`Cliente_idCliente`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `cliente`
--
ALTER TABLE `cliente`
  MODIFY `idCliente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT de la tabla `empleado`
--
ALTER TABLE `empleado`
  MODIFY `idEmpleado` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `factura`
--
ALTER TABLE `factura`
  MODIFY `idFactura` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT de la tabla `producto`
--
ALTER TABLE `producto`
  MODIFY `idProducto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;
--
-- AUTO_INCREMENT de la tabla `venta`
--
ALTER TABLE `venta`
  MODIFY `idVenta` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;
--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `detallefactura`
--
ALTER TABLE `detallefactura`
  ADD CONSTRAINT `fk_Venta_has_Factura_Factura1` FOREIGN KEY (`Factura_idFactura`) REFERENCES `factura` (`idFactura`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Venta_has_Factura_Venta1` FOREIGN KEY (`Venta_idVenta`) REFERENCES `venta` (`idVenta`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `detalleventa`
--
ALTER TABLE `detalleventa`
  ADD CONSTRAINT `fk_Producto_has_Venta_Producto1` FOREIGN KEY (`Producto_idProducto`) REFERENCES `producto` (`idProducto`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Producto_has_Venta_Venta1` FOREIGN KEY (`Venta_idVenta`) REFERENCES `venta` (`idVenta`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `factura`
--
ALTER TABLE `factura`
  ADD CONSTRAINT `fk_factura_venta1` FOREIGN KEY (`venta_idVenta`) REFERENCES `venta` (`idVenta`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `venta`
--
ALTER TABLE `venta`
  ADD CONSTRAINT `fk_Venta_Cliente1` FOREIGN KEY (`Cliente_idCliente`) REFERENCES `cliente` (`idCliente`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Venta_Empleado` FOREIGN KEY (`Empleado_idEmpleado`) REFERENCES `empleado` (`idEmpleado`) ON DELETE NO ACTION ON UPDATE NO ACTION;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

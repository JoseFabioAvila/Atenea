<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainView.aspx.cs" Inherits="Atenea.mainView" %>

<head>
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	<title>Index</title>
    <style>
		body {
			font-family:"Times New Roman", Times, serif;
			font-size:12px;
			background: url(Fondo-cameron-texturas-escos%C3%A9s3.jpg) center;
		}
		.cuerpoPrin{
			margin:0 auto; /* para ordenar en altura a partir de la linea 0 y automaticamente en ancho*/
			width: 900px;
			background:#FFFFCC;
		}
		.encabezado{
			height: 150px;
		}
		.cuerpo{
			height: 750px;
		}
		.piePagina{
			height: 150px;
		}
		.menu{
			padding-top: 55px;
			width: 699px;
			float: left;
		}
		.opMenu-1{
			width: 25%;
			height: 30px;
			padding-top: 5px;
			background:#996633;
			color:#000000;
			font-size:18px;
			float:left;
			text-align:center;
		}
		.opMenu-1 a, a:active {
		color:#000;
		text-decoration: none;
		}
		.opMenu-1 a:visited {
		color:#FFF;
		text-decoration: none;
		}
		.opMenu-1 a:hover {
		color:#FFF;
		background: #000;
		text-decoration:none;
		}
	.style1 {font-size: 36px}
    </style>
</head>

    <body>
        <div id="cuerpoPrin" class=" cuerpoPrin">
            <div id="encabezado" class="encabezado"> 
                <div id="menu" class="menu">
                    <div id="manu-1">
                    <div id="op1" class="opMenu-1">
                        <a>Ventana1</a> </div>
                    <div id="op2" class="opMenu-1">
                        <a>Ventana2</a></div>
                    <div id="op3" class="opMenu-1"> 
                        <a>Ventana3</a></div>
                    <div id="op4" class="opMenu-1">
                        <a>Ventana4</a></div>
                    </div>
                </div>
            </div>
  
            <div id="cuerpo" class="cuerpo">
                <h1>Cuerpo</h1>
            </div>
    
            <div id="piePagina" class="piePagina">
                <h1>Pie de Pagina</h1>
            </div>
        </div>
    </body>
</html>

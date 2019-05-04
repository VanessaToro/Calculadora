# Calculadora
Prueba técnica Calculadora (DITECH)

PROYECTO TESTCALCULATOR
========================

Descripción del proyecto
-------------------------
Es un proyecto de Calculadora básica, creado en Visual Studio 2015, implementando modelo MVC, se utilizo tambien
un servicio API,donde se realizan las operaciones matematicas en metodos idividuales 
(suma, resta, multiplicación, división y raíz cuadrada).

Contiene un archivo javascript, desde cual se comunica el formulario web con el servicio API, este archivo js tambien
contiene algunas validaciones como campos sin diligenciar.

Se realiza un metodo para guardar la trazabilidad de los procesos ejecutados en la calculadora, el cual genera
un archivo txt ubicado en el disco "D" bajo el nombre Calculator, (este contiene un JSON con la información correspondiente).

Se creo un archivo de recursos (basico), para administrar las las excepciones.



Pruebas Unitarias
---------------------
Se creo un segundo proyecto para pruebas unitarias (básicas) de cada uno de los metodos de calculos que se especifican
en el controlador.

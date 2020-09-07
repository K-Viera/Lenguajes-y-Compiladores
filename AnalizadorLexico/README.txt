El analizador lexico es un programas capaz de identificar cadenas de caracteres y clasificar los mismos segun una tabla
previamente creada.


funcionamiento:

el archivo txt se encuentra en AnalizadorLexico/bin/Debug/netcoreapp3.1

TablaSimbolos:Se puede agregar los simbolos y el tipo del mismo, por defecto los simbolos inicio de texto y fin de texto
son separadores, son los unidos obligatorios, el resto se pueden definir a gusto.

IngresarTexto:las cadenas de caracteres es ingresada por medio de un archivo .txt el cual lo ingresa en un matriz,
la cual permite el analisis 1 a 1.

Analizador:su funcionamiento se separa en 2 partes, primero verifica que exista un primer separador y guarda su ubicacion, luego verifica
el segundo, en caso de no existir recorre caracter por caracter hasta encontrarlo y guardar su ubicacion, esta busqueda
la realiza siguendo varias condiciones para el funcionamiento del mismo (mirar el archivo condiciones para mas informacion).

una vez se tiene el primer y segundo separador y su respectiva ubicacion se analiza la cadena contenida dentro de este intervalo,
se analiza si inicia por algun caracter no permitido y si corresponde a algun simbolo ya creado dentro de la tabla,
si aun asi no identifica una, lo asigna por defecto como identificador.


Pd: el programa esta desorganizado y tiene partes que se pueden realizar mucho mas eficientemente, eso sucede ya que a medida
que desarrollaba el programa identificaba nuevas condiciones que habia que tener en cuenta a la hora de hacer en analisis
y agregaba de manera que pudiera sin tener en cuenta la organizacion del mismo.

Existen metodos los cuales ihiben ciertos funcionamientos, como crear un nuevo tipo, pero que ya exista en la lista de tipos,
pero no hay ningun tipo de excepcion que identifique las mismas ya que no sabia como manejar las excepciones en c#
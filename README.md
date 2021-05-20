# AppAduanas-VisualStudio-WindowsForms

Se trata de generar un listado de elementos para luego cargar en Excel.
El problema es el siguiente:

- Se debe escribir la cabecera con los datos:   
CENTRO,AÑO,FACTURA,MEDIO,PTO DESCARGA,DESTINO,Nº LOTE,Nº REMOLQUE,CHASIS

- El listado tiene 2 opciones, Carretera o Tren (Radiobuttons)
- Debe indicar el puerto de descarga (Desplegable combobox con los puertos disponibles)
- Debe tener una caja de texto donde indicar el nº del tren (string)
- Debe poder seleccionarse la ciudad que se quiera en cualquier momento y en dicha ciudad se indicará el número de registros que deben crearse así como el lote del cual partir.
- En opción CARRETERA:
  - Deben hacerse bloques de 8 y 9 de forma consecutiva con sus matrículas de remolques correspondientes y estas deben ser siempre distintas
  - Para SUIZA y JAPON no deben generarse matrículas en los remolques aunque los bloques que deben hacerse son de 7. Se debe quedar planificado a futuro
  - Si se tienen suficientes elementos para crear un bloque de 9, este debe crearse, no debe crearse un bloque de 8 y otro de 1 unidad.
  
- En opción TREN:
  - En esta opción todos los elementos llevarán como matrícula de remolque el número del tren, para todos los elementos.

- Deben sacarse avisos para las validaciones de los campos, todos son obligatorios. Si una ciudad se indica, deben indicarse todos los elementos.

- OTROS:
  - Se generan avisos para indicar la creación del fichero y para la continuación de la escritura de este si existiera
  - Los ficheros se crean con la nomenclatura "Listado_fechadeldía" la fecha del día en formato dd-mm-yyyy
  - Se crea el fichero como .TXT listo para cargar en excel, con todos los elementos separados por comas.

![App Aduanas 1](https://user-images.githubusercontent.com/56634055/119023613-7002bc00-b9a2-11eb-86ed-df0e4ff3e360.jpg)
![App Aduanas 2](https://user-images.githubusercontent.com/56634055/119023619-72fdac80-b9a2-11eb-8258-70ed4ed4a5ee.jpg)

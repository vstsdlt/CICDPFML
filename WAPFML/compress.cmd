@ECHO OFF
del compress.zip
"C:\Program Files\7-Zip\7z" a -r -tzip compress -x!.vs -x!compress.zip -xr!bin -xr!obj
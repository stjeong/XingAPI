
FOR /F %%I IN ("%0") DO SET CURRENTDIR=%%~dpI
tlbimp C:\eBEST\xingAPI\XA_DataSet.dll /out:Interop.XA_DataSetLib.dll /namespace:XA_DataSetLib
tlbimp C:\eBEST\xingAPI\XA_Session.dll /out:Interop.XA_SessionLib.dll /namespace:XA_SessionLib
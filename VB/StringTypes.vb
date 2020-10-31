Imports System.Text

Module StringTypes
	Sub Main()
		Dim str1 as String = "Bihar"
		Dim Str2 as String = str1
		
		Dim str3 as new StringBuilder("Goa")
		Dim str4 as new StringBuilder()
		str4 = str3
		
		str1.replace("Bihar", "Muzaffarpur")
		str3.replace("Goa","Panaji")
		
		Console.WriteLine(str1)
		Console.WriteLine(Str2)
		Console.WriteLine(Str3)
		Console.WriteLine(Str4)
	End Sub
End Module

'Mutable means that the string can be modified
'Garbage collection
'String objects are not mutable
'In order to create mutable string we have to use StringBuilder class
'In addition to above classes Java has one more string class known as StringBuffer which is thread-safe
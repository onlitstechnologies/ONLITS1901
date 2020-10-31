Imports System

Module StringLength
	Sub Main()
		Dim name as String
		Dim l as Integer
		Console.write("Pelase enter your name: ")
		name = Console.ReadLine()
		
		l = name.length()
		
		Console.write("Your name contains " & l & " characters.")
	End Sub
End Module
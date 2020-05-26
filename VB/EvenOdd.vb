REM - PROGRAM TO ACCEPT AN INTEGER AND FIND WHETHER IT IS EVEN OR ODD.

Module EvenOdd
	Sub Main()
		Dim n As Integer
		
		'Console.Write("Please enter a number: ")
		'n = Console.ReadLine()
		
		n = InputBox("Please enter a number")
		
		If (n Mod 2 = 0 ) Then
			'Console.WriteLine(n & " is even")
			MsgBox(n & " is even")
			'MessageBox.show(n & " is odd")
		Else
			'Console.WriteLine(n & " is odd")
			MsgBox(n & " is odd")
			'MessageBox.show(n & " is odd")
		End If
		
	End Sub
End Module




'Mostly I use PascalCase in Visual Basic
'Indent/Indentation you will find in Ms-Word

'Jargon - Terms that are used by a particular community/profession of people

'VB6

'Window XP
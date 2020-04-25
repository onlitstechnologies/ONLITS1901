'Program to add two integers

imports System		'Namespace

Module Sum
	Sub Main()
		Dim a, b, c as Integer
		
		Console.Write("Please enter a number: ")	'Works as printf()
		a = Console.ReadLine()	'Equal to scanf()
		
		Console.Write("Please enter another number: ")
		b = Console.ReadLine()
		
		c = a + b
		
		Console.WriteLine("The sum is {0}.", c)
		
		Console.WriteLine("Program over...press enter to exit...")
		
		Console.ReadKey()	'Works as getch()
	End Sub
End Module
	
'What is Dim?
'What .Net Framework?
'What is CLR (Common Language Runtime)?
'What is sub keyword in vb?
'What is Module?
'What is JIT?


imports System.io

Module FirstFile
	Sub Main()
	
		Dim str as String
		
	
		'-------WRITING CONTENT TO A FILE
		Dim sw as new StreamWriter("FirstFile.txt")		'sw is reference to object of StreamWriter class
		Console.WriteLine("Please type some text below:")
		str = Console.ReadLine()
		sw.WriteLine(str)
		Console.WriteLine("Entered information successfully saved in the file: FirstFile")
		sw.close()
	
	
		'------READING CONTENT FROM A FILE
		Console.WriteLine("To view the content of FirstFile press any key...")
		Console.ReadKey()
		Dim sr as new StreamReader("FirstFile.txt")
		Console.WriteLine("FirstFile contains the following text:")
		str = sr.ReadLine()
		Console.WriteLine(str)	
		sr.close()
	End Sub
End Module






	'I try to follow single paradigm as far as possible 
	'.Net exe will run through CLR


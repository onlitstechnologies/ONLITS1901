Class DisposeFinalize
	Private a as Integer
	
	Sub New()
		a = 10
	End Sub
	
	Sub Dispose()
		Console.WriteLine("We are in Dispose Method")
	End Sub
End Class

Module ModDisposeFinalize
	Sub Main()
		Dim x as new DisposeFinalize()
	End Sub
End Module

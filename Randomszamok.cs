public static void Main(string[] args)
		{
			string fajlnev = "szamok.txt";
			int[]a = new int[5];
			int i = 0;
			StreamWriter ir = null;
			Random vsz = new Random();
			Console.WriteLine(" A számok :");
			for(i=0;i<5;i++)
			{
				a[i]=vsz.Next(101);
				Console.Write("{0,5}",a[i]);
			}
			try
			{
				ir = new StreamWriter(fajlnev);
				for(i=0;i<5;i++) ir.Write("{0,4}",a[i]);
				ir.Close();
			}
			catch(IOException)
			{
				Console.WriteLine(" I/O hiba");
			}
			Console.ReadKey(true);
		}
	}
}

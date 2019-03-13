# szinvaltas
oraimunka
public partial class MainForm : Form
	{
		public 	bool piros=false;
		public 	bool kek=false;
		public	bool green=false;
		
		public	int asd=0;
		
		public MainForm()
		{
			
			
			InitializeComponent();
			
			
			
		}
		void PirosClick(object sender, EventArgs e)
		{
			
				BackColor = Color.Red; 
				piros=true;
			
			
			
		}
		void KékClick(object sender, EventArgs e)
		{
			BackColor = Color.Blue; 
			kek=true;
		}
		void ZöldClick(object sender, EventArgs e)
		{
			BackColor = Color.Green;  
			green=true;
		}
		void RandomClick(object sender, EventArgs e)
		{
			Random r = new Random();
			
			
			int rnd;
			do{
				rnd = r.Next(1,4);
			}while(rnd == asd);
			asd = rnd;
			switch (rnd) {
						
					case 1: BackColor=Color.Blue;					 
					break;					
					case 2: BackColor=Color.Red;
					break;
					case 3: BackColor=Color.Green;
					break;
				}
					
			
		
			
		}
		void KilépésClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void ResetClick(object sender, EventArgs e)
		{
			BackColor = default(Color);
			piros=false;
			green=false;
			kek=false;
		}
		void PirosMouseEnter(object sender, EventArgs e)
		{
			BackColor = Color.Red; 
		}
		void PirosMouseLeave(object sender, EventArgs e)
		{
			if (!piros) {
				BackColor = default(Color);
			}
				
			
			
		}
		void KékMouseEnter(object sender, EventArgs e)
		{	
			if(!kek){
			BackColor = Color.Blue; 
			}
		}
		void KékMouseLeave(object sender, EventArgs e)
		{
			if(!kek){
				BackColor = default(Color);
			}
			
			
		}
		void ZöldMouseEnter(object sender, EventArgs e)
		{
			BackColor = Color.Green;
		}
		void ZöldMouseLeave(object sender, EventArgs e)
		{
			if (!green) {
			BackColor = default(Color);
			}
		}
		
	}
}

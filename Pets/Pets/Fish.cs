namespace Pets;  
  
public class Fish:Pet  
{  
    public Fish(string name) : base(name)  
    {        
	    base.noise = "blub";  
        base.trick = "blows bubbles";  
    }
}
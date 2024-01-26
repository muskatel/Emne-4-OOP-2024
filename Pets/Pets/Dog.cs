namespace Pets;  
  
public class Dog:Pet  
{  
    public Dog(string name) : base(name)  
    {        
	    base.noise = "woof";  
        base.trick = "fetch";  
    }
}
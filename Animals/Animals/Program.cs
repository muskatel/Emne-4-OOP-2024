using System.Runtime.InteropServices.JavaScript;

namespace Animals;

class Program
{
    static void Main(string[] args)
    {
        /*
        // DONT DO THIS
        List<Object> animals = new List<object>();
        animals.Add(new Cat());
        animals.Add(new Mouse());

        foreach (Object obj in animals)   
        {
                obj.
        }
        */
        
        Cat myCat = new Cat();
        myCat.getInfo();
        myCat.makeNoise();

        Mouse myMouse = new Mouse();
        myMouse.getInfo();
        myMouse.makeNoise();
        
        //how do we have a collection of theses?

    }
}
namespace IkeaApp.Interfaces;

/// <summary>
/// An interface to expose the assembly instructions.
/// Steps are stored in the implementing class
/// </summary>
public interface IAssemblable
{
    /// <summary>
    /// Provide assembly instructions for the product.
    /// </summary>
    /// <returns></returns>
    public String Assemble();

    protected String GetAssemblySteps();
}
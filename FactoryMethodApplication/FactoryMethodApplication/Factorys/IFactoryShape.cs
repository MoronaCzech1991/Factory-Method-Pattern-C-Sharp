using FactoryMethodApplication.Shapes;

namespace FactoryMethodApplication.Factorys
{
    public interface IFactoryShape
    {
        IShape CreateShape(EShape typeShape);
    }
}

using btreemath.Nodes;

namespace btreemath.Solvers;
public interface IExpressionSolver
{
    public ExpressionTypeEnum ExpressionType { get; }
    public double Solve(double left, double right);
}

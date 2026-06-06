namespace btreemath.Solvers.Strategies;
public class MultiplicationSolver : IExpressionSolver
{
    public ExpressionTypeEnum ExpressionType => ExpressionTypeEnum.Multiply;

    public double Solve(double left, double right) => left * right;
}

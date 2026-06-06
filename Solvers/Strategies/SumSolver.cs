namespace btreemath.Solvers.Strategies;
public class SumSolver : IExpressionSolver
{
    public ExpressionTypeEnum ExpressionType => ExpressionTypeEnum.Sum;

    public double Solve(double left, double right) => left + right;
}

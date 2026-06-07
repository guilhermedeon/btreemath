namespace btreemath.Solvers.Strategies;
public class SubtractionSolver : IExpressionSolver
{
    public ExpressionTypeEnum ExpressionType => ExpressionTypeEnum.Subtraction;

    public double Solve(double left, double right) => left - right;
}

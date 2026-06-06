namespace btreemath.Solvers.Strategies;
public class SubtractionSolver : IExpressionSolver
{
    public ExpressionTypeEnum ExpressionType => ExpressionTypeEnum.Subtract;

    public double Solve(double left, double right) => left - right;
}

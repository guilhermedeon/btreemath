namespace btreemath.Solvers.Strategies;
public class DivisionSolver : IExpressionSolver
{
    public ExpressionTypeEnum ExpressionType => ExpressionTypeEnum.Division;

    public double Solve(double left, double right) => left / right;
}

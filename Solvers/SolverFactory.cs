using btreemath.Solvers.Strategies;

namespace btreemath.Solvers
{
    public interface ISolverFactory
    {
        IExpressionSolver GetSolver(ExpressionTypeEnum expressionType);
    }

    public class SolverFactory : ISolverFactory
    {
        private Dictionary<ExpressionTypeEnum, IExpressionSolver> solvers;

        public SolverFactory()
        {
            solvers = new()
            {
                { ExpressionTypeEnum.Sum, new SumSolver() },
                { ExpressionTypeEnum.Subtract, new SubtractionSolver() },
                { ExpressionTypeEnum.Multiply, new MultiplicationSolver() },
                { ExpressionTypeEnum.Divide, new DivisionSolver() }
            };
        }

        public IExpressionSolver GetSolver(ExpressionTypeEnum expressionType)
        {
            return solvers.TryGetValue(expressionType, out IExpressionSolver? solver)
                ? solver
                : throw new ArgumentException("Unsupported expression type");
        }
    }
}

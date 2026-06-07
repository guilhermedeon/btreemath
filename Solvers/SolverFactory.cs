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
            List<IExpressionSolver> solverList =
            [
                new SumSolver(),
                new MultiplicationSolver(),
                new SubtractionSolver(),
                new DivisionSolver(),
                new ExponentiationSolver()
            ];

            solvers = solverList.ToDictionary(solver => solver.ExpressionType, solver => solver);
        }

        public IExpressionSolver GetSolver(ExpressionTypeEnum expressionType)
        {
            return solvers.TryGetValue(expressionType, out IExpressionSolver? solver)
                ? solver
                : throw new ArgumentException("Unsupported expression type");
        }
    }
}

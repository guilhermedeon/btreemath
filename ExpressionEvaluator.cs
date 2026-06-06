using btreemath.Nodes;
using btreemath.Solvers;

namespace btreemath;

public interface IExpressionEvaluator
{
    double Evaluate(BaseNode node);
}

public class ExpressionEvaluator(ISolverFactory solverFactory) : IExpressionEvaluator
{
    public double Evaluate(BaseNode node)
    {
        if (node.GetType() == typeof(ValueNode)) return ((ValueNode)node).Value;

        double left = Evaluate(((ExpressionNode)node).Left);
        double right = Evaluate(((ExpressionNode)node).Right);

        var solver = solverFactory.GetSolver(((ExpressionNode)node).Expression);

        return solver.Solve(left, right);
    }
}

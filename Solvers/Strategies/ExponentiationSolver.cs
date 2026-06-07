using System;
using System.Collections.Generic;
using System.Text;

namespace btreemath.Solvers.Strategies;

public class ExponentiationSolver : IExpressionSolver
{
    public ExpressionTypeEnum ExpressionType => ExpressionTypeEnum.Exponentiation;

    public double Solve(double left, double right) => Math.Pow(left, right);
}

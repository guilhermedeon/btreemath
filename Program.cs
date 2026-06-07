using System;
using btreemath;
using btreemath.Nodes;
using btreemath.Solvers;

// Simple runner examples for the btreemath library
var solverFactory = new SolverFactory();
var evaluator = new ExpressionEvaluator(solverFactory);

// Simple expression: 5 + 3
var simple = new ExpressionNode(
    new ValueNode(5),
    new ValueNode(3),
    ExpressionTypeEnum.Sum);

Console.WriteLine("Simple expression: 5 + 3");
Console.WriteLine($"Result: {evaluator.Evaluate(simple)}");
Console.WriteLine();

// Complex expression: (2 + 3) * (7 - (4 / 2))
var left = new ExpressionNode(new ValueNode(2), new ValueNode(3), ExpressionTypeEnum.Sum);
var innerDiv = new ExpressionNode(new ValueNode(4), new ValueNode(2), ExpressionTypeEnum.Divide);
var right = new ExpressionNode(new ValueNode(7), innerDiv, ExpressionTypeEnum.Subtract);
var complex = new ExpressionNode(left, right, ExpressionTypeEnum.Multiply);

Console.WriteLine("Complex expression: (2 + 3) * (7 - (4 / 2))");
Console.WriteLine($"Result: {evaluator.Evaluate(complex)}");

var evenMoreComplex = new ExpressionNode((BaseNode)complex.Clone(), (BaseNode)complex.Clone(), ExpressionTypeEnum.Exponentiation);
Console.WriteLine("Even more complex expression: ((2 + 3) * (7 - (4 / 2)) ^ (2 + 3) * (7 - (4 / 2)))");
Console.WriteLine($"Result: {evaluator.Evaluate(evenMoreComplex)}");

Console.WriteLine();
Console.WriteLine("Press any key to exit...");
Console.ReadKey();



namespace btreemath.Nodes;

public class ExpressionNode(BaseNode left, BaseNode right, ExpressionTypeEnum expression) : BaseNode
{
    public BaseNode Left { get; } = left;
    public BaseNode Right { get; } = right;
    public ExpressionTypeEnum Expression { get; } = expression;
}

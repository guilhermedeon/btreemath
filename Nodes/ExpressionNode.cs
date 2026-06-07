namespace btreemath.Nodes;

public class ExpressionNode(BaseNode left, BaseNode right, ExpressionTypeEnum expression) : BaseNode
{
    public BaseNode Left { get; } = left;
    public BaseNode Right { get; } = right;
    public ExpressionTypeEnum Expression { get; } = expression;

    public override object Clone()
    {
        BaseNode leftClone = (BaseNode)Left.Clone();
        BaseNode rightClone = (BaseNode)Right.Clone();

        return new ExpressionNode(leftClone, rightClone, Expression);
    }
}

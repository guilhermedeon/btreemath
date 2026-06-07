namespace btreemath.Nodes;
public class ValueNode(double value) : BaseNode
{
    public double Value { get; } = value;

    public override object Clone() => new ValueNode(Value);
}

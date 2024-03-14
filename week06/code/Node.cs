public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if (value > Data)
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
        // If value is equal to Data, do nothing (value already exists in the tree)
    }

    public bool Contains(int value)
    {
        if (value == Data)
        {
            return true; // Found the value in this node
        }
        else if (value < Data && Left != null)
        {
            return Left.Contains(value); // Search in the left subtree
        }
        else if (value > Data && Right != null)
        {
            return Right.Contains(value); // Search in the right subtree
        }
        return false; // Value not found in the tree
    }

    public int GetHeight()
    {
        static int GetHeight(Node? node)
        {
            if (node is null)
                return 0;
            return 1 + Math.Max(GetHeight(node.Left), GetHeight(node.Right));
        }
        return GetHeight(this);
    }
}

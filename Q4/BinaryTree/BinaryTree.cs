namespace BinaryTree;

public class BinaryTree
{
    public Node? Root { get; private set; }

    /// <summary>
    /// Add a value to the binary tree.
    /// </summary>
    /// <param name="value">Value of the new node.</param>
    /// <returns>True if a new node has been added, false if not.</returns>
    public bool Add(int value)
    {
        Node? previous = null, current = this.Root;
 
        while (current != null)
        {
            previous = current;
            if (value < current.Data)
            {
                current = current.LeftNode; 
            }
            else if (value > current.Data)
            {
                current = current.RightNode;
            }
            else
            {
                return false;
            }
        }
 
        Node newNode = new Node();
        newNode.Data = value;
 
        if (Root == null)
        {
            Root = newNode;
        }
        else
        {
            if (value < previous!.Data)
            {
                previous.LeftNode = newNode;
            }
            else
            {
                previous.RightNode = newNode;
            }
        }
 
        return true;
    }

    /// <summary>
    /// Method is used to find all single parent nodes in a binary tree.
    /// A single parent is a node which has only one child which is also an end node.
    /// </summary>
    /// <returns></returns>
    public List<Node> FindSingleParents()
    {
        var singleParents = new List<Node>();

        if (Root != null) FindSingleParentsRecurs(singleParents, Root);

        return singleParents;
    }

    private void FindSingleParentsRecurs(List<Node> singleParents, Node current)
    {
        if (current.LeftNode == null && current.RightNode == null)
        {
            return;            
        }

        if (current.LeftNode != null)
        {
            FindSingleParentsRecurs(singleParents, current.LeftNode);

            if ((current.RightNode == null)
                && (current.LeftNode.LeftNode == null 
                && current.LeftNode.RightNode == null))
            {
                singleParents.Add(current);
            }
        }

        if (current.RightNode != null)
        {
            FindSingleParentsRecurs(singleParents, current.RightNode);

            if ((current.LeftNode == null) 
                && (current.RightNode.LeftNode == null 
                && current.RightNode.RightNode == null))
            {
                singleParents.Add(current);
            }
        }
    }
}
import java.util.*;
public class Solution {
    public ArrayList<String> letterCombinations(String digits) {
        
        ArrayList<String> list = new ArrayList<String>();
 
        if(digits.length() == 0)
        {    
            list.add("");
            return list;
        }
        Map<Character, Character[]> numberLetters = new HashMap<Character, Character[]>();
        numberLetters.put('2', new Character[] { 'a', 'b', 'c' });
        numberLetters.put('3', new Character[] { 'd', 'e', 'f' });
        numberLetters.put('4', new Character[] { 'g', 'h', 'i' });
        numberLetters.put('5', new Character[] { 'j', 'k', 'l' });
        numberLetters.put('6', new Character[] { 'm', 'n', 'o' });
        numberLetters.put('7', new Character[] { 'p', 'q', 'r', 's' });
        numberLetters.put('8', new Character[] { 't', 'u', 'v' });
        numberLetters.put('9', new Character[] { 'w', 'x', 'y', 'z' });
 
        char[] digitsArray = digits.toCharArray();
        int count = numberLetters.get(digitsArray[0]).length;
        Queue<GNode> trees = new LinkedList<GNode>();
        GNode[] heads = new GNode[count];
        GNode node = null;
        for (int i = 0; i < count; i++)
        {
            node = new GNode(numberLetters.get(digitsArray[0])[i], 0);
            trees.add(node);
            heads[i] = node;
        }
 
        GNode current = null;
        int digitsLength = digitsArray.length;
        if (digitsLength == 1)
        {
            Character [] array = numberLetters.get(digitsArray[0]);
            for (Character c : array)
                list.add(c.charValue() + "");
            
            return list;
        }
 
        while (trees.size() != 0)
        {
            current = trees.remove();
            if (current.Depth < (digitsLength - 1))
                addChilds(current, numberLetters.get(digitsArray[current.Depth + 1]), trees);
        }
 
        for (int i = 0; i < count; i++)
        {
            GetDFDisplay(heads[i], list, digitsLength - 1);
        }
 
        return list;
    }
    
    private void addChilds(GNode current, Character[] p, Queue<GNode> trees)
    {
        int count = p.length;
        for (int i = 0; i < count; i++)
        {
            trees.add(current.Add(p[i]));
        }
    }
 
    public String GetDFDisplay(GNode Head, List<String> results, int digitsLength)
    { 
        StringBuilder sb = new StringBuilder();
 
        Stack<GNode> searchStack = new Stack<GNode>();
        searchStack.push(Head);
 
 
 
        GNode current = null;
        GNode child = null;
 
        sb.append(Head.Data);
        Head.visited = true;
 
        while (searchStack.size() != 0)
        {
            current = searchStack.peek();
            child = current.GetUnVisitedChild();
            if (child != null)
            {
                sb.append(child.Data);
                child.visited = true;
                searchStack.push(child);
 
                if (child.Depth == digitsLength)
                {
                    results.add(sb.toString());
                }
            }
            else
            {
                searchStack.pop();
                sb.deleteCharAt(sb.length() - 1);
            }
 
        }
 
        return sb.toString();
    }
}

class GNode
{
    public char Data = ' ';
 
 
    public boolean visited = false;
    public int Depth = 0;
 
 
    public List<GNode> Children = new ArrayList<GNode>();
 
    public GNode(char data, int depth)
    {
        Data = data;
        Depth = depth;
    }
 
    public GNode Add(char data)
    {
        GNode child = new GNode(data, (Depth + 1));  
        Children.add(child);
 
        return child;
    }
 
    public GNode GetUnVisitedChild()
    {
        for (GNode child : Children)
        {
            if (child.visited == false)
            {
                return child;
            }
        }
 
        return null;
    }
}
public class Solution {
    public boolean wordBreak(String s, Set<String> dict) {
        int index = 0;
        int length = dict.size();
        int head = 0;
        boolean found = false;
        String original = s;
        
        StringLengthListSort ss = new StringLengthListSort();
        List<String> list = new ArrayList<String>(dict);
        Collections.sort(list, ss);
        
        for (head = 0; head < length; head++)
        {
            s = original;
            for (int i = head; i < length; i++)
            {
                index = s.indexOf(list.get(i));
                if (index > -1)
                {
                    while (index > -1)
                    {
                        s = s.substring(0, index) +  s.substring(index + (list.get(i)).length());
                        index = s.indexOf(list.get(i));
                    }
                }
            }

            if (s.length() == 0) 
            {
                found = true;
                break;
            }
        }

        return found;
    }
}


class StringLengthListSort implements Comparator<String>{

    @Override
    public int compare(String s1, String s2) {
    return s2.length() - s1.length();
    }
}
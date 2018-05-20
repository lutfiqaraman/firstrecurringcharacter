using System.Collections.Generic;

namespace firstrecurringcharacter
{
    public class FirstRepeating
    {
        private string to_be_checked;

        public FirstRepeating(string astring)
        {
            to_be_checked = astring;
        }

        public char Processing()
        {
            var HashSet = new HashSet<char>();

            for (int i = 0; i < to_be_checked.Length; i++)
            {
                char c = to_be_checked[i];

                if (HashSet.Contains(c))
                    return c;
                else
                    HashSet.Add(c);
            }

            return '\0';
        }
    }
}

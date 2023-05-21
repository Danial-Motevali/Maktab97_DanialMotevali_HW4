namespace HW4
{
    public class ShowTheList
    {

        public string[] ShowList(string path)
        {
            int i = 0;

            if (File.ReadAllLines(path) == null)
            {
                return null;
            }
            else
            {
                var g = File.ReadAllLines(path);
                string[] f = new string[g.Length];
                foreach (string line in g)
                {
                    f[i] = line;
                    i++;
                }
                return f;
            }
        }
    }
}

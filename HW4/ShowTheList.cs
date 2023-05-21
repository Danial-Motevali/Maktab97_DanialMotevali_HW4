namespace HW4
{
    public class ShowTheList
    {

        public string[] ShowList(string path)
        {
            int i = 0;
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

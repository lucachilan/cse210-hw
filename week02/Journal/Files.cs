using System.IO;

public class Files
{
    public List<string> LoadFromFile(string filename)
        {
            List<string> filecontent = new List<string>();
            string[] lines = System.IO.File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }
                string[] parts = line.Split("\n");
                filecontent.Add(parts[0]);
            }
            return filecontent;
        }

    public void WriteInFile(string filename, string fileContent)
    {
        File.WriteAllText(filename,fileContent);
    }

}
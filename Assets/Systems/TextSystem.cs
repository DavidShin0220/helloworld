using System.Text;

public class TextSystem
{
    public string GetTextMerge(params string[] str)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < str.Length; i++)
        {
            sb.Append(str[i]);
        }

        return sb.ToString();
    }
}
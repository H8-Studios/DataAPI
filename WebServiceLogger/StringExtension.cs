using System.IO;

namespace WebServiceLogger
{
  public static class StringExtension
  {
    public static string PathMerge (this string basis, params string[] values)
    {
      if (basis == null) return null;
      foreach (string value in values)
      {
        basis = Path.Combine (basis, value);
      }
      return basis;
    }

    public static string RemoveFileFromPath(this string basis) => basis.PathMerge (basis.Split ('\\').RemoveLastEntry ());

    public static string RemoveFoldersFromPath(this string basis, int count = 1, bool RemoveFile = true)
    {
      if (RemoveFile) basis = basis.RemoveFileFromPath ();
      return basis;
    }

    public static string[] RemoveLastEntry(this string[] basis)
    {
      string[] result = new string[basis.Length - 1];
      for(int i = 0; i < result.Length; i++)
      {
        result[i] = basis[i];
      }
      return result;
    }
  }
}

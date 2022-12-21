// https://stackoverflow.com/questions/14663168/an-integer-array-as-a-key-for-dictionary
// https://stackoverflow.com/questions/63129018/c-sharp-check-if-dictionary-contains-key-which-is-a-reference-type

using System.Diagnostics.CodeAnalysis;

namespace EM
{
    public class EqualityComparer : IEqualityComparer<byte[]>
    {
        public bool Equals(byte[]? x, byte[]? y)
        {
            if (x.Length != y.Length)
            {
                return false;
            }
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] != y[i])
                {
                    return false;
                }
            }
            return true;
        }

        public int GetHashCode([DisallowNull] byte[] obj)
        {
            int result = 17;
            for (int i = 0; i < obj.Length; i++)
            {
                unchecked
                {
                    result = result * 23 + obj[i];
                }
            }
            return result;
        }
    }
}
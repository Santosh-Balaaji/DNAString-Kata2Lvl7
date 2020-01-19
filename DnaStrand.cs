namespace Tests
{
    public static class DnaStrand
    {
        public static string MakeComplement(string dna)
        {
            char[] dna_array = dna.ToCharArray();
            string result = "";
            foreach (var j in dna_array)
            {
                if (j=='A')
                {
                    result += 'T';
                }
                else if (j=='T')
                {
                    result += 'A';
                }
                else if(j=='C')
                {
                    result += 'G';
                }
                else if (j == 'G')
                {
                    result += 'C';
                }
            }

            return result;
        }
    }
}
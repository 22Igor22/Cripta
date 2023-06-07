package cripta.bay;

import java.util.Hashtable;
import java.util.List;
import java.util.Map;

public class EntropyMethotds {
    public String alphabetName;
    private List<Character> alphabet;
    public double alphabetEntropy = 0;

    public EntropyMethotds(List<Character> alphabet, double alphabetEntropy, String alphabetName)
    {
        this.alphabet = alphabet;
        this.alphabetEntropy = alphabetEntropy;
        this.alphabetName = alphabetName;
    }

    public EntropyMethotds()
    {
    }

    public Map<Character, Integer> alphabetListToDictionary()
    {
        Map<Character, Integer> dict = new Hashtable<>(alphabet.size());
        for (char x:
             alphabet) {
            dict.put(x, 0);
        }
        return dict;
    }

    public Map<Character, Double> getChances(String text, Map<Character, Integer> counts)
    {
        Map<Character, Double> chances = new Hashtable<>(alphabet.size());

        for (int i = 0; i < counts.size(); i++)
        {
            chances.put(alphabet.get(i),((double)counts.get(alphabet.get(i)) / (double)text.length()));
        }

        return chances;
    }

    public void getCounts(String text, Map<Character, Integer> alphabet)
    {
        for(int i = 0; i < this.alphabet.size(); i++) {
            for (int j = 0; j < text.length(); j++) {
                if (this.alphabet.get(i) == text.charAt(j)) {
                    alphabet.put(this.alphabet.get(i), alphabet.get(this.alphabet.get(i)).intValue() + 1);
                }
            }
        }
    }


    public void getTextEntropy(Map<Character, Double> chances)
    {
        for (int i = 0; i < alphabet.size(); i++)
        {
            if (chances.get(alphabet.get(i)) != 0)
            {
                alphabetEntropy += chances.get(alphabet.get(i)) * (Math.log10(chances.get(alphabet.get(i)))/Math.log10(2));
            }
        }
        alphabetEntropy = -alphabetEntropy;
    }

    public double getTextEntropyWithErrorForBin(String text, double p)
    {
        double q = (double)1 - p;
        double entropy = (1-(-p*(Math.log10(p)/Math.log10(2))-q*(Math.log10(q)/Math.log10(2))))*text.length();
        if (Double.isNaN(entropy))
        {
            return 0;
        }

        return entropy;
    }

    public double getTextEntropyWithError(String text, Map<Character, Double> chances, double p)
    {
        double entropy = 0;
        if (p >= 0.5)
        {
            return 0;
        }
        for (int i = 0; i < alphabet.size(); i++)
        {
            if (chances.get(alphabet.get(i)) != 0)
            {
                entropy -= (chances.get(alphabet.get(i)) * (Math.log10(chances.get(alphabet.get(i)))/Math.log10(2)));
            }
        }
        entropy *=text.length();

        return entropy;
    }
    public void printAlphabet()
    {
        System.out.println("\nАлфавит " + this.alphabetName + ":"); ;
        for (char x : this.alphabet)
        {
            System.out.print(x); System.out.print(" ");
        }

    }

    public void printChances(Map<Character, Double> chances)
    {
        System.out.println("\nШансы символа:");
        for (char x : this.alphabet)
        System.out.println(x + ":" + chances.get(x));
    }

    public void printEntropy()
    {
        System.out.println("\nЭнтропия языка '" + this.alphabetName + "' = " + this.alphabetEntropy);
    }
}

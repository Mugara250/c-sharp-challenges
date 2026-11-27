namespace c_sharp_challenges._17_11_2026;

public class WordCounter
{
    public static int CountOccurrences(string? text, string? targetWord)
    {
        if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text)) return 0;
        if (string.IsNullOrEmpty(targetWord) || string.IsNullOrWhiteSpace(targetWord)) return 0;
        var count = 0;

        var words = text.Split(" ");

        var punctuation = new char[] {'.', ',', '!', '?', ';', ':', '(', ')', '[', ']'};
        
        foreach (var word in words)
        {
            if (string.Equals(word.Trim(punctuation), targetWord.Trim(punctuation), StringComparison.OrdinalIgnoreCase))
            {
                count++;
            }    
        }

        return count;

    }
}

/*1. Split the input text into words using whitespace as the separator.
2. Count only complete word matches, not partial matches.
3. Matching must be case-insensitive.
4. Ignore the punctuation characters `. , ! ? ; : ( ) [ ]` when they appear at the beginning or end of a word.
5. Return `0` if the text is null, empty, or whitespace, or if the target word is null, empty, or whitespace.*/
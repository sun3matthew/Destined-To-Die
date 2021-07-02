
public class LanguageLocalization<T>
{
    public static readonly int language = 0;//english, chinese(simplified), chinese(traditional)
    public static readonly int languageAmt = 2;

    private T[] languageData = new T[languageAmt];

    public void addLanguage(T data, int language) => languageData[language] = data;
    public T getLanguage(int language) => languageData[language];
}


public class LanguageLocalization<T>
{
    private T[] languageData = new T[Language.languageAmt];

    public void addLanguage(T data, int language) => languageData[language] = data;
    public T getLanguage() => languageData[Language.language];
}
